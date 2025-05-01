using UnityEngine;

namespace SMPreloader
{
  public class Logger
  {
    public const int BUFFER_SIZE = 300;
    public static readonly Logger Global = new();
    public static void GlobalLog(string message) => Global.Log(message);
    public static Logger GlobalPrefixed(string prefix) => Global.WithPrefix(prefix);

    public readonly string Prefix;
    public readonly Logger Parent;
    public readonly LineBuffer Lines = new LineBuffer(BUFFER_SIZE);

    public Logger(string prefix = "", Logger parent = null)
    {
      this.Prefix = prefix;
      this.Parent = parent;
    }

    public void Log(string message, bool logUnity = true)
    {
      this.Lines.AddLine(message);
      var fullMessage = $"{Prefix}{message}";
      if (this.Parent != null)
        this.Parent.Log(fullMessage, logUnity);
      else if (logUnity)
        Debug.Log(fullMessage);
    }

    public Logger WithPrefix(string prefix)
    {
      return new Logger($"{this.Prefix}{prefix}", this);
    }

    public class LineBuffer
    {
      private readonly string[] lines;
      public int Count { get; private set; }
      public int TotalCount { get; private set; }
      private int start = 0;
      public LineBuffer(int bufferSize)
      {
        this.lines = new string[bufferSize];
      }

      public void AddLine(string line)
      {
        if (this.Count == this.lines.Length)
        {
          this.lines[this.start] = line;
          this.start = (this.start + 1) % this.lines.Length;
        }
        else
        {
          this.lines[this.Count] = line;
          this.Count++;
        }
        this.TotalCount++;
      }

      public string this[int index] => this.lines[(index + this.start) % this.lines.Length];
    }
  }
}