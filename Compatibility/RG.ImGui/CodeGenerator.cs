
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using HarmonyLib;

public class CodeGenerator
{
  public static void Main()
  {
    using var output = new StreamWriter("ImGui.cs");

    var primitives = new Dictionary<Type, string>()
    {
      [typeof(void)] = "void",
      [typeof(void*)] = "void*",
      [typeof(void**)] = "void**",
      [typeof(bool)] = "bool",
      [typeof(int)] = "int",
      [typeof(uint)] = "uint",
      [typeof(long)] = "long",
      [typeof(ulong)] = "ulong",
      [typeof(short)] = "short",
      [typeof(ushort)] = "ushort",
      [typeof(ushort*)] = "ushort*",
      [typeof(byte)] = "byte",
      [typeof(byte*)] = "byte*",
      [typeof(char)] = "char",
      [typeof(float)] = "float",
      [typeof(double)] = "double",
      [typeof(object)] = "object",
      [typeof(string)] = "string",
    };

    var banned = new List<string>()
    {
      "in",
      "out",
      "ref",
      "base",
    };
    banned.AddRange(primitives.Values);

    string DeclTypeName(Type type) => type.Name.Replace("`1", "<T>");

    string TypeName(Type type)
    {
      if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        return TypeName(type.GetGenericArguments()[0]) + "?";
      if (type.IsGenericParameter)
        return "T";
      if (primitives.TryGetValue(type, out var pname))
        return pname;
      if (type.IsByRef)
        return "ref " + TypeName(type.GetElementType());
      if (!type.IsGenericType)
        return type.FullName.Replace('+', '.').Replace("ImGuiNET.", "");
      var res = $"{type.Name.Replace("`1", "")}<";
      if (type.Namespace != "ImGuiNET")
        res = $"{type.Namespace}.{res}";
      var gargs = type.GetGenericArguments();
      for (var i = 0; i < gargs.Length; i++)
      {
        if (i != 0) res += ",";
        res += TypeName(gargs[i]);
      }
      res += ">";
      return res.Replace('+', '.');
    }

    bool IsTypeUnsafe(Type type)
    {
      if (type.IsByRef || type.IsArray)
        return IsTypeUnsafe(type.GetElementType());
      return type.IsPointer;
    }
    bool IsMethodUnsafe(MethodInfo method)
    {
      if (IsTypeUnsafe(method.ReturnType)) return true;
      foreach (var param in method.GetParameters())
        if (IsTypeUnsafe(param.ParameterType)) return true;
      return false;
    }

    string SafeName(string name)
    {
      if (banned.Contains(name))
        return "@" + name;
      return name;
    }

    void WriteType(Type type)
    {
      if (type.IsEnum)
      {
        WriteEnum(type);
        return;
      }
      if (typeof(Delegate).IsAssignableFrom(type))
      {
        WriteDelegate(type);
        return;
      }
      if (type.IsValueType)
        output.WriteLine($"public struct {DeclTypeName(type)}");
      else
        output.WriteLine($"public class {DeclTypeName(type)}");

      if (type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
        output.WriteLine($": {TypeName(type.BaseType)}");

      output.WriteLine("{");

      var refs = new List<Type>();

      int refIndex(Type rtype)
      {
        var idx = refs.IndexOf(rtype);
        if (idx == -1)
        {
          idx = refs.Count;
          refs.Add(rtype);
        }
        return idx;
      }

      foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
      {
        var prefix = "public";
        if (field.IsStatic)
          prefix += " static";
        if (IsTypeUnsafe(field.FieldType))
          prefix += " unsafe";
        var typeName = TypeName(field.FieldType);
        var suffix = "";
        var fixedAttr = field.GetCustomAttribute<FixedBufferAttribute>();
        if (fixedAttr != null)
        {
          prefix += " unsafe fixed";
          typeName = TypeName(fixedAttr.ElementType);
          suffix = $"[{fixedAttr.Length}]";
        }
        output.WriteLine($"{prefix} {typeName} {field.Name}{suffix};");
      }

      foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
      {
        var prefix = "public";
        if (prop.GetAccessors()[0].IsStatic)
          prefix += " static";

        if (IsTypeUnsafe(prop.PropertyType))
          prefix += " unsafe";

        var suffix = ";";

        var getValue = "default";
        if (prop.CanRead && prop.PropertyType.IsByRef)
          getValue = $"ref __{refIndex(prop.PropertyType.GetElementType())}";

        if (prop.CanRead && prop.CanWrite)
          suffix = $"{{ get => {getValue}; set {{ }} }}";
        else if (prop.CanRead)
          suffix = $"{{ get => {getValue}; }}";
        else if (prop.CanWrite)
          suffix = "{ set { } }";
        output.WriteLine($"{prefix} {TypeName(prop.PropertyType)} {prop.Name} {suffix}");
      }

      foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
      {
        if (method.IsSpecialName) continue;
        if (method.GetBaseDefinition().DeclaringType != type) continue;
        var str = new StringBuilder();
        str.Append("public ");
        if (method.IsStatic)
          str.Append("static ");
        if (IsMethodUnsafe(method))
          str.Append("unsafe ");
        str.Append($"{TypeName(method.ReturnType)} {method.Name}");
        if (method.IsGenericMethod)
          str.Append("<T>");
        str.Append("(");
        var ps = method.GetParameters();
        var body = "";
        if (method.ReturnType != typeof(void))
        {
          if (method.ReturnType.IsByRef)
          {
            if (method.IsGenericMethod)
              body = $"return ref {DeclTypeName(type)}<T>.__0;";
            else
              body = $"return ref __{refIndex(method.ReturnType.GetElementType())};";
          }
          else
            body = "return default;";
        }
        var tvalue = false;
        for (var i = 0; i < ps.Length; i++)
        {
          if (i != 0) str.Append(", ");
          var pname = SafeName(ps[i].Name);
          if (ps[i].IsOut)
          {
            str.Append($"out {TypeName(ps[i].ParameterType.GetElementType())} {pname}");
            body = $"{pname} = default; {body}";
          }
          else
          {
            var ptname = TypeName(ps[i].ParameterType);
            str.Append($"{ptname} {pname}");
            if (ptname == "T?")
              tvalue = true;
          }
        }
        str.Append(")");
        if (method.IsGenericMethod && tvalue)
          str.Append("where T : unmanaged");
        str.Append($"{{ {body} }}");

        output.WriteLine(str.ToString());
      }

      for (var i = 0; i < refs.Count; i++)
      {
        output.WriteLine($"internal static {TypeName(refs[i])} __{i};");
      }

      foreach (var ntype in type.GetNestedTypes(BindingFlags.Public))
      {
        if (ntype.GetCustomAttribute<CompilerGeneratedAttribute>() != null)
          continue;
        WriteType(ntype);
      }

      output.WriteLine("}");
    }

    void WriteEnum(Type type)
    {
      output.WriteLine($"public enum {type.Name} {{");

      var names = type.GetEnumNames();
      var underlying = Enum.GetUnderlyingType(type);
      var values = type.GetEnumValues().Cast<object>().Select(v => Convert.ChangeType(v, underlying)).ToArray();
      for (var i = 0; i < names.Length; i++)
      {
        output.WriteLine($"{names[i]} = {values[i]},");
      }

      output.WriteLine("}");
    }

    void WriteDelegate(Type type)
    {
      var invoke = type.GetMethod("Invoke");

      var str = new StringBuilder();
      str.Append("public ");
      if (IsMethodUnsafe(invoke))
        str.Append("unsafe ");
      str.Append($"delegate {TypeName(invoke.ReturnType)} {type.Name}");
      str.Append("(");
      var ps = invoke.GetParameters();
      for (var i = 0; i < ps.Length; i++)
      {
        if (i != 0) str.Append(", ");
        var pname = SafeName(ps[i].Name);
        if (ps[i].IsOut)
          str.Append($"out {TypeName(ps[i].ParameterType.GetElementType())} {pname}");
        else
          str.Append($"{TypeName(ps[i].ParameterType)} {pname}");
      }
      str.Append(");");

      output.WriteLine(str.ToString());
    }

    output.WriteLine("namespace ImGuiNET {");

    var assembly = Assembly.Load("RG.ImGui");

    foreach (var type in assembly.GetExportedTypes())
    {
      if (!type.IsPublic)
        continue;

      WriteType(type);
    }

    output.WriteLine("}");
  }
}