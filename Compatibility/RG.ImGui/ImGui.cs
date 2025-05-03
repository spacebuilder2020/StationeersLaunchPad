namespace ImGuiNET
{
  public struct ImBitArray
  {
  }
  public struct ImBitArrayPtr
  {
    public unsafe ImBitArray* NativePtr { get => default; }
    public void ClearAllBits() { }
    public void ClearBit(int n) { }
    public void SetAllBits() { }
    public void SetBit(int n) { }
    public void SetBitRange(int n, int n2) { }
    public bool TestBit(int n) { return default; }
    public void ImBitArray_destroy() { }
  }
  public struct ImColor
  {
    public UnityEngine.Vector4 Value;
  }
  public struct ImColorPtr
  {
    public unsafe ImColor* NativePtr { get => default; }
    public ref UnityEngine.Vector4 Value { get => ref __0; }
    public static ImColorPtr HSV(float h, float s, float v) { return default; }
    public static ImColorPtr HSV(float h, float s, float v, float a) { return default; }
    public void SetHSV(float h, float s, float v) { }
    public void SetHSV(float h, float s, float v, float a) { }
    public void ImColor_destroy() { }
    internal static UnityEngine.Vector4 __0;
  }
  public struct ImDrawChannel
  {
    public ImVector _CmdBuffer;
    public ImVector _IdxBuffer;
  }
  public struct ImDrawChannelPtr
  {
    public unsafe ImDrawChannel* NativePtr { get => default; }
    public ImPtrVector<ImDrawCmdPtr> _CmdBuffer { get => default; }
    public ImVector<ushort> _IdxBuffer { get => default; }
  }
  public struct ImDrawCmd
  {
    public UnityEngine.Vector4 ClipRect;
    public System.IntPtr TextureId;
    public uint VtxOffset;
    public uint IdxOffset;
    public uint ElemCount;
    public System.IntPtr UserCallback;
    public unsafe void* UserCallbackData;
  }
  public struct ImDrawCmdPtr
  {
    public unsafe ImDrawCmd* NativePtr { get => default; }
    public ref UnityEngine.Vector4 ClipRect { get => ref __0; }
    public System.IntPtr TextureId { get => default; set { } }
    public ref uint VtxOffset { get => ref __1; }
    public ref uint IdxOffset { get => ref __1; }
    public ref uint ElemCount { get => ref __1; }
    public ref ImDrawCallback UserCallback { get => ref __2; }
    public System.IntPtr UserCallbackData { get => default; set { } }
    public unsafe void* GetTexID() { return default; }
    public void ImDrawCmd_destroy() { }
    internal static UnityEngine.Vector4 __0;
    internal static uint __1;
    internal static ImDrawCallback __2;
  }
  public struct ImDrawCmdHeader
  {
    public UnityEngine.Vector4 ClipRect;
    public System.IntPtr TextureId;
    public uint VtxOffset;
  }
  public struct ImDrawCmdHeaderPtr
  {
    public unsafe ImDrawCmdHeader* NativePtr { get => default; }
    public ref UnityEngine.Vector4 ClipRect { get => ref __0; }
    public System.IntPtr TextureId { get => default; set { } }
    public ref uint VtxOffset { get => ref __1; }
    internal static UnityEngine.Vector4 __0;
    internal static uint __1;
  }
  public struct ImDrawData
  {
    public byte Valid;
    public int CmdListsCount;
    public int TotalIdxCount;
    public int TotalVtxCount;
    public unsafe ImDrawList** CmdLists;
    public UnityEngine.Vector2 DisplayPos;
    public UnityEngine.Vector2 DisplaySize;
    public UnityEngine.Vector2 FramebufferScale;
  }
  public struct ImDrawDataPtr
  {
    public unsafe ImDrawData* NativePtr { get => default; }
    public ref bool Valid { get => ref __0; }
    public ref int CmdListsCount { get => ref __1; }
    public ref int TotalIdxCount { get => ref __1; }
    public ref int TotalVtxCount { get => ref __1; }
    public System.IntPtr CmdLists { get => default; set { } }
    public ref UnityEngine.Vector2 DisplayPos { get => ref __2; }
    public ref UnityEngine.Vector2 DisplaySize { get => ref __2; }
    public ref UnityEngine.Vector2 FramebufferScale { get => ref __2; }
    public RangePtrAccessor<ImDrawListPtr> CmdListsRange { get => default; }
    public void Clear() { }
    public void DeIndexAllBuffers() { }
    public void ScaleClipRects(UnityEngine.Vector2 fb_scale) { }
    public void ImDrawData_destroy() { }
    internal static bool __0;
    internal static int __1;
    internal static UnityEngine.Vector2 __2;
  }
  public struct ImDrawDataBuilder
  {
    public ImVector Layers_0;
    public ImVector Layers_1;
  }
  public struct ImDrawDataBuilderPtr
  {
    public unsafe ImDrawDataBuilder* NativePtr { get => default; }
    public RangeAccessor<ImVector> Layers { get => default; }
    public void Clear() { }
    public void ClearFreeMemory() { }
    public void FlattenIntoSingleLayer() { }
    public int GetDrawListCount() { return default; }
  }
  public enum ImDrawFlags
  {
    None = 0,
    Closed = 1,
    RoundCornersTopLeft = 16,
    RoundCornersTopRight = 32,
    RoundCornersTop = 48,
    RoundCornersBottomLeft = 64,
    RoundCornersLeft = 80,
    RoundCornersBottomRight = 128,
    RoundCornersRight = 160,
    RoundCornersBottom = 192,
    RoundCornersAll = 240,
    RoundCornersDefault_ = 240,
    RoundCornersNone = 256,
    RoundCornersMask_ = 496,
  }
  public struct ImDrawList
  {
    public ImVector CmdBuffer;
    public ImVector IdxBuffer;
    public ImVector VtxBuffer;
    public ImDrawListFlags Flags;
    public uint _VtxCurrentIdx;
    public unsafe ImDrawListSharedData* _Data;
    public unsafe byte* _OwnerName;
    public unsafe ImDrawVert* _VtxWritePtr;
    public unsafe ushort* _IdxWritePtr;
    public ImVector _ClipRectStack;
    public ImVector _TextureIdStack;
    public ImVector _Path;
    public ImDrawCmdHeader _CmdHeader;
    public ImDrawListSplitter _Splitter;
    public float _FringeScale;
  }
  public struct ImDrawListPtr
  {
    public unsafe ImDrawList* NativePtr { get => default; }
    public ImPtrVector<ImDrawCmdPtr> CmdBuffer { get => default; }
    public ImVector<ushort> IdxBuffer { get => default; }
    public ImPtrVector<ImDrawVertPtr> VtxBuffer { get => default; }
    public ref ImDrawListFlags Flags { get => ref __0; }
    public ref uint _VtxCurrentIdx { get => ref __1; }
    public ref ImDrawListSharedDataPtr _Data { get => ref __2; }
    public ref string _OwnerName { get => ref __3; }
    public ref ImDrawVertPtr _VtxWritePtr { get => ref __4; }
    public System.IntPtr _IdxWritePtr { get => default; set { } }
    public ImPtrVector<UnityEngine.Vector4> _ClipRectStack { get => default; }
    public ImVector<System.IntPtr> _TextureIdStack { get => default; }
    public ImPtrVector<UnityEngine.Vector2> _Path { get => default; }
    public ref ImDrawCmdHeader _CmdHeader { get => ref __5; }
    public ref ImDrawListSplitter _Splitter { get => ref __6; }
    public ref float _FringeScale { get => ref __7; }
    public void AddBezierCubic(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col, float thickness) { }
    public void AddBezierCubic(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col, float thickness, int num_segments) { }
    public void AddBezierQuadratic(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col, float thickness) { }
    public void AddBezierQuadratic(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col, float thickness, int num_segments) { }
    public void AddCallback(ImDrawCallback callback, System.IntPtr callback_data) { }
    public void AddCircle(UnityEngine.Vector2 center, float radius, uint col) { }
    public void AddCircle(UnityEngine.Vector2 center, float radius, uint col, int num_segments) { }
    public void AddCircle(UnityEngine.Vector2 center, float radius, uint col, float thickness) { }
    public void AddCircle(UnityEngine.Vector2 center, float radius, uint col, int num_segments, float thickness) { }
    public void AddCircleFilled(UnityEngine.Vector2 center, float radius, uint col) { }
    public void AddCircleFilled(UnityEngine.Vector2 center, float radius, uint col, int num_segments) { }
    public void AddConvexPolyFilled(ref UnityEngine.Vector2 points, int num_points, uint col) { }
    public void AddDrawCmd() { }
    public void AddImage(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max) { }
    public void AddImage(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min) { }
    public void AddImage(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col) { }
    public void AddImage(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min, UnityEngine.Vector2 uv_max) { }
    public void AddImage(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min, uint col) { }
    public void AddImage(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min, UnityEngine.Vector2 uv_max, uint col) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, uint col) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2, UnityEngine.Vector2 uv3) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2, uint col) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2, UnityEngine.Vector2 uv3, UnityEngine.Vector2 uv4) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2, UnityEngine.Vector2 uv3, uint col) { }
    public void AddImageQuad(System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2, UnityEngine.Vector2 uv3, UnityEngine.Vector2 uv4, uint col) { }
    public void AddImageRounded(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min, UnityEngine.Vector2 uv_max, uint col, float rounding) { }
    public void AddImageRounded(System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min, UnityEngine.Vector2 uv_max, uint col, float rounding, ImDrawFlags flags) { }
    public void AddLine(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, uint col) { }
    public void AddLine(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, uint col, float thickness) { }
    public void AddNgon(UnityEngine.Vector2 center, float radius, uint col, int num_segments) { }
    public void AddNgon(UnityEngine.Vector2 center, float radius, uint col, int num_segments, float thickness) { }
    public void AddNgonFilled(UnityEngine.Vector2 center, float radius, uint col, int num_segments) { }
    public void AddPolyline(ref UnityEngine.Vector2 points, int num_points, uint col, ImDrawFlags flags, float thickness) { }
    public void AddQuad(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col) { }
    public void AddQuad(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col, float thickness) { }
    public void AddQuadFilled(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col) { }
    public void AddRect(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col) { }
    public void AddRect(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding) { }
    public void AddRect(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, ImDrawFlags flags) { }
    public void AddRect(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding, ImDrawFlags flags) { }
    public void AddRect(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding, float thickness) { }
    public void AddRect(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, ImDrawFlags flags, float thickness) { }
    public void AddRect(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness) { }
    public void AddRectFilled(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col) { }
    public void AddRectFilled(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding) { }
    public void AddRectFilled(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, ImDrawFlags flags) { }
    public void AddRectFilled(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding, ImDrawFlags flags) { }
    public void AddRectFilledMultiColor(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left) { }
    public void AddText(UnityEngine.Vector2 pos, uint col, string text_begin) { }
    public void AddText(UnityEngine.Vector2 pos, uint col, string text_begin, string text_end) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin, string text_end) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin, float wrap_width) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin, ref UnityEngine.Vector4 cpu_fine_clip_rect) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin, string text_end, float wrap_width) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin, string text_end, ref UnityEngine.Vector4 cpu_fine_clip_rect) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin, float wrap_width, ref UnityEngine.Vector4 cpu_fine_clip_rect) { }
    public void AddText(ImFontPtr font, float font_size, UnityEngine.Vector2 pos, uint col, string text_begin, string text_end, float wrap_width, ref UnityEngine.Vector4 cpu_fine_clip_rect) { }
    public void AddTriangle(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col) { }
    public void AddTriangle(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col, float thickness) { }
    public void AddTriangleFilled(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col) { }
    public void ChannelsMerge() { }
    public void ChannelsSetCurrent(int n) { }
    public void ChannelsSplit(int count) { }
    public ImDrawListPtr CloneOutput() { return default; }
    public UnityEngine.Vector2 GetClipRectMax() { return default; }
    public UnityEngine.Vector2 GetClipRectMin() { return default; }
    public void PathArcTo(UnityEngine.Vector2 center, float radius, float a_min, float a_max) { }
    public void PathArcTo(UnityEngine.Vector2 center, float radius, float a_min, float a_max, int num_segments) { }
    public void PathArcToFast(UnityEngine.Vector2 center, float radius, int a_min_of_12, int a_max_of_12) { }
    public void PathBezierCubicCurveTo(UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4) { }
    public void PathBezierCubicCurveTo(UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, int num_segments) { }
    public void PathBezierQuadraticCurveTo(UnityEngine.Vector2 p2, UnityEngine.Vector2 p3) { }
    public void PathBezierQuadraticCurveTo(UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, int num_segments) { }
    public void PathClear() { }
    public void PathFillConvex(uint col) { }
    public void PathLineTo(UnityEngine.Vector2 pos) { }
    public void PathLineToMergeDuplicate(UnityEngine.Vector2 pos) { }
    public void PathRect(UnityEngine.Vector2 rect_min, UnityEngine.Vector2 rect_max) { }
    public void PathRect(UnityEngine.Vector2 rect_min, UnityEngine.Vector2 rect_max, float rounding) { }
    public void PathRect(UnityEngine.Vector2 rect_min, UnityEngine.Vector2 rect_max, ImDrawFlags flags) { }
    public void PathRect(UnityEngine.Vector2 rect_min, UnityEngine.Vector2 rect_max, float rounding, ImDrawFlags flags) { }
    public void PathStroke(uint col) { }
    public void PathStroke(uint col, ImDrawFlags flags) { }
    public void PathStroke(uint col, float thickness) { }
    public void PathStroke(uint col, ImDrawFlags flags, float thickness) { }
    public void PopClipRect() { }
    public void PopTextureID() { }
    public void PrimQuadUV(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 d, UnityEngine.Vector2 uv_a, UnityEngine.Vector2 uv_b, UnityEngine.Vector2 uv_c, UnityEngine.Vector2 uv_d, uint col) { }
    public void PrimRect(UnityEngine.Vector2 a, UnityEngine.Vector2 b, uint col) { }
    public void PrimRectUV(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 uv_a, UnityEngine.Vector2 uv_b, uint col) { }
    public void PrimReserve(int idx_count, int vtx_count) { }
    public void PrimUnreserve(int idx_count, int vtx_count) { }
    public void PrimVtx(UnityEngine.Vector2 pos, UnityEngine.Vector2 uv, uint col) { }
    public void PrimWriteIdx(ushort idx) { }
    public void PrimWriteVtx(UnityEngine.Vector2 pos, UnityEngine.Vector2 uv, uint col) { }
    public void PushClipRect(UnityEngine.Vector2 clip_rect_min, UnityEngine.Vector2 clip_rect_max) { }
    public void PushClipRect(UnityEngine.Vector2 clip_rect_min, UnityEngine.Vector2 clip_rect_max, bool intersect_with_current_clip_rect) { }
    public void PushClipRectFullScreen() { }
    public void PushTextureID(System.IntPtr texture_id) { }
    public int _CalcCircleAutoSegmentCount(float radius) { return default; }
    public void _ClearFreeMemory() { }
    public void _OnChangedClipRect() { }
    public void _OnChangedTextureID() { }
    public void _OnChangedVtxOffset() { }
    public void _PathArcToFastEx(UnityEngine.Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step) { }
    public void _PathArcToN(UnityEngine.Vector2 center, float radius, float a_min, float a_max, int num_segments) { }
    public void _PopUnusedDrawCmd() { }
    public void _ResetForNewFrame() { }
    public void _TryMergeDrawCmds() { }
    public void ImDrawList_destroy() { }
    public bool Equals(ImDrawListPtr other) { return default; }
    internal static ImDrawListFlags __0;
    internal static uint __1;
    internal static ImDrawListSharedDataPtr __2;
    internal static string __3;
    internal static ImDrawVertPtr __4;
    internal static ImDrawCmdHeader __5;
    internal static ImDrawListSplitter __6;
    internal static float __7;
  }
  public enum ImDrawListFlags
  {
    None = 0,
    AntiAliasedLines = 1,
    AntiAliasedLinesUseTex = 2,
    AntiAliasedFill = 4,
    AllowVtxOffset = 8,
  }
  public struct ImDrawListSharedData
  {
    public UnityEngine.Vector2 TexUvWhitePixel;
    public unsafe ImFont* Font;
    public float FontSize;
    public float CurveTessellationTol;
    public float CircleSegmentMaxError;
    public UnityEngine.Vector4 ClipRectFullscreen;
    public ImDrawListFlags InitialFlags;
    public UnityEngine.Vector2 ArcFastVtx_0;
    public UnityEngine.Vector2 ArcFastVtx_1;
    public UnityEngine.Vector2 ArcFastVtx_2;
    public UnityEngine.Vector2 ArcFastVtx_3;
    public UnityEngine.Vector2 ArcFastVtx_4;
    public UnityEngine.Vector2 ArcFastVtx_5;
    public UnityEngine.Vector2 ArcFastVtx_6;
    public UnityEngine.Vector2 ArcFastVtx_7;
    public UnityEngine.Vector2 ArcFastVtx_8;
    public UnityEngine.Vector2 ArcFastVtx_9;
    public UnityEngine.Vector2 ArcFastVtx_10;
    public UnityEngine.Vector2 ArcFastVtx_11;
    public UnityEngine.Vector2 ArcFastVtx_12;
    public UnityEngine.Vector2 ArcFastVtx_13;
    public UnityEngine.Vector2 ArcFastVtx_14;
    public UnityEngine.Vector2 ArcFastVtx_15;
    public UnityEngine.Vector2 ArcFastVtx_16;
    public UnityEngine.Vector2 ArcFastVtx_17;
    public UnityEngine.Vector2 ArcFastVtx_18;
    public UnityEngine.Vector2 ArcFastVtx_19;
    public UnityEngine.Vector2 ArcFastVtx_20;
    public UnityEngine.Vector2 ArcFastVtx_21;
    public UnityEngine.Vector2 ArcFastVtx_22;
    public UnityEngine.Vector2 ArcFastVtx_23;
    public UnityEngine.Vector2 ArcFastVtx_24;
    public UnityEngine.Vector2 ArcFastVtx_25;
    public UnityEngine.Vector2 ArcFastVtx_26;
    public UnityEngine.Vector2 ArcFastVtx_27;
    public UnityEngine.Vector2 ArcFastVtx_28;
    public UnityEngine.Vector2 ArcFastVtx_29;
    public UnityEngine.Vector2 ArcFastVtx_30;
    public UnityEngine.Vector2 ArcFastVtx_31;
    public UnityEngine.Vector2 ArcFastVtx_32;
    public UnityEngine.Vector2 ArcFastVtx_33;
    public UnityEngine.Vector2 ArcFastVtx_34;
    public UnityEngine.Vector2 ArcFastVtx_35;
    public UnityEngine.Vector2 ArcFastVtx_36;
    public UnityEngine.Vector2 ArcFastVtx_37;
    public UnityEngine.Vector2 ArcFastVtx_38;
    public UnityEngine.Vector2 ArcFastVtx_39;
    public UnityEngine.Vector2 ArcFastVtx_40;
    public UnityEngine.Vector2 ArcFastVtx_41;
    public UnityEngine.Vector2 ArcFastVtx_42;
    public UnityEngine.Vector2 ArcFastVtx_43;
    public UnityEngine.Vector2 ArcFastVtx_44;
    public UnityEngine.Vector2 ArcFastVtx_45;
    public UnityEngine.Vector2 ArcFastVtx_46;
    public UnityEngine.Vector2 ArcFastVtx_47;
    public float ArcFastRadiusCutoff;
    public byte CircleSegmentCounts_0;
    public byte CircleSegmentCounts_1;
    public byte CircleSegmentCounts_2;
    public byte CircleSegmentCounts_3;
    public byte CircleSegmentCounts_4;
    public byte CircleSegmentCounts_5;
    public byte CircleSegmentCounts_6;
    public byte CircleSegmentCounts_7;
    public byte CircleSegmentCounts_8;
    public byte CircleSegmentCounts_9;
    public byte CircleSegmentCounts_10;
    public byte CircleSegmentCounts_11;
    public byte CircleSegmentCounts_12;
    public byte CircleSegmentCounts_13;
    public byte CircleSegmentCounts_14;
    public byte CircleSegmentCounts_15;
    public byte CircleSegmentCounts_16;
    public byte CircleSegmentCounts_17;
    public byte CircleSegmentCounts_18;
    public byte CircleSegmentCounts_19;
    public byte CircleSegmentCounts_20;
    public byte CircleSegmentCounts_21;
    public byte CircleSegmentCounts_22;
    public byte CircleSegmentCounts_23;
    public byte CircleSegmentCounts_24;
    public byte CircleSegmentCounts_25;
    public byte CircleSegmentCounts_26;
    public byte CircleSegmentCounts_27;
    public byte CircleSegmentCounts_28;
    public byte CircleSegmentCounts_29;
    public byte CircleSegmentCounts_30;
    public byte CircleSegmentCounts_31;
    public byte CircleSegmentCounts_32;
    public byte CircleSegmentCounts_33;
    public byte CircleSegmentCounts_34;
    public byte CircleSegmentCounts_35;
    public byte CircleSegmentCounts_36;
    public byte CircleSegmentCounts_37;
    public byte CircleSegmentCounts_38;
    public byte CircleSegmentCounts_39;
    public byte CircleSegmentCounts_40;
    public byte CircleSegmentCounts_41;
    public byte CircleSegmentCounts_42;
    public byte CircleSegmentCounts_43;
    public byte CircleSegmentCounts_44;
    public byte CircleSegmentCounts_45;
    public byte CircleSegmentCounts_46;
    public byte CircleSegmentCounts_47;
    public byte CircleSegmentCounts_48;
    public byte CircleSegmentCounts_49;
    public byte CircleSegmentCounts_50;
    public byte CircleSegmentCounts_51;
    public byte CircleSegmentCounts_52;
    public byte CircleSegmentCounts_53;
    public byte CircleSegmentCounts_54;
    public byte CircleSegmentCounts_55;
    public byte CircleSegmentCounts_56;
    public byte CircleSegmentCounts_57;
    public byte CircleSegmentCounts_58;
    public byte CircleSegmentCounts_59;
    public byte CircleSegmentCounts_60;
    public byte CircleSegmentCounts_61;
    public byte CircleSegmentCounts_62;
    public byte CircleSegmentCounts_63;
    public unsafe UnityEngine.Vector4* TexUvLines;
  }
  public struct ImDrawListSharedDataPtr
  {
    public unsafe ImDrawListSharedData* NativePtr { get => default; }
    public ref UnityEngine.Vector2 TexUvWhitePixel { get => ref __0; }
    public ref ImFontPtr Font { get => ref __1; }
    public ref float FontSize { get => ref __2; }
    public ref float CurveTessellationTol { get => ref __2; }
    public ref float CircleSegmentMaxError { get => ref __2; }
    public ref UnityEngine.Vector4 ClipRectFullscreen { get => ref __3; }
    public ref ImDrawListFlags InitialFlags { get => ref __4; }
    public RangeAccessor<UnityEngine.Vector2> ArcFastVtx { get => default; }
    public ref float ArcFastRadiusCutoff { get => ref __2; }
    public RangeAccessor<byte> CircleSegmentCounts { get => default; }
    public System.IntPtr TexUvLines { get => default; set { } }
    public void SetCircleTessellationMaxError(float max_error) { }
    public void ImDrawListSharedData_destroy() { }
    internal static UnityEngine.Vector2 __0;
    internal static ImFontPtr __1;
    internal static float __2;
    internal static UnityEngine.Vector4 __3;
    internal static ImDrawListFlags __4;
  }
  public struct ImDrawListSplitter
  {
    public int _Current;
    public int _Count;
    public ImVector _Channels;
  }
  public struct ImDrawListSplitterPtr
  {
    public unsafe ImDrawListSplitter* NativePtr { get => default; }
    public ref int _Current { get => ref __0; }
    public ref int _Count { get => ref __0; }
    public ImPtrVector<ImDrawChannelPtr> _Channels { get => default; }
    public void Clear() { }
    public void ClearFreeMemory() { }
    public void Merge(ImDrawListPtr draw_list) { }
    public void SetCurrentChannel(ImDrawListPtr draw_list, int channel_idx) { }
    public void Split(ImDrawListPtr draw_list, int count) { }
    public void ImDrawListSplitter_destroy() { }
    internal static int __0;
  }
  public struct ImDrawVert
  {
    public UnityEngine.Vector2 pos;
    public UnityEngine.Vector2 uv;
    public uint col;
  }
  public struct ImDrawVertPtr
  {
    public unsafe ImDrawVert* NativePtr { get => default; }
    public ref UnityEngine.Vector2 pos { get => ref __0; }
    public ref UnityEngine.Vector2 uv { get => ref __0; }
    public ref uint col { get => ref __1; }
    internal static UnityEngine.Vector2 __0;
    internal static uint __1;
  }
  public struct ImFont
  {
    public ImVector IndexAdvanceX;
    public float FallbackAdvanceX;
    public float FontSize;
    public ImVector IndexLookup;
    public ImVector Glyphs;
    public unsafe ImFontGlyph* FallbackGlyph;
    public unsafe ImFontAtlas* ContainerAtlas;
    public unsafe ImFontConfig* ConfigData;
    public short ConfigDataCount;
    public ushort FallbackChar;
    public ushort EllipsisChar;
    public ushort DotChar;
    public byte DirtyLookupTables;
    public float Scale;
    public float Ascent;
    public float Descent;
    public int MetricsTotalSurface;
    public byte Used4kPagesMap_0;
    public byte Used4kPagesMap_1;
  }
  public struct ImFontPtr
  {
    public unsafe ImFont* NativePtr { get => default; }
    public ImVector<float> IndexAdvanceX { get => default; }
    public ref float FallbackAdvanceX { get => ref __0; }
    public ref float FontSize { get => ref __0; }
    public ImVector<ushort> IndexLookup { get => default; }
    public ImPtrVector<ImFontGlyphPtr> Glyphs { get => default; }
    public ref ImFontGlyphPtr FallbackGlyph { get => ref __1; }
    public ref ImFontAtlasPtr ContainerAtlas { get => ref __2; }
    public ref ImFontConfigPtr ConfigData { get => ref __3; }
    public ref short ConfigDataCount { get => ref __4; }
    public ref ushort FallbackChar { get => ref __5; }
    public ref ushort EllipsisChar { get => ref __5; }
    public ref ushort DotChar { get => ref __5; }
    public ref bool DirtyLookupTables { get => ref __6; }
    public ref float Scale { get => ref __0; }
    public ref float Ascent { get => ref __0; }
    public ref float Descent { get => ref __0; }
    public ref int MetricsTotalSurface { get => ref __7; }
    public RangeAccessor<byte> Used4kPagesMap { get => default; }
    public void AddGlyph(ImFontConfigPtr src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x) { }
    public void AddRemapChar(ushort dst, ushort src) { }
    public void AddRemapChar(ushort dst, ushort src, bool overwrite_dst) { }
    public void BuildLookupTable() { }
    public UnityEngine.Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin) { return default; }
    public UnityEngine.Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin, string text_end) { return default; }
    public unsafe UnityEngine.Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin, ref byte* remaining) { return default; }
    public unsafe UnityEngine.Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, string text_begin, string text_end, ref byte* remaining) { return default; }
    public string CalcWordWrapPositionA(float scale, string text, string text_end, float wrap_width) { return default; }
    public void ClearOutputData() { }
    public ImFontGlyphPtr FindGlyph(ushort c) { return default; }
    public ImFontGlyphPtr FindGlyphNoFallback(ushort c) { return default; }
    public float GetCharAdvance(ushort c) { return default; }
    public string GetDebugName() { return default; }
    public void GrowIndex(int new_size) { }
    public bool IsGlyphRangeUnused(uint c_begin, uint c_last) { return default; }
    public bool IsLoaded() { return default; }
    public void RenderChar(ImDrawListPtr draw_list, float size, UnityEngine.Vector2 pos, uint col, ushort c) { }
    public void RenderText(ImDrawListPtr draw_list, float size, UnityEngine.Vector2 pos, uint col, UnityEngine.Vector4 clip_rect, string text_begin, string text_end) { }
    public void RenderText(ImDrawListPtr draw_list, float size, UnityEngine.Vector2 pos, uint col, UnityEngine.Vector4 clip_rect, string text_begin, string text_end, float wrap_width) { }
    public void RenderText(ImDrawListPtr draw_list, float size, UnityEngine.Vector2 pos, uint col, UnityEngine.Vector4 clip_rect, string text_begin, string text_end, bool cpu_fine_clip) { }
    public void RenderText(ImDrawListPtr draw_list, float size, UnityEngine.Vector2 pos, uint col, UnityEngine.Vector4 clip_rect, string text_begin, string text_end, float wrap_width, bool cpu_fine_clip) { }
    public void SetGlyphVisible(ushort c, bool visible) { }
    public void ImFont_destroy() { }
    public UnityEngine.Vector2 CalcTextSizeA(float font_size, float max_width, float wrap_width, char ch) { return default; }
    public int CalcWordWrapPositionA(float scale, string text, float wrap_width) { return default; }
    public void RenderText(ImDrawListPtr draw_list, float size, UnityEngine.Vector2 pos, uint col, UnityEngine.Vector4 clip_rect, string text, float wrap_width, bool cpu_fine_clip) { }
    internal static float __0;
    internal static ImFontGlyphPtr __1;
    internal static ImFontAtlasPtr __2;
    internal static ImFontConfigPtr __3;
    internal static short __4;
    internal static ushort __5;
    internal static bool __6;
    internal static int __7;
  }
  public struct ImFontAtlas
  {
    public ImFontAtlasFlags Flags;
    public System.IntPtr TexID;
    public int TexDesiredWidth;
    public int TexGlyphPadding;
    public byte Locked;
    public byte TexReady;
    public byte TexPixelsUseColors;
    public unsafe byte* TexPixelsAlpha8;
    public unsafe System.UInt32* TexPixelsRGBA32;
    public int TexWidth;
    public int TexHeight;
    public UnityEngine.Vector2 TexUvScale;
    public UnityEngine.Vector2 TexUvWhitePixel;
    public ImVector Fonts;
    public ImVector CustomRects;
    public ImVector ConfigData;
    public UnityEngine.Vector4 TexUvLines_0;
    public UnityEngine.Vector4 TexUvLines_1;
    public UnityEngine.Vector4 TexUvLines_2;
    public UnityEngine.Vector4 TexUvLines_3;
    public UnityEngine.Vector4 TexUvLines_4;
    public UnityEngine.Vector4 TexUvLines_5;
    public UnityEngine.Vector4 TexUvLines_6;
    public UnityEngine.Vector4 TexUvLines_7;
    public UnityEngine.Vector4 TexUvLines_8;
    public UnityEngine.Vector4 TexUvLines_9;
    public UnityEngine.Vector4 TexUvLines_10;
    public UnityEngine.Vector4 TexUvLines_11;
    public UnityEngine.Vector4 TexUvLines_12;
    public UnityEngine.Vector4 TexUvLines_13;
    public UnityEngine.Vector4 TexUvLines_14;
    public UnityEngine.Vector4 TexUvLines_15;
    public UnityEngine.Vector4 TexUvLines_16;
    public UnityEngine.Vector4 TexUvLines_17;
    public UnityEngine.Vector4 TexUvLines_18;
    public UnityEngine.Vector4 TexUvLines_19;
    public UnityEngine.Vector4 TexUvLines_20;
    public UnityEngine.Vector4 TexUvLines_21;
    public UnityEngine.Vector4 TexUvLines_22;
    public UnityEngine.Vector4 TexUvLines_23;
    public UnityEngine.Vector4 TexUvLines_24;
    public UnityEngine.Vector4 TexUvLines_25;
    public UnityEngine.Vector4 TexUvLines_26;
    public UnityEngine.Vector4 TexUvLines_27;
    public UnityEngine.Vector4 TexUvLines_28;
    public UnityEngine.Vector4 TexUvLines_29;
    public UnityEngine.Vector4 TexUvLines_30;
    public UnityEngine.Vector4 TexUvLines_31;
    public UnityEngine.Vector4 TexUvLines_32;
    public UnityEngine.Vector4 TexUvLines_33;
    public UnityEngine.Vector4 TexUvLines_34;
    public UnityEngine.Vector4 TexUvLines_35;
    public UnityEngine.Vector4 TexUvLines_36;
    public UnityEngine.Vector4 TexUvLines_37;
    public UnityEngine.Vector4 TexUvLines_38;
    public UnityEngine.Vector4 TexUvLines_39;
    public UnityEngine.Vector4 TexUvLines_40;
    public UnityEngine.Vector4 TexUvLines_41;
    public UnityEngine.Vector4 TexUvLines_42;
    public UnityEngine.Vector4 TexUvLines_43;
    public UnityEngine.Vector4 TexUvLines_44;
    public UnityEngine.Vector4 TexUvLines_45;
    public UnityEngine.Vector4 TexUvLines_46;
    public UnityEngine.Vector4 TexUvLines_47;
    public UnityEngine.Vector4 TexUvLines_48;
    public UnityEngine.Vector4 TexUvLines_49;
    public UnityEngine.Vector4 TexUvLines_50;
    public UnityEngine.Vector4 TexUvLines_51;
    public UnityEngine.Vector4 TexUvLines_52;
    public UnityEngine.Vector4 TexUvLines_53;
    public UnityEngine.Vector4 TexUvLines_54;
    public UnityEngine.Vector4 TexUvLines_55;
    public UnityEngine.Vector4 TexUvLines_56;
    public UnityEngine.Vector4 TexUvLines_57;
    public UnityEngine.Vector4 TexUvLines_58;
    public UnityEngine.Vector4 TexUvLines_59;
    public UnityEngine.Vector4 TexUvLines_60;
    public UnityEngine.Vector4 TexUvLines_61;
    public UnityEngine.Vector4 TexUvLines_62;
    public UnityEngine.Vector4 TexUvLines_63;
    public unsafe ImFontBuilderIO* FontBuilderIO;
    public uint FontBuilderFlags;
    public int PackIdMouseCursors;
    public int PackIdLines;
  }
  public struct ImFontAtlasPtr
  {
    public unsafe ImFontAtlas* NativePtr { get => default; }
    public ref ImFontAtlasFlags Flags { get => ref __0; }
    public System.IntPtr TexID { get => default; set { } }
    public ref int TexDesiredWidth { get => ref __1; }
    public ref int TexGlyphPadding { get => ref __1; }
    public ref bool Locked { get => ref __2; }
    public ref bool TexReady { get => ref __2; }
    public ref bool TexPixelsUseColors { get => ref __2; }
    public System.IntPtr TexPixelsAlpha8 { get => default; set { } }
    public System.IntPtr TexPixelsRGBA32 { get => default; set { } }
    public ref int TexWidth { get => ref __1; }
    public ref int TexHeight { get => ref __1; }
    public ref UnityEngine.Vector2 TexUvScale { get => ref __3; }
    public ref UnityEngine.Vector2 TexUvWhitePixel { get => ref __3; }
    public ImVector<ImFontPtr> Fonts { get => default; }
    public ImPtrVector<ImFontAtlasCustomRectPtr> CustomRects { get => default; }
    public ImPtrVector<ImFontConfigPtr> ConfigData { get => default; }
    public RangeAccessor<UnityEngine.Vector4> TexUvLines { get => default; }
    public ref ImFontBuilderIOPtr FontBuilderIO { get => ref __4; }
    public ref uint FontBuilderFlags { get => ref __5; }
    public ref int PackIdMouseCursors { get => ref __1; }
    public ref int PackIdLines { get => ref __1; }
    public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advance_x) { return default; }
    public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advance_x, UnityEngine.Vector2 offset) { return default; }
    public int AddCustomRectRegular(int width, int height) { return default; }
    public ImFontPtr AddFont(ImFontConfigPtr font_cfg) { return default; }
    public ImFontPtr AddFontDefault() { return default; }
    public ImFontPtr AddFontDefault(ImFontConfigPtr font_cfg) { return default; }
    public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels) { return default; }
    public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels, ImFontConfigPtr font_cfg) { return default; }
    public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels, ref ushort glyph_ranges) { return default; }
    public ImFontPtr AddFontFromFileTTF(string filename, float size_pixels, ImFontConfigPtr font_cfg, ref ushort glyph_ranges) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels, ImFontConfigPtr font_cfg) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels, ref ushort glyph_ranges) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedBase85TTF(string compressed_font_data_base85, float size_pixels, ImFontConfigPtr font_cfg, ref ushort glyph_ranges) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedTTF(System.IntPtr compressed_font_data, int compressed_font_size, float size_pixels) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedTTF(System.IntPtr compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfigPtr font_cfg) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedTTF(System.IntPtr compressed_font_data, int compressed_font_size, float size_pixels, ref ushort glyph_ranges) { return default; }
    public ImFontPtr AddFontFromMemoryCompressedTTF(System.IntPtr compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfigPtr font_cfg, ref ushort glyph_ranges) { return default; }
    public ImFontPtr AddFontFromMemoryTTF(System.IntPtr font_data, int font_size, float size_pixels) { return default; }
    public ImFontPtr AddFontFromMemoryTTF(System.IntPtr font_data, int font_size, float size_pixels, ImFontConfigPtr font_cfg) { return default; }
    public ImFontPtr AddFontFromMemoryTTF(System.IntPtr font_data, int font_size, float size_pixels, ref ushort glyph_ranges) { return default; }
    public ImFontPtr AddFontFromMemoryTTF(System.IntPtr font_data, int font_size, float size_pixels, ImFontConfigPtr font_cfg, ref ushort glyph_ranges) { return default; }
    public bool Build() { return default; }
    public void CalcCustomRectUV(ImFontAtlasCustomRectPtr rect, out UnityEngine.Vector2 out_uv_min, out UnityEngine.Vector2 out_uv_max) { out_uv_max = default; out_uv_min = default; }
    public void Clear() { }
    public void ClearFonts() { }
    public void ClearInputData() { }
    public void ClearTexData() { }
    public ImFontAtlasCustomRectPtr GetCustomRectByIndex(int index) { return default; }
    public unsafe ushort* GetGlyphRangesChineseFull() { return default; }
    public unsafe ushort* GetGlyphRangesChineseSimplifiedCommon() { return default; }
    public unsafe ushort* GetGlyphRangesCyrillic() { return default; }
    public unsafe ushort* GetGlyphRangesDefault() { return default; }
    public unsafe ushort* GetGlyphRangesJapanese() { return default; }
    public unsafe ushort* GetGlyphRangesKorean() { return default; }
    public unsafe ushort* GetGlyphRangesThai() { return default; }
    public unsafe ushort* GetGlyphRangesVietnamese() { return default; }
    public bool GetMouseCursorTexData(ImGuiMouseCursor cursor, out UnityEngine.Vector2 out_offset, out UnityEngine.Vector2 out_size, out UnityEngine.Vector2 out_uv_border, out UnityEngine.Vector2 out_uv_fill) { out_uv_fill = default; out_uv_border = default; out_size = default; out_offset = default; return default; }
    public unsafe void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height) { out_height = default; out_width = default; out_pixels = default; }
    public unsafe void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel) { out_bytes_per_pixel = default; out_height = default; out_width = default; out_pixels = default; }
    public unsafe void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height) { out_height = default; out_width = default; out_pixels = default; }
    public unsafe void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel) { out_bytes_per_pixel = default; out_height = default; out_width = default; out_pixels = default; }
    public bool IsBuilt() { return default; }
    public void SetTexID(System.IntPtr id) { }
    public void ImFontAtlas_destroy() { }
    internal static ImFontAtlasFlags __0;
    internal static int __1;
    internal static bool __2;
    internal static UnityEngine.Vector2 __3;
    internal static ImFontBuilderIOPtr __4;
    internal static uint __5;
  }
  public struct ImFontAtlasCustomRect
  {
    public ushort Width;
    public ushort Height;
    public ushort X;
    public ushort Y;
    public uint GlyphID;
    public float GlyphAdvanceX;
    public UnityEngine.Vector2 GlyphOffset;
    public unsafe ImFont* Font;
  }
  public struct ImFontAtlasCustomRectPtr
  {
    public unsafe ImFontAtlasCustomRect* NativePtr { get => default; }
    public ref ushort Width { get => ref __0; }
    public ref ushort Height { get => ref __0; }
    public ref ushort X { get => ref __0; }
    public ref ushort Y { get => ref __0; }
    public ref uint GlyphID { get => ref __1; }
    public ref float GlyphAdvanceX { get => ref __2; }
    public ref UnityEngine.Vector2 GlyphOffset { get => ref __3; }
    public ref ImFontPtr Font { get => ref __4; }
    public bool IsPacked() { return default; }
    public void ImFontAtlasCustomRect_destroy() { }
    internal static ushort __0;
    internal static uint __1;
    internal static float __2;
    internal static UnityEngine.Vector2 __3;
    internal static ImFontPtr __4;
  }
  public enum ImFontAtlasFlags
  {
    None = 0,
    NoPowerOfTwoHeight = 1,
    NoMouseCursors = 2,
    NoBakedLines = 4,
  }
  public struct ImFontBuilderIO
  {
    public System.IntPtr FontBuilder_Build;
  }
  public struct ImFontBuilderIOPtr
  {
    public unsafe ImFontBuilderIO* NativePtr { get => default; }
    public System.IntPtr FontBuilder_Build { get => default; set { } }
  }
  public struct ImFontConfig
  {
    public unsafe void* FontData;
    public int FontDataSize;
    public byte FontDataOwnedByAtlas;
    public int FontNo;
    public float SizePixels;
    public int OversampleH;
    public int OversampleV;
    public byte PixelSnapH;
    public UnityEngine.Vector2 GlyphExtraSpacing;
    public UnityEngine.Vector2 GlyphOffset;
    public unsafe ushort* GlyphRanges;
    public float GlyphMinAdvanceX;
    public float GlyphMaxAdvanceX;
    public byte MergeMode;
    public uint FontBuilderFlags;
    public float RasterizerMultiply;
    public ushort EllipsisChar;
    public byte Name_0;
    public byte Name_1;
    public byte Name_2;
    public byte Name_3;
    public byte Name_4;
    public byte Name_5;
    public byte Name_6;
    public byte Name_7;
    public byte Name_8;
    public byte Name_9;
    public byte Name_10;
    public byte Name_11;
    public byte Name_12;
    public byte Name_13;
    public byte Name_14;
    public byte Name_15;
    public byte Name_16;
    public byte Name_17;
    public byte Name_18;
    public byte Name_19;
    public byte Name_20;
    public byte Name_21;
    public byte Name_22;
    public byte Name_23;
    public byte Name_24;
    public byte Name_25;
    public byte Name_26;
    public byte Name_27;
    public byte Name_28;
    public byte Name_29;
    public byte Name_30;
    public byte Name_31;
    public byte Name_32;
    public byte Name_33;
    public byte Name_34;
    public byte Name_35;
    public byte Name_36;
    public byte Name_37;
    public byte Name_38;
    public byte Name_39;
    public unsafe ImFont* DstFont;
  }
  public struct ImFontConfigPtr
  {
    public unsafe ImFontConfig* NativePtr { get => default; }
    public System.IntPtr FontData { get => default; set { } }
    public ref int FontDataSize { get => ref __0; }
    public ref bool FontDataOwnedByAtlas { get => ref __1; }
    public ref int FontNo { get => ref __0; }
    public ref float SizePixels { get => ref __2; }
    public ref int OversampleH { get => ref __0; }
    public ref int OversampleV { get => ref __0; }
    public ref bool PixelSnapH { get => ref __1; }
    public ref UnityEngine.Vector2 GlyphExtraSpacing { get => ref __3; }
    public ref UnityEngine.Vector2 GlyphOffset { get => ref __3; }
    public System.IntPtr GlyphRanges { get => default; set { } }
    public ref float GlyphMinAdvanceX { get => ref __2; }
    public ref float GlyphMaxAdvanceX { get => ref __2; }
    public ref bool MergeMode { get => ref __1; }
    public ref uint FontBuilderFlags { get => ref __4; }
    public ref float RasterizerMultiply { get => ref __2; }
    public ref ushort EllipsisChar { get => ref __5; }
    public RangeAccessor<byte> Name { get => default; }
    public ref ImFontPtr DstFont { get => ref __6; }
    public void ImFontConfig_destroy() { }
    internal static int __0;
    internal static bool __1;
    internal static float __2;
    internal static UnityEngine.Vector2 __3;
    internal static uint __4;
    internal static ushort __5;
    internal static ImFontPtr __6;
  }
  public struct ImFontGlyph
  {
    public uint Colored;
    public uint Visible;
    public uint Codepoint;
    public float AdvanceX;
    public float X0;
    public float Y0;
    public float X1;
    public float Y1;
    public float U0;
    public float V0;
    public float U1;
    public float V1;
  }
  public struct ImFontGlyphPtr
  {
    public unsafe ImFontGlyph* NativePtr { get => default; }
    public ref uint Colored { get => ref __0; }
    public ref uint Visible { get => ref __0; }
    public ref uint Codepoint { get => ref __0; }
    public ref float AdvanceX { get => ref __1; }
    public ref float X0 { get => ref __1; }
    public ref float Y0 { get => ref __1; }
    public ref float X1 { get => ref __1; }
    public ref float Y1 { get => ref __1; }
    public ref float U0 { get => ref __1; }
    public ref float V0 { get => ref __1; }
    public ref float U1 { get => ref __1; }
    public ref float V1 { get => ref __1; }
    internal static uint __0;
    internal static float __1;
  }
  public struct ImFontGlyphRangesBuilder
  {
    public ImVector UsedChars;
  }
  public struct ImFontGlyphRangesBuilderPtr
  {
    public unsafe ImFontGlyphRangesBuilder* NativePtr { get => default; }
    public ImVector<uint> UsedChars { get => default; }
    public void AddChar(ushort c) { }
    public void AddRanges(ref ushort ranges) { }
    public void AddText(string text) { }
    public void AddText(string text, string text_end) { }
    public void BuildRanges(ImVector out_ranges) { }
    public void Clear() { }
    public bool GetBit(uint n) { return default; }
    public void SetBit(uint n) { }
    public void ImFontGlyphRangesBuilder_destroy() { }
  }
  public class ImGui
  {
    public static ImGuiPayloadPtr AcceptDragDropPayload(string type) { return default; }
    public static ImGuiPayloadPtr AcceptDragDropPayload(string type, ImGuiDragDropFlags flags) { return default; }
    public static void ActivateItem(uint id) { }
    public static uint AddContextHook(System.IntPtr context, System.IntPtr hook) { return default; }
    public static void AddSettingsHandler(ImGuiSettingsHandlerPtr handler) { }
    public static void AlignTextToFramePadding() { }
    public static bool ArrowButton(string str_id, ImGuiDir dir) { return default; }
    public static bool ArrowButtonEx(string str_id, ImGuiDir dir, UnityEngine.Vector2 size_arg) { return default; }
    public static bool ArrowButtonEx(string str_id, ImGuiDir dir, UnityEngine.Vector2 size_arg, ImGuiButtonFlags flags) { return default; }
    public static bool Begin(string name) { return default; }
    public static bool Begin(string name, ref bool p_open) { return default; }
    public static bool Begin(string name, ImGuiWindowFlags flags) { return default; }
    public static bool Begin(string name, ref bool p_open, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(string str_id) { return default; }
    public static bool BeginChild(string str_id, UnityEngine.Vector2 size) { return default; }
    public static bool BeginChild(string str_id, bool border) { return default; }
    public static bool BeginChild(string str_id, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(string str_id, UnityEngine.Vector2 size, bool border) { return default; }
    public static bool BeginChild(string str_id, UnityEngine.Vector2 size, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(string str_id, bool border, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(string str_id, UnityEngine.Vector2 size, bool border, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(uint id) { return default; }
    public static bool BeginChild(uint id, UnityEngine.Vector2 size) { return default; }
    public static bool BeginChild(uint id, bool border) { return default; }
    public static bool BeginChild(uint id, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(uint id, UnityEngine.Vector2 size, bool border) { return default; }
    public static bool BeginChild(uint id, UnityEngine.Vector2 size, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(uint id, bool border, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChild(uint id, UnityEngine.Vector2 size, bool border, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChildEx(string name, uint id, UnityEngine.Vector2 size_arg, bool border, ImGuiWindowFlags flags) { return default; }
    public static bool BeginChildFrame(uint id, UnityEngine.Vector2 size) { return default; }
    public static bool BeginChildFrame(uint id, UnityEngine.Vector2 size, ImGuiWindowFlags flags) { return default; }
    public static void BeginColumns(string str_id, int count) { }
    public static void BeginColumns(string str_id, int count, ImGuiOldColumnFlags flags) { }
    public static bool BeginCombo(string label, string preview_value) { return default; }
    public static bool BeginCombo(string label, string preview_value, ImGuiComboFlags flags) { return default; }
    public static bool BeginComboPopup(uint popup_id, UnityEngine.Rect bb, ImGuiComboFlags flags) { return default; }
    public static bool BeginComboPreview() { return default; }
    public static void BeginDisabled() { }
    public static void BeginDisabled(bool disabled) { }
    public static bool BeginDragDropSource() { return default; }
    public static bool BeginDragDropSource(ImGuiDragDropFlags flags) { return default; }
    public static bool BeginDragDropTarget() { return default; }
    public static bool BeginDragDropTargetCustom(UnityEngine.Rect bb, uint id) { return default; }
    public static void BeginGroup() { }
    public static bool BeginListBox(string label) { return default; }
    public static bool BeginListBox(string label, UnityEngine.Vector2 size) { return default; }
    public static bool BeginMainMenuBar() { return default; }
    public static bool BeginMenu(string label) { return default; }
    public static bool BeginMenu(string label, bool enabled) { return default; }
    public static bool BeginMenuBar() { return default; }
    public static bool BeginMenuEx(string label, string icon) { return default; }
    public static bool BeginMenuEx(string label, string icon, bool enabled) { return default; }
    public static bool BeginPopup(string str_id) { return default; }
    public static bool BeginPopup(string str_id, ImGuiWindowFlags flags) { return default; }
    public static bool BeginPopupContextItem() { return default; }
    public static bool BeginPopupContextItem(string str_id) { return default; }
    public static bool BeginPopupContextItem(ImGuiPopupFlags popup_flags) { return default; }
    public static bool BeginPopupContextItem(string str_id, ImGuiPopupFlags popup_flags) { return default; }
    public static bool BeginPopupContextVoid() { return default; }
    public static bool BeginPopupContextVoid(string str_id) { return default; }
    public static bool BeginPopupContextVoid(ImGuiPopupFlags popup_flags) { return default; }
    public static bool BeginPopupContextVoid(string str_id, ImGuiPopupFlags popup_flags) { return default; }
    public static bool BeginPopupContextWindow() { return default; }
    public static bool BeginPopupContextWindow(string str_id) { return default; }
    public static bool BeginPopupContextWindow(ImGuiPopupFlags popup_flags) { return default; }
    public static bool BeginPopupContextWindow(string str_id, ImGuiPopupFlags popup_flags) { return default; }
    public static bool BeginPopupEx(uint id, ImGuiWindowFlags extra_flags) { return default; }
    public static bool BeginPopupModal(string name) { return default; }
    public static bool BeginPopupModal(string name, ref bool p_open) { return default; }
    public static bool BeginPopupModal(string name, ImGuiWindowFlags flags) { return default; }
    public static bool BeginPopupModal(string name, ref bool p_open, ImGuiWindowFlags flags) { return default; }
    public static bool BeginTabBar(string str_id) { return default; }
    public static bool BeginTabBar(string str_id, ImGuiTabBarFlags flags) { return default; }
    public static bool BeginTabBarEx(ImGuiTabBarPtr tab_bar, UnityEngine.Rect bb, ImGuiTabBarFlags flags) { return default; }
    public static bool BeginTabItem(string label) { return default; }
    public static bool BeginTabItem(string label, ref bool p_open) { return default; }
    public static bool BeginTabItem(string label, ImGuiTabItemFlags flags) { return default; }
    public static bool BeginTabItem(string label, ref bool p_open, ImGuiTabItemFlags flags) { return default; }
    public static bool BeginTable(string str_id, int column) { return default; }
    public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags) { return default; }
    public static bool BeginTable(string str_id, int column, UnityEngine.Vector2 outer_size) { return default; }
    public static bool BeginTable(string str_id, int column, float inner_width) { return default; }
    public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags, UnityEngine.Vector2 outer_size) { return default; }
    public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags, float inner_width) { return default; }
    public static bool BeginTable(string str_id, int column, UnityEngine.Vector2 outer_size, float inner_width) { return default; }
    public static bool BeginTable(string str_id, int column, ImGuiTableFlags flags, UnityEngine.Vector2 outer_size, float inner_width) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count, UnityEngine.Vector2 outer_size) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count, float inner_width) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags, UnityEngine.Vector2 outer_size) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags, float inner_width) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count, UnityEngine.Vector2 outer_size, float inner_width) { return default; }
    public static bool BeginTableEx(string name, uint id, int columns_count, ImGuiTableFlags flags, UnityEngine.Vector2 outer_size, float inner_width) { return default; }
    public static void BeginTooltip() { }
    public static void BeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags) { }
    public static bool BeginViewportSideBar(string name, ImGuiViewportPtr viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags) { return default; }
    public static void BringWindowToDisplayBack(ImGuiWindowPtr window) { }
    public static void BringWindowToDisplayBehind(ImGuiWindowPtr window, ImGuiWindowPtr above_window) { }
    public static void BringWindowToDisplayFront(ImGuiWindowPtr window) { }
    public static void BringWindowToFocusFront(ImGuiWindowPtr window) { }
    public static void Bullet() { }
    public static void BulletText(string fmt) { }
    public static void BulletTextV(string fmt) { }
    public static bool Button(string label) { return default; }
    public static bool Button(string label, UnityEngine.Vector2 size) { return default; }
    public static bool ButtonBehavior(UnityEngine.Rect bb, uint id, out bool out_hovered, out bool out_held) { out_held = default; out_hovered = default; return default; }
    public static bool ButtonBehavior(UnityEngine.Rect bb, uint id, out bool out_hovered, out bool out_held, ImGuiButtonFlags flags) { out_held = default; out_hovered = default; return default; }
    public static bool ButtonEx(string label) { return default; }
    public static bool ButtonEx(string label, UnityEngine.Vector2 size_arg) { return default; }
    public static bool ButtonEx(string label, ImGuiButtonFlags flags) { return default; }
    public static bool ButtonEx(string label, UnityEngine.Vector2 size_arg, ImGuiButtonFlags flags) { return default; }
    public static UnityEngine.Vector2 CalcItemSize(UnityEngine.Vector2 size, float default_w, float default_h) { return default; }
    public static float CalcItemWidth() { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text) { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text, string text_end) { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text, bool hide_text_after_double_hash) { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text, float wrap_width) { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text, string text_end, bool hide_text_after_double_hash) { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text, string text_end, float wrap_width) { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text, bool hide_text_after_double_hash, float wrap_width) { return default; }
    public static UnityEngine.Vector2 CalcTextSize(string text, string text_end, bool hide_text_after_double_hash, float wrap_width) { return default; }
    public static int CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate) { return default; }
    public static UnityEngine.Vector2 CalcWindowNextAutoFitSize(ImGuiWindowPtr window) { return default; }
    public static float CalcWrapWidthForPos(UnityEngine.Vector2 pos, float wrap_pos_x) { return default; }
    public static void CallContextHooks(System.IntPtr context, System.IntPtr type) { }
    public static bool Checkbox(string label, ref bool v) { return default; }
    public static bool CheckboxFlags(string label, ref int flags, int flags_value) { return default; }
    public static bool CheckboxFlags(string label, ref uint flags, uint flags_value) { return default; }
    public static bool CheckboxFlags(string label, ref long flags, long flags_value) { return default; }
    public static bool CheckboxFlags(string label, ref ulong flags, ulong flags_value) { return default; }
    public static void ClearActiveID() { }
    public static void ClearDragDrop() { }
    public static void ClearIniSettings() { }
    public static bool CloseButton(uint id, UnityEngine.Vector2 pos) { return default; }
    public static void CloseCurrentPopup() { }
    public static void ClosePopupToLevel(int remaining, bool restore_focus_to_window_under_popup) { }
    public static void ClosePopupsExceptModals() { }
    public static void ClosePopupsOverWindow(ImGuiWindowPtr ref_window, bool restore_focus_to_window_under_popup) { }
    public static bool CollapseButton(uint id, UnityEngine.Vector2 pos) { return default; }
    public static bool CollapsingHeader(string label) { return default; }
    public static bool CollapsingHeader(string label, ImGuiTreeNodeFlags flags) { return default; }
    public static bool CollapsingHeader(string label, ref bool p_visible) { return default; }
    public static bool CollapsingHeader(string label, ref bool p_visible, ImGuiTreeNodeFlags flags) { return default; }
    public static bool ColorButton(string desc_id, UnityEngine.Vector4 col) { return default; }
    public static bool ColorButton(string desc_id, UnityEngine.Vector4 col, ImGuiColorEditFlags flags) { return default; }
    public static bool ColorButton(string desc_id, UnityEngine.Vector4 col, UnityEngine.Vector2 size) { return default; }
    public static bool ColorButton(string desc_id, UnityEngine.Vector4 col, ImGuiColorEditFlags flags, UnityEngine.Vector2 size) { return default; }
    public static uint ColorConvertFloat4ToU32(UnityEngine.Vector4 @in) { return default; }
    public static void ColorConvertHSVtoRGB(float h, float s, float v, out float out_r, out float out_g, out float out_b) { out_b = default; out_g = default; out_r = default; }
    public static void ColorConvertRGBtoHSV(float r, float g, float b, out float out_h, out float out_s, out float out_v) { out_v = default; out_s = default; out_h = default; }
    public static UnityEngine.Vector4 ColorConvertU32ToFloat4(uint @in) { return default; }
    public static bool ColorEdit3(string label, ref UnityEngine.Vector3 col) { return default; }
    public static bool ColorEdit3(string label, ref UnityEngine.Vector3 col, ImGuiColorEditFlags flags) { return default; }
    public static bool ColorEdit4(string label, ref UnityEngine.Vector4 col) { return default; }
    public static bool ColorEdit4(string label, ref UnityEngine.Vector4 col, ImGuiColorEditFlags flags) { return default; }
    public static void ColorEditOptionsPopup(ref System.Single[] col, ImGuiColorEditFlags flags) { }
    public static bool ColorPicker3(string label, ref UnityEngine.Vector3 col) { return default; }
    public static bool ColorPicker3(string label, ref UnityEngine.Vector3 col, ImGuiColorEditFlags flags) { return default; }
    public static bool ColorPicker4(string label, ref UnityEngine.Vector4 col) { return default; }
    public static bool ColorPicker4(string label, ref UnityEngine.Vector4 col, ImGuiColorEditFlags flags) { return default; }
    public static bool ColorPicker4(string label, ref UnityEngine.Vector4 col, ref System.Single[] ref_col) { return default; }
    public static bool ColorPicker4(string label, ref UnityEngine.Vector4 col, ImGuiColorEditFlags flags, ref System.Single[] ref_col) { return default; }
    public static void ColorPickerOptionsPopup(ref System.Single[] ref_col, ImGuiColorEditFlags flags) { }
    public static void ColorTooltip(string text, ref System.Single[] col, ImGuiColorEditFlags flags) { }
    public static void Columns() { }
    public static void Columns(int count) { }
    public static void Columns(string id) { }
    public static void Columns(bool border) { }
    public static void Columns(int count, string id) { }
    public static void Columns(int count, bool border) { }
    public static void Columns(string id, bool border) { }
    public static void Columns(int count, string id, bool border) { }
    public static bool Combo(string label, ref int current_item, System.String[] items, int items_count) { return default; }
    public static bool Combo(string label, ref int current_item, System.String[] items, int items_count, int popup_max_height_in_items) { return default; }
    public static bool Combo(string label, ref int current_item, string items_separated_by_zeros) { return default; }
    public static bool Combo(string label, ref int current_item, string items_separated_by_zeros, int popup_max_height_in_items) { return default; }
    public static bool Combo(string label, ref int current_item, System.IntPtr items_getter, System.IntPtr data, int items_count) { return default; }
    public static bool Combo(string label, ref int current_item, System.IntPtr items_getter, System.IntPtr data, int items_count, int popup_max_height_in_items) { return default; }
    public static System.IntPtr CreateContext() { return default; }
    public static System.IntPtr CreateContext(ImFontAtlasPtr shared_font_atlas) { return default; }
    public static System.IntPtr CreateNewWindowSettings(string name) { return default; }
    public static bool DataTypeApplyFromText(string buf, ImGuiDataType data_type, System.IntPtr p_data, string format) { return default; }
    public static void DataTypeApplyOp(ImGuiDataType data_type, int op, System.IntPtr output, System.IntPtr arg_1, System.IntPtr arg_2) { }
    public static bool DataTypeClamp(ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static int DataTypeCompare(ImGuiDataType data_type, System.IntPtr arg_1, System.IntPtr arg_2) { return default; }
    public static int DataTypeFormatString(ref byte buf, int buf_size, ImGuiDataType data_type, System.IntPtr p_data, string format) { return default; }
    public static ImGuiDataTypeInfoPtr DataTypeGetInfo(ImGuiDataType data_type) { return default; }
    public static bool DebugCheckVersionAndDataLayout(string version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx) { return default; }
    public static void DebugDrawItemRect() { }
    public static void DebugDrawItemRect(uint col) { }
    public static void DebugHookIdInfo(uint id, ImGuiDataType data_type, System.IntPtr data_id, System.IntPtr data_id_end) { }
    public static void DebugLog(string fmt) { }
    public static void DebugLogV(string fmt) { }
    public static void DebugNodeColumns(ImGuiOldColumnsPtr columns) { }
    public static void DebugNodeDrawList(ImGuiWindowPtr window, ImDrawListPtr draw_list, string label) { }
    public static void DebugNodeFont(ImFontPtr font) { }
    public static void DebugNodeFontGlyph(ImFontPtr font, ImFontGlyphPtr glyph) { }
    public static void DebugNodeInputTextState(System.IntPtr state) { }
    public static void DebugNodeStorage(ImGuiStoragePtr storage, string label) { }
    public static void DebugNodeTabBar(ImGuiTabBarPtr tab_bar, string label) { }
    public static void DebugNodeTable(ImGuiTablePtr table) { }
    public static void DebugNodeTableSettings(ImGuiTableSettingsPtr settings) { }
    public static void DebugNodeViewport(ImGuiViewportPPtr viewport) { }
    public static void DebugNodeWindow(ImGuiWindowPtr window, string label) { }
    public static void DebugNodeWindowSettings(System.IntPtr settings) { }
    public static void DebugNodeWindowsList(ImVector windows, string label) { }
    public static unsafe void DebugNodeWindowsListByBeginStackParent(ref ImGuiWindow* windows, int windows_size, ImGuiWindowPtr parent_in_begin_stack) { }
    public static void DebugRenderViewportThumbnail(ImDrawListPtr draw_list, ImGuiViewportPPtr viewport, UnityEngine.Rect bb) { }
    public static void DebugStartItemPicker() { }
    public static void DebugTextEncoding(string text) { }
    public static void DestroyContext() { }
    public static void DestroyContext(System.IntPtr ctx) { }
    public static bool DragBehavior(uint id, ImGuiDataType data_type, System.IntPtr p_v, float v_speed, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed) { return default; }
    public static bool DragFloat(string label, ref float v, string format) { return default; }
    public static bool DragFloat(string label, ref float v, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, string format) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min, string format) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat(string label, ref float v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, string format) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, string format) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min, float v_max) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min, string format) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min, float v_max, string format) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat2(string label, ref UnityEngine.Vector2 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, string format) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, string format) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min, float v_max) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min, string format) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min, float v_max, string format) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat3(string label, ref UnityEngine.Vector3 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, string format) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, string format) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min, float v_max) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min, string format) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min, float v_max, string format) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloat4(string label, ref UnityEngine.Vector4 v, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, string format) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, string format) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, string format, string format_max) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, string format) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, string format, string format_max) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, string format, string format_max) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed) { return default; }
    public static bool DragInt(string label, ref int v, int v_min) { return default; }
    public static bool DragInt(string label, ref int v, string format) { return default; }
    public static bool DragInt(string label, ref int v, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, string format) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool DragInt(string label, ref int v, int v_min, string format) { return default; }
    public static bool DragInt(string label, ref int v, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min, string format) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool DragInt(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min) { return default; }
    public static bool DragInt2(string label, ref int v, string format) { return default; }
    public static bool DragInt2(string label, ref int v, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, string format) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min, string format) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min, string format) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, string format) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt2(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min) { return default; }
    public static bool DragInt3(string label, ref int v, string format) { return default; }
    public static bool DragInt3(string label, ref int v, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, string format) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min, string format) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min, string format) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, string format) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt3(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min) { return default; }
    public static bool DragInt4(string label, ref int v, string format) { return default; }
    public static bool DragInt4(string label, ref int v, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, string format) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min, string format) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min, string format) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, string format) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragInt4(string label, ref int v, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, string format) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, string format) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, int v_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, string format) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, string format, string format_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, string format) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, string format, string format_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, int v_max, string format) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, string format, string format_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, string format, string format_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, int v_max, string format, string format_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, int v_min, int v_max, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, string format, string format_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, string format) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, string format) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, string format) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, string format) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, string format) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, System.IntPtr p_max, string format) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, System.IntPtr p_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, string format) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, string format) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, string format) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, string format) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max, string format) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, System.IntPtr p_max, string format) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, System.IntPtr p_max, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool DragScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static void Dummy(UnityEngine.Vector2 size) { }
    public static void End() { }
    public static void EndChild() { }
    public static void EndChildFrame() { }
    public static void EndColumns() { }
    public static void EndCombo() { }
    public static void EndComboPreview() { }
    public static void EndDisabled() { }
    public static void EndDragDropSource() { }
    public static void EndDragDropTarget() { }
    public static void EndFrame() { }
    public static void EndGroup() { }
    public static void EndListBox() { }
    public static void EndMainMenuBar() { }
    public static void EndMenu() { }
    public static void EndMenuBar() { }
    public static void EndPopup() { }
    public static void EndTabBar() { }
    public static void EndTabItem() { }
    public static void EndTable() { }
    public static void EndTooltip() { }
    public static UnityEngine.Vector2 FindBestWindowPosForPopup(ImGuiWindowPtr window) { return default; }
    public static UnityEngine.Vector2 FindBestWindowPosForPopupEx(UnityEngine.Vector2 ref_pos, UnityEngine.Vector2 size, ref ImGuiDir last_dir, UnityEngine.Rect r_outer, UnityEngine.Rect r_avoid, ImGuiPopupPositionPolicy policy) { return default; }
    public static ImGuiWindowPtr FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindowPtr window) { return default; }
    public static ImGuiOldColumnsPtr FindOrCreateColumns(ImGuiWindowPtr window, uint id) { return default; }
    public static System.IntPtr FindOrCreateWindowSettings(string name) { return default; }
    public static string FindRenderedTextEnd(string text) { return default; }
    public static string FindRenderedTextEnd(string text, string text_end) { return default; }
    public static ImGuiSettingsHandlerPtr FindSettingsHandler(string type_name) { return default; }
    public static ImGuiWindowPtr FindWindowByID(uint id) { return default; }
    public static ImGuiWindowPtr FindWindowByName(string name) { return default; }
    public static int FindWindowDisplayIndex(ImGuiWindowPtr window) { return default; }
    public static System.IntPtr FindWindowSettings(uint id) { return default; }
    public static void FocusTopMostWindowUnderOne(ImGuiWindowPtr under_this_window, ImGuiWindowPtr ignore_window) { }
    public static void FocusWindow(ImGuiWindowPtr window) { }
    public static void GcAwakeTransientWindowBuffers(ImGuiWindowPtr window) { }
    public static void GcCompactTransientMiscBuffers() { }
    public static void GcCompactTransientWindowBuffers(ImGuiWindowPtr window) { }
    public static uint GetActiveID() { return default; }
    public static ImDrawListPtr GetBackgroundDrawList() { return default; }
    public static ImDrawListPtr GetBackgroundDrawList(ImGuiViewportPtr viewport) { return default; }
    public static string GetClipboardText() { return default; }
    public static uint GetColorU32(ImGuiCol idx) { return default; }
    public static uint GetColorU32(ImGuiCol idx, float alpha_mul) { return default; }
    public static uint GetColorU32(UnityEngine.Vector4 col) { return default; }
    public static uint GetColorU32(uint col) { return default; }
    public static int GetColumnIndex() { return default; }
    public static float GetColumnNormFromOffset(ImGuiOldColumnsPtr columns, float offset) { return default; }
    public static float GetColumnOffset() { return default; }
    public static float GetColumnOffset(int column_index) { return default; }
    public static float GetColumnOffsetFromNorm(ImGuiOldColumnsPtr columns, float offset_norm) { return default; }
    public static float GetColumnWidth() { return default; }
    public static float GetColumnWidth(int column_index) { return default; }
    public static int GetColumnsCount() { return default; }
    public static uint GetColumnsID(string str_id, int count) { return default; }
    public static UnityEngine.Vector2 GetContentRegionAvail() { return default; }
    public static UnityEngine.Vector2 GetContentRegionMax() { return default; }
    public static UnityEngine.Vector2 GetContentRegionMaxAbs() { return default; }
    public static System.IntPtr GetCurrentContext() { return default; }
    public static ImGuiTablePtr GetCurrentTable() { return default; }
    public static ImGuiWindowPtr GetCurrentWindow() { return default; }
    public static ImGuiWindowPtr GetCurrentWindowRead() { return default; }
    public static UnityEngine.Vector2 GetCursorPos() { return default; }
    public static float GetCursorPosX() { return default; }
    public static float GetCursorPosY() { return default; }
    public static UnityEngine.Vector2 GetCursorScreenPos() { return default; }
    public static UnityEngine.Vector2 GetCursorStartPos() { return default; }
    public static ImFontPtr GetDefaultFont() { return default; }
    public static ImGuiPayloadPtr GetDragDropPayload() { return default; }
    public static ImDrawDataPtr GetDrawData() { return default; }
    public static ImDrawListSharedDataPtr GetDrawListSharedData() { return default; }
    public static uint GetFocusID() { return default; }
    public static uint GetFocusScope() { return default; }
    public static uint GetFocusedFocusScope() { return default; }
    public static ImFontPtr GetFont() { return default; }
    public static float GetFontSize() { return default; }
    public static UnityEngine.Vector2 GetFontTexUvWhitePixel() { return default; }
    public static ImDrawListPtr GetForegroundDrawList() { return default; }
    public static ImDrawListPtr GetForegroundDrawList(ImGuiWindowPtr window) { return default; }
    public static ImDrawListPtr GetForegroundDrawList(ImGuiViewportPtr viewport) { return default; }
    public static int GetFrameCount() { return default; }
    public static float GetFrameHeight() { return default; }
    public static float GetFrameHeightWithSpacing() { return default; }
    public static uint GetHoveredID() { return default; }
    public static uint GetID(string str_id) { return default; }
    public static uint GetID(string str_id_begin, string str_id_end) { return default; }
    public static uint GetID(System.IntPtr ptr_id) { return default; }
    public static uint GetIDWithSeed(string str_id_begin, string str_id_end, uint seed) { return default; }
    public static ImGuiIOPtr GetIO() { return default; }
    public static System.IntPtr GetInputTextState(uint id) { return default; }
    public static ImGuiItemFlags GetItemFlags() { return default; }
    public static uint GetItemID() { return default; }
    public static UnityEngine.Vector2 GetItemRectMax() { return default; }
    public static UnityEngine.Vector2 GetItemRectMin() { return default; }
    public static UnityEngine.Vector2 GetItemRectSize() { return default; }
    public static ImGuiItemStatusFlags GetItemStatusFlags() { return default; }
    public static ImGuiKeyDataPtr GetKeyData(ImGuiKey key) { return default; }
    public static int GetKeyIndex(ImGuiKey key) { return default; }
    public static string GetKeyName(ImGuiKey key) { return default; }
    public static int GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate) { return default; }
    public static ImGuiViewportPtr GetMainViewport() { return default; }
    public static ImGuiModFlags GetMergedModFlags() { return default; }
    public static int GetMouseClickedCount(ImGuiMouseButton button) { return default; }
    public static ImGuiMouseCursor GetMouseCursor() { return default; }
    public static UnityEngine.Vector2 GetMouseDragDelta() { return default; }
    public static UnityEngine.Vector2 GetMouseDragDelta(ImGuiMouseButton button) { return default; }
    public static UnityEngine.Vector2 GetMouseDragDelta(float lock_threshold) { return default; }
    public static UnityEngine.Vector2 GetMouseDragDelta(ImGuiMouseButton button, float lock_threshold) { return default; }
    public static UnityEngine.Vector2 GetMousePos() { return default; }
    public static UnityEngine.Vector2 GetMousePosOnOpeningCurrentPopup() { return default; }
    public static float GetNavInputAmount(ImGuiNavInput n, ImGuiNavReadMode mode) { return default; }
    public static UnityEngine.Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiNavReadMode mode) { return default; }
    public static UnityEngine.Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiNavReadMode mode, float slow_factor) { return default; }
    public static UnityEngine.Vector2 GetNavInputAmount2d(ImGuiNavDirSourceFlags dir_sources, ImGuiNavReadMode mode, float slow_factor, float fast_factor) { return default; }
    public static string GetNavInputName(ImGuiNavInput n) { return default; }
    public static UnityEngine.Rect GetPopupAllowedExtentRect(ImGuiWindowPtr window) { return default; }
    public static float GetScrollMaxX() { return default; }
    public static float GetScrollMaxY() { return default; }
    public static float GetScrollX() { return default; }
    public static float GetScrollY() { return default; }
    public static ImGuiStoragePtr GetStateStorage() { return default; }
    public static ImGuiStylePtr GetStyle() { return default; }
    public static string GetStyleColorName(ImGuiCol idx) { return default; }
    public static unsafe UnityEngine.Vector4* GetStyleColorVec4(ImGuiCol idx) { return default; }
    public static float GetTextLineHeight() { return default; }
    public static float GetTextLineHeightWithSpacing() { return default; }
    public static double GetTime() { return default; }
    public static ImGuiWindowPtr GetTopMostAndVisiblePopupModal() { return default; }
    public static ImGuiWindowPtr GetTopMostPopupModal() { return default; }
    public static float GetTreeNodeToLabelSpacing() { return default; }
    public static string GetVersion() { return default; }
    public static UnityEngine.Vector2 GetWindowContentRegionMax() { return default; }
    public static UnityEngine.Vector2 GetWindowContentRegionMin() { return default; }
    public static ImDrawListPtr GetWindowDrawList() { return default; }
    public static float GetWindowHeight() { return default; }
    public static UnityEngine.Vector2 GetWindowPos() { return default; }
    public static uint GetWindowResizeBorderID(ImGuiWindowPtr window, ImGuiDir dir) { return default; }
    public static uint GetWindowResizeCornerID(ImGuiWindowPtr window, int n) { return default; }
    public static uint GetWindowScrollbarID(ImGuiWindowPtr window, ImGuiAxis axis) { return default; }
    public static UnityEngine.Rect GetWindowScrollbarRect(ImGuiWindowPtr window, ImGuiAxis axis) { return default; }
    public static UnityEngine.Vector2 GetWindowSize() { return default; }
    public static float GetWindowWidth() { return default; }
    public static int ImAbs(int x) { return default; }
    public static float ImAbs(float x) { return default; }
    public static double ImAbs(double x) { return default; }
    public static uint ImAlphaBlendColors(uint col_a, uint col_b) { return default; }
    public static UnityEngine.Vector2 ImBezierCubicCalc(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, float t) { return default; }
    public static UnityEngine.Vector2 ImBezierCubicClosestPoint(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 p, int num_segments) { return default; }
    public static UnityEngine.Vector2 ImBezierCubicClosestPointCasteljau(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 p, float tess_tol) { return default; }
    public static UnityEngine.Vector2 ImBezierQuadraticCalc(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, float t) { return default; }
    public static void ImBitArrayClearBit(ref uint arr, int n) { }
    public static void ImBitArraySetBit(ref uint arr, int n) { }
    public static void ImBitArraySetBitRange(ref uint arr, int n, int n2) { }
    public static bool ImBitArrayTestBit(ref uint arr, int n) { return default; }
    public static bool ImCharIsBlankA(byte c) { return default; }
    public static bool ImCharIsBlankW(uint c) { return default; }
    public static UnityEngine.Vector2 ImClamp(UnityEngine.Vector2 v, UnityEngine.Vector2 mn, UnityEngine.Vector2 mx) { return default; }
    public static float ImDot(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { return default; }
    public static unsafe void* ImFileLoadToMemory(string filename, string mode) { return default; }
    public static unsafe void* ImFileLoadToMemory(string filename, string mode, out uint out_file_size) { out_file_size = default; return default; }
    public static unsafe void* ImFileLoadToMemory(string filename, string mode, int padding_bytes) { return default; }
    public static unsafe void* ImFileLoadToMemory(string filename, string mode, out uint out_file_size, int padding_bytes) { out_file_size = default; return default; }
    public static float ImFloor(float f) { return default; }
    public static UnityEngine.Vector2 ImFloor(UnityEngine.Vector2 v) { return default; }
    public static float ImFloorSigned(float f) { return default; }
    public static UnityEngine.Vector2 ImFloorSigned(UnityEngine.Vector2 v) { return default; }
    public static void ImFontAtlasBuildFinish(ImFontAtlasPtr atlas) { }
    public static void ImFontAtlasBuildInit(ImFontAtlasPtr atlas) { }
    public static void ImFontAtlasBuildMultiplyCalcLookupTable(out byte out_table, float in_multiply_factor) { out_table = default; }
    public static void ImFontAtlasBuildMultiplyRectAlpha8(ref byte table, ref byte pixels, int x, int y, int w, int h, int stride) { }
    public static void ImFontAtlasBuildPackCustomRects(ImFontAtlasPtr atlas, System.IntPtr stbrp_context_opaque) { }
    public static void ImFontAtlasBuildRender32bppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, string in_str, byte in_marker_char, uint in_marker_pixel_value) { }
    public static void ImFontAtlasBuildRender8bppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, string in_str, byte in_marker_char, byte in_marker_pixel_value) { }
    public static void ImFontAtlasBuildSetupFont(ImFontAtlasPtr atlas, ImFontPtr font, ImFontConfigPtr font_config, float ascent, float descent) { }
    public static ImFontBuilderIOPtr ImFontAtlasGetBuilderForStbTruetype() { return default; }
    public static int ImFormatString(ref byte buf, uint buf_size, string fmt) { return default; }
    public static unsafe void ImFormatStringToTempBuffer(out byte* out_buf, out byte* out_buf_end, string fmt) { out_buf_end = default; out_buf = default; }
    public static unsafe void ImFormatStringToTempBufferV(out byte* out_buf, out byte* out_buf_end, string fmt) { out_buf_end = default; out_buf = default; }
    public static int ImFormatStringV(ref byte buf, uint buf_size, string fmt) { return default; }
    public static ImGuiDir ImGetDirQuadrantFromDelta(float dx, float dy) { return default; }
    public static uint ImHashData(System.IntPtr data, uint data_size) { return default; }
    public static uint ImHashData(System.IntPtr data, uint data_size, uint seed) { return default; }
    public static uint ImHashStr(string data) { return default; }
    public static uint ImHashStr(string data, uint data_size) { return default; }
    public static uint ImHashStr(string data, uint data_size, uint seed) { return default; }
    public static float ImInvLength(UnityEngine.Vector2 lhs, float fail_value) { return default; }
    public static bool ImIsFloatAboveGuaranteedIntegerPrecision(float f) { return default; }
    public static bool ImIsPowerOfTwo(int v) { return default; }
    public static bool ImIsPowerOfTwo(ulong v) { return default; }
    public static float ImLengthSqr(UnityEngine.Vector2 lhs) { return default; }
    public static float ImLengthSqr(UnityEngine.Vector4 lhs) { return default; }
    public static UnityEngine.Vector2 ImLerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t) { return default; }
    public static UnityEngine.Vector2 ImLerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 t) { return default; }
    public static UnityEngine.Vector4 ImLerp(UnityEngine.Vector4 a, UnityEngine.Vector4 b, float t) { return default; }
    public static UnityEngine.Vector2 ImLineClosestPoint(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p) { return default; }
    public static float ImLinearSweep(float current, float target, float speed) { return default; }
    public static float ImLog(float x) { return default; }
    public static double ImLog(double x) { return default; }
    public static UnityEngine.Vector2 ImMax(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { return default; }
    public static UnityEngine.Vector2 ImMin(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { return default; }
    public static int ImModPositive(int a, int b) { return default; }
    public static UnityEngine.Vector2 ImMul(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { return default; }
    public static string ImParseFormatFindEnd(string format) { return default; }
    public static string ImParseFormatFindStart(string format) { return default; }
    public static int ImParseFormatPrecision(string format, int default_value) { return default; }
    public static void ImParseFormatSanitizeForPrinting(string fmt_in, ref byte fmt_out, uint fmt_out_size) { }
    public static string ImParseFormatSanitizeForScanning(string fmt_in, ref byte fmt_out, uint fmt_out_size) { return default; }
    public static string ImParseFormatTrimDecorations(string format, ref byte buf, uint buf_size) { return default; }
    public static float ImPow(float x, float y) { return default; }
    public static double ImPow(double x, double y) { return default; }
    public static void ImQsort(System.IntPtr @base, uint count, uint size_of_element, System.IntPtr compare_func) { }
    public static UnityEngine.Vector2 ImRotate(UnityEngine.Vector2 v, float cos_a, float sin_a) { return default; }
    public static float ImRsqrt(float x) { return default; }
    public static double ImRsqrt(double x) { return default; }
    public static float ImSaturate(float f) { return default; }
    public static float ImSign(float x) { return default; }
    public static double ImSign(double x) { return default; }
    public static string ImStrSkipBlank(string str) { return default; }
    public static void ImStrTrimBlanks(ref byte str) { }
    public static unsafe ushort* ImStrbolW(ref ushort buf_mid_line, ref ushort buf_begin) { return default; }
    public static string ImStrchrRange(string str_begin, string str_end, byte c) { return default; }
    public static unsafe byte* ImStrdup(string str) { return default; }
    public static unsafe byte* ImStrdupcpy(ref byte dst, ref uint p_dst_size, string str) { return default; }
    public static string ImStreolRange(string str, string str_end) { return default; }
    public static int ImStricmp(string str1, string str2) { return default; }
    public static string ImStristr(string haystack, string haystack_end, string needle, string needle_end) { return default; }
    public static int ImStrlenW(ref ushort str) { return default; }
    public static void ImStrncpy(ref byte dst, string src, uint count) { }
    public static int ImStrnicmp(string str1, string str2, uint count) { return default; }
    public static int ImTextCharFromUtf8(out uint out_char, string in_text, string in_text_end) { out_char = default; return default; }
    public static string ImTextCharToUtf8(out byte out_buf, uint c) { out_buf = default; return default; }
    public static int ImTextCountCharsFromUtf8(string in_text, string in_text_end) { return default; }
    public static int ImTextCountUtf8BytesFromChar(string in_text, string in_text_end) { return default; }
    public static int ImTextCountUtf8BytesFromStr(ref ushort in_text, ref ushort in_text_end) { return default; }
    public static int ImTextStrFromUtf8(out ushort out_buf, int out_buf_size, string in_text, string in_text_end) { out_buf = default; return default; }
    public static unsafe int ImTextStrFromUtf8(out ushort out_buf, int out_buf_size, string in_text, string in_text_end, ref byte* in_remaining) { out_buf = default; return default; }
    public static int ImTextStrToUtf8(out byte out_buf, int out_buf_size, ref ushort in_text, ref ushort in_text_end) { out_buf = default; return default; }
    public static float ImTriangleArea(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c) { return default; }
    public static void ImTriangleBarycentricCoords(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 p, out float out_u, out float out_v, out float out_w) { out_w = default; out_v = default; out_u = default; }
    public static UnityEngine.Vector2 ImTriangleClosestPoint(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 p) { return default; }
    public static bool ImTriangleContainsPoint(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 p) { return default; }
    public static int ImUpperPowerOfTwo(int v) { return default; }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector4 tint_col) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector4 tint_col) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector4 tint_col, UnityEngine.Vector4 border_col) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector4 tint_col) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector4 tint_col, UnityEngine.Vector4 border_col) { }
    public static void Image(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector4 tint_col, UnityEngine.Vector4 border_col) { }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, int frame_padding) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector4 bg_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, int frame_padding) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector4 bg_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, int frame_padding, UnityEngine.Vector4 bg_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, int frame_padding) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector4 bg_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, int frame_padding, UnityEngine.Vector4 bg_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, int frame_padding, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, int frame_padding, UnityEngine.Vector4 bg_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, int frame_padding, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static bool ImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, int frame_padding, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static bool ImageButtonEx(uint id, System.IntPtr texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector2 padding, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static void Indent() { }
    public static void Indent(float indent_w) { }
    public static void Initialize() { }
    public static bool InputDouble(string label, ref double v) { return default; }
    public static bool InputDouble(string label, ref double v, double step) { return default; }
    public static bool InputDouble(string label, ref double v, string format) { return default; }
    public static bool InputDouble(string label, ref double v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputDouble(string label, ref double v, double step, double step_fast) { return default; }
    public static bool InputDouble(string label, ref double v, double step, string format) { return default; }
    public static bool InputDouble(string label, ref double v, double step, ImGuiInputTextFlags flags) { return default; }
    public static bool InputDouble(string label, ref double v, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputDouble(string label, ref double v, double step, double step_fast, string format) { return default; }
    public static bool InputDouble(string label, ref double v, double step, double step_fast, ImGuiInputTextFlags flags) { return default; }
    public static bool InputDouble(string label, ref double v, double step, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputDouble(string label, ref double v, double step, double step_fast, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat(string label, ref float v) { return default; }
    public static bool InputFloat(string label, ref float v, float step) { return default; }
    public static bool InputFloat(string label, ref float v, string format) { return default; }
    public static bool InputFloat(string label, ref float v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat(string label, ref float v, float step, float step_fast) { return default; }
    public static bool InputFloat(string label, ref float v, float step, string format) { return default; }
    public static bool InputFloat(string label, ref float v, float step, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat(string label, ref float v, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat(string label, ref float v, float step, float step_fast, string format) { return default; }
    public static bool InputFloat(string label, ref float v, float step, float step_fast, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat(string label, ref float v, float step, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat(string label, ref float v, float step, float step_fast, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat2(string label, ref UnityEngine.Vector2 v) { return default; }
    public static bool InputFloat2(string label, ref UnityEngine.Vector2 v, string format) { return default; }
    public static bool InputFloat2(string label, ref UnityEngine.Vector2 v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat2(string label, ref UnityEngine.Vector2 v, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat3(string label, ref UnityEngine.Vector3 v) { return default; }
    public static bool InputFloat3(string label, ref UnityEngine.Vector3 v, string format) { return default; }
    public static bool InputFloat3(string label, ref UnityEngine.Vector3 v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat3(string label, ref UnityEngine.Vector3 v, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat4(string label, ref UnityEngine.Vector4 v) { return default; }
    public static bool InputFloat4(string label, ref UnityEngine.Vector4 v, string format) { return default; }
    public static bool InputFloat4(string label, ref UnityEngine.Vector4 v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputFloat4(string label, ref UnityEngine.Vector4 v, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputInt(string label, ref int v) { return default; }
    public static bool InputInt(string label, ref int v, int step) { return default; }
    public static bool InputInt(string label, ref int v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputInt(string label, ref int v, int step, int step_fast) { return default; }
    public static bool InputInt(string label, ref int v, int step, ImGuiInputTextFlags flags) { return default; }
    public static bool InputInt(string label, ref int v, int step, int step_fast, ImGuiInputTextFlags flags) { return default; }
    public static bool InputInt2(string label, ref int v) { return default; }
    public static bool InputInt2(string label, ref int v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputInt3(string label, ref int v) { return default; }
    public static bool InputInt3(string label, ref int v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputInt4(string label, ref int v) { return default; }
    public static bool InputInt4(string label, ref int v, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, string format) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, System.IntPtr p_step_fast) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, string format) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, System.IntPtr p_step_fast, string format) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, System.IntPtr p_step_fast, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, System.IntPtr p_step_fast, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, string format) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, System.IntPtr p_step_fast) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, string format) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, System.IntPtr p_step_fast, string format) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, System.IntPtr p_step_fast, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, System.IntPtr p_step_fast, string format, ImGuiInputTextFlags flags) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size, ImGuiInputTextCallback callback) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size, System.IntPtr user_data) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, System.IntPtr user_data) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputText(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextEx(string label, string hint, ref byte buf, int buf_size, UnityEngine.Vector2 size_arg, ImGuiInputTextFlags flags) { return default; }
    public static bool InputTextEx(string label, string hint, ref byte buf, int buf_size, UnityEngine.Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextEx(string label, string hint, ref byte buf, int buf_size, UnityEngine.Vector2 size_arg, ImGuiInputTextFlags flags, System.IntPtr user_data) { return default; }
    public static bool InputTextEx(string label, string hint, ref byte buf, int buf_size, UnityEngine.Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size, ImGuiInputTextFlags flags) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size, ImGuiInputTextFlags flags, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref byte buf, uint buf_size, UnityEngine.Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size, ImGuiInputTextFlags flags) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size, System.IntPtr user_data) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, System.IntPtr user_data) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref byte buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InvisibleButton(string str_id, UnityEngine.Vector2 size) { return default; }
    public static bool InvisibleButton(string str_id, UnityEngine.Vector2 size, ImGuiButtonFlags flags) { return default; }
    public static bool IsActiveIdUsingKey(ImGuiKey key) { return default; }
    public static bool IsActiveIdUsingNavDir(ImGuiDir dir) { return default; }
    public static bool IsActiveIdUsingNavInput(ImGuiNavInput input) { return default; }
    public static bool IsAnyItemActive() { return default; }
    public static bool IsAnyItemFocused() { return default; }
    public static bool IsAnyItemHovered() { return default; }
    public static bool IsAnyMouseDown() { return default; }
    public static bool IsClippedEx(UnityEngine.Rect bb, uint id) { return default; }
    public static bool IsDragDropActive() { return default; }
    public static bool IsDragDropPayloadBeingAccepted() { return default; }
    public static bool IsGamepadKey(ImGuiKey key) { return default; }
    public static bool IsItemActivated() { return default; }
    public static bool IsItemActive() { return default; }
    public static bool IsItemClicked() { return default; }
    public static bool IsItemClicked(ImGuiMouseButton mouse_button) { return default; }
    public static bool IsItemDeactivated() { return default; }
    public static bool IsItemDeactivatedAfterEdit() { return default; }
    public static bool IsItemEdited() { return default; }
    public static bool IsItemFocused() { return default; }
    public static bool IsItemHovered() { return default; }
    public static bool IsItemHovered(ImGuiHoveredFlags flags) { return default; }
    public static bool IsItemToggledOpen() { return default; }
    public static bool IsItemToggledSelection() { return default; }
    public static bool IsItemVisible() { return default; }
    public static bool IsKeyDown(ImGuiKey key) { return default; }
    public static bool IsKeyPressed(ImGuiKey key) { return default; }
    public static bool IsKeyPressed(ImGuiKey key, bool repeat) { return default; }
    public static bool IsKeyPressedMap(ImGuiKey key) { return default; }
    public static bool IsKeyPressedMap(ImGuiKey key, bool repeat) { return default; }
    public static bool IsKeyReleased(ImGuiKey key) { return default; }
    public static bool IsLegacyKey(ImGuiKey key) { return default; }
    public static bool IsMouseClicked(ImGuiMouseButton button) { return default; }
    public static bool IsMouseClicked(ImGuiMouseButton button, bool repeat) { return default; }
    public static bool IsMouseDoubleClicked(ImGuiMouseButton button) { return default; }
    public static bool IsMouseDown(ImGuiMouseButton button) { return default; }
    public static bool IsMouseDragPastThreshold(ImGuiMouseButton button) { return default; }
    public static bool IsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold) { return default; }
    public static bool IsMouseDragging(ImGuiMouseButton button) { return default; }
    public static bool IsMouseDragging(ImGuiMouseButton button, float lock_threshold) { return default; }
    public static bool IsMouseHoveringRect(UnityEngine.Vector2 r_min, UnityEngine.Vector2 r_max) { return default; }
    public static bool IsMouseHoveringRect(UnityEngine.Vector2 r_min, UnityEngine.Vector2 r_max, bool clip) { return default; }
    public static bool IsMousePosValid() { return default; }
    public static bool IsMousePosValid(ref UnityEngine.Vector2 mouse_pos) { return default; }
    public static bool IsMouseReleased(ImGuiMouseButton button) { return default; }
    public static bool IsNamedKey(ImGuiKey key) { return default; }
    public static bool IsNavInputDown(ImGuiNavInput n) { return default; }
    public static bool IsNavInputTest(ImGuiNavInput n, ImGuiNavReadMode rm) { return default; }
    public static bool IsPopupOpen(string str_id) { return default; }
    public static bool IsPopupOpen(string str_id, ImGuiPopupFlags flags) { return default; }
    public static bool IsPopupOpen(uint id, ImGuiPopupFlags popup_flags) { return default; }
    public static bool IsRectVisible(UnityEngine.Vector2 size) { return default; }
    public static bool IsRectVisible(UnityEngine.Vector2 rect_min, UnityEngine.Vector2 rect_max) { return default; }
    public static bool IsWindowAbove(ImGuiWindowPtr potential_above, ImGuiWindowPtr potential_below) { return default; }
    public static bool IsWindowAppearing() { return default; }
    public static bool IsWindowChildOf(ImGuiWindowPtr window, ImGuiWindowPtr potential_parent, bool popup_hierarchy) { return default; }
    public static bool IsWindowCollapsed() { return default; }
    public static bool IsWindowFocused() { return default; }
    public static bool IsWindowFocused(ImGuiFocusedFlags flags) { return default; }
    public static bool IsWindowHovered() { return default; }
    public static bool IsWindowHovered(ImGuiHoveredFlags flags) { return default; }
    public static bool IsWindowNavFocusable(ImGuiWindowPtr window) { return default; }
    public static bool IsWindowWithinBeginStackOf(ImGuiWindowPtr window, ImGuiWindowPtr potential_parent) { return default; }
    public static bool ItemAdd(UnityEngine.Rect bb, uint id) { return default; }
    public static bool ItemAdd(UnityEngine.Rect bb, uint id, ref UnityEngine.Rect nav_bb) { return default; }
    public static bool ItemAdd(UnityEngine.Rect bb, uint id, ImGuiItemFlags extra_flags) { return default; }
    public static bool ItemAdd(UnityEngine.Rect bb, uint id, ref UnityEngine.Rect nav_bb, ImGuiItemFlags extra_flags) { return default; }
    public static bool ItemHoverable(UnityEngine.Rect bb, uint id) { return default; }
    public static void ItemSize(UnityEngine.Vector2 size) { }
    public static void ItemSize(UnityEngine.Vector2 size, float text_baseline_y) { }
    public static void ItemSize(UnityEngine.Rect bb) { }
    public static void ItemSize(UnityEngine.Rect bb, float text_baseline_y) { }
    public static void KeepAliveID(uint id) { }
    public static void LabelText(string label, string fmt) { }
    public static void LabelTextV(string label, string fmt) { }
    public static bool ListBox(string label, ref int current_item, System.String[] items, int items_count) { return default; }
    public static bool ListBox(string label, ref int current_item, System.String[] items, int items_count, int height_in_items) { return default; }
    public static bool ListBox(string label, ref int current_item, System.IntPtr items_getter, System.IntPtr data, int items_count) { return default; }
    public static bool ListBox(string label, ref int current_item, System.IntPtr items_getter, System.IntPtr data, int items_count, int height_in_items) { return default; }
    public static void LoadIniSettingsFromDisk(string ini_filename) { }
    public static void LoadIniSettingsFromMemory(string ini_data) { }
    public static void LoadIniSettingsFromMemory(string ini_data, uint ini_size) { }
    public static void LogBegin(ImGuiLogType type, int auto_open_depth) { }
    public static void LogButtons() { }
    public static void LogFinish() { }
    public static void LogRenderedText(ref UnityEngine.Vector2 ref_pos, string text) { }
    public static void LogRenderedText(ref UnityEngine.Vector2 ref_pos, string text, string text_end) { }
    public static void LogSetNextTextDecoration(string prefix, string suffix) { }
    public static void LogText(string fmt) { }
    public static void LogTextV(string fmt) { }
    public static void LogToBuffer() { }
    public static void LogToBuffer(int auto_open_depth) { }
    public static void LogToClipboard() { }
    public static void LogToClipboard(int auto_open_depth) { }
    public static void LogToFile() { }
    public static void LogToFile(int auto_open_depth) { }
    public static void LogToFile(string filename) { }
    public static void LogToFile(int auto_open_depth, string filename) { }
    public static void LogToTTY() { }
    public static void LogToTTY(int auto_open_depth) { }
    public static void MarkIniSettingsDirty() { }
    public static void MarkIniSettingsDirty(ImGuiWindowPtr window) { }
    public static void MarkItemEdited(uint id) { }
    public static unsafe void* MemAlloc(uint size) { return default; }
    public static void MemFree(System.IntPtr ptr) { }
    public static bool MenuItem(string label) { return default; }
    public static bool MenuItem(string label, string shortcut) { return default; }
    public static bool MenuItem(string label, bool selected) { return default; }
    public static bool MenuItem(string label, string shortcut, bool selected) { return default; }
    public static bool MenuItem(string label, bool selected, bool enabled) { return default; }
    public static bool MenuItem(string label, string shortcut, bool selected, bool enabled) { return default; }
    public static bool MenuItem(string label, string shortcut, ref bool p_selected) { return default; }
    public static bool MenuItem(string label, string shortcut, ref bool p_selected, bool enabled) { return default; }
    public static bool MenuItemEx(string label, string icon) { return default; }
    public static bool MenuItemEx(string label, string icon, string shortcut) { return default; }
    public static bool MenuItemEx(string label, string icon, bool selected) { return default; }
    public static bool MenuItemEx(string label, string icon, string shortcut, bool selected) { return default; }
    public static bool MenuItemEx(string label, string icon, bool selected, bool enabled) { return default; }
    public static bool MenuItemEx(string label, string icon, string shortcut, bool selected, bool enabled) { return default; }
    public static void NavInitRequestApplyResult() { }
    public static void NavInitWindow(ImGuiWindowPtr window, bool force_reinit) { }
    public static void NavMoveRequestApplyResult() { }
    public static bool NavMoveRequestButNoResultYet() { return default; }
    public static void NavMoveRequestCancel() { }
    public static void NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags) { }
    public static void NavMoveRequestResolveWithLastItem(System.IntPtr result) { }
    public static void NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags) { }
    public static void NavMoveRequestTryWrapping(ImGuiWindowPtr window, ImGuiNavMoveFlags move_flags) { }
    public static void NewFrame() { }
    public static void NewLine() { }
    public static void NextColumn() { }
    public static void OpenPopup(string str_id) { }
    public static void OpenPopup(string str_id, ImGuiPopupFlags popup_flags) { }
    public static void OpenPopup(uint id) { }
    public static void OpenPopup(uint id, ImGuiPopupFlags popup_flags) { }
    public static void OpenPopupEx(uint id) { }
    public static void OpenPopupEx(uint id, ImGuiPopupFlags popup_flags) { }
    public static void OpenPopupOnItemClick() { }
    public static void OpenPopupOnItemClick(string str_id) { }
    public static void OpenPopupOnItemClick(ImGuiPopupFlags popup_flags) { }
    public static void OpenPopupOnItemClick(string str_id, ImGuiPopupFlags popup_flags) { }
    public static int PlotEx(ImGuiPlotType plot_type, string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 frame_size) { return default; }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotHistogram(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, ref System.Single[] values, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min, float scale_max) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min, float scale_max) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PlotLines(string label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, string overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void PopAllowKeyboardFocus() { }
    public static void PopButtonRepeat() { }
    public static void PopClipRect() { }
    public static void PopColumnsBackground() { }
    public static void PopFocusScope() { }
    public static void PopFont() { }
    public static void PopID() { }
    public static void PopItemFlag() { }
    public static void PopItemWidth() { }
    public static void PopStyleColor() { }
    public static void PopStyleColor(int count) { }
    public static void PopStyleVar() { }
    public static void PopStyleVar(int count) { }
    public static void PopTextWrapPos() { }
    public static void ProgressBar(float fraction) { }
    public static void ProgressBar(float fraction, UnityEngine.Vector2 size_arg) { }
    public static void ProgressBar(float fraction, string overlay) { }
    public static void ProgressBar(float fraction, UnityEngine.Vector2 size_arg, string overlay) { }
    public static void PushAllowKeyboardFocus(bool allow_keyboard_focus) { }
    public static void PushButtonRepeat(bool repeat) { }
    public static void PushClipRect(UnityEngine.Vector2 clip_rect_min, UnityEngine.Vector2 clip_rect_max, bool intersect_with_current_clip_rect) { }
    public static void PushColumnClipRect(int column_index) { }
    public static void PushColumnsBackground() { }
    public static void PushFocusScope(uint id) { }
    public static void PushFont(ImFontPtr font) { }
    public static void PushID(string str_id) { }
    public static void PushID(string str_id_begin, string str_id_end) { }
    public static void PushID(System.IntPtr ptr_id) { }
    public static void PushID(int int_id) { }
    public static void PushItemFlag(ImGuiItemFlags option, bool enabled) { }
    public static void PushItemWidth(float item_width) { }
    public static void PushMultiItemsWidths(int components, float width_full) { }
    public static void PushOverrideID(uint id) { }
    public static void PushStyleColor(ImGuiCol idx, uint col) { }
    public static void PushStyleColor(ImGuiCol idx, UnityEngine.Vector4 col) { }
    public static void PushStyleVar(ImGuiStyleVar idx, float val) { }
    public static void PushStyleVar(ImGuiStyleVar idx, UnityEngine.Vector2 val) { }
    public static void PushTextWrapPos() { }
    public static void PushTextWrapPos(float wrap_local_pos_x) { }
    public static bool RadioButton(string label, bool active) { return default; }
    public static bool RadioButton(string label, ref int v, int v_button) { return default; }
    public static void RemoveContextHook(System.IntPtr context, uint hook_to_remove) { }
    public static void RemoveSettingsHandler(string type_name) { }
    public static void Render() { }
    public static void RenderArrow(ImDrawListPtr draw_list, UnityEngine.Vector2 pos, uint col, ImGuiDir dir) { }
    public static void RenderArrow(ImDrawListPtr draw_list, UnityEngine.Vector2 pos, uint col, ImGuiDir dir, float scale) { }
    public static void RenderArrowPointingAt(ImDrawListPtr draw_list, UnityEngine.Vector2 pos, UnityEngine.Vector2 half_sz, ImGuiDir direction, uint col) { }
    public static void RenderBullet(ImDrawListPtr draw_list, UnityEngine.Vector2 pos, uint col) { }
    public static void RenderCheckMark(ImDrawListPtr draw_list, UnityEngine.Vector2 pos, uint col, float sz) { }
    public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, float grid_step, UnityEngine.Vector2 grid_off) { }
    public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, float grid_step, UnityEngine.Vector2 grid_off, float rounding) { }
    public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, float grid_step, UnityEngine.Vector2 grid_off, ImDrawFlags flags) { }
    public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, float grid_step, UnityEngine.Vector2 grid_off, float rounding, ImDrawFlags flags) { }
    public static void RenderFrame(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col) { }
    public static void RenderFrame(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, bool border) { }
    public static void RenderFrame(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, float rounding) { }
    public static void RenderFrame(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, bool border, float rounding) { }
    public static void RenderFrameBorder(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max) { }
    public static void RenderFrameBorder(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, float rounding) { }
    public static void RenderMouseCursor(UnityEngine.Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow) { }
    public static void RenderNavHighlight(UnityEngine.Rect bb, uint id) { }
    public static void RenderNavHighlight(UnityEngine.Rect bb, uint id, ImGuiNavHighlightFlags flags) { }
    public static void RenderRectFilledRangeH(ImDrawListPtr draw_list, UnityEngine.Rect rect, uint col, float x_start_norm, float x_end_norm, float rounding) { }
    public static void RenderRectFilledWithHole(ImDrawListPtr draw_list, UnityEngine.Rect outer, UnityEngine.Rect inner, uint col, float rounding) { }
    public static void RenderText(UnityEngine.Vector2 pos, string text) { }
    public static void RenderText(UnityEngine.Vector2 pos, string text, string text_end) { }
    public static void RenderText(UnityEngine.Vector2 pos, string text, bool hide_text_after_hash) { }
    public static void RenderText(UnityEngine.Vector2 pos, string text, string text_end, bool hide_text_after_hash) { }
    public static void RenderTextClipped(UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known) { }
    public static void RenderTextClipped(UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known, UnityEngine.Vector2 align) { }
    public static void RenderTextClipped(UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known, ref UnityEngine.Rect clip_rect) { }
    public static void RenderTextClipped(UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known, UnityEngine.Vector2 align, ref UnityEngine.Rect clip_rect) { }
    public static void RenderTextClippedEx(ImDrawListPtr draw_list, UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known) { }
    public static void RenderTextClippedEx(ImDrawListPtr draw_list, UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known, UnityEngine.Vector2 align) { }
    public static void RenderTextClippedEx(ImDrawListPtr draw_list, UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known, ref UnityEngine.Rect clip_rect) { }
    public static void RenderTextClippedEx(ImDrawListPtr draw_list, UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known, UnityEngine.Vector2 align, ref UnityEngine.Rect clip_rect) { }
    public static void RenderTextEllipsis(ImDrawListPtr draw_list, UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, float clip_max_x, float ellipsis_max_x, string text, string text_end, ref UnityEngine.Vector2 text_size_if_known) { }
    public static void RenderTextWrapped(UnityEngine.Vector2 pos, string text, string text_end, float wrap_width) { }
    public static void ResetMouseDragDelta() { }
    public static void ResetMouseDragDelta(ImGuiMouseButton button) { }
    public static void SameLine() { }
    public static void SameLine(float offset_from_start_x) { }
    public static void SameLine(float offset_from_start_x, float spacing) { }
    public static void SaveIniSettingsToDisk(string ini_filename) { }
    public static string SaveIniSettingsToMemory() { return default; }
    public static string SaveIniSettingsToMemory(out uint out_ini_size) { out_ini_size = default; return default; }
    public static void ScrollToBringRectIntoView(ImGuiWindowPtr window, UnityEngine.Rect rect) { }
    public static void ScrollToItem() { }
    public static void ScrollToItem(ImGuiScrollFlags flags) { }
    public static void ScrollToRect(ImGuiWindowPtr window, UnityEngine.Rect rect) { }
    public static void ScrollToRect(ImGuiWindowPtr window, UnityEngine.Rect rect, ImGuiScrollFlags flags) { }
    public static UnityEngine.Vector2 ScrollToRectEx(ImGuiWindowPtr window, UnityEngine.Rect rect) { return default; }
    public static UnityEngine.Vector2 ScrollToRectEx(ImGuiWindowPtr window, UnityEngine.Rect rect, ImGuiScrollFlags flags) { return default; }
    public static void Scrollbar(ImGuiAxis axis) { }
    public static bool ScrollbarEx(UnityEngine.Rect bb, uint id, ImGuiAxis axis, ref long p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags) { return default; }
    public static bool Selectable(string label) { return default; }
    public static bool Selectable(string label, bool selected) { return default; }
    public static bool Selectable(string label, ImGuiSelectableFlags flags) { return default; }
    public static bool Selectable(string label, UnityEngine.Vector2 size) { return default; }
    public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags) { return default; }
    public static bool Selectable(string label, bool selected, UnityEngine.Vector2 size) { return default; }
    public static bool Selectable(string label, ImGuiSelectableFlags flags, UnityEngine.Vector2 size) { return default; }
    public static bool Selectable(string label, bool selected, ImGuiSelectableFlags flags, UnityEngine.Vector2 size) { return default; }
    public static bool Selectable(string label, ref bool p_selected) { return default; }
    public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags) { return default; }
    public static bool Selectable(string label, ref bool p_selected, UnityEngine.Vector2 size) { return default; }
    public static bool Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags, UnityEngine.Vector2 size) { return default; }
    public static void Separator() { }
    public static void SeparatorEx(ImGuiSeparatorFlags flags) { }
    public static void SetActiveID(uint id, ImGuiWindowPtr window) { }
    public static void SetActiveIdUsingKey(ImGuiKey key) { }
    public static void SetActiveIdUsingNavAndKeys() { }
    public static void SetClipboardText(string text) { }
    public static void SetColorEditOptions(ImGuiColorEditFlags flags) { }
    public static void SetColumnOffset(int column_index, float offset_x) { }
    public static void SetColumnWidth(int column_index, float width) { }
    public static void SetCurrentContext(System.IntPtr ctx) { }
    public static void SetCurrentFont(ImFontPtr font) { }
    public static void SetCursorPos(UnityEngine.Vector2 local_pos) { }
    public static void SetCursorPosX(float local_x) { }
    public static void SetCursorPosY(float local_y) { }
    public static void SetCursorScreenPos(UnityEngine.Vector2 pos) { }
    public static bool SetDragDropPayload(string type, System.IntPtr data, uint sz) { return default; }
    public static bool SetDragDropPayload(string type, System.IntPtr data, uint sz, ImGuiCond cond) { return default; }
    public static void SetFocusID(uint id, ImGuiWindowPtr window) { }
    public static void SetHoveredID(uint id) { }
    public static void SetItemAllowOverlap() { }
    public static void SetItemDefaultFocus() { }
    public static void SetItemUsingMouseWheel() { }
    public static void SetKeyboardFocusHere() { }
    public static void SetKeyboardFocusHere(int offset) { }
    public static void SetLastItemData(uint item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, UnityEngine.Rect item_rect) { }
    public static void SetMouseCursor(ImGuiMouseCursor cursor_type) { }
    public static void SetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, UnityEngine.Rect rect_rel) { }
    public static void SetNavWindow(ImGuiWindowPtr window) { }
    public static void SetNextFrameWantCaptureKeyboard(bool want_capture_keyboard) { }
    public static void SetNextFrameWantCaptureMouse(bool want_capture_mouse) { }
    public static void SetNextItemOpen(bool is_open) { }
    public static void SetNextItemOpen(bool is_open, ImGuiCond cond) { }
    public static void SetNextItemWidth(float item_width) { }
    public static void SetNextWindowBgAlpha(float alpha) { }
    public static void SetNextWindowCollapsed(bool collapsed) { }
    public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond) { }
    public static void SetNextWindowContentSize(UnityEngine.Vector2 size) { }
    public static void SetNextWindowFocus() { }
    public static void SetNextWindowPos(UnityEngine.Vector2 pos) { }
    public static void SetNextWindowPos(UnityEngine.Vector2 pos, ImGuiCond cond) { }
    public static void SetNextWindowPos(UnityEngine.Vector2 pos, UnityEngine.Vector2 pivot) { }
    public static void SetNextWindowPos(UnityEngine.Vector2 pos, ImGuiCond cond, UnityEngine.Vector2 pivot) { }
    public static void SetNextWindowScroll(UnityEngine.Vector2 scroll) { }
    public static void SetNextWindowSize(UnityEngine.Vector2 size) { }
    public static void SetNextWindowSize(UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static void SetNextWindowSizeConstraints(UnityEngine.Vector2 size_min, UnityEngine.Vector2 size_max) { }
    public static void SetNextWindowSizeConstraints(UnityEngine.Vector2 size_min, UnityEngine.Vector2 size_max, ImGuiSizeCallback custom_callback) { }
    public static void SetNextWindowSizeConstraints(UnityEngine.Vector2 size_min, UnityEngine.Vector2 size_max, System.IntPtr custom_callback_data) { }
    public static void SetNextWindowSizeConstraints(UnityEngine.Vector2 size_min, UnityEngine.Vector2 size_max, ImGuiSizeCallback custom_callback, System.IntPtr custom_callback_data) { }
    public static void SetScrollFromPosX(float local_x) { }
    public static void SetScrollFromPosX(float local_x, float center_x_ratio) { }
    public static void SetScrollFromPosX(ImGuiWindowPtr window, float local_x, float center_x_ratio) { }
    public static void SetScrollFromPosY(float local_y) { }
    public static void SetScrollFromPosY(float local_y, float center_y_ratio) { }
    public static void SetScrollFromPosY(ImGuiWindowPtr window, float local_y, float center_y_ratio) { }
    public static void SetScrollHereX() { }
    public static void SetScrollHereX(float center_x_ratio) { }
    public static void SetScrollHereY() { }
    public static void SetScrollHereY(float center_y_ratio) { }
    public static void SetScrollX(float scroll_x) { }
    public static void SetScrollX(ImGuiWindowPtr window, float scroll_x) { }
    public static void SetScrollY(float scroll_y) { }
    public static void SetScrollY(ImGuiWindowPtr window, float scroll_y) { }
    public static void SetStateStorage(ImGuiStoragePtr storage) { }
    public static void SetTabItemClosed(string tab_or_docked_window_label) { }
    public static void SetTooltip(string fmt) { }
    public static void SetTooltipV(string fmt) { }
    public static void SetWindowClipRectBeforeSetChannel(ImGuiWindowPtr window, UnityEngine.Rect clip_rect) { }
    public static void SetWindowCollapsed(bool collapsed) { }
    public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond) { }
    public static void SetWindowCollapsed(string name, bool collapsed) { }
    public static void SetWindowCollapsed(string name, bool collapsed, ImGuiCond cond) { }
    public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed) { }
    public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed, ImGuiCond cond) { }
    public static void SetWindowFocus() { }
    public static void SetWindowFocus(string name) { }
    public static void SetWindowFontScale(float scale) { }
    public static void SetWindowHitTestHole(ImGuiWindowPtr window, UnityEngine.Vector2 pos, UnityEngine.Vector2 size) { }
    public static void SetWindowPos(UnityEngine.Vector2 pos) { }
    public static void SetWindowPos(UnityEngine.Vector2 pos, ImGuiCond cond) { }
    public static void SetWindowPos(string name, UnityEngine.Vector2 pos) { }
    public static void SetWindowPos(string name, UnityEngine.Vector2 pos, ImGuiCond cond) { }
    public static void SetWindowPos(ImGuiWindowPtr window, UnityEngine.Vector2 pos) { }
    public static void SetWindowPos(ImGuiWindowPtr window, UnityEngine.Vector2 pos, ImGuiCond cond) { }
    public static void SetWindowSize(UnityEngine.Vector2 size) { }
    public static void SetWindowSize(UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static void SetWindowSize(string name, UnityEngine.Vector2 size) { }
    public static void SetWindowSize(string name, UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static void SetWindowSize(ImGuiWindowPtr window, UnityEngine.Vector2 size) { }
    public static void SetWindowSize(ImGuiWindowPtr window, UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static void SetWindowViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport) { }
    public static void ShadeVertsLinearColorGradientKeepAlpha(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, UnityEngine.Vector2 gradient_p0, UnityEngine.Vector2 gradient_p1, uint col0, uint col1) { }
    public static void ShadeVertsLinearUV(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 uv_a, UnityEngine.Vector2 uv_b, bool clamp) { }
    public static void ShowAboutWindow() { }
    public static void ShowAboutWindow(ref bool p_open) { }
    public static void ShowDebugLogWindow() { }
    public static void ShowDebugLogWindow(ref bool p_open) { }
    public static void ShowDemoWindow() { }
    public static void ShowDemoWindow(ref bool p_open) { }
    public static void ShowFontAtlas(ImFontAtlasPtr atlas) { }
    public static void ShowFontSelector(string label) { }
    public static void ShowMetricsWindow() { }
    public static void ShowMetricsWindow(ref bool p_open) { }
    public static void ShowStackToolWindow() { }
    public static void ShowStackToolWindow(ref bool p_open) { }
    public static void ShowStyleEditor() { }
    public static void ShowStyleEditor(ImGuiStylePtr @ref) { }
    public static bool ShowStyleSelector(string label) { return default; }
    public static void ShowUserGuide() { }
    public static void ShrinkWidths(ImGuiShrinkWidthItemPtr items, int count, float width_excess) { }
    public static void Shutdown() { }
    public static bool SliderAngle(string label, ref float v_rad) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, string format) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, ImGuiSliderFlags flags) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, string format) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, ImGuiSliderFlags flags) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, string format) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderAngle(string label, ref float v_rad, float v_degrees_min, float v_degrees_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderBehavior(UnityEngine.Rect bb, uint id, ImGuiDataType data_type, System.IntPtr p_v, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags, out UnityEngine.Rect out_grab_bb) { out_grab_bb = default; return default; }
    public static bool SliderFloat(string label, ref float v, float v_min, float v_max) { return default; }
    public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format) { return default; }
    public static bool SliderFloat(string label, ref float v, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderFloat(string label, ref float v, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderFloat2(string label, ref UnityEngine.Vector2 v, float v_min, float v_max) { return default; }
    public static bool SliderFloat2(string label, ref UnityEngine.Vector2 v, float v_min, float v_max, string format) { return default; }
    public static bool SliderFloat2(string label, ref UnityEngine.Vector2 v, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderFloat2(string label, ref UnityEngine.Vector2 v, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderFloat3(string label, ref UnityEngine.Vector3 v, float v_min, float v_max) { return default; }
    public static bool SliderFloat3(string label, ref UnityEngine.Vector3 v, float v_min, float v_max, string format) { return default; }
    public static bool SliderFloat3(string label, ref UnityEngine.Vector3 v, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderFloat3(string label, ref UnityEngine.Vector3 v, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderFloat4(string label, ref UnityEngine.Vector4 v, float v_min, float v_max) { return default; }
    public static bool SliderFloat4(string label, ref UnityEngine.Vector4 v, float v_min, float v_max, string format) { return default; }
    public static bool SliderFloat4(string label, ref UnityEngine.Vector4 v, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderFloat4(string label, ref UnityEngine.Vector4 v, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool SliderInt(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt2(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool SliderInt2(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool SliderInt2(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt2(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt3(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool SliderInt3(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool SliderInt3(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt3(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt4(string label, ref int v, int v_min, int v_max) { return default; }
    public static bool SliderInt4(string label, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool SliderInt4(string label, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderInt4(string label, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static bool SliderScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, string format) { return default; }
    public static bool SliderScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderScalar(string label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SliderScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static bool SliderScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max, string format) { return default; }
    public static bool SliderScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max, ImGuiSliderFlags flags) { return default; }
    public static bool SliderScalarN(string label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool SmallButton(string label) { return default; }
    public static void Spacing() { }
    public static bool SplitterBehavior(UnityEngine.Rect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2) { return default; }
    public static bool SplitterBehavior(UnityEngine.Rect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend) { return default; }
    public static bool SplitterBehavior(UnityEngine.Rect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay) { return default; }
    public static void StartMouseMovingWindow(ImGuiWindowPtr window) { }
    public static void StyleColorsClassic() { }
    public static void StyleColorsClassic(ImGuiStylePtr dst) { }
    public static void StyleColorsDark() { }
    public static void StyleColorsDark(ImGuiStylePtr dst) { }
    public static void StyleColorsLight() { }
    public static void StyleColorsLight(ImGuiStylePtr dst) { }
    public static void TabBarCloseTab(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab) { }
    public static ImGuiTabItemPtr TabBarFindTabByID(ImGuiTabBarPtr tab_bar, uint tab_id) { return default; }
    public static bool TabBarProcessReorder(ImGuiTabBarPtr tab_bar) { return default; }
    public static void TabBarQueueReorder(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, int offset) { }
    public static void TabBarQueueReorderFromMousePos(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, UnityEngine.Vector2 mouse_pos) { }
    public static void TabBarRemoveTab(ImGuiTabBarPtr tab_bar, uint tab_id) { }
    public static void TabItemBackground(ImDrawListPtr draw_list, UnityEngine.Rect bb, ImGuiTabItemFlags flags, uint col) { }
    public static bool TabItemButton(string label) { return default; }
    public static bool TabItemButton(string label, ImGuiTabItemFlags flags) { return default; }
    public static UnityEngine.Vector2 TabItemCalcSize(string label, bool has_close_button) { return default; }
    public static bool TabItemEx(ImGuiTabBarPtr tab_bar, string label, ref bool p_open, ImGuiTabItemFlags flags) { return default; }
    public static void TabItemLabelAndCloseButton(ImDrawListPtr draw_list, UnityEngine.Rect bb, ImGuiTabItemFlags flags, UnityEngine.Vector2 frame_padding, string label, uint tab_id, uint close_button_id, bool is_contents_visible, out bool out_just_closed, out bool out_text_clipped) { out_text_clipped = default; out_just_closed = default; }
    public static void TableBeginApplyRequests(ImGuiTablePtr table) { }
    public static void TableBeginCell(ImGuiTablePtr table, int column_n) { }
    public static void TableBeginInitMemory(ImGuiTablePtr table, int columns_count) { }
    public static void TableBeginRow(ImGuiTablePtr table) { }
    public static void TableDrawBorders(ImGuiTablePtr table) { }
    public static void TableDrawContextMenu(ImGuiTablePtr table) { }
    public static void TableEndCell(ImGuiTablePtr table) { }
    public static void TableEndRow(ImGuiTablePtr table) { }
    public static ImGuiTablePtr TableFindByID(uint id) { return default; }
    public static void TableFixColumnSortDirection(ImGuiTablePtr table, ImGuiTableColumnPtr column) { }
    public static void TableGcCompactSettings() { }
    public static void TableGcCompactTransientBuffers(ImGuiTablePtr table) { }
    public static void TableGcCompactTransientBuffers(ImGuiTableTempDataPtr table) { }
    public static ImGuiTableSettingsPtr TableGetBoundSettings(ImGuiTablePtr table) { return default; }
    public static UnityEngine.Rect TableGetCellBgRect(ImGuiTablePtr table, int column_n) { return default; }
    public static int TableGetColumnCount() { return default; }
    public static ImGuiTableColumnFlags TableGetColumnFlags() { return default; }
    public static ImGuiTableColumnFlags TableGetColumnFlags(int column_n) { return default; }
    public static int TableGetColumnIndex() { return default; }
    public static string TableGetColumnName() { return default; }
    public static string TableGetColumnName(int column_n) { return default; }
    public static string TableGetColumnName(ImGuiTablePtr table, int column_n) { return default; }
    public static ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumnPtr column) { return default; }
    public static uint TableGetColumnResizeID(ImGuiTablePtr table, int column_n) { return default; }
    public static uint TableGetColumnResizeID(ImGuiTablePtr table, int column_n, int instance_no) { return default; }
    public static float TableGetColumnWidthAuto(ImGuiTablePtr table, ImGuiTableColumnPtr column) { return default; }
    public static float TableGetHeaderRowHeight() { return default; }
    public static int TableGetHoveredColumn() { return default; }
    public static ImGuiTableInstanceDataPtr TableGetInstanceData(ImGuiTablePtr table, int instance_no) { return default; }
    public static float TableGetMaxColumnWidth(ImGuiTablePtr table, int column_n) { return default; }
    public static int TableGetRowIndex() { return default; }
    public static ImGuiTableSortSpecsPtr TableGetSortSpecs() { return default; }
    public static void TableHeader(string label) { }
    public static void TableHeadersRow() { }
    public static void TableLoadSettings(ImGuiTablePtr table) { }
    public static void TableMergeDrawChannels(ImGuiTablePtr table) { }
    public static bool TableNextColumn() { return default; }
    public static void TableNextRow() { }
    public static void TableNextRow(ImGuiTableRowFlags row_flags) { }
    public static void TableNextRow(float min_row_height) { }
    public static void TableNextRow(ImGuiTableRowFlags row_flags, float min_row_height) { }
    public static void TableOpenContextMenu() { }
    public static void TableOpenContextMenu(int column_n) { }
    public static void TablePopBackgroundChannel() { }
    public static void TablePushBackgroundChannel() { }
    public static void TableRemove(ImGuiTablePtr table) { }
    public static void TableResetSettings(ImGuiTablePtr table) { }
    public static void TableSaveSettings(ImGuiTablePtr table) { }
    public static void TableSetBgColor(ImGuiTableBgTarget target, uint color) { }
    public static void TableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n) { }
    public static void TableSetColumnEnabled(int column_n, bool v) { }
    public static bool TableSetColumnIndex(int column_n) { return default; }
    public static void TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, bool append_to_sort_specs) { }
    public static void TableSetColumnWidth(int column_n, float width) { }
    public static void TableSetColumnWidthAutoAll(ImGuiTablePtr table) { }
    public static void TableSetColumnWidthAutoSingle(ImGuiTablePtr table, int column_n) { }
    public static void TableSettingsAddSettingsHandler() { }
    public static ImGuiTableSettingsPtr TableSettingsCreate(uint id, int columns_count) { return default; }
    public static ImGuiTableSettingsPtr TableSettingsFindByID(uint id) { return default; }
    public static void TableSetupColumn(string label) { }
    public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags) { }
    public static void TableSetupColumn(string label, float init_width_or_weight) { }
    public static void TableSetupColumn(string label, uint user_id) { }
    public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags, float init_width_or_weight) { }
    public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags, uint user_id) { }
    public static void TableSetupColumn(string label, float init_width_or_weight, uint user_id) { }
    public static void TableSetupColumn(string label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id) { }
    public static void TableSetupDrawChannels(ImGuiTablePtr table) { }
    public static void TableSetupScrollFreeze(int cols, int rows) { }
    public static void TableSortSpecsBuild(ImGuiTablePtr table) { }
    public static void TableSortSpecsSanitize(ImGuiTablePtr table) { }
    public static void TableUpdateBorders(ImGuiTablePtr table) { }
    public static void TableUpdateColumnsWeightFromWidth(ImGuiTablePtr table) { }
    public static void TableUpdateLayout(ImGuiTablePtr table) { }
    public static bool TempInputIsActive(uint id) { return default; }
    public static bool TempInputScalar(UnityEngine.Rect bb, uint id, string label, ImGuiDataType data_type, System.IntPtr p_data, string format) { return default; }
    public static bool TempInputScalar(UnityEngine.Rect bb, uint id, string label, ImGuiDataType data_type, System.IntPtr p_data, string format, System.IntPtr p_clamp_min) { return default; }
    public static bool TempInputScalar(UnityEngine.Rect bb, uint id, string label, ImGuiDataType data_type, System.IntPtr p_data, string format, System.IntPtr p_clamp_min, System.IntPtr p_clamp_max) { return default; }
    public static bool TempInputText(UnityEngine.Rect bb, uint id, string label, ref byte buf, int buf_size, ImGuiInputTextFlags flags) { return default; }
    public static void Text(string fmt) { }
    public static void TextColored(UnityEngine.Vector4 col, string fmt) { }
    public static void TextColoredV(UnityEngine.Vector4 col, string fmt) { }
    public static void TextDisabled(string fmt) { }
    public static void TextDisabledV(string fmt) { }
    public static void TextEx(string text) { }
    public static void TextEx(string text, string text_end) { }
    public static void TextEx(string text, ImGuiTextFlags flags) { }
    public static void TextEx(string text, string text_end, ImGuiTextFlags flags) { }
    public static void TextUnformatted(string text) { }
    public static void TextUnformatted(string text, string text_end) { }
    public static void TextV(string fmt) { }
    public static void TextWrapped(string fmt) { }
    public static void TextWrappedV(string fmt) { }
    public static bool TreeNode(string label) { return default; }
    public static bool TreeNode(string str_id, string fmt) { return default; }
    public static bool TreeNode(System.IntPtr ptr_id, string fmt) { return default; }
    public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, string label) { return default; }
    public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, string label, string label_end) { return default; }
    public static bool TreeNodeBehaviorIsOpen(uint id) { return default; }
    public static bool TreeNodeBehaviorIsOpen(uint id, ImGuiTreeNodeFlags flags) { return default; }
    public static bool TreeNodeEx(string label) { return default; }
    public static bool TreeNodeEx(string label, ImGuiTreeNodeFlags flags) { return default; }
    public static bool TreeNodeEx(string str_id, ImGuiTreeNodeFlags flags, string fmt) { return default; }
    public static bool TreeNodeEx(System.IntPtr ptr_id, ImGuiTreeNodeFlags flags, string fmt) { return default; }
    public static bool TreeNodeExV(string str_id, ImGuiTreeNodeFlags flags, string fmt) { return default; }
    public static bool TreeNodeExV(System.IntPtr ptr_id, ImGuiTreeNodeFlags flags, string fmt) { return default; }
    public static bool TreeNodeV(string str_id, string fmt) { return default; }
    public static bool TreeNodeV(System.IntPtr ptr_id, string fmt) { return default; }
    public static void TreePop() { }
    public static void TreePush(string str_id) { }
    public static void TreePush() { }
    public static void TreePush(System.IntPtr ptr_id) { }
    public static void TreePushOverrideID(uint id) { }
    public static void Unindent() { }
    public static void Unindent(float indent_w) { }
    public static void UpdateHoveredWindowAndCaptureFlags() { }
    public static void UpdateInputEvents(bool trickle_fast_inputs) { }
    public static void UpdateMouseMovingWindowEndFrame() { }
    public static void UpdateMouseMovingWindowNewFrame() { }
    public static void UpdateWindowParentAndRootLinks(ImGuiWindowPtr window, ImGuiWindowFlags flags, ImGuiWindowPtr parent_window) { }
    public static bool VSliderFloat(string label, UnityEngine.Vector2 size, ref float v, float v_min, float v_max) { return default; }
    public static bool VSliderFloat(string label, UnityEngine.Vector2 size, ref float v, float v_min, float v_max, string format) { return default; }
    public static bool VSliderFloat(string label, UnityEngine.Vector2 size, ref float v, float v_min, float v_max, ImGuiSliderFlags flags) { return default; }
    public static bool VSliderFloat(string label, UnityEngine.Vector2 size, ref float v, float v_min, float v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool VSliderInt(string label, UnityEngine.Vector2 size, ref int v, int v_min, int v_max) { return default; }
    public static bool VSliderInt(string label, UnityEngine.Vector2 size, ref int v, int v_min, int v_max, string format) { return default; }
    public static bool VSliderInt(string label, UnityEngine.Vector2 size, ref int v, int v_min, int v_max, ImGuiSliderFlags flags) { return default; }
    public static bool VSliderInt(string label, UnityEngine.Vector2 size, ref int v, int v_min, int v_max, string format, ImGuiSliderFlags flags) { return default; }
    public static bool VSliderScalar(string label, UnityEngine.Vector2 size, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static bool VSliderScalar(string label, UnityEngine.Vector2 size, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, string format) { return default; }
    public static bool VSliderScalar(string label, UnityEngine.Vector2 size, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, ImGuiSliderFlags flags) { return default; }
    public static bool VSliderScalar(string label, UnityEngine.Vector2 size, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, string format, ImGuiSliderFlags flags) { return default; }
    public static void Value(string prefix, bool b) { }
    public static void Value(string prefix, int v) { }
    public static void Value(string prefix, uint v) { }
    public static void Value(string prefix, float v) { }
    public static void Value(string prefix, float v, string float_format) { }
    public static UnityEngine.Rect WindowRectAbsToRel(ImGuiWindowPtr window, UnityEngine.Rect r) { return default; }
    public static UnityEngine.Rect WindowRectRelToAbs(ImGuiWindowPtr window, UnityEngine.Rect r) { return default; }
    public static ImGuiInputTextCallback CreateInputTextCallback(ImGuiInputTextSafeCallback callback) { return default; }
    public static ImGuiSizeCallback CreateSizeCallback(ImGuiSizeSafeCallback callback) { return default; }
    public static void SetDragDropPayload<T>(string type, T data, ImGuiCond cond) { }
    public static bool AcceptDragDropPayload<T>(string type, out T payload, ImGuiDragDropFlags flags) { payload = default; return default; }
    public static void SetDragDropPayload(string type, string data, ImGuiCond cond) { }
    public static bool AcceptDragDropPayload(string type, out string payload, ImGuiDragDropFlags flags) { payload = default; return default; }
    public static bool InputTextWithHint(string label, string hint, ref string input, uint maxLength) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref string input, uint maxLength, ImGuiInputTextFlags flags) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref string input, uint maxLength, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextWithHint(string label, string hint, ref string input, uint maxLength, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputText(string label, System.Byte[] buf, uint buf_size) { return default; }
    public static bool InputText(string label, System.Byte[] buf, uint buf_size, ImGuiInputTextFlags flags) { return default; }
    public static bool InputText(string label, System.Byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputText(string label, System.Byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputText(string label, ref string input, uint maxLength) { return default; }
    public static bool InputText(string label, ref string input, uint maxLength, ImGuiInputTextFlags flags) { return default; }
    public static bool InputText(string label, ref string input, uint maxLength, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputText(string label, ref string input, uint maxLength, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputTextMultiline(string label, ref string input, uint maxLength, UnityEngine.Vector2 size) { return default; }
    public static bool InputTextMultiline(string label, ref string input, uint maxLength, UnityEngine.Vector2 size, ImGuiInputTextFlags flags) { return default; }
    public static bool InputTextMultiline(string label, ref string input, uint maxLength, UnityEngine.Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputTextMultiline(string label, ref string input, uint maxLength, UnityEngine.Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static bool InputText(string label, System.IntPtr buf, uint buf_size) { return default; }
    public static bool InputText(string label, System.IntPtr buf, uint buf_size, ImGuiInputTextFlags flags) { return default; }
    public static bool InputText(string label, System.IntPtr buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback) { return default; }
    public static bool InputText(string label, System.IntPtr buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
  }
  public enum ImGuiActivateFlags
  {
    None = 0,
    PreferInput = 1,
    PreferTweak = 2,
    TryToPreserveState = 4,
  }
  public enum ImGuiAxis
  {
    X = 0,
    Y = 1,
    None = -1,
  }
  public enum ImGuiBackendFlags
  {
    None = 0,
    HasGamepad = 1,
    HasMouseCursors = 2,
    HasSetMousePos = 4,
    RendererHasVtxOffset = 8,
  }
  public enum ImGuiButtonFlags
  {
    None = 0,
    MouseButtonLeft = 1,
    MouseButtonDefault_ = 1,
    MouseButtonRight = 2,
    MouseButtonMiddle = 4,
    MouseButtonMask_ = 7,
  }
  public enum ImGuiCol
  {
    Text = 0,
    TextDisabled = 1,
    WindowBg = 2,
    ChildBg = 3,
    PopupBg = 4,
    Border = 5,
    BorderShadow = 6,
    FrameBg = 7,
    FrameBgHovered = 8,
    FrameBgActive = 9,
    TitleBg = 10,
    TitleBgActive = 11,
    TitleBgCollapsed = 12,
    MenuBarBg = 13,
    ScrollbarBg = 14,
    ScrollbarGrab = 15,
    ScrollbarGrabHovered = 16,
    ScrollbarGrabActive = 17,
    CheckMark = 18,
    SliderGrab = 19,
    SliderGrabActive = 20,
    Button = 21,
    ButtonHovered = 22,
    ButtonActive = 23,
    Header = 24,
    HeaderHovered = 25,
    HeaderActive = 26,
    Separator = 27,
    SeparatorHovered = 28,
    SeparatorActive = 29,
    ResizeGrip = 30,
    ResizeGripHovered = 31,
    ResizeGripActive = 32,
    Tab = 33,
    TabHovered = 34,
    TabActive = 35,
    TabUnfocused = 36,
    TabUnfocusedActive = 37,
    PlotLines = 38,
    PlotLinesHovered = 39,
    PlotHistogram = 40,
    PlotHistogramHovered = 41,
    TableHeaderBg = 42,
    TableBorderStrong = 43,
    TableBorderLight = 44,
    TableRowBg = 45,
    TableRowBgAlt = 46,
    TextSelectedBg = 47,
    DragDropTarget = 48,
    NavHighlight = 49,
    NavWindowingHighlight = 50,
    NavWindowingDimBg = 51,
    ModalWindowDimBg = 52,
    COUNT = 53,
  }
  public enum ImGuiColorEditFlags
  {
    None = 0,
    NoAlpha = 2,
    NoPicker = 4,
    NoOptions = 8,
    NoSmallPreview = 16,
    NoInputs = 32,
    NoTooltip = 64,
    NoLabel = 128,
    NoSidePreview = 256,
    NoDragDrop = 512,
    NoBorder = 1024,
    AlphaBar = 65536,
    AlphaPreview = 131072,
    AlphaPreviewHalf = 262144,
    HDR = 524288,
    DisplayRGB = 1048576,
    DisplayHSV = 2097152,
    DisplayHex = 4194304,
    DisplayMask_ = 7340032,
    Uint8 = 8388608,
    Float = 16777216,
    DataTypeMask_ = 25165824,
    PickerHueBar = 33554432,
    PickerHueWheel = 67108864,
    PickerMask_ = 100663296,
    InputRGB = 134217728,
    DefaultOptions_ = 177209344,
    InputHSV = 268435456,
    InputMask_ = 402653184,
  }
  public struct ImGuiColorMod
  {
    public ImGuiCol Col;
    public UnityEngine.Vector4 BackupValue;
  }
  public struct ImGuiColorModPtr
  {
    public unsafe ImGuiColorMod* NativePtr { get => default; }
    public ref ImGuiCol Col { get => ref __0; }
    public ref UnityEngine.Vector4 BackupValue { get => ref __1; }
    internal static ImGuiCol __0;
    internal static UnityEngine.Vector4 __1;
  }
  public enum ImGuiComboFlags
  {
    None = 0,
    PopupAlignLeft = 1,
    HeightSmall = 2,
    HeightRegular = 4,
    HeightLarge = 8,
    HeightLargest = 16,
    HeightMask_ = 30,
    NoArrowButton = 32,
    NoPreview = 64,
  }
  public enum ImGuiComboFlagsPrivate
  {
    CustomPreview = 1048576,
  }
  public struct ImGuiComboPreviewData
  {
    public UnityEngine.Rect PreviewRect;
    public UnityEngine.Vector2 BackupCursorPos;
    public UnityEngine.Vector2 BackupCursorMaxPos;
    public UnityEngine.Vector2 BackupCursorPosPrevLine;
    public float BackupPrevLineTextBaseOffset;
    public ImGuiLayoutType BackupLayout;
  }
  public struct ImGuiComboPreviewDataPtr
  {
    public unsafe ImGuiComboPreviewData* NativePtr { get => default; }
    public ref UnityEngine.Rect PreviewRect { get => ref __0; }
    public ref UnityEngine.Vector2 BackupCursorPos { get => ref __1; }
    public ref UnityEngine.Vector2 BackupCursorMaxPos { get => ref __1; }
    public ref UnityEngine.Vector2 BackupCursorPosPrevLine { get => ref __1; }
    public ref float BackupPrevLineTextBaseOffset { get => ref __2; }
    public ref ImGuiLayoutType BackupLayout { get => ref __3; }
    public void ImGuiComboPreviewData_destroy() { }
    internal static UnityEngine.Rect __0;
    internal static UnityEngine.Vector2 __1;
    internal static float __2;
    internal static ImGuiLayoutType __3;
  }
  public enum ImGuiCond
  {
    None = 0,
    Always = 1,
    Once = 2,
    FirstUseEver = 4,
    Appearing = 8,
  }
  public enum ImGuiConfigFlags
  {
    None = 0,
    NavEnableKeyboard = 1,
    NavEnableGamepad = 2,
    NavEnableSetMousePos = 4,
    NavNoCaptureKeyboard = 8,
    NoMouse = 16,
    NoMouseCursorChange = 32,
    IsSRGB = 1048576,
    IsTouchScreen = 2097152,
  }
  public enum ImGuiContextHookType
  {
    NewFramePre = 0,
    NewFramePost = 1,
    EndFramePre = 2,
    EndFramePost = 3,
    RenderPre = 4,
    RenderPost = 5,
    Shutdown = 6,
    PendingRemoval_ = 7,
  }
  public enum ImGuiDataType
  {
    S8 = 0,
    U8 = 1,
    S16 = 2,
    U16 = 3,
    S32 = 4,
    U32 = 5,
    S64 = 6,
    U64 = 7,
    Float = 8,
    Double = 9,
    COUNT = 10,
  }
  public struct ImGuiDataTypeInfo
  {
    public uint Size;
    public unsafe byte* Name;
    public unsafe byte* PrintFmt;
    public unsafe byte* ScanFmt;
  }
  public struct ImGuiDataTypeInfoPtr
  {
    public unsafe ImGuiDataTypeInfo* NativePtr { get => default; }
    public ref uint Size { get => ref __0; }
    public ref string Name { get => ref __1; }
    public ref string PrintFmt { get => ref __1; }
    public ref string ScanFmt { get => ref __1; }
    internal static uint __0;
    internal static string __1;
  }
  public enum ImGuiDataTypePrivate
  {
    String = 11,
    Pointer = 12,
    ID = 13,
  }
  public struct ImGuiDataTypeTempStorage
  {
    public byte Data_0;
    public byte Data_1;
    public byte Data_2;
    public byte Data_3;
    public byte Data_4;
    public byte Data_5;
    public byte Data_6;
    public byte Data_7;
  }
  public struct ImGuiDataTypeTempStoragePtr
  {
    public unsafe ImGuiDataTypeTempStorage* NativePtr { get => default; }
    public RangeAccessor<byte> Data { get => default; }
  }
  public enum ImGuiDebugLogFlags
  {
    None = 0,
    EventActiveId = 1,
    EventFocus = 2,
    EventPopup = 4,
    EventNav = 8,
    EventIO = 16,
    EventMask_ = 31,
    OutputToTTY = 1024,
  }
  public enum ImGuiDir
  {
    Left = 0,
    Right = 1,
    Up = 2,
    Down = 3,
    COUNT = 4,
    None = -1,
  }
  public enum ImGuiDragDropFlags
  {
    None = 0,
    SourceNoPreviewTooltip = 1,
    SourceNoDisableHover = 2,
    SourceNoHoldToOpenOthers = 4,
    SourceAllowNullID = 8,
    SourceExtern = 16,
    SourceAutoExpirePayload = 32,
    AcceptBeforeDelivery = 1024,
    AcceptNoDrawDefaultRect = 2048,
    AcceptPeekOnly = 3072,
    AcceptNoPreviewTooltip = 4096,
  }
  public enum ImGuiFocusedFlags
  {
    None = 0,
    ChildWindows = 1,
    RootWindow = 2,
    RootAndChildWindows = 3,
    AnyWindow = 4,
    NoPopupHierarchy = 8,
  }
  public struct ImGuiGroupData
  {
    public uint WindowID;
    public UnityEngine.Vector2 BackupCursorPos;
    public UnityEngine.Vector2 BackupCursorMaxPos;
    public ImVec1 BackupIndent;
    public ImVec1 BackupGroupOffset;
    public UnityEngine.Vector2 BackupCurrLineSize;
    public float BackupCurrLineTextBaseOffset;
    public uint BackupActiveIdIsAlive;
    public byte BackupActiveIdPreviousFrameIsAlive;
    public byte BackupHoveredIdIsAlive;
    public byte EmitItem;
  }
  public struct ImGuiGroupDataPtr
  {
    public unsafe ImGuiGroupData* NativePtr { get => default; }
    public ref uint WindowID { get => ref __0; }
    public ref UnityEngine.Vector2 BackupCursorPos { get => ref __1; }
    public ref UnityEngine.Vector2 BackupCursorMaxPos { get => ref __1; }
    public ref ImVec1 BackupIndent { get => ref __2; }
    public ref ImVec1 BackupGroupOffset { get => ref __2; }
    public ref UnityEngine.Vector2 BackupCurrLineSize { get => ref __1; }
    public ref float BackupCurrLineTextBaseOffset { get => ref __3; }
    public ref uint BackupActiveIdIsAlive { get => ref __0; }
    public ref bool BackupActiveIdPreviousFrameIsAlive { get => ref __4; }
    public ref bool BackupHoveredIdIsAlive { get => ref __4; }
    public ref bool EmitItem { get => ref __4; }
    internal static uint __0;
    internal static UnityEngine.Vector2 __1;
    internal static ImVec1 __2;
    internal static float __3;
    internal static bool __4;
  }
  public enum ImGuiHoveredFlags
  {
    None = 0,
    ChildWindows = 1,
    RootWindow = 2,
    RootAndChildWindows = 3,
    AnyWindow = 4,
    NoPopupHierarchy = 8,
    AllowWhenBlockedByPopup = 32,
    AllowWhenBlockedByActiveItem = 128,
    AllowWhenOverlapped = 256,
    RectOnly = 416,
    AllowWhenDisabled = 512,
    NoNavOverride = 1024,
  }
  public struct ImGuiInputEventAppFocused
  {
    public byte Focused;
  }
  public struct ImGuiInputEventAppFocusedPtr
  {
    public unsafe ImGuiInputEventAppFocused* NativePtr { get => default; }
    public ref bool Focused { get => ref __0; }
    internal static bool __0;
  }
  public struct ImGuiInputEventKey
  {
    public ImGuiKey Key;
    public byte Down;
    public float AnalogValue;
  }
  public struct ImGuiInputEventKeyPtr
  {
    public unsafe ImGuiInputEventKey* NativePtr { get => default; }
    public ref ImGuiKey Key { get => ref __0; }
    public ref bool Down { get => ref __1; }
    public ref float AnalogValue { get => ref __2; }
    internal static ImGuiKey __0;
    internal static bool __1;
    internal static float __2;
  }
  public struct ImGuiInputEventMouseButton
  {
    public int Button;
    public byte Down;
  }
  public struct ImGuiInputEventMouseButtonPtr
  {
    public unsafe ImGuiInputEventMouseButton* NativePtr { get => default; }
    public ref int Button { get => ref __0; }
    public ref bool Down { get => ref __1; }
    internal static int __0;
    internal static bool __1;
  }
  public struct ImGuiInputEventMousePos
  {
    public float PosX;
    public float PosY;
  }
  public struct ImGuiInputEventMousePosPtr
  {
    public unsafe ImGuiInputEventMousePos* NativePtr { get => default; }
    public ref float PosX { get => ref __0; }
    public ref float PosY { get => ref __0; }
    internal static float __0;
  }
  public struct ImGuiInputEventMouseWheel
  {
    public float WheelX;
    public float WheelY;
  }
  public struct ImGuiInputEventMouseWheelPtr
  {
    public unsafe ImGuiInputEventMouseWheel* NativePtr { get => default; }
    public ref float WheelX { get => ref __0; }
    public ref float WheelY { get => ref __0; }
    internal static float __0;
  }
  public struct ImGuiInputEventText
  {
    public uint Char;
  }
  public struct ImGuiInputEventTextPtr
  {
    public unsafe ImGuiInputEventText* NativePtr { get => default; }
    public ref uint Char { get => ref __0; }
    internal static uint __0;
  }
  public enum ImGuiInputEventType
  {
    None = 0,
    MousePos = 1,
    MouseWheel = 2,
    MouseButton = 3,
    Key = 4,
    Text = 5,
    Focus = 6,
    COUNT = 7,
  }
  public enum ImGuiInputSource
  {
    None = 0,
    Mouse = 1,
    Keyboard = 2,
    Gamepad = 3,
    Clipboard = 4,
    Nav = 5,
    COUNT = 6,
  }
  public struct ImGuiInputTextCallbackData
  {
    public ImGuiInputTextFlags EventFlag;
    public ImGuiInputTextFlags Flags;
    public unsafe void* UserData;
    public ushort EventChar;
    public ImGuiKey EventKey;
    public unsafe byte* Buf;
    public int BufTextLen;
    public int BufSize;
    public byte BufDirty;
    public int CursorPos;
    public int SelectionStart;
    public int SelectionEnd;
  }
  public struct ImGuiInputTextCallbackDataPtr
  {
    public unsafe ImGuiInputTextCallbackData* NativePtr { get => default; }
    public ref ImGuiInputTextFlags EventFlag { get => ref __0; }
    public ref ImGuiInputTextFlags Flags { get => ref __0; }
    public System.IntPtr UserData { get => default; set { } }
    public ref ushort EventChar { get => ref __1; }
    public ref ImGuiKey EventKey { get => ref __2; }
    public System.IntPtr Buf { get => default; set { } }
    public ref int BufTextLen { get => ref __3; }
    public ref int BufSize { get => ref __3; }
    public ref bool BufDirty { get => ref __4; }
    public ref int CursorPos { get => ref __3; }
    public ref int SelectionStart { get => ref __3; }
    public ref int SelectionEnd { get => ref __3; }
    public string Text { get => default; }
    public void ClearSelection() { }
    public void DeleteChars(int pos, int bytes_count) { }
    public bool HasSelection() { return default; }
    public void InsertChars(int pos, string text) { }
    public void InsertChars(int pos, string text, string text_end) { }
    public void SelectAll() { }
    public void ImGuiInputTextCallbackData_destroy() { }
    internal static ImGuiInputTextFlags __0;
    internal static ushort __1;
    internal static ImGuiKey __2;
    internal static int __3;
    internal static bool __4;
  }
  public enum ImGuiInputTextFlags
  {
    None = 0,
    CharsDecimal = 1,
    CharsHexadecimal = 2,
    CharsUppercase = 4,
    CharsNoBlank = 8,
    AutoSelectAll = 16,
    EnterReturnsTrue = 32,
    CallbackCompletion = 64,
    CallbackHistory = 128,
    CallbackAlways = 256,
    CallbackCharFilter = 512,
    AllowTabInput = 1024,
    CtrlEnterForNewLine = 2048,
    NoHorizontalScroll = 4096,
    AlwaysOverwrite = 8192,
    ReadOnly = 16384,
    Password = 32768,
    NoUndoRedo = 65536,
    CharsScientific = 131072,
    CallbackResize = 262144,
    CallbackEdit = 524288,
  }
  public enum ImGuiInputTextFlagsPrivate
  {
    Multiline = 67108864,
    NoMarkEdited = 134217728,
    MergedItem = 268435456,
  }
  public struct ImGuiIO
  {
    public ImGuiConfigFlags ConfigFlags;
    public ImGuiBackendFlags BackendFlags;
    public UnityEngine.Vector2 DisplaySize;
    public float DeltaTime;
    public float IniSavingRate;
    public unsafe byte* IniFilename;
    public unsafe byte* LogFilename;
    public float MouseDoubleClickTime;
    public float MouseDoubleClickMaxDist;
    public float MouseDragThreshold;
    public float KeyRepeatDelay;
    public float KeyRepeatRate;
    public unsafe void* UserData;
    public unsafe ImFontAtlas* Fonts;
    public float FontGlobalScale;
    public byte FontAllowUserScaling;
    public unsafe ImFont* FontDefault;
    public UnityEngine.Vector2 DisplayFramebufferScale;
    public byte MouseDrawCursor;
    public byte ConfigMacOSXBehaviors;
    public byte ConfigInputTrickleEventQueue;
    public byte ConfigInputTextCursorBlink;
    public byte ConfigDragClickToInputText;
    public byte ConfigWindowsResizeFromEdges;
    public byte ConfigWindowsMoveFromTitleBarOnly;
    public float ConfigMemoryCompactTimer;
    public unsafe byte* BackendPlatformName;
    public unsafe byte* BackendRendererName;
    public unsafe void* BackendPlatformUserData;
    public unsafe void* BackendRendererUserData;
    public unsafe void* BackendLanguageUserData;
    public System.IntPtr GetClipboardTextFn;
    public System.IntPtr SetClipboardTextFn;
    public unsafe void* ClipboardUserData;
    public System.IntPtr SetPlatformImeDataFn;
    public System.IntPtr _UnusedPadding;
    public byte WantCaptureMouse;
    public byte WantCaptureKeyboard;
    public byte WantTextInput;
    public byte WantSetMousePos;
    public byte WantSaveIniSettings;
    public byte NavActive;
    public byte NavVisible;
    public float Framerate;
    public int MetricsRenderVertices;
    public int MetricsRenderIndices;
    public int MetricsRenderWindows;
    public int MetricsActiveWindows;
    public int MetricsActiveAllocations;
    public UnityEngine.Vector2 MouseDelta;
    public unsafe fixed int KeyMap[645];
    public unsafe fixed byte KeysDown[645];
    public UnityEngine.Vector2 MousePos;
    public unsafe fixed byte MouseDown[5];
    public float MouseWheel;
    public float MouseWheelH;
    public byte KeyCtrl;
    public byte KeyShift;
    public byte KeyAlt;
    public byte KeySuper;
    public unsafe fixed float NavInputs[20];
    public ImGuiModFlags KeyMods;
    public ImGuiKeyData KeysData_0;
    public ImGuiKeyData KeysData_1;
    public ImGuiKeyData KeysData_2;
    public ImGuiKeyData KeysData_3;
    public ImGuiKeyData KeysData_4;
    public ImGuiKeyData KeysData_5;
    public ImGuiKeyData KeysData_6;
    public ImGuiKeyData KeysData_7;
    public ImGuiKeyData KeysData_8;
    public ImGuiKeyData KeysData_9;
    public ImGuiKeyData KeysData_10;
    public ImGuiKeyData KeysData_11;
    public ImGuiKeyData KeysData_12;
    public ImGuiKeyData KeysData_13;
    public ImGuiKeyData KeysData_14;
    public ImGuiKeyData KeysData_15;
    public ImGuiKeyData KeysData_16;
    public ImGuiKeyData KeysData_17;
    public ImGuiKeyData KeysData_18;
    public ImGuiKeyData KeysData_19;
    public ImGuiKeyData KeysData_20;
    public ImGuiKeyData KeysData_21;
    public ImGuiKeyData KeysData_22;
    public ImGuiKeyData KeysData_23;
    public ImGuiKeyData KeysData_24;
    public ImGuiKeyData KeysData_25;
    public ImGuiKeyData KeysData_26;
    public ImGuiKeyData KeysData_27;
    public ImGuiKeyData KeysData_28;
    public ImGuiKeyData KeysData_29;
    public ImGuiKeyData KeysData_30;
    public ImGuiKeyData KeysData_31;
    public ImGuiKeyData KeysData_32;
    public ImGuiKeyData KeysData_33;
    public ImGuiKeyData KeysData_34;
    public ImGuiKeyData KeysData_35;
    public ImGuiKeyData KeysData_36;
    public ImGuiKeyData KeysData_37;
    public ImGuiKeyData KeysData_38;
    public ImGuiKeyData KeysData_39;
    public ImGuiKeyData KeysData_40;
    public ImGuiKeyData KeysData_41;
    public ImGuiKeyData KeysData_42;
    public ImGuiKeyData KeysData_43;
    public ImGuiKeyData KeysData_44;
    public ImGuiKeyData KeysData_45;
    public ImGuiKeyData KeysData_46;
    public ImGuiKeyData KeysData_47;
    public ImGuiKeyData KeysData_48;
    public ImGuiKeyData KeysData_49;
    public ImGuiKeyData KeysData_50;
    public ImGuiKeyData KeysData_51;
    public ImGuiKeyData KeysData_52;
    public ImGuiKeyData KeysData_53;
    public ImGuiKeyData KeysData_54;
    public ImGuiKeyData KeysData_55;
    public ImGuiKeyData KeysData_56;
    public ImGuiKeyData KeysData_57;
    public ImGuiKeyData KeysData_58;
    public ImGuiKeyData KeysData_59;
    public ImGuiKeyData KeysData_60;
    public ImGuiKeyData KeysData_61;
    public ImGuiKeyData KeysData_62;
    public ImGuiKeyData KeysData_63;
    public ImGuiKeyData KeysData_64;
    public ImGuiKeyData KeysData_65;
    public ImGuiKeyData KeysData_66;
    public ImGuiKeyData KeysData_67;
    public ImGuiKeyData KeysData_68;
    public ImGuiKeyData KeysData_69;
    public ImGuiKeyData KeysData_70;
    public ImGuiKeyData KeysData_71;
    public ImGuiKeyData KeysData_72;
    public ImGuiKeyData KeysData_73;
    public ImGuiKeyData KeysData_74;
    public ImGuiKeyData KeysData_75;
    public ImGuiKeyData KeysData_76;
    public ImGuiKeyData KeysData_77;
    public ImGuiKeyData KeysData_78;
    public ImGuiKeyData KeysData_79;
    public ImGuiKeyData KeysData_80;
    public ImGuiKeyData KeysData_81;
    public ImGuiKeyData KeysData_82;
    public ImGuiKeyData KeysData_83;
    public ImGuiKeyData KeysData_84;
    public ImGuiKeyData KeysData_85;
    public ImGuiKeyData KeysData_86;
    public ImGuiKeyData KeysData_87;
    public ImGuiKeyData KeysData_88;
    public ImGuiKeyData KeysData_89;
    public ImGuiKeyData KeysData_90;
    public ImGuiKeyData KeysData_91;
    public ImGuiKeyData KeysData_92;
    public ImGuiKeyData KeysData_93;
    public ImGuiKeyData KeysData_94;
    public ImGuiKeyData KeysData_95;
    public ImGuiKeyData KeysData_96;
    public ImGuiKeyData KeysData_97;
    public ImGuiKeyData KeysData_98;
    public ImGuiKeyData KeysData_99;
    public ImGuiKeyData KeysData_100;
    public ImGuiKeyData KeysData_101;
    public ImGuiKeyData KeysData_102;
    public ImGuiKeyData KeysData_103;
    public ImGuiKeyData KeysData_104;
    public ImGuiKeyData KeysData_105;
    public ImGuiKeyData KeysData_106;
    public ImGuiKeyData KeysData_107;
    public ImGuiKeyData KeysData_108;
    public ImGuiKeyData KeysData_109;
    public ImGuiKeyData KeysData_110;
    public ImGuiKeyData KeysData_111;
    public ImGuiKeyData KeysData_112;
    public ImGuiKeyData KeysData_113;
    public ImGuiKeyData KeysData_114;
    public ImGuiKeyData KeysData_115;
    public ImGuiKeyData KeysData_116;
    public ImGuiKeyData KeysData_117;
    public ImGuiKeyData KeysData_118;
    public ImGuiKeyData KeysData_119;
    public ImGuiKeyData KeysData_120;
    public ImGuiKeyData KeysData_121;
    public ImGuiKeyData KeysData_122;
    public ImGuiKeyData KeysData_123;
    public ImGuiKeyData KeysData_124;
    public ImGuiKeyData KeysData_125;
    public ImGuiKeyData KeysData_126;
    public ImGuiKeyData KeysData_127;
    public ImGuiKeyData KeysData_128;
    public ImGuiKeyData KeysData_129;
    public ImGuiKeyData KeysData_130;
    public ImGuiKeyData KeysData_131;
    public ImGuiKeyData KeysData_132;
    public ImGuiKeyData KeysData_133;
    public ImGuiKeyData KeysData_134;
    public ImGuiKeyData KeysData_135;
    public ImGuiKeyData KeysData_136;
    public ImGuiKeyData KeysData_137;
    public ImGuiKeyData KeysData_138;
    public ImGuiKeyData KeysData_139;
    public ImGuiKeyData KeysData_140;
    public ImGuiKeyData KeysData_141;
    public ImGuiKeyData KeysData_142;
    public ImGuiKeyData KeysData_143;
    public ImGuiKeyData KeysData_144;
    public ImGuiKeyData KeysData_145;
    public ImGuiKeyData KeysData_146;
    public ImGuiKeyData KeysData_147;
    public ImGuiKeyData KeysData_148;
    public ImGuiKeyData KeysData_149;
    public ImGuiKeyData KeysData_150;
    public ImGuiKeyData KeysData_151;
    public ImGuiKeyData KeysData_152;
    public ImGuiKeyData KeysData_153;
    public ImGuiKeyData KeysData_154;
    public ImGuiKeyData KeysData_155;
    public ImGuiKeyData KeysData_156;
    public ImGuiKeyData KeysData_157;
    public ImGuiKeyData KeysData_158;
    public ImGuiKeyData KeysData_159;
    public ImGuiKeyData KeysData_160;
    public ImGuiKeyData KeysData_161;
    public ImGuiKeyData KeysData_162;
    public ImGuiKeyData KeysData_163;
    public ImGuiKeyData KeysData_164;
    public ImGuiKeyData KeysData_165;
    public ImGuiKeyData KeysData_166;
    public ImGuiKeyData KeysData_167;
    public ImGuiKeyData KeysData_168;
    public ImGuiKeyData KeysData_169;
    public ImGuiKeyData KeysData_170;
    public ImGuiKeyData KeysData_171;
    public ImGuiKeyData KeysData_172;
    public ImGuiKeyData KeysData_173;
    public ImGuiKeyData KeysData_174;
    public ImGuiKeyData KeysData_175;
    public ImGuiKeyData KeysData_176;
    public ImGuiKeyData KeysData_177;
    public ImGuiKeyData KeysData_178;
    public ImGuiKeyData KeysData_179;
    public ImGuiKeyData KeysData_180;
    public ImGuiKeyData KeysData_181;
    public ImGuiKeyData KeysData_182;
    public ImGuiKeyData KeysData_183;
    public ImGuiKeyData KeysData_184;
    public ImGuiKeyData KeysData_185;
    public ImGuiKeyData KeysData_186;
    public ImGuiKeyData KeysData_187;
    public ImGuiKeyData KeysData_188;
    public ImGuiKeyData KeysData_189;
    public ImGuiKeyData KeysData_190;
    public ImGuiKeyData KeysData_191;
    public ImGuiKeyData KeysData_192;
    public ImGuiKeyData KeysData_193;
    public ImGuiKeyData KeysData_194;
    public ImGuiKeyData KeysData_195;
    public ImGuiKeyData KeysData_196;
    public ImGuiKeyData KeysData_197;
    public ImGuiKeyData KeysData_198;
    public ImGuiKeyData KeysData_199;
    public ImGuiKeyData KeysData_200;
    public ImGuiKeyData KeysData_201;
    public ImGuiKeyData KeysData_202;
    public ImGuiKeyData KeysData_203;
    public ImGuiKeyData KeysData_204;
    public ImGuiKeyData KeysData_205;
    public ImGuiKeyData KeysData_206;
    public ImGuiKeyData KeysData_207;
    public ImGuiKeyData KeysData_208;
    public ImGuiKeyData KeysData_209;
    public ImGuiKeyData KeysData_210;
    public ImGuiKeyData KeysData_211;
    public ImGuiKeyData KeysData_212;
    public ImGuiKeyData KeysData_213;
    public ImGuiKeyData KeysData_214;
    public ImGuiKeyData KeysData_215;
    public ImGuiKeyData KeysData_216;
    public ImGuiKeyData KeysData_217;
    public ImGuiKeyData KeysData_218;
    public ImGuiKeyData KeysData_219;
    public ImGuiKeyData KeysData_220;
    public ImGuiKeyData KeysData_221;
    public ImGuiKeyData KeysData_222;
    public ImGuiKeyData KeysData_223;
    public ImGuiKeyData KeysData_224;
    public ImGuiKeyData KeysData_225;
    public ImGuiKeyData KeysData_226;
    public ImGuiKeyData KeysData_227;
    public ImGuiKeyData KeysData_228;
    public ImGuiKeyData KeysData_229;
    public ImGuiKeyData KeysData_230;
    public ImGuiKeyData KeysData_231;
    public ImGuiKeyData KeysData_232;
    public ImGuiKeyData KeysData_233;
    public ImGuiKeyData KeysData_234;
    public ImGuiKeyData KeysData_235;
    public ImGuiKeyData KeysData_236;
    public ImGuiKeyData KeysData_237;
    public ImGuiKeyData KeysData_238;
    public ImGuiKeyData KeysData_239;
    public ImGuiKeyData KeysData_240;
    public ImGuiKeyData KeysData_241;
    public ImGuiKeyData KeysData_242;
    public ImGuiKeyData KeysData_243;
    public ImGuiKeyData KeysData_244;
    public ImGuiKeyData KeysData_245;
    public ImGuiKeyData KeysData_246;
    public ImGuiKeyData KeysData_247;
    public ImGuiKeyData KeysData_248;
    public ImGuiKeyData KeysData_249;
    public ImGuiKeyData KeysData_250;
    public ImGuiKeyData KeysData_251;
    public ImGuiKeyData KeysData_252;
    public ImGuiKeyData KeysData_253;
    public ImGuiKeyData KeysData_254;
    public ImGuiKeyData KeysData_255;
    public ImGuiKeyData KeysData_256;
    public ImGuiKeyData KeysData_257;
    public ImGuiKeyData KeysData_258;
    public ImGuiKeyData KeysData_259;
    public ImGuiKeyData KeysData_260;
    public ImGuiKeyData KeysData_261;
    public ImGuiKeyData KeysData_262;
    public ImGuiKeyData KeysData_263;
    public ImGuiKeyData KeysData_264;
    public ImGuiKeyData KeysData_265;
    public ImGuiKeyData KeysData_266;
    public ImGuiKeyData KeysData_267;
    public ImGuiKeyData KeysData_268;
    public ImGuiKeyData KeysData_269;
    public ImGuiKeyData KeysData_270;
    public ImGuiKeyData KeysData_271;
    public ImGuiKeyData KeysData_272;
    public ImGuiKeyData KeysData_273;
    public ImGuiKeyData KeysData_274;
    public ImGuiKeyData KeysData_275;
    public ImGuiKeyData KeysData_276;
    public ImGuiKeyData KeysData_277;
    public ImGuiKeyData KeysData_278;
    public ImGuiKeyData KeysData_279;
    public ImGuiKeyData KeysData_280;
    public ImGuiKeyData KeysData_281;
    public ImGuiKeyData KeysData_282;
    public ImGuiKeyData KeysData_283;
    public ImGuiKeyData KeysData_284;
    public ImGuiKeyData KeysData_285;
    public ImGuiKeyData KeysData_286;
    public ImGuiKeyData KeysData_287;
    public ImGuiKeyData KeysData_288;
    public ImGuiKeyData KeysData_289;
    public ImGuiKeyData KeysData_290;
    public ImGuiKeyData KeysData_291;
    public ImGuiKeyData KeysData_292;
    public ImGuiKeyData KeysData_293;
    public ImGuiKeyData KeysData_294;
    public ImGuiKeyData KeysData_295;
    public ImGuiKeyData KeysData_296;
    public ImGuiKeyData KeysData_297;
    public ImGuiKeyData KeysData_298;
    public ImGuiKeyData KeysData_299;
    public ImGuiKeyData KeysData_300;
    public ImGuiKeyData KeysData_301;
    public ImGuiKeyData KeysData_302;
    public ImGuiKeyData KeysData_303;
    public ImGuiKeyData KeysData_304;
    public ImGuiKeyData KeysData_305;
    public ImGuiKeyData KeysData_306;
    public ImGuiKeyData KeysData_307;
    public ImGuiKeyData KeysData_308;
    public ImGuiKeyData KeysData_309;
    public ImGuiKeyData KeysData_310;
    public ImGuiKeyData KeysData_311;
    public ImGuiKeyData KeysData_312;
    public ImGuiKeyData KeysData_313;
    public ImGuiKeyData KeysData_314;
    public ImGuiKeyData KeysData_315;
    public ImGuiKeyData KeysData_316;
    public ImGuiKeyData KeysData_317;
    public ImGuiKeyData KeysData_318;
    public ImGuiKeyData KeysData_319;
    public ImGuiKeyData KeysData_320;
    public ImGuiKeyData KeysData_321;
    public ImGuiKeyData KeysData_322;
    public ImGuiKeyData KeysData_323;
    public ImGuiKeyData KeysData_324;
    public ImGuiKeyData KeysData_325;
    public ImGuiKeyData KeysData_326;
    public ImGuiKeyData KeysData_327;
    public ImGuiKeyData KeysData_328;
    public ImGuiKeyData KeysData_329;
    public ImGuiKeyData KeysData_330;
    public ImGuiKeyData KeysData_331;
    public ImGuiKeyData KeysData_332;
    public ImGuiKeyData KeysData_333;
    public ImGuiKeyData KeysData_334;
    public ImGuiKeyData KeysData_335;
    public ImGuiKeyData KeysData_336;
    public ImGuiKeyData KeysData_337;
    public ImGuiKeyData KeysData_338;
    public ImGuiKeyData KeysData_339;
    public ImGuiKeyData KeysData_340;
    public ImGuiKeyData KeysData_341;
    public ImGuiKeyData KeysData_342;
    public ImGuiKeyData KeysData_343;
    public ImGuiKeyData KeysData_344;
    public ImGuiKeyData KeysData_345;
    public ImGuiKeyData KeysData_346;
    public ImGuiKeyData KeysData_347;
    public ImGuiKeyData KeysData_348;
    public ImGuiKeyData KeysData_349;
    public ImGuiKeyData KeysData_350;
    public ImGuiKeyData KeysData_351;
    public ImGuiKeyData KeysData_352;
    public ImGuiKeyData KeysData_353;
    public ImGuiKeyData KeysData_354;
    public ImGuiKeyData KeysData_355;
    public ImGuiKeyData KeysData_356;
    public ImGuiKeyData KeysData_357;
    public ImGuiKeyData KeysData_358;
    public ImGuiKeyData KeysData_359;
    public ImGuiKeyData KeysData_360;
    public ImGuiKeyData KeysData_361;
    public ImGuiKeyData KeysData_362;
    public ImGuiKeyData KeysData_363;
    public ImGuiKeyData KeysData_364;
    public ImGuiKeyData KeysData_365;
    public ImGuiKeyData KeysData_366;
    public ImGuiKeyData KeysData_367;
    public ImGuiKeyData KeysData_368;
    public ImGuiKeyData KeysData_369;
    public ImGuiKeyData KeysData_370;
    public ImGuiKeyData KeysData_371;
    public ImGuiKeyData KeysData_372;
    public ImGuiKeyData KeysData_373;
    public ImGuiKeyData KeysData_374;
    public ImGuiKeyData KeysData_375;
    public ImGuiKeyData KeysData_376;
    public ImGuiKeyData KeysData_377;
    public ImGuiKeyData KeysData_378;
    public ImGuiKeyData KeysData_379;
    public ImGuiKeyData KeysData_380;
    public ImGuiKeyData KeysData_381;
    public ImGuiKeyData KeysData_382;
    public ImGuiKeyData KeysData_383;
    public ImGuiKeyData KeysData_384;
    public ImGuiKeyData KeysData_385;
    public ImGuiKeyData KeysData_386;
    public ImGuiKeyData KeysData_387;
    public ImGuiKeyData KeysData_388;
    public ImGuiKeyData KeysData_389;
    public ImGuiKeyData KeysData_390;
    public ImGuiKeyData KeysData_391;
    public ImGuiKeyData KeysData_392;
    public ImGuiKeyData KeysData_393;
    public ImGuiKeyData KeysData_394;
    public ImGuiKeyData KeysData_395;
    public ImGuiKeyData KeysData_396;
    public ImGuiKeyData KeysData_397;
    public ImGuiKeyData KeysData_398;
    public ImGuiKeyData KeysData_399;
    public ImGuiKeyData KeysData_400;
    public ImGuiKeyData KeysData_401;
    public ImGuiKeyData KeysData_402;
    public ImGuiKeyData KeysData_403;
    public ImGuiKeyData KeysData_404;
    public ImGuiKeyData KeysData_405;
    public ImGuiKeyData KeysData_406;
    public ImGuiKeyData KeysData_407;
    public ImGuiKeyData KeysData_408;
    public ImGuiKeyData KeysData_409;
    public ImGuiKeyData KeysData_410;
    public ImGuiKeyData KeysData_411;
    public ImGuiKeyData KeysData_412;
    public ImGuiKeyData KeysData_413;
    public ImGuiKeyData KeysData_414;
    public ImGuiKeyData KeysData_415;
    public ImGuiKeyData KeysData_416;
    public ImGuiKeyData KeysData_417;
    public ImGuiKeyData KeysData_418;
    public ImGuiKeyData KeysData_419;
    public ImGuiKeyData KeysData_420;
    public ImGuiKeyData KeysData_421;
    public ImGuiKeyData KeysData_422;
    public ImGuiKeyData KeysData_423;
    public ImGuiKeyData KeysData_424;
    public ImGuiKeyData KeysData_425;
    public ImGuiKeyData KeysData_426;
    public ImGuiKeyData KeysData_427;
    public ImGuiKeyData KeysData_428;
    public ImGuiKeyData KeysData_429;
    public ImGuiKeyData KeysData_430;
    public ImGuiKeyData KeysData_431;
    public ImGuiKeyData KeysData_432;
    public ImGuiKeyData KeysData_433;
    public ImGuiKeyData KeysData_434;
    public ImGuiKeyData KeysData_435;
    public ImGuiKeyData KeysData_436;
    public ImGuiKeyData KeysData_437;
    public ImGuiKeyData KeysData_438;
    public ImGuiKeyData KeysData_439;
    public ImGuiKeyData KeysData_440;
    public ImGuiKeyData KeysData_441;
    public ImGuiKeyData KeysData_442;
    public ImGuiKeyData KeysData_443;
    public ImGuiKeyData KeysData_444;
    public ImGuiKeyData KeysData_445;
    public ImGuiKeyData KeysData_446;
    public ImGuiKeyData KeysData_447;
    public ImGuiKeyData KeysData_448;
    public ImGuiKeyData KeysData_449;
    public ImGuiKeyData KeysData_450;
    public ImGuiKeyData KeysData_451;
    public ImGuiKeyData KeysData_452;
    public ImGuiKeyData KeysData_453;
    public ImGuiKeyData KeysData_454;
    public ImGuiKeyData KeysData_455;
    public ImGuiKeyData KeysData_456;
    public ImGuiKeyData KeysData_457;
    public ImGuiKeyData KeysData_458;
    public ImGuiKeyData KeysData_459;
    public ImGuiKeyData KeysData_460;
    public ImGuiKeyData KeysData_461;
    public ImGuiKeyData KeysData_462;
    public ImGuiKeyData KeysData_463;
    public ImGuiKeyData KeysData_464;
    public ImGuiKeyData KeysData_465;
    public ImGuiKeyData KeysData_466;
    public ImGuiKeyData KeysData_467;
    public ImGuiKeyData KeysData_468;
    public ImGuiKeyData KeysData_469;
    public ImGuiKeyData KeysData_470;
    public ImGuiKeyData KeysData_471;
    public ImGuiKeyData KeysData_472;
    public ImGuiKeyData KeysData_473;
    public ImGuiKeyData KeysData_474;
    public ImGuiKeyData KeysData_475;
    public ImGuiKeyData KeysData_476;
    public ImGuiKeyData KeysData_477;
    public ImGuiKeyData KeysData_478;
    public ImGuiKeyData KeysData_479;
    public ImGuiKeyData KeysData_480;
    public ImGuiKeyData KeysData_481;
    public ImGuiKeyData KeysData_482;
    public ImGuiKeyData KeysData_483;
    public ImGuiKeyData KeysData_484;
    public ImGuiKeyData KeysData_485;
    public ImGuiKeyData KeysData_486;
    public ImGuiKeyData KeysData_487;
    public ImGuiKeyData KeysData_488;
    public ImGuiKeyData KeysData_489;
    public ImGuiKeyData KeysData_490;
    public ImGuiKeyData KeysData_491;
    public ImGuiKeyData KeysData_492;
    public ImGuiKeyData KeysData_493;
    public ImGuiKeyData KeysData_494;
    public ImGuiKeyData KeysData_495;
    public ImGuiKeyData KeysData_496;
    public ImGuiKeyData KeysData_497;
    public ImGuiKeyData KeysData_498;
    public ImGuiKeyData KeysData_499;
    public ImGuiKeyData KeysData_500;
    public ImGuiKeyData KeysData_501;
    public ImGuiKeyData KeysData_502;
    public ImGuiKeyData KeysData_503;
    public ImGuiKeyData KeysData_504;
    public ImGuiKeyData KeysData_505;
    public ImGuiKeyData KeysData_506;
    public ImGuiKeyData KeysData_507;
    public ImGuiKeyData KeysData_508;
    public ImGuiKeyData KeysData_509;
    public ImGuiKeyData KeysData_510;
    public ImGuiKeyData KeysData_511;
    public ImGuiKeyData KeysData_512;
    public ImGuiKeyData KeysData_513;
    public ImGuiKeyData KeysData_514;
    public ImGuiKeyData KeysData_515;
    public ImGuiKeyData KeysData_516;
    public ImGuiKeyData KeysData_517;
    public ImGuiKeyData KeysData_518;
    public ImGuiKeyData KeysData_519;
    public ImGuiKeyData KeysData_520;
    public ImGuiKeyData KeysData_521;
    public ImGuiKeyData KeysData_522;
    public ImGuiKeyData KeysData_523;
    public ImGuiKeyData KeysData_524;
    public ImGuiKeyData KeysData_525;
    public ImGuiKeyData KeysData_526;
    public ImGuiKeyData KeysData_527;
    public ImGuiKeyData KeysData_528;
    public ImGuiKeyData KeysData_529;
    public ImGuiKeyData KeysData_530;
    public ImGuiKeyData KeysData_531;
    public ImGuiKeyData KeysData_532;
    public ImGuiKeyData KeysData_533;
    public ImGuiKeyData KeysData_534;
    public ImGuiKeyData KeysData_535;
    public ImGuiKeyData KeysData_536;
    public ImGuiKeyData KeysData_537;
    public ImGuiKeyData KeysData_538;
    public ImGuiKeyData KeysData_539;
    public ImGuiKeyData KeysData_540;
    public ImGuiKeyData KeysData_541;
    public ImGuiKeyData KeysData_542;
    public ImGuiKeyData KeysData_543;
    public ImGuiKeyData KeysData_544;
    public ImGuiKeyData KeysData_545;
    public ImGuiKeyData KeysData_546;
    public ImGuiKeyData KeysData_547;
    public ImGuiKeyData KeysData_548;
    public ImGuiKeyData KeysData_549;
    public ImGuiKeyData KeysData_550;
    public ImGuiKeyData KeysData_551;
    public ImGuiKeyData KeysData_552;
    public ImGuiKeyData KeysData_553;
    public ImGuiKeyData KeysData_554;
    public ImGuiKeyData KeysData_555;
    public ImGuiKeyData KeysData_556;
    public ImGuiKeyData KeysData_557;
    public ImGuiKeyData KeysData_558;
    public ImGuiKeyData KeysData_559;
    public ImGuiKeyData KeysData_560;
    public ImGuiKeyData KeysData_561;
    public ImGuiKeyData KeysData_562;
    public ImGuiKeyData KeysData_563;
    public ImGuiKeyData KeysData_564;
    public ImGuiKeyData KeysData_565;
    public ImGuiKeyData KeysData_566;
    public ImGuiKeyData KeysData_567;
    public ImGuiKeyData KeysData_568;
    public ImGuiKeyData KeysData_569;
    public ImGuiKeyData KeysData_570;
    public ImGuiKeyData KeysData_571;
    public ImGuiKeyData KeysData_572;
    public ImGuiKeyData KeysData_573;
    public ImGuiKeyData KeysData_574;
    public ImGuiKeyData KeysData_575;
    public ImGuiKeyData KeysData_576;
    public ImGuiKeyData KeysData_577;
    public ImGuiKeyData KeysData_578;
    public ImGuiKeyData KeysData_579;
    public ImGuiKeyData KeysData_580;
    public ImGuiKeyData KeysData_581;
    public ImGuiKeyData KeysData_582;
    public ImGuiKeyData KeysData_583;
    public ImGuiKeyData KeysData_584;
    public ImGuiKeyData KeysData_585;
    public ImGuiKeyData KeysData_586;
    public ImGuiKeyData KeysData_587;
    public ImGuiKeyData KeysData_588;
    public ImGuiKeyData KeysData_589;
    public ImGuiKeyData KeysData_590;
    public ImGuiKeyData KeysData_591;
    public ImGuiKeyData KeysData_592;
    public ImGuiKeyData KeysData_593;
    public ImGuiKeyData KeysData_594;
    public ImGuiKeyData KeysData_595;
    public ImGuiKeyData KeysData_596;
    public ImGuiKeyData KeysData_597;
    public ImGuiKeyData KeysData_598;
    public ImGuiKeyData KeysData_599;
    public ImGuiKeyData KeysData_600;
    public ImGuiKeyData KeysData_601;
    public ImGuiKeyData KeysData_602;
    public ImGuiKeyData KeysData_603;
    public ImGuiKeyData KeysData_604;
    public ImGuiKeyData KeysData_605;
    public ImGuiKeyData KeysData_606;
    public ImGuiKeyData KeysData_607;
    public ImGuiKeyData KeysData_608;
    public ImGuiKeyData KeysData_609;
    public ImGuiKeyData KeysData_610;
    public ImGuiKeyData KeysData_611;
    public ImGuiKeyData KeysData_612;
    public ImGuiKeyData KeysData_613;
    public ImGuiKeyData KeysData_614;
    public ImGuiKeyData KeysData_615;
    public ImGuiKeyData KeysData_616;
    public ImGuiKeyData KeysData_617;
    public ImGuiKeyData KeysData_618;
    public ImGuiKeyData KeysData_619;
    public ImGuiKeyData KeysData_620;
    public ImGuiKeyData KeysData_621;
    public ImGuiKeyData KeysData_622;
    public ImGuiKeyData KeysData_623;
    public ImGuiKeyData KeysData_624;
    public ImGuiKeyData KeysData_625;
    public ImGuiKeyData KeysData_626;
    public ImGuiKeyData KeysData_627;
    public ImGuiKeyData KeysData_628;
    public ImGuiKeyData KeysData_629;
    public ImGuiKeyData KeysData_630;
    public ImGuiKeyData KeysData_631;
    public ImGuiKeyData KeysData_632;
    public ImGuiKeyData KeysData_633;
    public ImGuiKeyData KeysData_634;
    public ImGuiKeyData KeysData_635;
    public ImGuiKeyData KeysData_636;
    public ImGuiKeyData KeysData_637;
    public ImGuiKeyData KeysData_638;
    public ImGuiKeyData KeysData_639;
    public ImGuiKeyData KeysData_640;
    public ImGuiKeyData KeysData_641;
    public ImGuiKeyData KeysData_642;
    public ImGuiKeyData KeysData_643;
    public ImGuiKeyData KeysData_644;
    public byte WantCaptureMouseUnlessPopupClose;
    public UnityEngine.Vector2 MousePosPrev;
    public UnityEngine.Vector2 MouseClickedPos_0;
    public UnityEngine.Vector2 MouseClickedPos_1;
    public UnityEngine.Vector2 MouseClickedPos_2;
    public UnityEngine.Vector2 MouseClickedPos_3;
    public UnityEngine.Vector2 MouseClickedPos_4;
    public unsafe fixed double MouseClickedTime[5];
    public unsafe fixed byte MouseClicked[5];
    public unsafe fixed byte MouseDoubleClicked[5];
    public ushort MouseClickedCount_0;
    public ushort MouseClickedCount_1;
    public ushort MouseClickedCount_2;
    public ushort MouseClickedCount_3;
    public ushort MouseClickedCount_4;
    public ushort MouseClickedLastCount_0;
    public ushort MouseClickedLastCount_1;
    public ushort MouseClickedLastCount_2;
    public ushort MouseClickedLastCount_3;
    public ushort MouseClickedLastCount_4;
    public unsafe fixed byte MouseReleased[5];
    public unsafe fixed byte MouseDownOwned[5];
    public unsafe fixed byte MouseDownOwnedUnlessPopupClose[5];
    public unsafe fixed float MouseDownDuration[5];
    public unsafe fixed float MouseDownDurationPrev[5];
    public unsafe fixed float MouseDragMaxDistanceSqr[5];
    public unsafe fixed float NavInputsDownDuration[20];
    public unsafe fixed float NavInputsDownDurationPrev[20];
    public float PenPressure;
    public byte AppFocusLost;
    public byte AppAcceptingEvents;
    public System.SByte BackendUsingLegacyKeyArrays;
    public byte BackendUsingLegacyNavInputArray;
    public ushort InputQueueSurrogate;
    public ImVector InputQueueCharacters;
  }
  public struct ImGuiIOPtr
  {
    public unsafe ImGuiIO* NativePtr { get => default; }
    public ref ImGuiConfigFlags ConfigFlags { get => ref __0; }
    public ref ImGuiBackendFlags BackendFlags { get => ref __1; }
    public ref UnityEngine.Vector2 DisplaySize { get => ref __2; }
    public ref float DeltaTime { get => ref __3; }
    public ref float IniSavingRate { get => ref __3; }
    public ref string IniFilename { get => ref __4; }
    public ref string LogFilename { get => ref __4; }
    public ref float MouseDoubleClickTime { get => ref __3; }
    public ref float MouseDoubleClickMaxDist { get => ref __3; }
    public ref float MouseDragThreshold { get => ref __3; }
    public ref float KeyRepeatDelay { get => ref __3; }
    public ref float KeyRepeatRate { get => ref __3; }
    public System.IntPtr UserData { get => default; set { } }
    public ref ImFontAtlasPtr Fonts { get => ref __5; }
    public ref float FontGlobalScale { get => ref __3; }
    public ref bool FontAllowUserScaling { get => ref __6; }
    public ref ImFontPtr FontDefault { get => ref __7; }
    public ref UnityEngine.Vector2 DisplayFramebufferScale { get => ref __2; }
    public ref bool MouseDrawCursor { get => ref __6; }
    public ref bool ConfigMacOSXBehaviors { get => ref __6; }
    public ref bool ConfigInputTrickleEventQueue { get => ref __6; }
    public ref bool ConfigInputTextCursorBlink { get => ref __6; }
    public ref bool ConfigDragClickToInputText { get => ref __6; }
    public ref bool ConfigWindowsResizeFromEdges { get => ref __6; }
    public ref bool ConfigWindowsMoveFromTitleBarOnly { get => ref __6; }
    public ref float ConfigMemoryCompactTimer { get => ref __3; }
    public ref string BackendPlatformName { get => ref __4; }
    public ref string BackendRendererName { get => ref __4; }
    public System.IntPtr BackendPlatformUserData { get => default; set { } }
    public System.IntPtr BackendRendererUserData { get => default; set { } }
    public System.IntPtr BackendLanguageUserData { get => default; set { } }
    public System.IntPtr GetClipboardTextFn { get => default; set { } }
    public System.IntPtr SetClipboardTextFn { get => default; set { } }
    public System.IntPtr ClipboardUserData { get => default; set { } }
    public System.IntPtr SetPlatformImeDataFn { get => default; set { } }
    public System.IntPtr _UnusedPadding { get => default; set { } }
    public ref bool WantCaptureMouse { get => ref __6; }
    public ref bool WantCaptureKeyboard { get => ref __6; }
    public ref bool WantTextInput { get => ref __6; }
    public ref bool WantSetMousePos { get => ref __6; }
    public ref bool WantSaveIniSettings { get => ref __6; }
    public ref bool NavActive { get => ref __6; }
    public ref bool NavVisible { get => ref __6; }
    public ref float Framerate { get => ref __3; }
    public ref int MetricsRenderVertices { get => ref __8; }
    public ref int MetricsRenderIndices { get => ref __8; }
    public ref int MetricsRenderWindows { get => ref __8; }
    public ref int MetricsActiveWindows { get => ref __8; }
    public ref int MetricsActiveAllocations { get => ref __8; }
    public ref UnityEngine.Vector2 MouseDelta { get => ref __2; }
    public RangeAccessor<int> KeyMap { get => default; }
    public RangeAccessor<bool> KeysDown { get => default; }
    public ref UnityEngine.Vector2 MousePos { get => ref __2; }
    public RangeAccessor<bool> MouseDown { get => default; }
    public ref float MouseWheel { get => ref __3; }
    public ref float MouseWheelH { get => ref __3; }
    public ref bool KeyCtrl { get => ref __6; }
    public ref bool KeyShift { get => ref __6; }
    public ref bool KeyAlt { get => ref __6; }
    public ref bool KeySuper { get => ref __6; }
    public RangeAccessor<float> NavInputs { get => default; }
    public ref ImGuiModFlags KeyMods { get => ref __9; }
    public RangeAccessor<ImGuiKeyData> KeysData { get => default; }
    public ref bool WantCaptureMouseUnlessPopupClose { get => ref __6; }
    public ref UnityEngine.Vector2 MousePosPrev { get => ref __2; }
    public RangeAccessor<UnityEngine.Vector2> MouseClickedPos { get => default; }
    public RangeAccessor<double> MouseClickedTime { get => default; }
    public RangeAccessor<bool> MouseClicked { get => default; }
    public RangeAccessor<bool> MouseDoubleClicked { get => default; }
    public RangeAccessor<ushort> MouseClickedCount { get => default; }
    public RangeAccessor<ushort> MouseClickedLastCount { get => default; }
    public RangeAccessor<bool> MouseReleased { get => default; }
    public RangeAccessor<bool> MouseDownOwned { get => default; }
    public RangeAccessor<bool> MouseDownOwnedUnlessPopupClose { get => default; }
    public RangeAccessor<float> MouseDownDuration { get => default; }
    public RangeAccessor<float> MouseDownDurationPrev { get => default; }
    public RangeAccessor<float> MouseDragMaxDistanceSqr { get => default; }
    public RangeAccessor<float> NavInputsDownDuration { get => default; }
    public RangeAccessor<float> NavInputsDownDurationPrev { get => default; }
    public ref float PenPressure { get => ref __3; }
    public ref bool AppFocusLost { get => ref __6; }
    public ref bool AppAcceptingEvents { get => ref __6; }
    public ref System.SByte BackendUsingLegacyKeyArrays { get => ref __10; }
    public ref bool BackendUsingLegacyNavInputArray { get => ref __6; }
    public ref ushort InputQueueSurrogate { get => ref __11; }
    public ImVector<ushort> InputQueueCharacters { get => default; }
    public void AddFocusEvent(bool focused) { }
    public void AddInputCharacter(uint c) { }
    public void AddInputCharacterUTF16(ushort c) { }
    public void AddInputCharactersUTF8(string str) { }
    public void AddKeyAnalogEvent(ImGuiKey key, bool down, float v) { }
    public void AddKeyEvent(ImGuiKey key, bool down) { }
    public void AddMouseButtonEvent(int button, bool down) { }
    public void AddMousePosEvent(float x, float y) { }
    public void AddMouseWheelEvent(float wh_x, float wh_y) { }
    public void ClearInputCharacters() { }
    public void ClearInputKeys() { }
    public void SetAppAcceptingEvents(bool accepting_events) { }
    public void SetKeyEventNativeData(ImGuiKey key, int native_keycode, int native_scancode) { }
    public void SetKeyEventNativeData(ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index) { }
    public void ImGuiIO_destroy() { }
    public void SetBackendRendererName(string name) { }
    public void SetBackendPlatformName(string name) { }
    public void SetIniFilename(string name) { }
    public void SetBackendPlatformUserData<T>(T? data) where T : unmanaged { }
    internal static ImGuiConfigFlags __0;
    internal static ImGuiBackendFlags __1;
    internal static UnityEngine.Vector2 __2;
    internal static float __3;
    internal static string __4;
    internal static ImFontAtlasPtr __5;
    internal static bool __6;
    internal static ImFontPtr __7;
    internal static int __8;
    internal static ImGuiModFlags __9;
    internal static System.SByte __10;
    internal static ushort __11;
  }
  public enum ImGuiItemFlags
  {
    None = 0,
    NoTabStop = 1,
    ButtonRepeat = 2,
    Disabled = 4,
    NoNav = 8,
    NoNavDefaultFocus = 16,
    SelectableDontClosePopup = 32,
    MixedValue = 64,
    ReadOnly = 128,
    Inputable = 256,
  }
  public enum ImGuiItemStatusFlags
  {
    None = 0,
    HoveredRect = 1,
    HasDisplayRect = 2,
    Edited = 4,
    ToggledSelection = 8,
    ToggledOpen = 16,
    HasDeactivated = 32,
    Deactivated = 64,
    HoveredWindow = 128,
    FocusedByTabbing = 256,
  }
  public enum ImGuiKey
  {
    None = 0,
    KeysData_OFFSET = 0,
    NamedKey_COUNT = 133,
    NamedKey_BEGIN = 512,
    Tab = 512,
    LeftArrow = 513,
    RightArrow = 514,
    UpArrow = 515,
    DownArrow = 516,
    PageUp = 517,
    PageDown = 518,
    Home = 519,
    End = 520,
    Insert = 521,
    Delete = 522,
    Backspace = 523,
    Space = 524,
    Enter = 525,
    Escape = 526,
    LeftCtrl = 527,
    LeftShift = 528,
    LeftAlt = 529,
    LeftSuper = 530,
    RightCtrl = 531,
    RightShift = 532,
    RightAlt = 533,
    RightSuper = 534,
    Menu = 535,
    _0 = 536,
    _1 = 537,
    _2 = 538,
    _3 = 539,
    _4 = 540,
    _5 = 541,
    _6 = 542,
    _7 = 543,
    _8 = 544,
    _9 = 545,
    A = 546,
    B = 547,
    C = 548,
    D = 549,
    E = 550,
    F = 551,
    G = 552,
    H = 553,
    I = 554,
    J = 555,
    K = 556,
    L = 557,
    M = 558,
    N = 559,
    O = 560,
    P = 561,
    Q = 562,
    R = 563,
    S = 564,
    T = 565,
    U = 566,
    V = 567,
    W = 568,
    X = 569,
    Y = 570,
    Z = 571,
    F1 = 572,
    F2 = 573,
    F3 = 574,
    F4 = 575,
    F5 = 576,
    F6 = 577,
    F7 = 578,
    F8 = 579,
    F9 = 580,
    F10 = 581,
    F11 = 582,
    F12 = 583,
    Apostrophe = 584,
    Comma = 585,
    Minus = 586,
    Period = 587,
    Slash = 588,
    Semicolon = 589,
    Equal = 590,
    LeftBracket = 591,
    Backslash = 592,
    RightBracket = 593,
    GraveAccent = 594,
    CapsLock = 595,
    ScrollLock = 596,
    NumLock = 597,
    PrintScreen = 598,
    Pause = 599,
    Keypad0 = 600,
    Keypad1 = 601,
    Keypad2 = 602,
    Keypad3 = 603,
    Keypad4 = 604,
    Keypad5 = 605,
    Keypad6 = 606,
    Keypad7 = 607,
    Keypad8 = 608,
    Keypad9 = 609,
    KeypadDecimal = 610,
    KeypadDivide = 611,
    KeypadMultiply = 612,
    KeypadSubtract = 613,
    KeypadAdd = 614,
    KeypadEnter = 615,
    KeypadEqual = 616,
    GamepadStart = 617,
    GamepadBack = 618,
    GamepadFaceUp = 619,
    GamepadFaceDown = 620,
    GamepadFaceLeft = 621,
    GamepadFaceRight = 622,
    GamepadDpadUp = 623,
    GamepadDpadDown = 624,
    GamepadDpadLeft = 625,
    GamepadDpadRight = 626,
    GamepadL1 = 627,
    GamepadR1 = 628,
    GamepadL2 = 629,
    GamepadR2 = 630,
    GamepadL3 = 631,
    GamepadR3 = 632,
    GamepadLStickUp = 633,
    GamepadLStickDown = 634,
    GamepadLStickLeft = 635,
    GamepadLStickRight = 636,
    GamepadRStickUp = 637,
    GamepadRStickDown = 638,
    GamepadRStickLeft = 639,
    GamepadRStickRight = 640,
    ModCtrl = 641,
    ModShift = 642,
    ModAlt = 643,
    ModSuper = 644,
    COUNT = 645,
    NamedKey_END = 645,
    KeysData_SIZE = 645,
  }
  public struct ImGuiKeyData
  {
    public byte Down;
    public float DownDuration;
    public float DownDurationPrev;
    public float AnalogValue;
  }
  public struct ImGuiKeyDataPtr
  {
    public unsafe ImGuiKeyData* NativePtr { get => default; }
    public ref bool Down { get => ref __0; }
    public ref float DownDuration { get => ref __1; }
    public ref float DownDurationPrev { get => ref __1; }
    public ref float AnalogValue { get => ref __1; }
    internal static bool __0;
    internal static float __1;
  }
  public enum ImGuiKeyPrivate
  {
    LegacyNativeKey_BEGIN = 0,
    LegacyNativeKey_END = 512,
    Gamepad_BEGIN = 617,
    Gamepad_END = 641,
  }
  public struct ImGuiLastItemData
  {
    public uint ID;
    public ImGuiItemFlags InFlags;
    public ImGuiItemStatusFlags StatusFlags;
    public UnityEngine.Rect Rect;
    public UnityEngine.Rect NavRect;
    public UnityEngine.Rect DisplayRect;
  }
  public struct ImGuiLastItemDataPtr
  {
    public unsafe ImGuiLastItemData* NativePtr { get => default; }
    public ref uint ID { get => ref __0; }
    public ref ImGuiItemFlags InFlags { get => ref __1; }
    public ref ImGuiItemStatusFlags StatusFlags { get => ref __2; }
    public ref UnityEngine.Rect Rect { get => ref __3; }
    public ref UnityEngine.Rect NavRect { get => ref __3; }
    public ref UnityEngine.Rect DisplayRect { get => ref __3; }
    public void ImGuiLastItemData_destroy() { }
    internal static uint __0;
    internal static ImGuiItemFlags __1;
    internal static ImGuiItemStatusFlags __2;
    internal static UnityEngine.Rect __3;
  }
  public enum ImGuiLayoutType
  {
    Horizontal = 0,
    Vertical = 1,
  }
  public struct ImGuiListClipper
  {
    public int DisplayStart;
    public int DisplayEnd;
    public int ItemsCount;
    public float ItemsHeight;
    public float StartPosY;
    public unsafe void* TempData;
  }
  public struct ImGuiListClipperPtr
  {
    public unsafe ImGuiListClipper* NativePtr { get => default; }
    public ref int DisplayStart { get => ref __0; }
    public ref int DisplayEnd { get => ref __0; }
    public ref int ItemsCount { get => ref __0; }
    public ref float ItemsHeight { get => ref __1; }
    public ref float StartPosY { get => ref __1; }
    public System.IntPtr TempData { get => default; set { } }
    public void Begin(int items_count) { }
    public void Begin(int items_count, float items_height) { }
    public void End() { }
    public void ForceDisplayRangeByIndices(int item_min, int item_max) { }
    public bool Step() { return default; }
    public void ImGuiListClipper_destroy() { }
    internal static int __0;
    internal static float __1;
  }
  public struct ImGuiListClipperData
  {
    public unsafe ImGuiListClipper* ListClipper;
    public float LossynessOffset;
    public int StepNo;
    public int ItemsFrozen;
    public ImVector Ranges;
  }
  public struct ImGuiListClipperDataPtr
  {
    public unsafe ImGuiListClipperData* NativePtr { get => default; }
    public ref ImGuiListClipperPtr ListClipper { get => ref __0; }
    public ref float LossynessOffset { get => ref __1; }
    public ref int StepNo { get => ref __2; }
    public ref int ItemsFrozen { get => ref __2; }
    public ImPtrVector<ImGuiListClipperRangePtr> Ranges { get => default; }
    public void Reset(ImGuiListClipperPtr clipper) { }
    public void ImGuiListClipperData_destroy() { }
    internal static ImGuiListClipperPtr __0;
    internal static float __1;
    internal static int __2;
  }
  public struct ImGuiListClipperRange
  {
    public int Min;
    public int Max;
    public byte PosToIndexConvert;
    public System.SByte PosToIndexOffsetMin;
    public System.SByte PosToIndexOffsetMax;
  }
  public struct ImGuiListClipperRangePtr
  {
    public unsafe ImGuiListClipperRange* NativePtr { get => default; }
    public ref int Min { get => ref __0; }
    public ref int Max { get => ref __0; }
    public ref bool PosToIndexConvert { get => ref __1; }
    public ref System.SByte PosToIndexOffsetMin { get => ref __2; }
    public ref System.SByte PosToIndexOffsetMax { get => ref __2; }
    public static ImGuiListClipperRange FromIndices(int min, int max) { return default; }
    public static ImGuiListClipperRange FromPositions(float y1, float y2, int off_min, int off_max) { return default; }
    internal static int __0;
    internal static bool __1;
    internal static System.SByte __2;
  }
  public enum ImGuiLogType
  {
    None = 0,
    TTY = 1,
    File = 2,
    Buffer = 3,
    Clipboard = 4,
  }
  public struct ImGuiMenuColumns
  {
    public uint TotalWidth;
    public uint NextTotalWidth;
    public ushort Spacing;
    public ushort OffsetIcon;
    public ushort OffsetLabel;
    public ushort OffsetShortcut;
    public ushort OffsetMark;
    public ushort Widths_0;
    public ushort Widths_1;
    public ushort Widths_2;
    public ushort Widths_3;
  }
  public struct ImGuiMenuColumnsPtr
  {
    public unsafe ImGuiMenuColumns* NativePtr { get => default; }
    public ref uint TotalWidth { get => ref __0; }
    public ref uint NextTotalWidth { get => ref __0; }
    public ref ushort Spacing { get => ref __1; }
    public ref ushort OffsetIcon { get => ref __1; }
    public ref ushort OffsetLabel { get => ref __1; }
    public ref ushort OffsetShortcut { get => ref __1; }
    public ref ushort OffsetMark { get => ref __1; }
    public RangeAccessor<ushort> Widths { get => default; }
    public void CalcNextTotalWidth(bool update_offsets) { }
    public float DeclColumns(float w_icon, float w_label, float w_shortcut, float w_mark) { return default; }
    public void Update(float spacing, bool window_reappearing) { }
    public void ImGuiMenuColumns_destroy() { }
    internal static uint __0;
    internal static ushort __1;
  }
  public struct ImGuiMetricsConfig
  {
    public byte ShowDebugLog;
    public byte ShowStackTool;
    public byte ShowWindowsRects;
    public byte ShowWindowsBeginOrder;
    public byte ShowTablesRects;
    public byte ShowDrawCmdMesh;
    public byte ShowDrawCmdBoundingBoxes;
    public int ShowWindowsRectsType;
    public int ShowTablesRectsType;
  }
  public struct ImGuiMetricsConfigPtr
  {
    public unsafe ImGuiMetricsConfig* NativePtr { get => default; }
    public ref bool ShowDebugLog { get => ref __0; }
    public ref bool ShowStackTool { get => ref __0; }
    public ref bool ShowWindowsRects { get => ref __0; }
    public ref bool ShowWindowsBeginOrder { get => ref __0; }
    public ref bool ShowTablesRects { get => ref __0; }
    public ref bool ShowDrawCmdMesh { get => ref __0; }
    public ref bool ShowDrawCmdBoundingBoxes { get => ref __0; }
    public ref int ShowWindowsRectsType { get => ref __1; }
    public ref int ShowTablesRectsType { get => ref __1; }
    public void ImGuiMetricsConfig_destroy() { }
    internal static bool __0;
    internal static int __1;
  }
  public enum ImGuiModFlags
  {
    None = 0,
    Ctrl = 1,
    Shift = 2,
    Alt = 4,
    Super = 8,
  }
  public enum ImGuiMouseButton
  {
    Left = 0,
    Right = 1,
    Middle = 2,
    COUNT = 5,
  }
  public enum ImGuiMouseCursor
  {
    Arrow = 0,
    TextInput = 1,
    ResizeAll = 2,
    ResizeNS = 3,
    ResizeEW = 4,
    ResizeNESW = 5,
    ResizeNWSE = 6,
    Hand = 7,
    NotAllowed = 8,
    COUNT = 9,
    None = -1,
  }
  public class ImGuiNative
  {
    public static unsafe void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a) { }
    public static unsafe ImColor* ImColor_ImColor_Nil() { return default; }
    public static unsafe ImColor* ImColor_ImColor_Float(float r, float g, float b, float a) { return default; }
    public static unsafe ImColor* ImColor_ImColor_Vec4(UnityEngine.Vector4 col) { return default; }
    public static unsafe ImColor* ImColor_ImColor_Int(int r, int g, int b, int a) { return default; }
    public static unsafe ImColor* ImColor_ImColor_U32(uint rgba) { return default; }
    public static unsafe void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a) { }
    public static unsafe void ImColor_destroy(ImColor* self) { }
    public static unsafe System.IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self) { return default; }
    public static unsafe ImDrawCmd* ImDrawCmd_ImDrawCmd() { return default; }
    public static unsafe void ImDrawCmd_destroy(ImDrawCmd* self) { }
    public static unsafe void ImDrawData_Clear(ImDrawData* self) { }
    public static unsafe void ImDrawData_DeIndexAllBuffers(ImDrawData* self) { }
    public static unsafe ImDrawData* ImDrawData_ImDrawData() { return default; }
    public static unsafe void ImDrawData_ScaleClipRects(ImDrawData* self, UnityEngine.Vector2 fb_scale) { }
    public static unsafe void ImDrawData_destroy(ImDrawData* self) { }
    public static unsafe void ImDrawDataBuilder_Clear(ImDrawDataBuilder* self) { }
    public static unsafe void ImDrawDataBuilder_ClearFreeMemory(ImDrawDataBuilder* self) { }
    public static unsafe void ImDrawDataBuilder_FlattenIntoSingleLayer(ImDrawDataBuilder* self) { }
    public static unsafe int ImDrawDataBuilder_GetDrawListCount(ImDrawDataBuilder* self) { return default; }
    public static unsafe void ImDrawList_AddBezierCubic(ImDrawList* self, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col, float thickness, int num_segments) { }
    public static unsafe void ImDrawList_AddBezierQuadratic(ImDrawList* self, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col, float thickness, int num_segments) { }
    public static unsafe void ImDrawList_AddCallback(ImDrawList* self, ImDrawCallback callback, System.IntPtr callback_data) { }
    public static unsafe void ImDrawList_AddCircle(ImDrawList* self, UnityEngine.Vector2 center, float radius, uint col, int num_segments, float thickness) { }
    public static unsafe void ImDrawList_AddCircleFilled(ImDrawList* self, UnityEngine.Vector2 center, float radius, uint col, int num_segments) { }
    public static unsafe void ImDrawList_AddConvexPolyFilled(ImDrawList* self, UnityEngine.Vector2* points, int num_points, uint col) { }
    public static unsafe void ImDrawList_AddDrawCmd(ImDrawList* self) { }
    public static unsafe void ImDrawList_AddImage(ImDrawList* self, System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min, UnityEngine.Vector2 uv_max, uint col) { }
    public static unsafe void ImDrawList_AddImageQuad(ImDrawList* self, System.IntPtr user_texture_id, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 uv1, UnityEngine.Vector2 uv2, UnityEngine.Vector2 uv3, UnityEngine.Vector2 uv4, uint col) { }
    public static unsafe void ImDrawList_AddImageRounded(ImDrawList* self, System.IntPtr user_texture_id, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, UnityEngine.Vector2 uv_min, UnityEngine.Vector2 uv_max, uint col, float rounding, ImDrawFlags flags) { }
    public static unsafe void ImDrawList_AddLine(ImDrawList* self, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, uint col, float thickness) { }
    public static unsafe void ImDrawList_AddNgon(ImDrawList* self, UnityEngine.Vector2 center, float radius, uint col, int num_segments, float thickness) { }
    public static unsafe void ImDrawList_AddNgonFilled(ImDrawList* self, UnityEngine.Vector2 center, float radius, uint col, int num_segments) { }
    public static unsafe void ImDrawList_AddPolyline(ImDrawList* self, UnityEngine.Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness) { }
    public static unsafe void ImDrawList_AddQuad(ImDrawList* self, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col, float thickness) { }
    public static unsafe void ImDrawList_AddQuadFilled(ImDrawList* self, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, uint col) { }
    public static unsafe void ImDrawList_AddRect(ImDrawList* self, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness) { }
    public static unsafe void ImDrawList_AddRectFilled(ImDrawList* self, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col, float rounding, ImDrawFlags flags) { }
    public static unsafe void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left) { }
    public static unsafe void ImDrawList_AddText_Vec2(ImDrawList* self, UnityEngine.Vector2 pos, uint col, byte* text_begin, byte* text_end) { }
    public static unsafe void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, UnityEngine.Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, UnityEngine.Vector4* cpu_fine_clip_rect) { }
    public static unsafe void ImDrawList_AddTriangle(ImDrawList* self, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col, float thickness) { }
    public static unsafe void ImDrawList_AddTriangleFilled(ImDrawList* self, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, uint col) { }
    public static unsafe void ImDrawList_ChannelsMerge(ImDrawList* self) { }
    public static unsafe void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n) { }
    public static unsafe void ImDrawList_ChannelsSplit(ImDrawList* self, int count) { }
    public static unsafe ImDrawList* ImDrawList_CloneOutput(ImDrawList* self) { return default; }
    public static unsafe void ImDrawList_GetClipRectMax(UnityEngine.Vector2* pOut, ImDrawList* self) { }
    public static unsafe void ImDrawList_GetClipRectMin(UnityEngine.Vector2* pOut, ImDrawList* self) { }
    public static unsafe ImDrawList* ImDrawList_ImDrawList(ImDrawListSharedData* shared_data) { return default; }
    public static unsafe void ImDrawList_PathArcTo(ImDrawList* self, UnityEngine.Vector2 center, float radius, float a_min, float a_max, int num_segments) { }
    public static unsafe void ImDrawList_PathArcToFast(ImDrawList* self, UnityEngine.Vector2 center, float radius, int a_min_of_12, int a_max_of_12) { }
    public static unsafe void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, int num_segments) { }
    public static unsafe void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, int num_segments) { }
    public static unsafe void ImDrawList_PathClear(ImDrawList* self) { }
    public static unsafe void ImDrawList_PathFillConvex(ImDrawList* self, uint col) { }
    public static unsafe void ImDrawList_PathLineTo(ImDrawList* self, UnityEngine.Vector2 pos) { }
    public static unsafe void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, UnityEngine.Vector2 pos) { }
    public static unsafe void ImDrawList_PathRect(ImDrawList* self, UnityEngine.Vector2 rect_min, UnityEngine.Vector2 rect_max, float rounding, ImDrawFlags flags) { }
    public static unsafe void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness) { }
    public static unsafe void ImDrawList_PopClipRect(ImDrawList* self) { }
    public static unsafe void ImDrawList_PopTextureID(ImDrawList* self) { }
    public static unsafe void ImDrawList_PrimQuadUV(ImDrawList* self, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 d, UnityEngine.Vector2 uv_a, UnityEngine.Vector2 uv_b, UnityEngine.Vector2 uv_c, UnityEngine.Vector2 uv_d, uint col) { }
    public static unsafe void ImDrawList_PrimRect(ImDrawList* self, UnityEngine.Vector2 a, UnityEngine.Vector2 b, uint col) { }
    public static unsafe void ImDrawList_PrimRectUV(ImDrawList* self, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 uv_a, UnityEngine.Vector2 uv_b, uint col) { }
    public static unsafe void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count) { }
    public static unsafe void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count) { }
    public static unsafe void ImDrawList_PrimVtx(ImDrawList* self, UnityEngine.Vector2 pos, UnityEngine.Vector2 uv, uint col) { }
    public static unsafe void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx) { }
    public static unsafe void ImDrawList_PrimWriteVtx(ImDrawList* self, UnityEngine.Vector2 pos, UnityEngine.Vector2 uv, uint col) { }
    public static unsafe void ImDrawList_PushClipRect(ImDrawList* self, UnityEngine.Vector2 clip_rect_min, UnityEngine.Vector2 clip_rect_max, byte intersect_with_current_clip_rect) { }
    public static unsafe void ImDrawList_PushClipRectFullScreen(ImDrawList* self) { }
    public static unsafe void ImDrawList_PushTextureID(ImDrawList* self, System.IntPtr texture_id) { }
    public static unsafe int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius) { return default; }
    public static unsafe void ImDrawList__ClearFreeMemory(ImDrawList* self) { }
    public static unsafe void ImDrawList__OnChangedClipRect(ImDrawList* self) { }
    public static unsafe void ImDrawList__OnChangedTextureID(ImDrawList* self) { }
    public static unsafe void ImDrawList__OnChangedVtxOffset(ImDrawList* self) { }
    public static unsafe void ImDrawList__PathArcToFastEx(ImDrawList* self, UnityEngine.Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step) { }
    public static unsafe void ImDrawList__PathArcToN(ImDrawList* self, UnityEngine.Vector2 center, float radius, float a_min, float a_max, int num_segments) { }
    public static unsafe void ImDrawList__PopUnusedDrawCmd(ImDrawList* self) { }
    public static unsafe void ImDrawList__ResetForNewFrame(ImDrawList* self) { }
    public static unsafe void ImDrawList__TryMergeDrawCmds(ImDrawList* self) { }
    public static unsafe void ImDrawList_destroy(ImDrawList* self) { }
    public static unsafe ImDrawListSharedData* ImDrawListSharedData_ImDrawListSharedData() { return default; }
    public static unsafe void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error) { }
    public static unsafe void ImDrawListSharedData_destroy(ImDrawListSharedData* self) { }
    public static unsafe void ImDrawListSplitter_Clear(ImDrawListSplitter* self) { }
    public static unsafe void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self) { }
    public static unsafe ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter() { return default; }
    public static unsafe void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list) { }
    public static unsafe void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx) { }
    public static unsafe void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count) { }
    public static unsafe void ImDrawListSplitter_destroy(ImDrawListSplitter* self) { }
    public static unsafe void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x) { }
    public static unsafe void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst) { }
    public static unsafe void ImFont_BuildLookupTable(ImFont* self) { }
    public static unsafe void ImFont_CalcTextSizeA(UnityEngine.Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, System.Byte** remaining) { }
    public static unsafe byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width) { return default; }
    public static unsafe void ImFont_ClearOutputData(ImFont* self) { }
    public static unsafe ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c) { return default; }
    public static unsafe ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c) { return default; }
    public static unsafe float ImFont_GetCharAdvance(ImFont* self, ushort c) { return default; }
    public static unsafe byte* ImFont_GetDebugName(ImFont* self) { return default; }
    public static unsafe void ImFont_GrowIndex(ImFont* self, int new_size) { }
    public static unsafe ImFont* ImFont_ImFont() { return default; }
    public static unsafe byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last) { return default; }
    public static unsafe byte ImFont_IsLoaded(ImFont* self) { return default; }
    public static unsafe void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, UnityEngine.Vector2 pos, uint col, ushort c) { }
    public static unsafe void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, UnityEngine.Vector2 pos, uint col, UnityEngine.Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip) { }
    public static unsafe void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible) { }
    public static unsafe void ImFont_destroy(ImFont* self) { }
    public static unsafe int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, UnityEngine.Vector2 offset) { return default; }
    public static unsafe int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height) { return default; }
    public static unsafe ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg) { return default; }
    public static unsafe ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg) { return default; }
    public static unsafe ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges) { return default; }
    public static unsafe ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges) { return default; }
    public static unsafe ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, System.IntPtr compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges) { return default; }
    public static unsafe ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, System.IntPtr font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges) { return default; }
    public static unsafe byte ImFontAtlas_Build(ImFontAtlas* self) { return default; }
    public static unsafe void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, UnityEngine.Vector2* out_uv_min, UnityEngine.Vector2* out_uv_max) { }
    public static unsafe void ImFontAtlas_Clear(ImFontAtlas* self) { }
    public static unsafe void ImFontAtlas_ClearFonts(ImFontAtlas* self) { }
    public static unsafe void ImFontAtlas_ClearInputData(ImFontAtlas* self) { }
    public static unsafe void ImFontAtlas_ClearTexData(ImFontAtlas* self) { }
    public static unsafe ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self) { return default; }
    public static unsafe ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self) { return default; }
    public static unsafe byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, UnityEngine.Vector2* out_offset, UnityEngine.Vector2* out_size, UnityEngine.Vector2* out_uv_border, UnityEngine.Vector2* out_uv_fill) { return default; }
    public static unsafe void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, System.Byte** out_pixels, System.Int32* out_width, System.Int32* out_height, System.Int32* out_bytes_per_pixel) { }
    public static unsafe void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, System.Byte** out_pixels, System.Int32* out_width, System.Int32* out_height, System.Int32* out_bytes_per_pixel) { }
    public static unsafe ImFontAtlas* ImFontAtlas_ImFontAtlas() { return default; }
    public static unsafe byte ImFontAtlas_IsBuilt(ImFontAtlas* self) { return default; }
    public static unsafe void ImFontAtlas_SetTexID(ImFontAtlas* self, System.IntPtr id) { }
    public static unsafe void ImFontAtlas_destroy(ImFontAtlas* self) { }
    public static unsafe ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect() { return default; }
    public static unsafe byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self) { return default; }
    public static unsafe void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self) { }
    public static unsafe ImFontConfig* ImFontConfig_ImFontConfig() { return default; }
    public static unsafe void ImFontConfig_destroy(ImFontConfig* self) { }
    public static unsafe void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c) { }
    public static unsafe void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges) { }
    public static unsafe void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end) { }
    public static unsafe void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector out_ranges) { }
    public static unsafe void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self) { }
    public static unsafe byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n) { return default; }
    public static unsafe ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder() { return default; }
    public static unsafe void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n) { }
    public static unsafe void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self) { }
    public static unsafe ImGuiComboPreviewData* ImGuiComboPreviewData_ImGuiComboPreviewData() { return default; }
    public static unsafe void ImGuiComboPreviewData_destroy(ImGuiComboPreviewData* self) { }
    public static unsafe void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused) { }
    public static unsafe void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c) { }
    public static unsafe void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c) { }
    public static unsafe void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str) { }
    public static unsafe void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v) { }
    public static unsafe void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down) { }
    public static unsafe void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down) { }
    public static unsafe void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y) { }
    public static unsafe void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wh_x, float wh_y) { }
    public static unsafe void ImGuiIO_ClearInputCharacters(ImGuiIO* self) { }
    public static unsafe void ImGuiIO_ClearInputKeys(ImGuiIO* self) { }
    public static unsafe ImGuiIO* ImGuiIO_ImGuiIO() { return default; }
    public static unsafe void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events) { }
    public static unsafe void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index) { }
    public static unsafe void ImGuiIO_destroy(ImGuiIO* self) { }
    public static unsafe void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self) { }
    public static unsafe void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count) { }
    public static unsafe byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self) { return default; }
    public static unsafe ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData() { return default; }
    public static unsafe void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end) { }
    public static unsafe void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self) { }
    public static unsafe void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self) { }
    public static unsafe ImGuiLastItemData* ImGuiLastItemData_ImGuiLastItemData() { return default; }
    public static unsafe void ImGuiLastItemData_destroy(ImGuiLastItemData* self) { }
    public static unsafe void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height) { }
    public static unsafe void ImGuiListClipper_End(ImGuiListClipper* self) { }
    public static unsafe void ImGuiListClipper_ForceDisplayRangeByIndices(ImGuiListClipper* self, int item_min, int item_max) { }
    public static unsafe ImGuiListClipper* ImGuiListClipper_ImGuiListClipper() { return default; }
    public static unsafe byte ImGuiListClipper_Step(ImGuiListClipper* self) { return default; }
    public static unsafe void ImGuiListClipper_destroy(ImGuiListClipper* self) { }
    public static unsafe ImGuiListClipperData* ImGuiListClipperData_ImGuiListClipperData() { return default; }
    public static unsafe void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper) { }
    public static unsafe void ImGuiListClipperData_destroy(ImGuiListClipperData* self) { }
    public static ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max) { return default; }
    public static ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max) { return default; }
    public static unsafe void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, byte update_offsets) { }
    public static unsafe float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark) { return default; }
    public static unsafe ImGuiMenuColumns* ImGuiMenuColumns_ImGuiMenuColumns() { return default; }
    public static unsafe void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, byte window_reappearing) { }
    public static unsafe void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self) { }
    public static unsafe ImGuiMetricsConfig* ImGuiMetricsConfig_ImGuiMetricsConfig() { return default; }
    public static unsafe void ImGuiMetricsConfig_destroy(ImGuiMetricsConfig* self) { }
    public static unsafe void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self) { }
    public static unsafe ImGuiNextItemData* ImGuiNextItemData_ImGuiNextItemData() { return default; }
    public static unsafe void ImGuiNextItemData_destroy(ImGuiNextItemData* self) { }
    public static unsafe void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self) { }
    public static unsafe ImGuiNextWindowData* ImGuiNextWindowData_ImGuiNextWindowData() { return default; }
    public static unsafe void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self) { }
    public static unsafe ImGuiOldColumnData* ImGuiOldColumnData_ImGuiOldColumnData() { return default; }
    public static unsafe void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self) { }
    public static unsafe ImGuiOldColumns* ImGuiOldColumns_ImGuiOldColumns() { return default; }
    public static unsafe void ImGuiOldColumns_destroy(ImGuiOldColumns* self) { }
    public static unsafe ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame() { return default; }
    public static unsafe void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self) { }
    public static unsafe void ImGuiPayload_Clear(ImGuiPayload* self) { }
    public static unsafe ImGuiPayload* ImGuiPayload_ImGuiPayload() { return default; }
    public static unsafe byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type) { return default; }
    public static unsafe byte ImGuiPayload_IsDelivery(ImGuiPayload* self) { return default; }
    public static unsafe byte ImGuiPayload_IsPreview(ImGuiPayload* self) { return default; }
    public static unsafe void ImGuiPayload_destroy(ImGuiPayload* self) { }
    public static unsafe ImGuiPlatformImeData* ImGuiPlatformImeData_ImGuiPlatformImeData() { return default; }
    public static unsafe void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self) { }
    public static unsafe ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr(System.IntPtr ptr) { return default; }
    public static unsafe ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int(int index) { return default; }
    public static unsafe void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self) { }
    public static unsafe ImGuiSettingsHandler* ImGuiSettingsHandler_ImGuiSettingsHandler() { return default; }
    public static unsafe void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self) { }
    public static unsafe ImGuiStackLevelInfo* ImGuiStackLevelInfo_ImGuiStackLevelInfo() { return default; }
    public static unsafe void ImGuiStackLevelInfo_destroy(ImGuiStackLevelInfo* self) { }
    public static unsafe void ImGuiStackSizes_CompareWithCurrentState(ImGuiStackSizes* self) { }
    public static unsafe ImGuiStackSizes* ImGuiStackSizes_ImGuiStackSizes() { return default; }
    public static unsafe void ImGuiStackSizes_SetToCurrentState(ImGuiStackSizes* self) { }
    public static unsafe void ImGuiStackSizes_destroy(ImGuiStackSizes* self) { }
    public static unsafe ImGuiStackTool* ImGuiStackTool_ImGuiStackTool() { return default; }
    public static unsafe void ImGuiStackTool_destroy(ImGuiStackTool* self) { }
    public static unsafe void ImGuiStorage_BuildSortByKey(ImGuiStorage* self) { }
    public static unsafe void ImGuiStorage_Clear(ImGuiStorage* self) { }
    public static unsafe byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val) { return default; }
    public static unsafe byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val) { return default; }
    public static unsafe float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val) { return default; }
    public static unsafe System.Single* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val) { return default; }
    public static unsafe int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val) { return default; }
    public static unsafe System.Int32* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val) { return default; }
    public static unsafe System.IntPtr ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key) { return default; }
    public static unsafe System.IntPtr ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, System.IntPtr default_val) { return default; }
    public static unsafe void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val) { }
    public static unsafe void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val) { }
    public static unsafe void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val) { }
    public static unsafe void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val) { }
    public static unsafe void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, System.IntPtr val) { }
    public static unsafe ImGuiStyle* ImGuiStyle_ImGuiStyle() { return default; }
    public static unsafe void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor) { }
    public static unsafe void ImGuiStyle_destroy(ImGuiStyle* self) { }
    public static unsafe byte* ImGuiTabBar_GetTabName(ImGuiTabBar* self, ImGuiTabItem* tab) { return default; }
    public static unsafe int ImGuiTabBar_GetTabOrder(ImGuiTabBar* self, ImGuiTabItem* tab) { return default; }
    public static unsafe ImGuiTabBar* ImGuiTabBar_ImGuiTabBar() { return default; }
    public static unsafe void ImGuiTabBar_destroy(ImGuiTabBar* self) { }
    public static unsafe ImGuiTabItem* ImGuiTabItem_ImGuiTabItem() { return default; }
    public static unsafe void ImGuiTabItem_destroy(ImGuiTabItem* self) { }
    public static unsafe ImGuiTable* ImGuiTable_ImGuiTable() { return default; }
    public static unsafe void ImGuiTable_destroy(ImGuiTable* self) { }
    public static unsafe ImGuiTableColumn* ImGuiTableColumn_ImGuiTableColumn() { return default; }
    public static unsafe void ImGuiTableColumn_destroy(ImGuiTableColumn* self) { }
    public static unsafe ImGuiTableColumnSettings* ImGuiTableColumnSettings_ImGuiTableColumnSettings() { return default; }
    public static unsafe void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self) { }
    public static unsafe ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs() { return default; }
    public static unsafe void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self) { }
    public static unsafe ImGuiTableInstanceData* ImGuiTableInstanceData_ImGuiTableInstanceData() { return default; }
    public static unsafe void ImGuiTableInstanceData_destroy(ImGuiTableInstanceData* self) { }
    public static unsafe ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self) { return default; }
    public static unsafe ImGuiTableSettings* ImGuiTableSettings_ImGuiTableSettings() { return default; }
    public static unsafe void ImGuiTableSettings_destroy(ImGuiTableSettings* self) { }
    public static unsafe ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs() { return default; }
    public static unsafe void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self) { }
    public static unsafe ImGuiTableTempData* ImGuiTableTempData_ImGuiTableTempData() { return default; }
    public static unsafe void ImGuiTableTempData_destroy(ImGuiTableTempData* self) { }
    public static unsafe ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer() { return default; }
    public static unsafe void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end) { }
    public static unsafe void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt) { }
    public static unsafe void ImGuiTextBuffer_appendfv(ImGuiTextBuffer* self, byte* fmt) { }
    public static unsafe byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self) { return default; }
    public static unsafe byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self) { return default; }
    public static unsafe void ImGuiTextBuffer_clear(ImGuiTextBuffer* self) { }
    public static unsafe void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self) { }
    public static unsafe byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self) { return default; }
    public static unsafe byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self) { return default; }
    public static unsafe void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity) { }
    public static unsafe int ImGuiTextBuffer_size(ImGuiTextBuffer* self) { return default; }
    public static unsafe void ImGuiTextFilter_Build(ImGuiTextFilter* self) { }
    public static unsafe void ImGuiTextFilter_Clear(ImGuiTextFilter* self) { }
    public static unsafe byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width) { return default; }
    public static unsafe ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter) { return default; }
    public static unsafe byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self) { return default; }
    public static unsafe byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end) { return default; }
    public static unsafe void ImGuiTextFilter_destroy(ImGuiTextFilter* self) { }
    public static unsafe ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Nil() { return default; }
    public static unsafe ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Str(byte* _b, byte* _e) { return default; }
    public static unsafe void ImGuiTextRange_destroy(ImGuiTextRange* self) { }
    public static unsafe byte ImGuiTextRange_empty(ImGuiTextRange* self) { return default; }
    public static unsafe void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector @out) { }
    public static unsafe void ImGuiViewport_GetCenter(UnityEngine.Vector2* pOut, ImGuiViewport* self) { }
    public static unsafe void ImGuiViewport_GetWorkCenter(UnityEngine.Vector2* pOut, ImGuiViewport* self) { }
    public static unsafe ImGuiViewport* ImGuiViewport_ImGuiViewport() { return default; }
    public static unsafe void ImGuiViewport_destroy(ImGuiViewport* self) { }
    public static unsafe void ImGuiViewportP_CalcWorkRectPos(UnityEngine.Vector2* pOut, ImGuiViewportP* self, UnityEngine.Vector2 off_min) { }
    public static unsafe void ImGuiViewportP_CalcWorkRectSize(UnityEngine.Vector2* pOut, ImGuiViewportP* self, UnityEngine.Vector2 off_min, UnityEngine.Vector2 off_max) { }
    public static unsafe void ImGuiViewportP_GetBuildWorkRect(UnityEngine.Rect* pOut, ImGuiViewportP* self) { }
    public static unsafe void ImGuiViewportP_GetMainRect(UnityEngine.Rect* pOut, ImGuiViewportP* self) { }
    public static unsafe void ImGuiViewportP_GetWorkRect(UnityEngine.Rect* pOut, ImGuiViewportP* self) { }
    public static unsafe ImGuiViewportP* ImGuiViewportP_ImGuiViewportP() { return default; }
    public static unsafe void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self) { }
    public static unsafe void ImGuiViewportP_destroy(ImGuiViewportP* self) { }
    public static unsafe float ImGuiWindow_CalcFontSize(ImGuiWindow* self) { return default; }
    public static unsafe uint ImGuiWindow_GetID_Str(ImGuiWindow* self, byte* str, byte* str_end) { return default; }
    public static unsafe uint ImGuiWindow_GetID_Ptr(ImGuiWindow* self, System.IntPtr ptr) { return default; }
    public static unsafe uint ImGuiWindow_GetID_Int(ImGuiWindow* self, int n) { return default; }
    public static unsafe uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, UnityEngine.Rect r_abs) { return default; }
    public static unsafe ImGuiWindow* ImGuiWindow_ImGuiWindow(System.IntPtr context, byte* name) { return default; }
    public static unsafe float ImGuiWindow_MenuBarHeight(ImGuiWindow* self) { return default; }
    public static unsafe void ImGuiWindow_MenuBarRect(UnityEngine.Rect* pOut, ImGuiWindow* self) { }
    public static unsafe void ImGuiWindow_Rect(UnityEngine.Rect* pOut, ImGuiWindow* self) { }
    public static unsafe float ImGuiWindow_TitleBarHeight(ImGuiWindow* self) { return default; }
    public static unsafe void ImGuiWindow_TitleBarRect(UnityEngine.Rect* pOut, ImGuiWindow* self) { }
    public static unsafe void ImGuiWindow_destroy(ImGuiWindow* self) { }
    public static unsafe ImVec1* ImVec1_ImVec1_Nil() { return default; }
    public static unsafe ImVec1* ImVec1_ImVec1_Float(float _x) { return default; }
    public static unsafe void ImVec1_destroy(ImVec1* self) { }
    public static unsafe void ImBitArray_ClearAllBits(ImBitArray* self) { }
    public static unsafe void ImBitArray_ClearBit(ImBitArray* self, int n) { }
    public static unsafe ImBitArray* ImBitArray_ImBitArray() { return default; }
    public static unsafe void ImBitArray_SetAllBits(ImBitArray* self) { }
    public static unsafe void ImBitArray_SetBit(ImBitArray* self, int n) { }
    public static unsafe void ImBitArray_SetBitRange(ImBitArray* self, int n, int n2) { }
    public static unsafe byte ImBitArray_TestBit(ImBitArray* self, int n) { return default; }
    public static unsafe void ImBitArray_destroy(ImBitArray* self) { }
    public static unsafe int ImSpanAllocator_GetArenaSizeInBytes(ImSpanAllocator* self) { return default; }
    public static unsafe System.IntPtr ImSpanAllocator_GetSpanPtrBegin(ImSpanAllocator* self, int n) { return default; }
    public static unsafe System.IntPtr ImSpanAllocator_GetSpanPtrEnd(ImSpanAllocator* self, int n) { return default; }
    public static unsafe ImSpanAllocator* ImSpanAllocator_ImSpanAllocator() { return default; }
    public static unsafe void ImSpanAllocator_Reserve(ImSpanAllocator* self, int n, uint sz, int a) { }
    public static unsafe void ImSpanAllocator_SetArenaBasePtr(ImSpanAllocator* self, System.IntPtr base_ptr) { }
    public static unsafe void ImSpanAllocator_destroy(ImSpanAllocator* self) { }
    public static unsafe ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags) { return default; }
    public static void igActivateItem(uint id) { }
    public static uint igAddContextHook(System.IntPtr context, System.IntPtr hook) { return default; }
    public static unsafe void igAddSettingsHandler(ImGuiSettingsHandler* handler) { }
    public static void igAlignTextToFramePadding() { }
    public static unsafe byte igArrowButton(byte* str_id, ImGuiDir dir) { return default; }
    public static unsafe byte igArrowButtonEx(byte* str_id, ImGuiDir dir, UnityEngine.Vector2 size_arg, ImGuiButtonFlags flags) { return default; }
    public static unsafe byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags) { return default; }
    public static unsafe byte igBeginChild_Str(byte* str_id, UnityEngine.Vector2 size, byte border, ImGuiWindowFlags flags) { return default; }
    public static byte igBeginChild_ID(uint id, UnityEngine.Vector2 size, byte border, ImGuiWindowFlags flags) { return default; }
    public static unsafe byte igBeginChildEx(byte* name, uint id, UnityEngine.Vector2 size_arg, byte border, ImGuiWindowFlags flags) { return default; }
    public static byte igBeginChildFrame(uint id, UnityEngine.Vector2 size, ImGuiWindowFlags flags) { return default; }
    public static unsafe void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags) { }
    public static unsafe byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags) { return default; }
    public static byte igBeginComboPopup(uint popup_id, UnityEngine.Rect bb, ImGuiComboFlags flags) { return default; }
    public static byte igBeginComboPreview() { return default; }
    public static void igBeginDisabled(byte disabled) { }
    public static byte igBeginDragDropSource(ImGuiDragDropFlags flags) { return default; }
    public static byte igBeginDragDropTarget() { return default; }
    public static byte igBeginDragDropTargetCustom(UnityEngine.Rect bb, uint id) { return default; }
    public static void igBeginGroup() { }
    public static unsafe byte igBeginListBox(byte* label, UnityEngine.Vector2 size) { return default; }
    public static byte igBeginMainMenuBar() { return default; }
    public static unsafe byte igBeginMenu(byte* label, byte enabled) { return default; }
    public static byte igBeginMenuBar() { return default; }
    public static unsafe byte igBeginMenuEx(byte* label, byte* icon, byte enabled) { return default; }
    public static unsafe byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags) { return default; }
    public static unsafe byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags) { return default; }
    public static unsafe byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags) { return default; }
    public static unsafe byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags) { return default; }
    public static byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_flags) { return default; }
    public static unsafe byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags) { return default; }
    public static unsafe byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags) { return default; }
    public static unsafe byte igBeginTabBarEx(ImGuiTabBar* tab_bar, UnityEngine.Rect bb, ImGuiTabBarFlags flags) { return default; }
    public static unsafe byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags) { return default; }
    public static unsafe byte igBeginTable(byte* str_id, int column, ImGuiTableFlags flags, UnityEngine.Vector2 outer_size, float inner_width) { return default; }
    public static unsafe byte igBeginTableEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, UnityEngine.Vector2 outer_size, float inner_width) { return default; }
    public static void igBeginTooltip() { }
    public static void igBeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags) { }
    public static unsafe byte igBeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags) { return default; }
    public static unsafe void igBringWindowToDisplayBack(ImGuiWindow* window) { }
    public static unsafe void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window) { }
    public static unsafe void igBringWindowToDisplayFront(ImGuiWindow* window) { }
    public static unsafe void igBringWindowToFocusFront(ImGuiWindow* window) { }
    public static void igBullet() { }
    public static unsafe void igBulletText(byte* fmt) { }
    public static unsafe void igBulletTextV(byte* fmt) { }
    public static unsafe byte igButton(byte* label, UnityEngine.Vector2 size) { return default; }
    public static unsafe byte igButtonBehavior(UnityEngine.Rect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags) { return default; }
    public static unsafe byte igButtonEx(byte* label, UnityEngine.Vector2 size_arg, ImGuiButtonFlags flags) { return default; }
    public static unsafe void igCalcItemSize(UnityEngine.Vector2* pOut, UnityEngine.Vector2 size, float default_w, float default_h) { }
    public static float igCalcItemWidth() { return default; }
    public static unsafe void igCalcTextSize(UnityEngine.Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width) { }
    public static int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate) { return default; }
    public static unsafe void igCalcWindowNextAutoFitSize(UnityEngine.Vector2* pOut, ImGuiWindow* window) { }
    public static float igCalcWrapWidthForPos(UnityEngine.Vector2 pos, float wrap_pos_x) { return default; }
    public static void igCallContextHooks(System.IntPtr context, System.IntPtr type) { }
    public static unsafe byte igCheckbox(byte* label, byte* v) { return default; }
    public static unsafe byte igCheckboxFlags_IntPtr(byte* label, System.Int32* flags, int flags_value) { return default; }
    public static unsafe byte igCheckboxFlags_UintPtr(byte* label, System.UInt32* flags, uint flags_value) { return default; }
    public static unsafe byte igCheckboxFlags_S64Ptr(byte* label, System.Int64* flags, long flags_value) { return default; }
    public static unsafe byte igCheckboxFlags_U64Ptr(byte* label, System.UInt64* flags, ulong flags_value) { return default; }
    public static void igClearActiveID() { }
    public static void igClearDragDrop() { }
    public static void igClearIniSettings() { }
    public static byte igCloseButton(uint id, UnityEngine.Vector2 pos) { return default; }
    public static void igCloseCurrentPopup() { }
    public static void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup) { }
    public static void igClosePopupsExceptModals() { }
    public static unsafe void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup) { }
    public static byte igCollapseButton(uint id, UnityEngine.Vector2 pos) { return default; }
    public static unsafe byte igCollapsingHeader_TreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags) { return default; }
    public static unsafe byte igCollapsingHeader_BoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags) { return default; }
    public static unsafe byte igColorButton(byte* desc_id, UnityEngine.Vector4 col, ImGuiColorEditFlags flags, UnityEngine.Vector2 size) { return default; }
    public static uint igColorConvertFloat4ToU32(UnityEngine.Vector4 @in) { return default; }
    public static unsafe void igColorConvertHSVtoRGB(float h, float s, float v, System.Single* out_r, System.Single* out_g, System.Single* out_b) { }
    public static unsafe void igColorConvertRGBtoHSV(float r, float g, float b, System.Single* out_h, System.Single* out_s, System.Single* out_v) { }
    public static unsafe void igColorConvertU32ToFloat4(UnityEngine.Vector4* pOut, uint @in) { }
    public static unsafe byte igColorEdit3(byte* label, UnityEngine.Vector3* col, ImGuiColorEditFlags flags) { return default; }
    public static unsafe byte igColorEdit4(byte* label, UnityEngine.Vector4* col, ImGuiColorEditFlags flags) { return default; }
    public static unsafe void igColorEditOptionsPopup(System.Single* col, ImGuiColorEditFlags flags) { }
    public static unsafe byte igColorPicker3(byte* label, UnityEngine.Vector3* col, ImGuiColorEditFlags flags) { return default; }
    public static unsafe byte igColorPicker4(byte* label, UnityEngine.Vector4* col, ImGuiColorEditFlags flags, System.Single* ref_col) { return default; }
    public static unsafe void igColorPickerOptionsPopup(System.Single* ref_col, ImGuiColorEditFlags flags) { }
    public static unsafe void igColorTooltip(byte* text, System.Single* col, ImGuiColorEditFlags flags) { }
    public static unsafe void igColumns(int count, byte* id, byte border) { }
    public static unsafe byte igCombo_Str_arr(byte* label, System.Int32* current_item, System.Byte** items, int items_count, int popup_max_height_in_items) { return default; }
    public static unsafe byte igCombo_Str(byte* label, System.Int32* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items) { return default; }
    public static unsafe byte igCombo_FnBoolPtr(byte* label, System.Int32* current_item, System.IntPtr items_getter, System.IntPtr data, int items_count, int popup_max_height_in_items) { return default; }
    public static unsafe System.IntPtr igCreateContext(ImFontAtlas* shared_font_atlas) { return default; }
    public static unsafe System.IntPtr igCreateNewWindowSettings(byte* name) { return default; }
    public static unsafe byte igDataTypeApplyFromText(byte* buf, ImGuiDataType data_type, System.IntPtr p_data, byte* format) { return default; }
    public static void igDataTypeApplyOp(ImGuiDataType data_type, int op, System.IntPtr output, System.IntPtr arg_1, System.IntPtr arg_2) { }
    public static byte igDataTypeClamp(ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max) { return default; }
    public static int igDataTypeCompare(ImGuiDataType data_type, System.IntPtr arg_1, System.IntPtr arg_2) { return default; }
    public static unsafe int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, System.IntPtr p_data, byte* format) { return default; }
    public static unsafe ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type) { return default; }
    public static unsafe byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx) { return default; }
    public static void igDebugDrawItemRect(uint col) { }
    public static void igDebugHookIdInfo(uint id, ImGuiDataType data_type, System.IntPtr data_id, System.IntPtr data_id_end) { }
    public static unsafe void igDebugLog(byte* fmt) { }
    public static unsafe void igDebugLogV(byte* fmt) { }
    public static unsafe void igDebugNodeColumns(ImGuiOldColumns* columns) { }
    public static unsafe void igDebugNodeDrawList(ImGuiWindow* window, ImDrawList* draw_list, byte* label) { }
    public static unsafe void igDebugNodeFont(ImFont* font) { }
    public static unsafe void igDebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph) { }
    public static void igDebugNodeInputTextState(System.IntPtr state) { }
    public static unsafe void igDebugNodeStorage(ImGuiStorage* storage, byte* label) { }
    public static unsafe void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label) { }
    public static unsafe void igDebugNodeTable(ImGuiTable* table) { }
    public static unsafe void igDebugNodeTableSettings(ImGuiTableSettings* settings) { }
    public static unsafe void igDebugNodeViewport(ImGuiViewportP* viewport) { }
    public static unsafe void igDebugNodeWindow(ImGuiWindow* window, byte* label) { }
    public static void igDebugNodeWindowSettings(System.IntPtr settings) { }
    public static unsafe void igDebugNodeWindowsList(ImVector windows, byte* label) { }
    public static unsafe void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack) { }
    public static unsafe void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, UnityEngine.Rect bb) { }
    public static void igDebugStartItemPicker() { }
    public static unsafe void igDebugTextEncoding(byte* text) { }
    public static void igDestroyContext(System.IntPtr ctx) { }
    public static unsafe byte igDragBehavior(uint id, ImGuiDataType data_type, System.IntPtr p_v, float v_speed, System.IntPtr p_min, System.IntPtr p_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragFloat(byte* label, System.Single* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragFloat2(byte* label, UnityEngine.Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragFloat3(byte* label, UnityEngine.Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragFloat4(byte* label, UnityEngine.Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragFloatRange2(byte* label, System.Single* v_current_min, System.Single* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragInt(byte* label, System.Int32* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragInt2(byte* label, System.Int32* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragInt3(byte* label, System.Int32* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragInt4(byte* label, System.Int32* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragIntRange2(byte* label, System.Int32* v_current_min, System.Int32* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragScalar(byte* label, ImGuiDataType data_type, System.IntPtr p_data, float v_speed, System.IntPtr p_min, System.IntPtr p_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igDragScalarN(byte* label, ImGuiDataType data_type, System.IntPtr p_data, int components, float v_speed, System.IntPtr p_min, System.IntPtr p_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static void igDummy(UnityEngine.Vector2 size) { }
    public static void igEnd() { }
    public static void igEndChild() { }
    public static void igEndChildFrame() { }
    public static void igEndColumns() { }
    public static void igEndCombo() { }
    public static void igEndComboPreview() { }
    public static void igEndDisabled() { }
    public static void igEndDragDropSource() { }
    public static void igEndDragDropTarget() { }
    public static void igEndFrame() { }
    public static void igEndGroup() { }
    public static void igEndListBox() { }
    public static void igEndMainMenuBar() { }
    public static void igEndMenu() { }
    public static void igEndMenuBar() { }
    public static void igEndPopup() { }
    public static void igEndTabBar() { }
    public static void igEndTabItem() { }
    public static void igEndTable() { }
    public static void igEndTooltip() { }
    public static unsafe void igFindBestWindowPosForPopup(UnityEngine.Vector2* pOut, ImGuiWindow* window) { }
    public static unsafe void igFindBestWindowPosForPopupEx(UnityEngine.Vector2* pOut, UnityEngine.Vector2 ref_pos, UnityEngine.Vector2 size, ImGuiDir* last_dir, UnityEngine.Rect r_outer, UnityEngine.Rect r_avoid, ImGuiPopupPositionPolicy policy) { }
    public static unsafe ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window) { return default; }
    public static unsafe ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id) { return default; }
    public static unsafe System.IntPtr igFindOrCreateWindowSettings(byte* name) { return default; }
    public static unsafe byte* igFindRenderedTextEnd(byte* text, byte* text_end) { return default; }
    public static unsafe ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name) { return default; }
    public static unsafe ImGuiWindow* igFindWindowByID(uint id) { return default; }
    public static unsafe ImGuiWindow* igFindWindowByName(byte* name) { return default; }
    public static unsafe int igFindWindowDisplayIndex(ImGuiWindow* window) { return default; }
    public static System.IntPtr igFindWindowSettings(uint id) { return default; }
    public static unsafe void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window) { }
    public static unsafe void igFocusWindow(ImGuiWindow* window) { }
    public static unsafe void igGcAwakeTransientWindowBuffers(ImGuiWindow* window) { }
    public static void igGcCompactTransientMiscBuffers() { }
    public static unsafe void igGcCompactTransientWindowBuffers(ImGuiWindow* window) { }
    public static uint igGetActiveID() { return default; }
    public static unsafe ImDrawList* igGetBackgroundDrawList_Nil() { return default; }
    public static unsafe ImDrawList* igGetBackgroundDrawList_ViewportPtr(ImGuiViewport* viewport) { return default; }
    public static unsafe byte* igGetClipboardText() { return default; }
    public static uint igGetColorU32_Col(ImGuiCol idx, float alpha_mul) { return default; }
    public static uint igGetColorU32_Vec4(UnityEngine.Vector4 col) { return default; }
    public static uint igGetColorU32_U32(uint col) { return default; }
    public static int igGetColumnIndex() { return default; }
    public static unsafe float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset) { return default; }
    public static float igGetColumnOffset(int column_index) { return default; }
    public static unsafe float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm) { return default; }
    public static float igGetColumnWidth(int column_index) { return default; }
    public static int igGetColumnsCount() { return default; }
    public static unsafe uint igGetColumnsID(byte* str_id, int count) { return default; }
    public static unsafe void igGetContentRegionAvail(UnityEngine.Vector2* pOut) { }
    public static unsafe void igGetContentRegionMax(UnityEngine.Vector2* pOut) { }
    public static unsafe void igGetContentRegionMaxAbs(UnityEngine.Vector2* pOut) { }
    public static System.IntPtr igGetCurrentContext() { return default; }
    public static unsafe ImGuiTable* igGetCurrentTable() { return default; }
    public static unsafe ImGuiWindow* igGetCurrentWindow() { return default; }
    public static unsafe ImGuiWindow* igGetCurrentWindowRead() { return default; }
    public static unsafe void igGetCursorPos(UnityEngine.Vector2* pOut) { }
    public static float igGetCursorPosX() { return default; }
    public static float igGetCursorPosY() { return default; }
    public static unsafe void igGetCursorScreenPos(UnityEngine.Vector2* pOut) { }
    public static unsafe void igGetCursorStartPos(UnityEngine.Vector2* pOut) { }
    public static unsafe ImFont* igGetDefaultFont() { return default; }
    public static unsafe ImGuiPayload* igGetDragDropPayload() { return default; }
    public static unsafe ImDrawData* igGetDrawData() { return default; }
    public static unsafe ImDrawListSharedData* igGetDrawListSharedData() { return default; }
    public static uint igGetFocusID() { return default; }
    public static uint igGetFocusScope() { return default; }
    public static uint igGetFocusedFocusScope() { return default; }
    public static unsafe ImFont* igGetFont() { return default; }
    public static float igGetFontSize() { return default; }
    public static unsafe void igGetFontTexUvWhitePixel(UnityEngine.Vector2* pOut) { }
    public static unsafe ImDrawList* igGetForegroundDrawList_Nil() { return default; }
    public static unsafe ImDrawList* igGetForegroundDrawList_WindowPtr(ImGuiWindow* window) { return default; }
    public static unsafe ImDrawList* igGetForegroundDrawList_ViewportPtr(ImGuiViewport* viewport) { return default; }
    public static int igGetFrameCount() { return default; }
    public static float igGetFrameHeight() { return default; }
    public static float igGetFrameHeightWithSpacing() { return default; }
    public static uint igGetHoveredID() { return default; }
    public static unsafe uint igGetID_Str(byte* str_id) { return default; }
    public static unsafe uint igGetID_StrStr(byte* str_id_begin, byte* str_id_end) { return default; }
    public static uint igGetID_Ptr(System.IntPtr ptr_id) { return default; }
    public static unsafe uint igGetIDWithSeed(byte* str_id_begin, byte* str_id_end, uint seed) { return default; }
    public static unsafe ImGuiIO* igGetIO() { return default; }
    public static System.IntPtr igGetInputTextState(uint id) { return default; }
    public static ImGuiItemFlags igGetItemFlags() { return default; }
    public static uint igGetItemID() { return default; }
    public static unsafe void igGetItemRectMax(UnityEngine.Vector2* pOut) { }
    public static unsafe void igGetItemRectMin(UnityEngine.Vector2* pOut) { }
    public static unsafe void igGetItemRectSize(UnityEngine.Vector2* pOut) { }
    public static ImGuiItemStatusFlags igGetItemStatusFlags() { return default; }
    public static unsafe ImGuiKeyData* igGetKeyData(ImGuiKey key) { return default; }
    public static int igGetKeyIndex(ImGuiKey key) { return default; }
    public static unsafe byte* igGetKeyName(ImGuiKey key) { return default; }
    public static int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate) { return default; }
    public static unsafe ImGuiViewport* igGetMainViewport() { return default; }
    public static ImGuiModFlags igGetMergedModFlags() { return default; }
    public static int igGetMouseClickedCount(ImGuiMouseButton button) { return default; }
    public static ImGuiMouseCursor igGetMouseCursor() { return default; }
    public static unsafe void igGetMouseDragDelta(UnityEngine.Vector2* pOut, ImGuiMouseButton button, float lock_threshold) { }
    public static unsafe void igGetMousePos(UnityEngine.Vector2* pOut) { }
    public static unsafe void igGetMousePosOnOpeningCurrentPopup(UnityEngine.Vector2* pOut) { }
    public static float igGetNavInputAmount(ImGuiNavInput n, ImGuiNavReadMode mode) { return default; }
    public static unsafe void igGetNavInputAmount2d(UnityEngine.Vector2* pOut, ImGuiNavDirSourceFlags dir_sources, ImGuiNavReadMode mode, float slow_factor, float fast_factor) { }
    public static unsafe byte* igGetNavInputName(ImGuiNavInput n) { return default; }
    public static unsafe void igGetPopupAllowedExtentRect(UnityEngine.Rect* pOut, ImGuiWindow* window) { }
    public static float igGetScrollMaxX() { return default; }
    public static float igGetScrollMaxY() { return default; }
    public static float igGetScrollX() { return default; }
    public static float igGetScrollY() { return default; }
    public static unsafe ImGuiStorage* igGetStateStorage() { return default; }
    public static unsafe ImGuiStyle* igGetStyle() { return default; }
    public static unsafe byte* igGetStyleColorName(ImGuiCol idx) { return default; }
    public static unsafe UnityEngine.Vector4* igGetStyleColorVec4(ImGuiCol idx) { return default; }
    public static float igGetTextLineHeight() { return default; }
    public static float igGetTextLineHeightWithSpacing() { return default; }
    public static double igGetTime() { return default; }
    public static unsafe ImGuiWindow* igGetTopMostAndVisiblePopupModal() { return default; }
    public static unsafe ImGuiWindow* igGetTopMostPopupModal() { return default; }
    public static float igGetTreeNodeToLabelSpacing() { return default; }
    public static unsafe byte* igGetVersion() { return default; }
    public static unsafe void igGetWindowContentRegionMax(UnityEngine.Vector2* pOut) { }
    public static unsafe void igGetWindowContentRegionMin(UnityEngine.Vector2* pOut) { }
    public static unsafe ImDrawList* igGetWindowDrawList() { return default; }
    public static float igGetWindowHeight() { return default; }
    public static unsafe void igGetWindowPos(UnityEngine.Vector2* pOut) { }
    public static unsafe uint igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir) { return default; }
    public static unsafe uint igGetWindowResizeCornerID(ImGuiWindow* window, int n) { return default; }
    public static unsafe uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis) { return default; }
    public static unsafe void igGetWindowScrollbarRect(UnityEngine.Rect* pOut, ImGuiWindow* window, ImGuiAxis axis) { }
    public static unsafe void igGetWindowSize(UnityEngine.Vector2* pOut) { }
    public static float igGetWindowWidth() { return default; }
    public static int igImAbs_Int(int x) { return default; }
    public static float igImAbs_Float(float x) { return default; }
    public static double igImAbs_double(double x) { return default; }
    public static uint igImAlphaBlendColors(uint col_a, uint col_b) { return default; }
    public static unsafe void igImBezierCubicCalc(UnityEngine.Vector2* pOut, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, float t) { }
    public static unsafe void igImBezierCubicClosestPoint(UnityEngine.Vector2* pOut, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 p, int num_segments) { }
    public static unsafe void igImBezierCubicClosestPointCasteljau(UnityEngine.Vector2* pOut, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4, UnityEngine.Vector2 p, float tess_tol) { }
    public static unsafe void igImBezierQuadraticCalc(UnityEngine.Vector2* pOut, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, float t) { }
    public static unsafe void igImBitArrayClearBit(System.UInt32* arr, int n) { }
    public static unsafe void igImBitArraySetBit(System.UInt32* arr, int n) { }
    public static unsafe void igImBitArraySetBitRange(System.UInt32* arr, int n, int n2) { }
    public static unsafe byte igImBitArrayTestBit(System.UInt32* arr, int n) { return default; }
    public static byte igImCharIsBlankA(byte c) { return default; }
    public static byte igImCharIsBlankW(uint c) { return default; }
    public static unsafe void igImClamp(UnityEngine.Vector2* pOut, UnityEngine.Vector2 v, UnityEngine.Vector2 mn, UnityEngine.Vector2 mx) { }
    public static float igImDot(UnityEngine.Vector2 a, UnityEngine.Vector2 b) { return default; }
    public static unsafe System.IntPtr igImFileLoadToMemory(byte* filename, byte* mode, System.UInt32* out_file_size, int padding_bytes) { return default; }
    public static float igImFloor_Float(float f) { return default; }
    public static unsafe void igImFloor_Vec2(UnityEngine.Vector2* pOut, UnityEngine.Vector2 v) { }
    public static float igImFloorSigned_Float(float f) { return default; }
    public static unsafe void igImFloorSigned_Vec2(UnityEngine.Vector2* pOut, UnityEngine.Vector2 v) { }
    public static unsafe void igImFontAtlasBuildFinish(ImFontAtlas* atlas) { }
    public static unsafe void igImFontAtlasBuildInit(ImFontAtlas* atlas) { }
    public static unsafe void igImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor) { }
    public static unsafe void igImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride) { }
    public static unsafe void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, System.IntPtr stbrp_context_opaque) { }
    public static unsafe void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value) { }
    public static unsafe void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value) { }
    public static unsafe void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent) { }
    public static unsafe ImFontBuilderIO* igImFontAtlasGetBuilderForStbTruetype() { return default; }
    public static unsafe int igImFormatString(byte* buf, uint buf_size, byte* fmt) { return default; }
    public static unsafe void igImFormatStringToTempBuffer(System.Byte** out_buf, System.Byte** out_buf_end, byte* fmt) { }
    public static unsafe void igImFormatStringToTempBufferV(System.Byte** out_buf, System.Byte** out_buf_end, byte* fmt) { }
    public static unsafe int igImFormatStringV(byte* buf, uint buf_size, byte* fmt) { return default; }
    public static ImGuiDir igImGetDirQuadrantFromDelta(float dx, float dy) { return default; }
    public static uint igImHashData(System.IntPtr data, uint data_size, uint seed) { return default; }
    public static unsafe uint igImHashStr(byte* data, uint data_size, uint seed) { return default; }
    public static float igImInvLength(UnityEngine.Vector2 lhs, float fail_value) { return default; }
    public static byte igImIsFloatAboveGuaranteedIntegerPrecision(float f) { return default; }
    public static byte igImIsPowerOfTwo_Int(int v) { return default; }
    public static byte igImIsPowerOfTwo_U64(ulong v) { return default; }
    public static float igImLengthSqr_Vec2(UnityEngine.Vector2 lhs) { return default; }
    public static float igImLengthSqr_Vec4(UnityEngine.Vector4 lhs) { return default; }
    public static unsafe void igImLerp_Vec2Float(UnityEngine.Vector2* pOut, UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t) { }
    public static unsafe void igImLerp_Vec2Vec2(UnityEngine.Vector2* pOut, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 t) { }
    public static unsafe void igImLerp_Vec4(UnityEngine.Vector4* pOut, UnityEngine.Vector4 a, UnityEngine.Vector4 b, float t) { }
    public static unsafe void igImLineClosestPoint(UnityEngine.Vector2* pOut, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p) { }
    public static float igImLinearSweep(float current, float target, float speed) { return default; }
    public static float igImLog_Float(float x) { return default; }
    public static double igImLog_double(double x) { return default; }
    public static unsafe void igImMax(UnityEngine.Vector2* pOut, UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
    public static unsafe void igImMin(UnityEngine.Vector2* pOut, UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
    public static int igImModPositive(int a, int b) { return default; }
    public static unsafe void igImMul(UnityEngine.Vector2* pOut, UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs) { }
    public static unsafe byte* igImParseFormatFindEnd(byte* format) { return default; }
    public static unsafe byte* igImParseFormatFindStart(byte* format) { return default; }
    public static unsafe int igImParseFormatPrecision(byte* format, int default_value) { return default; }
    public static unsafe void igImParseFormatSanitizeForPrinting(byte* fmt_in, byte* fmt_out, uint fmt_out_size) { }
    public static unsafe byte* igImParseFormatSanitizeForScanning(byte* fmt_in, byte* fmt_out, uint fmt_out_size) { return default; }
    public static unsafe byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size) { return default; }
    public static float igImPow_Float(float x, float y) { return default; }
    public static double igImPow_double(double x, double y) { return default; }
    public static void igImQsort(System.IntPtr @base, uint count, uint size_of_element, System.IntPtr compare_func) { }
    public static unsafe void igImRotate(UnityEngine.Vector2* pOut, UnityEngine.Vector2 v, float cos_a, float sin_a) { }
    public static float igImRsqrt_Float(float x) { return default; }
    public static double igImRsqrt_double(double x) { return default; }
    public static float igImSaturate(float f) { return default; }
    public static float igImSign_Float(float x) { return default; }
    public static double igImSign_double(double x) { return default; }
    public static unsafe byte* igImStrSkipBlank(byte* str) { return default; }
    public static unsafe void igImStrTrimBlanks(byte* str) { }
    public static unsafe ushort* igImStrbolW(ushort* buf_mid_line, ushort* buf_begin) { return default; }
    public static unsafe byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c) { return default; }
    public static unsafe byte* igImStrdup(byte* str) { return default; }
    public static unsafe byte* igImStrdupcpy(byte* dst, System.UInt32* p_dst_size, byte* str) { return default; }
    public static unsafe byte* igImStreolRange(byte* str, byte* str_end) { return default; }
    public static unsafe int igImStricmp(byte* str1, byte* str2) { return default; }
    public static unsafe byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end) { return default; }
    public static unsafe int igImStrlenW(ushort* str) { return default; }
    public static unsafe void igImStrncpy(byte* dst, byte* src, uint count) { }
    public static unsafe int igImStrnicmp(byte* str1, byte* str2, uint count) { return default; }
    public static unsafe int igImTextCharFromUtf8(System.UInt32* out_char, byte* in_text, byte* in_text_end) { return default; }
    public static unsafe byte* igImTextCharToUtf8(byte* out_buf, uint c) { return default; }
    public static unsafe int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end) { return default; }
    public static unsafe int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end) { return default; }
    public static unsafe int igImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end) { return default; }
    public static unsafe int igImTextStrFromUtf8(ushort* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, System.Byte** in_remaining) { return default; }
    public static unsafe int igImTextStrToUtf8(byte* out_buf, int out_buf_size, ushort* in_text, ushort* in_text_end) { return default; }
    public static float igImTriangleArea(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c) { return default; }
    public static unsafe void igImTriangleBarycentricCoords(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 p, System.Single* out_u, System.Single* out_v, System.Single* out_w) { }
    public static unsafe void igImTriangleClosestPoint(UnityEngine.Vector2* pOut, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 p) { }
    public static byte igImTriangleContainsPoint(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 p) { return default; }
    public static int igImUpperPowerOfTwo(int v) { return default; }
    public static void igImage(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector4 tint_col, UnityEngine.Vector4 border_col) { }
    public static byte igImageButton(System.IntPtr user_texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, int frame_padding, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static byte igImageButtonEx(uint id, System.IntPtr texture_id, UnityEngine.Vector2 size, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector2 padding, UnityEngine.Vector4 bg_col, UnityEngine.Vector4 tint_col) { return default; }
    public static void igIndent(float indent_w) { }
    public static void igInitialize() { }
    public static unsafe byte igInputDouble(byte* label, System.Double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputFloat(byte* label, System.Single* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputFloat2(byte* label, UnityEngine.Vector2* v, byte* format, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputFloat3(byte* label, UnityEngine.Vector3* v, byte* format, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputFloat4(byte* label, UnityEngine.Vector4* v, byte* format, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputInt(byte* label, System.Int32* v, int step, int step_fast, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputInt2(byte* label, System.Int32* v, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputInt3(byte* label, System.Int32* v, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputInt4(byte* label, System.Int32* v, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputScalar(byte* label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_step, System.IntPtr p_step_fast, byte* format, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputScalarN(byte* label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_step, System.IntPtr p_step_fast, byte* format, ImGuiInputTextFlags flags) { return default; }
    public static unsafe byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static unsafe byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, UnityEngine.Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static unsafe byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, UnityEngine.Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static unsafe byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, System.IntPtr user_data) { return default; }
    public static unsafe byte igInvisibleButton(byte* str_id, UnityEngine.Vector2 size, ImGuiButtonFlags flags) { return default; }
    public static byte igIsActiveIdUsingKey(ImGuiKey key) { return default; }
    public static byte igIsActiveIdUsingNavDir(ImGuiDir dir) { return default; }
    public static byte igIsActiveIdUsingNavInput(ImGuiNavInput input) { return default; }
    public static byte igIsAnyItemActive() { return default; }
    public static byte igIsAnyItemFocused() { return default; }
    public static byte igIsAnyItemHovered() { return default; }
    public static byte igIsAnyMouseDown() { return default; }
    public static byte igIsClippedEx(UnityEngine.Rect bb, uint id) { return default; }
    public static byte igIsDragDropActive() { return default; }
    public static byte igIsDragDropPayloadBeingAccepted() { return default; }
    public static byte igIsGamepadKey(ImGuiKey key) { return default; }
    public static byte igIsItemActivated() { return default; }
    public static byte igIsItemActive() { return default; }
    public static byte igIsItemClicked(ImGuiMouseButton mouse_button) { return default; }
    public static byte igIsItemDeactivated() { return default; }
    public static byte igIsItemDeactivatedAfterEdit() { return default; }
    public static byte igIsItemEdited() { return default; }
    public static byte igIsItemFocused() { return default; }
    public static byte igIsItemHovered(ImGuiHoveredFlags flags) { return default; }
    public static byte igIsItemToggledOpen() { return default; }
    public static byte igIsItemToggledSelection() { return default; }
    public static byte igIsItemVisible() { return default; }
    public static byte igIsKeyDown(ImGuiKey key) { return default; }
    public static byte igIsKeyPressed(ImGuiKey key, byte repeat) { return default; }
    public static byte igIsKeyPressedMap(ImGuiKey key, byte repeat) { return default; }
    public static byte igIsKeyReleased(ImGuiKey key) { return default; }
    public static byte igIsLegacyKey(ImGuiKey key) { return default; }
    public static byte igIsMouseClicked(ImGuiMouseButton button, byte repeat) { return default; }
    public static byte igIsMouseDoubleClicked(ImGuiMouseButton button) { return default; }
    public static byte igIsMouseDown(ImGuiMouseButton button) { return default; }
    public static byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold) { return default; }
    public static byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold) { return default; }
    public static byte igIsMouseHoveringRect(UnityEngine.Vector2 r_min, UnityEngine.Vector2 r_max, byte clip) { return default; }
    public static unsafe byte igIsMousePosValid(UnityEngine.Vector2* mouse_pos) { return default; }
    public static byte igIsMouseReleased(ImGuiMouseButton button) { return default; }
    public static byte igIsNamedKey(ImGuiKey key) { return default; }
    public static byte igIsNavInputDown(ImGuiNavInput n) { return default; }
    public static byte igIsNavInputTest(ImGuiNavInput n, ImGuiNavReadMode rm) { return default; }
    public static unsafe byte igIsPopupOpen_Str(byte* str_id, ImGuiPopupFlags flags) { return default; }
    public static byte igIsPopupOpen_ID(uint id, ImGuiPopupFlags popup_flags) { return default; }
    public static byte igIsRectVisible_Nil(UnityEngine.Vector2 size) { return default; }
    public static byte igIsRectVisible_Vec2(UnityEngine.Vector2 rect_min, UnityEngine.Vector2 rect_max) { return default; }
    public static unsafe byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below) { return default; }
    public static byte igIsWindowAppearing() { return default; }
    public static unsafe byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy) { return default; }
    public static byte igIsWindowCollapsed() { return default; }
    public static byte igIsWindowFocused(ImGuiFocusedFlags flags) { return default; }
    public static byte igIsWindowHovered(ImGuiHoveredFlags flags) { return default; }
    public static unsafe byte igIsWindowNavFocusable(ImGuiWindow* window) { return default; }
    public static unsafe byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent) { return default; }
    public static unsafe byte igItemAdd(UnityEngine.Rect bb, uint id, UnityEngine.Rect* nav_bb, ImGuiItemFlags extra_flags) { return default; }
    public static byte igItemHoverable(UnityEngine.Rect bb, uint id) { return default; }
    public static void igItemSize_Vec2(UnityEngine.Vector2 size, float text_baseline_y) { }
    public static void igItemSize_Rect(UnityEngine.Rect bb, float text_baseline_y) { }
    public static void igKeepAliveID(uint id) { }
    public static unsafe void igLabelText(byte* label, byte* fmt) { }
    public static unsafe void igLabelTextV(byte* label, byte* fmt) { }
    public static unsafe byte igListBox_Str_arr(byte* label, System.Int32* current_item, System.Byte** items, int items_count, int height_in_items) { return default; }
    public static unsafe byte igListBox_FnBoolPtr(byte* label, System.Int32* current_item, System.IntPtr items_getter, System.IntPtr data, int items_count, int height_in_items) { return default; }
    public static unsafe void igLoadIniSettingsFromDisk(byte* ini_filename) { }
    public static unsafe void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size) { }
    public static void igLogBegin(ImGuiLogType type, int auto_open_depth) { }
    public static void igLogButtons() { }
    public static void igLogFinish() { }
    public static unsafe void igLogRenderedText(UnityEngine.Vector2* ref_pos, byte* text, byte* text_end) { }
    public static unsafe void igLogSetNextTextDecoration(byte* prefix, byte* suffix) { }
    public static unsafe void igLogText(byte* fmt) { }
    public static unsafe void igLogTextV(byte* fmt) { }
    public static void igLogToBuffer(int auto_open_depth) { }
    public static void igLogToClipboard(int auto_open_depth) { }
    public static unsafe void igLogToFile(int auto_open_depth, byte* filename) { }
    public static void igLogToTTY(int auto_open_depth) { }
    public static void igMarkIniSettingsDirty_Nil() { }
    public static unsafe void igMarkIniSettingsDirty_WindowPtr(ImGuiWindow* window) { }
    public static void igMarkItemEdited(uint id) { }
    public static System.IntPtr igMemAlloc(uint size) { return default; }
    public static void igMemFree(System.IntPtr ptr) { }
    public static unsafe byte igMenuItem_Bool(byte* label, byte* shortcut, byte selected, byte enabled) { return default; }
    public static unsafe byte igMenuItem_BoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled) { return default; }
    public static unsafe byte igMenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled) { return default; }
    public static void igNavInitRequestApplyResult() { }
    public static unsafe void igNavInitWindow(ImGuiWindow* window, byte force_reinit) { }
    public static void igNavMoveRequestApplyResult() { }
    public static byte igNavMoveRequestButNoResultYet() { return default; }
    public static void igNavMoveRequestCancel() { }
    public static void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags) { }
    public static void igNavMoveRequestResolveWithLastItem(System.IntPtr result) { }
    public static void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags) { }
    public static unsafe void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags) { }
    public static void igNewFrame() { }
    public static void igNewLine() { }
    public static void igNextColumn() { }
    public static unsafe void igOpenPopup_Str(byte* str_id, ImGuiPopupFlags popup_flags) { }
    public static void igOpenPopup_ID(uint id, ImGuiPopupFlags popup_flags) { }
    public static void igOpenPopupEx(uint id, ImGuiPopupFlags popup_flags) { }
    public static unsafe void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags) { }
    public static unsafe int igPlotEx(ImGuiPlotType plot_type, byte* label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 frame_size) { return default; }
    public static unsafe void igPlotHistogram_FloatPtr(byte* label, System.Single* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static unsafe void igPlotHistogram_FnFloatPtr(byte* label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static unsafe void igPlotLines_FloatPtr(byte* label, System.Single* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size, int stride) { }
    public static unsafe void igPlotLines_FnFloatPtr(byte* label, System.IntPtr values_getter, System.IntPtr data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, UnityEngine.Vector2 graph_size) { }
    public static void igPopAllowKeyboardFocus() { }
    public static void igPopButtonRepeat() { }
    public static void igPopClipRect() { }
    public static void igPopColumnsBackground() { }
    public static void igPopFocusScope() { }
    public static void igPopFont() { }
    public static void igPopID() { }
    public static void igPopItemFlag() { }
    public static void igPopItemWidth() { }
    public static void igPopStyleColor(int count) { }
    public static void igPopStyleVar(int count) { }
    public static void igPopTextWrapPos() { }
    public static unsafe void igProgressBar(float fraction, UnityEngine.Vector2 size_arg, byte* overlay) { }
    public static void igPushAllowKeyboardFocus(byte allow_keyboard_focus) { }
    public static void igPushButtonRepeat(byte repeat) { }
    public static void igPushClipRect(UnityEngine.Vector2 clip_rect_min, UnityEngine.Vector2 clip_rect_max, byte intersect_with_current_clip_rect) { }
    public static void igPushColumnClipRect(int column_index) { }
    public static void igPushColumnsBackground() { }
    public static void igPushFocusScope(uint id) { }
    public static unsafe void igPushFont(ImFont* font) { }
    public static unsafe void igPushID_Str(byte* str_id) { }
    public static unsafe void igPushID_StrStr(byte* str_id_begin, byte* str_id_end) { }
    public static void igPushID_Ptr(System.IntPtr ptr_id) { }
    public static void igPushID_Int(int int_id) { }
    public static void igPushItemFlag(ImGuiItemFlags option, byte enabled) { }
    public static void igPushItemWidth(float item_width) { }
    public static void igPushMultiItemsWidths(int components, float width_full) { }
    public static void igPushOverrideID(uint id) { }
    public static void igPushStyleColor_U32(ImGuiCol idx, uint col) { }
    public static void igPushStyleColor_Vec4(ImGuiCol idx, UnityEngine.Vector4 col) { }
    public static void igPushStyleVar_Float(ImGuiStyleVar idx, float val) { }
    public static void igPushStyleVar_Vec2(ImGuiStyleVar idx, UnityEngine.Vector2 val) { }
    public static void igPushTextWrapPos(float wrap_local_pos_x) { }
    public static unsafe byte igRadioButton_Bool(byte* label, byte active) { return default; }
    public static unsafe byte igRadioButton_IntPtr(byte* label, System.Int32* v, int v_button) { return default; }
    public static void igRemoveContextHook(System.IntPtr context, uint hook_to_remove) { }
    public static unsafe void igRemoveSettingsHandler(byte* type_name) { }
    public static void igRender() { }
    public static unsafe void igRenderArrow(ImDrawList* draw_list, UnityEngine.Vector2 pos, uint col, ImGuiDir dir, float scale) { }
    public static unsafe void igRenderArrowPointingAt(ImDrawList* draw_list, UnityEngine.Vector2 pos, UnityEngine.Vector2 half_sz, ImGuiDir direction, uint col) { }
    public static unsafe void igRenderBullet(ImDrawList* draw_list, UnityEngine.Vector2 pos, uint col) { }
    public static unsafe void igRenderCheckMark(ImDrawList* draw_list, UnityEngine.Vector2 pos, uint col, float sz) { }
    public static unsafe void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, float grid_step, UnityEngine.Vector2 grid_off, float rounding, ImDrawFlags flags) { }
    public static void igRenderFrame(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, uint fill_col, byte border, float rounding) { }
    public static void igRenderFrameBorder(UnityEngine.Vector2 p_min, UnityEngine.Vector2 p_max, float rounding) { }
    public static void igRenderMouseCursor(UnityEngine.Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow) { }
    public static void igRenderNavHighlight(UnityEngine.Rect bb, uint id, ImGuiNavHighlightFlags flags) { }
    public static unsafe void igRenderRectFilledRangeH(ImDrawList* draw_list, UnityEngine.Rect rect, uint col, float x_start_norm, float x_end_norm, float rounding) { }
    public static unsafe void igRenderRectFilledWithHole(ImDrawList* draw_list, UnityEngine.Rect outer, UnityEngine.Rect inner, uint col, float rounding) { }
    public static unsafe void igRenderText(UnityEngine.Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash) { }
    public static unsafe void igRenderTextClipped(UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, byte* text, byte* text_end, UnityEngine.Vector2* text_size_if_known, UnityEngine.Vector2 align, UnityEngine.Rect* clip_rect) { }
    public static unsafe void igRenderTextClippedEx(ImDrawList* draw_list, UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, byte* text, byte* text_end, UnityEngine.Vector2* text_size_if_known, UnityEngine.Vector2 align, UnityEngine.Rect* clip_rect) { }
    public static unsafe void igRenderTextEllipsis(ImDrawList* draw_list, UnityEngine.Vector2 pos_min, UnityEngine.Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, UnityEngine.Vector2* text_size_if_known) { }
    public static unsafe void igRenderTextWrapped(UnityEngine.Vector2 pos, byte* text, byte* text_end, float wrap_width) { }
    public static void igResetMouseDragDelta(ImGuiMouseButton button) { }
    public static void igSameLine(float offset_from_start_x, float spacing) { }
    public static unsafe void igSaveIniSettingsToDisk(byte* ini_filename) { }
    public static unsafe byte* igSaveIniSettingsToMemory(System.UInt32* out_ini_size) { return default; }
    public static unsafe void igScrollToBringRectIntoView(ImGuiWindow* window, UnityEngine.Rect rect) { }
    public static void igScrollToItem(ImGuiScrollFlags flags) { }
    public static unsafe void igScrollToRect(ImGuiWindow* window, UnityEngine.Rect rect, ImGuiScrollFlags flags) { }
    public static unsafe void igScrollToRectEx(UnityEngine.Vector2* pOut, ImGuiWindow* window, UnityEngine.Rect rect, ImGuiScrollFlags flags) { }
    public static void igScrollbar(ImGuiAxis axis) { }
    public static unsafe byte igScrollbarEx(UnityEngine.Rect bb, uint id, ImGuiAxis axis, System.Int64* p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags) { return default; }
    public static unsafe byte igSelectable_Bool(byte* label, byte selected, ImGuiSelectableFlags flags, UnityEngine.Vector2 size) { return default; }
    public static unsafe byte igSelectable_BoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, UnityEngine.Vector2 size) { return default; }
    public static void igSeparator() { }
    public static void igSeparatorEx(ImGuiSeparatorFlags flags) { }
    public static unsafe void igSetActiveID(uint id, ImGuiWindow* window) { }
    public static void igSetActiveIdUsingKey(ImGuiKey key) { }
    public static void igSetActiveIdUsingNavAndKeys() { }
    public static unsafe void igSetClipboardText(byte* text) { }
    public static void igSetColorEditOptions(ImGuiColorEditFlags flags) { }
    public static void igSetColumnOffset(int column_index, float offset_x) { }
    public static void igSetColumnWidth(int column_index, float width) { }
    public static void igSetCurrentContext(System.IntPtr ctx) { }
    public static unsafe void igSetCurrentFont(ImFont* font) { }
    public static void igSetCursorPos(UnityEngine.Vector2 local_pos) { }
    public static void igSetCursorPosX(float local_x) { }
    public static void igSetCursorPosY(float local_y) { }
    public static void igSetCursorScreenPos(UnityEngine.Vector2 pos) { }
    public static unsafe byte igSetDragDropPayload(byte* type, System.IntPtr data, uint sz, ImGuiCond cond) { return default; }
    public static unsafe void igSetFocusID(uint id, ImGuiWindow* window) { }
    public static void igSetHoveredID(uint id) { }
    public static void igSetItemAllowOverlap() { }
    public static void igSetItemDefaultFocus() { }
    public static void igSetItemUsingMouseWheel() { }
    public static void igSetKeyboardFocusHere(int offset) { }
    public static void igSetLastItemData(uint item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, UnityEngine.Rect item_rect) { }
    public static void igSetMouseCursor(ImGuiMouseCursor cursor_type) { }
    public static void igSetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, UnityEngine.Rect rect_rel) { }
    public static unsafe void igSetNavWindow(ImGuiWindow* window) { }
    public static void igSetNextFrameWantCaptureKeyboard(byte want_capture_keyboard) { }
    public static void igSetNextFrameWantCaptureMouse(byte want_capture_mouse) { }
    public static void igSetNextItemOpen(byte is_open, ImGuiCond cond) { }
    public static void igSetNextItemWidth(float item_width) { }
    public static void igSetNextWindowBgAlpha(float alpha) { }
    public static void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond) { }
    public static void igSetNextWindowContentSize(UnityEngine.Vector2 size) { }
    public static void igSetNextWindowFocus() { }
    public static void igSetNextWindowPos(UnityEngine.Vector2 pos, ImGuiCond cond, UnityEngine.Vector2 pivot) { }
    public static void igSetNextWindowScroll(UnityEngine.Vector2 scroll) { }
    public static void igSetNextWindowSize(UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static void igSetNextWindowSizeConstraints(UnityEngine.Vector2 size_min, UnityEngine.Vector2 size_max, ImGuiSizeCallback custom_callback, System.IntPtr custom_callback_data) { }
    public static void igSetScrollFromPosX_Float(float local_x, float center_x_ratio) { }
    public static unsafe void igSetScrollFromPosX_WindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio) { }
    public static void igSetScrollFromPosY_Float(float local_y, float center_y_ratio) { }
    public static unsafe void igSetScrollFromPosY_WindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio) { }
    public static void igSetScrollHereX(float center_x_ratio) { }
    public static void igSetScrollHereY(float center_y_ratio) { }
    public static void igSetScrollX_Float(float scroll_x) { }
    public static unsafe void igSetScrollX_WindowPtr(ImGuiWindow* window, float scroll_x) { }
    public static void igSetScrollY_Float(float scroll_y) { }
    public static unsafe void igSetScrollY_WindowPtr(ImGuiWindow* window, float scroll_y) { }
    public static unsafe void igSetStateStorage(ImGuiStorage* storage) { }
    public static unsafe void igSetTabItemClosed(byte* tab_or_docked_window_label) { }
    public static unsafe void igSetTooltip(byte* fmt) { }
    public static unsafe void igSetTooltipV(byte* fmt) { }
    public static unsafe void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, UnityEngine.Rect clip_rect) { }
    public static void igSetWindowCollapsed_Bool(byte collapsed, ImGuiCond cond) { }
    public static unsafe void igSetWindowCollapsed_Str(byte* name, byte collapsed, ImGuiCond cond) { }
    public static unsafe void igSetWindowCollapsed_WindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond) { }
    public static void igSetWindowFocus_Nil() { }
    public static unsafe void igSetWindowFocus_Str(byte* name) { }
    public static void igSetWindowFontScale(float scale) { }
    public static unsafe void igSetWindowHitTestHole(ImGuiWindow* window, UnityEngine.Vector2 pos, UnityEngine.Vector2 size) { }
    public static void igSetWindowPos_Vec2(UnityEngine.Vector2 pos, ImGuiCond cond) { }
    public static unsafe void igSetWindowPos_Str(byte* name, UnityEngine.Vector2 pos, ImGuiCond cond) { }
    public static unsafe void igSetWindowPos_WindowPtr(ImGuiWindow* window, UnityEngine.Vector2 pos, ImGuiCond cond) { }
    public static void igSetWindowSize_Vec2(UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static unsafe void igSetWindowSize_Str(byte* name, UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static unsafe void igSetWindowSize_WindowPtr(ImGuiWindow* window, UnityEngine.Vector2 size, ImGuiCond cond) { }
    public static unsafe void igSetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport) { }
    public static unsafe void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, UnityEngine.Vector2 gradient_p0, UnityEngine.Vector2 gradient_p1, uint col0, uint col1) { }
    public static unsafe void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 uv_a, UnityEngine.Vector2 uv_b, byte clamp) { }
    public static unsafe void igShowAboutWindow(byte* p_open) { }
    public static unsafe void igShowDebugLogWindow(byte* p_open) { }
    public static unsafe void igShowDemoWindow(byte* p_open) { }
    public static unsafe void igShowFontAtlas(ImFontAtlas* atlas) { }
    public static unsafe void igShowFontSelector(byte* label) { }
    public static unsafe void igShowMetricsWindow(byte* p_open) { }
    public static unsafe void igShowStackToolWindow(byte* p_open) { }
    public static unsafe void igShowStyleEditor(ImGuiStyle* @ref) { }
    public static unsafe byte igShowStyleSelector(byte* label) { return default; }
    public static void igShowUserGuide() { }
    public static unsafe void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess) { }
    public static void igShutdown() { }
    public static unsafe byte igSliderAngle(byte* label, System.Single* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderBehavior(UnityEngine.Rect bb, uint id, ImGuiDataType data_type, System.IntPtr p_v, System.IntPtr p_min, System.IntPtr p_max, byte* format, ImGuiSliderFlags flags, UnityEngine.Rect* out_grab_bb) { return default; }
    public static unsafe byte igSliderFloat(byte* label, System.Single* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderFloat2(byte* label, UnityEngine.Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderFloat3(byte* label, UnityEngine.Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderFloat4(byte* label, UnityEngine.Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderInt(byte* label, System.Int32* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderInt2(byte* label, System.Int32* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderInt3(byte* label, System.Int32* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderInt4(byte* label, System.Int32* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderScalar(byte* label, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSliderScalarN(byte* label, ImGuiDataType data_type, System.IntPtr p_data, int components, System.IntPtr p_min, System.IntPtr p_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igSmallButton(byte* label) { return default; }
    public static void igSpacing() { }
    public static unsafe byte igSplitterBehavior(UnityEngine.Rect bb, uint id, ImGuiAxis axis, System.Single* size1, System.Single* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay) { return default; }
    public static unsafe void igStartMouseMovingWindow(ImGuiWindow* window) { }
    public static unsafe void igStyleColorsClassic(ImGuiStyle* dst) { }
    public static unsafe void igStyleColorsDark(ImGuiStyle* dst) { }
    public static unsafe void igStyleColorsLight(ImGuiStyle* dst) { }
    public static unsafe void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab) { }
    public static unsafe ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id) { return default; }
    public static unsafe byte igTabBarProcessReorder(ImGuiTabBar* tab_bar) { return default; }
    public static unsafe void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset) { }
    public static unsafe void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, UnityEngine.Vector2 mouse_pos) { }
    public static unsafe void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id) { }
    public static unsafe void igTabItemBackground(ImDrawList* draw_list, UnityEngine.Rect bb, ImGuiTabItemFlags flags, uint col) { }
    public static unsafe byte igTabItemButton(byte* label, ImGuiTabItemFlags flags) { return default; }
    public static unsafe void igTabItemCalcSize(UnityEngine.Vector2* pOut, byte* label, byte has_close_button) { }
    public static unsafe byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags) { return default; }
    public static unsafe void igTabItemLabelAndCloseButton(ImDrawList* draw_list, UnityEngine.Rect bb, ImGuiTabItemFlags flags, UnityEngine.Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped) { }
    public static unsafe void igTableBeginApplyRequests(ImGuiTable* table) { }
    public static unsafe void igTableBeginCell(ImGuiTable* table, int column_n) { }
    public static unsafe void igTableBeginInitMemory(ImGuiTable* table, int columns_count) { }
    public static unsafe void igTableBeginRow(ImGuiTable* table) { }
    public static unsafe void igTableDrawBorders(ImGuiTable* table) { }
    public static unsafe void igTableDrawContextMenu(ImGuiTable* table) { }
    public static unsafe void igTableEndCell(ImGuiTable* table) { }
    public static unsafe void igTableEndRow(ImGuiTable* table) { }
    public static unsafe ImGuiTable* igTableFindByID(uint id) { return default; }
    public static unsafe void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column) { }
    public static void igTableGcCompactSettings() { }
    public static unsafe void igTableGcCompactTransientBuffers_TablePtr(ImGuiTable* table) { }
    public static unsafe void igTableGcCompactTransientBuffers_TableTempDataPtr(ImGuiTableTempData* table) { }
    public static unsafe ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table) { return default; }
    public static unsafe void igTableGetCellBgRect(UnityEngine.Rect* pOut, ImGuiTable* table, int column_n) { }
    public static int igTableGetColumnCount() { return default; }
    public static ImGuiTableColumnFlags igTableGetColumnFlags(int column_n) { return default; }
    public static int igTableGetColumnIndex() { return default; }
    public static unsafe byte* igTableGetColumnName_Int(int column_n) { return default; }
    public static unsafe byte* igTableGetColumnName_TablePtr(ImGuiTable* table, int column_n) { return default; }
    public static unsafe ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column) { return default; }
    public static unsafe uint igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no) { return default; }
    public static unsafe float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column) { return default; }
    public static float igTableGetHeaderRowHeight() { return default; }
    public static int igTableGetHoveredColumn() { return default; }
    public static unsafe ImGuiTableInstanceData* igTableGetInstanceData(ImGuiTable* table, int instance_no) { return default; }
    public static unsafe float igTableGetMaxColumnWidth(ImGuiTable* table, int column_n) { return default; }
    public static int igTableGetRowIndex() { return default; }
    public static unsafe ImGuiTableSortSpecs* igTableGetSortSpecs() { return default; }
    public static unsafe void igTableHeader(byte* label) { }
    public static void igTableHeadersRow() { }
    public static unsafe void igTableLoadSettings(ImGuiTable* table) { }
    public static unsafe void igTableMergeDrawChannels(ImGuiTable* table) { }
    public static byte igTableNextColumn() { return default; }
    public static void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height) { }
    public static void igTableOpenContextMenu(int column_n) { }
    public static void igTablePopBackgroundChannel() { }
    public static void igTablePushBackgroundChannel() { }
    public static unsafe void igTableRemove(ImGuiTable* table) { }
    public static unsafe void igTableResetSettings(ImGuiTable* table) { }
    public static unsafe void igTableSaveSettings(ImGuiTable* table) { }
    public static void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n) { }
    public static void igTableSetColumnEnabled(int column_n, byte v) { }
    public static byte igTableSetColumnIndex(int column_n) { return default; }
    public static void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs) { }
    public static void igTableSetColumnWidth(int column_n, float width) { }
    public static unsafe void igTableSetColumnWidthAutoAll(ImGuiTable* table) { }
    public static unsafe void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n) { }
    public static void igTableSettingsAddSettingsHandler() { }
    public static unsafe ImGuiTableSettings* igTableSettingsCreate(uint id, int columns_count) { return default; }
    public static unsafe ImGuiTableSettings* igTableSettingsFindByID(uint id) { return default; }
    public static unsafe void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id) { }
    public static unsafe void igTableSetupDrawChannels(ImGuiTable* table) { }
    public static void igTableSetupScrollFreeze(int cols, int rows) { }
    public static unsafe void igTableSortSpecsBuild(ImGuiTable* table) { }
    public static unsafe void igTableSortSpecsSanitize(ImGuiTable* table) { }
    public static unsafe void igTableUpdateBorders(ImGuiTable* table) { }
    public static unsafe void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table) { }
    public static unsafe void igTableUpdateLayout(ImGuiTable* table) { }
    public static byte igTempInputIsActive(uint id) { return default; }
    public static unsafe byte igTempInputScalar(UnityEngine.Rect bb, uint id, byte* label, ImGuiDataType data_type, System.IntPtr p_data, byte* format, System.IntPtr p_clamp_min, System.IntPtr p_clamp_max) { return default; }
    public static unsafe byte igTempInputText(UnityEngine.Rect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags) { return default; }
    public static unsafe void igText(byte* fmt) { }
    public static unsafe void igTextColored(UnityEngine.Vector4 col, byte* fmt) { }
    public static unsafe void igTextColoredV(UnityEngine.Vector4 col, byte* fmt) { }
    public static unsafe void igTextDisabled(byte* fmt) { }
    public static unsafe void igTextDisabledV(byte* fmt) { }
    public static unsafe void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags) { }
    public static unsafe void igTextUnformatted(byte* text, byte* text_end) { }
    public static unsafe void igTextV(byte* fmt) { }
    public static unsafe void igTextWrapped(byte* fmt) { }
    public static unsafe void igTextWrappedV(byte* fmt) { }
    public static unsafe byte igTreeNode_Str(byte* label) { return default; }
    public static unsafe byte igTreeNode_StrStr(byte* str_id, byte* fmt) { return default; }
    public static unsafe byte igTreeNode_Ptr(System.IntPtr ptr_id, byte* fmt) { return default; }
    public static unsafe byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end) { return default; }
    public static byte igTreeNodeBehaviorIsOpen(uint id, ImGuiTreeNodeFlags flags) { return default; }
    public static unsafe byte igTreeNodeEx_Str(byte* label, ImGuiTreeNodeFlags flags) { return default; }
    public static unsafe byte igTreeNodeEx_StrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt) { return default; }
    public static unsafe byte igTreeNodeEx_Ptr(System.IntPtr ptr_id, ImGuiTreeNodeFlags flags, byte* fmt) { return default; }
    public static unsafe byte igTreeNodeExV_Str(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt) { return default; }
    public static unsafe byte igTreeNodeExV_Ptr(System.IntPtr ptr_id, ImGuiTreeNodeFlags flags, byte* fmt) { return default; }
    public static unsafe byte igTreeNodeV_Str(byte* str_id, byte* fmt) { return default; }
    public static unsafe byte igTreeNodeV_Ptr(System.IntPtr ptr_id, byte* fmt) { return default; }
    public static void igTreePop() { }
    public static unsafe void igTreePush_Str(byte* str_id) { }
    public static void igTreePush_Ptr(System.IntPtr ptr_id) { }
    public static void igTreePushOverrideID(uint id) { }
    public static void igUnindent(float indent_w) { }
    public static void igUpdateHoveredWindowAndCaptureFlags() { }
    public static void igUpdateInputEvents(byte trickle_fast_inputs) { }
    public static void igUpdateMouseMovingWindowEndFrame() { }
    public static void igUpdateMouseMovingWindowNewFrame() { }
    public static unsafe void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window) { }
    public static unsafe byte igVSliderFloat(byte* label, UnityEngine.Vector2 size, System.Single* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igVSliderInt(byte* label, UnityEngine.Vector2 size, System.Int32* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe byte igVSliderScalar(byte* label, UnityEngine.Vector2 size, ImGuiDataType data_type, System.IntPtr p_data, System.IntPtr p_min, System.IntPtr p_max, byte* format, ImGuiSliderFlags flags) { return default; }
    public static unsafe void igValue_Bool(byte* prefix, byte b) { }
    public static unsafe void igValue_Int(byte* prefix, int v) { }
    public static unsafe void igValue_Uint(byte* prefix, uint v) { }
    public static unsafe void igValue_Float(byte* prefix, float v, byte* float_format) { }
    public static unsafe void igWindowRectAbsToRel(UnityEngine.Rect* pOut, ImGuiWindow* window, UnityEngine.Rect r) { }
    public static unsafe void igWindowRectRelToAbs(UnityEngine.Rect* pOut, ImGuiWindow* window, UnityEngine.Rect r) { }
  }
  public enum ImGuiNavDirSourceFlags
  {
    None = 0,
    RawKeyboard = 1,
    Keyboard = 2,
    PadDPad = 4,
    PadLStick = 8,
  }
  public enum ImGuiNavHighlightFlags
  {
    None = 0,
    TypeDefault = 1,
    TypeThin = 2,
    AlwaysDraw = 4,
    NoRounding = 8,
  }
  public enum ImGuiNavInput
  {
    Activate = 0,
    Cancel = 1,
    Input = 2,
    Menu = 3,
    DpadLeft = 4,
    DpadRight = 5,
    DpadUp = 6,
    DpadDown = 7,
    LStickLeft = 8,
    LStickRight = 9,
    LStickUp = 10,
    LStickDown = 11,
    FocusPrev = 12,
    FocusNext = 13,
    TweakSlow = 14,
    TweakFast = 15,
    KeyLeft_ = 16,
    KeyRight_ = 17,
    KeyUp_ = 18,
    KeyDown_ = 19,
    COUNT = 20,
  }
  public enum ImGuiNavLayer
  {
    Main = 0,
    Menu = 1,
    COUNT = 2,
  }
  public enum ImGuiNavMoveFlags
  {
    None = 0,
    LoopX = 1,
    LoopY = 2,
    WrapX = 4,
    WrapY = 8,
    AllowCurrentNavId = 16,
    AlsoScoreVisibleSet = 32,
    ScrollToEdgeY = 64,
    Forwarded = 128,
    DebugNoResult = 256,
    FocusApi = 512,
    Tabbing = 1024,
    Activate = 2048,
    DontSetNavHighlight = 4096,
  }
  public enum ImGuiNavReadMode
  {
    Down = 0,
    Pressed = 1,
    Released = 2,
    Repeat = 3,
    RepeatSlow = 4,
    RepeatFast = 5,
  }
  public struct ImGuiNextItemData
  {
    public ImGuiNextItemDataFlags Flags;
    public float Width;
    public uint FocusScopeId;
    public ImGuiCond OpenCond;
    public byte OpenVal;
  }
  public struct ImGuiNextItemDataPtr
  {
    public unsafe ImGuiNextItemData* NativePtr { get => default; }
    public ref ImGuiNextItemDataFlags Flags { get => ref __0; }
    public ref float Width { get => ref __1; }
    public ref uint FocusScopeId { get => ref __2; }
    public ref ImGuiCond OpenCond { get => ref __3; }
    public ref bool OpenVal { get => ref __4; }
    public void ClearFlags() { }
    public void ImGuiNextItemData_destroy() { }
    internal static ImGuiNextItemDataFlags __0;
    internal static float __1;
    internal static uint __2;
    internal static ImGuiCond __3;
    internal static bool __4;
  }
  public enum ImGuiNextItemDataFlags
  {
    None = 0,
    HasWidth = 1,
    HasOpen = 2,
  }
  public struct ImGuiNextWindowData
  {
    public ImGuiNextWindowDataFlags Flags;
    public ImGuiCond PosCond;
    public ImGuiCond SizeCond;
    public ImGuiCond CollapsedCond;
    public UnityEngine.Vector2 PosVal;
    public UnityEngine.Vector2 PosPivotVal;
    public UnityEngine.Vector2 SizeVal;
    public UnityEngine.Vector2 ContentSizeVal;
    public UnityEngine.Vector2 ScrollVal;
    public byte CollapsedVal;
    public UnityEngine.Rect SizeConstraintRect;
    public System.IntPtr SizeCallback;
    public unsafe void* SizeCallbackUserData;
    public float BgAlphaVal;
    public UnityEngine.Vector2 MenuBarOffsetMinVal;
  }
  public struct ImGuiNextWindowDataPtr
  {
    public unsafe ImGuiNextWindowData* NativePtr { get => default; }
    public ref ImGuiNextWindowDataFlags Flags { get => ref __0; }
    public ref ImGuiCond PosCond { get => ref __1; }
    public ref ImGuiCond SizeCond { get => ref __1; }
    public ref ImGuiCond CollapsedCond { get => ref __1; }
    public ref UnityEngine.Vector2 PosVal { get => ref __2; }
    public ref UnityEngine.Vector2 PosPivotVal { get => ref __2; }
    public ref UnityEngine.Vector2 SizeVal { get => ref __2; }
    public ref UnityEngine.Vector2 ContentSizeVal { get => ref __2; }
    public ref UnityEngine.Vector2 ScrollVal { get => ref __2; }
    public ref bool CollapsedVal { get => ref __3; }
    public ref UnityEngine.Rect SizeConstraintRect { get => ref __4; }
    public ref ImGuiSizeCallback SizeCallback { get => ref __5; }
    public System.IntPtr SizeCallbackUserData { get => default; set { } }
    public ref float BgAlphaVal { get => ref __6; }
    public ref UnityEngine.Vector2 MenuBarOffsetMinVal { get => ref __2; }
    public void ClearFlags() { }
    public void ImGuiNextWindowData_destroy() { }
    internal static ImGuiNextWindowDataFlags __0;
    internal static ImGuiCond __1;
    internal static UnityEngine.Vector2 __2;
    internal static bool __3;
    internal static UnityEngine.Rect __4;
    internal static ImGuiSizeCallback __5;
    internal static float __6;
  }
  public enum ImGuiNextWindowDataFlags
  {
    None = 0,
    HasPos = 1,
    HasSize = 2,
    HasContentSize = 4,
    HasCollapsed = 8,
    HasSizeConstraint = 16,
    HasFocus = 32,
    HasBgAlpha = 64,
    HasScroll = 128,
  }
  public struct ImGuiOldColumnData
  {
    public float OffsetNorm;
    public float OffsetNormBeforeResize;
    public ImGuiOldColumnFlags Flags;
    public UnityEngine.Rect ClipRect;
  }
  public struct ImGuiOldColumnDataPtr
  {
    public unsafe ImGuiOldColumnData* NativePtr { get => default; }
    public ref float OffsetNorm { get => ref __0; }
    public ref float OffsetNormBeforeResize { get => ref __0; }
    public ref ImGuiOldColumnFlags Flags { get => ref __1; }
    public ref UnityEngine.Rect ClipRect { get => ref __2; }
    public void ImGuiOldColumnData_destroy() { }
    internal static float __0;
    internal static ImGuiOldColumnFlags __1;
    internal static UnityEngine.Rect __2;
  }
  public enum ImGuiOldColumnFlags
  {
    None = 0,
    NoBorder = 1,
    NoResize = 2,
    NoPreserveWidths = 4,
    NoForceWithinWindow = 8,
    GrowParentContentsSize = 16,
  }
  public struct ImGuiOldColumns
  {
    public uint ID;
    public ImGuiOldColumnFlags Flags;
    public byte IsFirstFrame;
    public byte IsBeingResized;
    public int Current;
    public int Count;
    public float OffMinX;
    public float OffMaxX;
    public float LineMinY;
    public float LineMaxY;
    public float HostCursorPosY;
    public float HostCursorMaxPosX;
    public UnityEngine.Rect HostInitialClipRect;
    public UnityEngine.Rect HostBackupClipRect;
    public UnityEngine.Rect HostBackupParentWorkRect;
    public ImVector Columns;
    public ImDrawListSplitter Splitter;
  }
  public struct ImGuiOldColumnsPtr
  {
    public unsafe ImGuiOldColumns* NativePtr { get => default; }
    public ref uint ID { get => ref __0; }
    public ref ImGuiOldColumnFlags Flags { get => ref __1; }
    public ref bool IsFirstFrame { get => ref __2; }
    public ref bool IsBeingResized { get => ref __2; }
    public ref int Current { get => ref __3; }
    public ref int Count { get => ref __3; }
    public ref float OffMinX { get => ref __4; }
    public ref float OffMaxX { get => ref __4; }
    public ref float LineMinY { get => ref __4; }
    public ref float LineMaxY { get => ref __4; }
    public ref float HostCursorPosY { get => ref __4; }
    public ref float HostCursorMaxPosX { get => ref __4; }
    public ref UnityEngine.Rect HostInitialClipRect { get => ref __5; }
    public ref UnityEngine.Rect HostBackupClipRect { get => ref __5; }
    public ref UnityEngine.Rect HostBackupParentWorkRect { get => ref __5; }
    public ImPtrVector<ImGuiOldColumnDataPtr> Columns { get => default; }
    public ref ImDrawListSplitter Splitter { get => ref __6; }
    public void ImGuiOldColumns_destroy() { }
    internal static uint __0;
    internal static ImGuiOldColumnFlags __1;
    internal static bool __2;
    internal static int __3;
    internal static float __4;
    internal static UnityEngine.Rect __5;
    internal static ImDrawListSplitter __6;
  }
  public struct ImGuiOnceUponAFrame
  {
    public int RefFrame;
  }
  public struct ImGuiOnceUponAFramePtr
  {
    public unsafe ImGuiOnceUponAFrame* NativePtr { get => default; }
    public ref int RefFrame { get => ref __0; }
    public void ImGuiOnceUponAFrame_destroy() { }
    internal static int __0;
  }
  public struct ImGuiPayload
  {
    public unsafe void* Data;
    public int DataSize;
    public uint SourceId;
    public uint SourceParentId;
    public int DataFrameCount;
    public byte DataType_0;
    public byte DataType_1;
    public byte DataType_2;
    public byte DataType_3;
    public byte DataType_4;
    public byte DataType_5;
    public byte DataType_6;
    public byte DataType_7;
    public byte DataType_8;
    public byte DataType_9;
    public byte DataType_10;
    public byte DataType_11;
    public byte DataType_12;
    public byte DataType_13;
    public byte DataType_14;
    public byte DataType_15;
    public byte DataType_16;
    public byte DataType_17;
    public byte DataType_18;
    public byte DataType_19;
    public byte DataType_20;
    public byte DataType_21;
    public byte DataType_22;
    public byte DataType_23;
    public byte DataType_24;
    public byte DataType_25;
    public byte DataType_26;
    public byte DataType_27;
    public byte DataType_28;
    public byte DataType_29;
    public byte DataType_30;
    public byte DataType_31;
    public byte DataType_32;
    public byte Preview;
    public byte Delivery;
  }
  public struct ImGuiPayloadPtr
  {
    public unsafe ImGuiPayload* NativePtr { get => default; }
    public System.IntPtr Data { get => default; set { } }
    public ref int DataSize { get => ref __0; }
    public ref uint SourceId { get => ref __1; }
    public ref uint SourceParentId { get => ref __1; }
    public ref int DataFrameCount { get => ref __0; }
    public RangeAccessor<byte> DataType { get => default; }
    public ref bool Preview { get => ref __2; }
    public ref bool Delivery { get => ref __2; }
    public void Clear() { }
    public bool IsDataType(string type) { return default; }
    public bool IsDelivery() { return default; }
    public bool IsPreview() { return default; }
    public void ImGuiPayload_destroy() { }
    internal static int __0;
    internal static uint __1;
    internal static bool __2;
  }
  public struct ImGuiPlatformImeData
  {
    public byte WantVisible;
    public UnityEngine.Vector2 InputPos;
    public float InputLineHeight;
  }
  public struct ImGuiPlatformImeDataPtr
  {
    public unsafe ImGuiPlatformImeData* NativePtr { get => default; }
    public ref bool WantVisible { get => ref __0; }
    public ref UnityEngine.Vector2 InputPos { get => ref __1; }
    public ref float InputLineHeight { get => ref __2; }
    public void ImGuiPlatformImeData_destroy() { }
    internal static bool __0;
    internal static UnityEngine.Vector2 __1;
    internal static float __2;
  }
  public enum ImGuiPlotType
  {
    Lines = 0,
    Histogram = 1,
  }
  public enum ImGuiPopupFlags
  {
    None = 0,
    MouseButtonLeft = 0,
    MouseButtonRight = 1,
    MouseButtonDefault_ = 1,
    MouseButtonMiddle = 2,
    MouseButtonMask_ = 31,
    NoOpenOverExistingPopup = 32,
    NoOpenOverItems = 64,
    AnyPopupId = 128,
    AnyPopupLevel = 256,
    AnyPopup = 384,
  }
  public enum ImGuiPopupPositionPolicy
  {
    Default = 0,
    ComboBox = 1,
    Tooltip = 2,
  }
  public struct ImGuiPtrOrIndex
  {
    public System.IntPtr Ptr;
    public int Index;
  }
  public struct ImGuiPtrOrIndexPtr
  {
    public unsafe ImGuiPtrOrIndex* NativePtr { get => default; }
    public System.IntPtr Ptr { get => default; set { } }
    public ref int Index { get => ref __0; }
    public void ImGuiPtrOrIndex_destroy() { }
    internal static int __0;
  }
  public enum ImGuiScrollFlags
  {
    None = 0,
    KeepVisibleEdgeX = 1,
    KeepVisibleEdgeY = 2,
    KeepVisibleCenterX = 4,
    KeepVisibleCenterY = 8,
    AlwaysCenterX = 16,
    MaskX_ = 21,
    AlwaysCenterY = 32,
    MaskY_ = 42,
    NoScrollParent = 64,
  }
  public enum ImGuiSelectableFlags
  {
    None = 0,
    DontClosePopups = 1,
    SpanAllColumns = 2,
    AllowDoubleClick = 4,
    Disabled = 8,
    AllowItemOverlap = 16,
  }
  public enum ImGuiSelectableFlagsPrivate
  {
    NoHoldingActiveID = 1048576,
    SelectOnNav = 2097152,
    SelectOnClick = 4194304,
    SelectOnRelease = 8388608,
    SpanAvailWidth = 16777216,
    DrawHoveredWhenHeld = 33554432,
    SetNavIdOnHover = 67108864,
    NoPadWithHalfSpacing = 134217728,
  }
  public enum ImGuiSeparatorFlags
  {
    None = 0,
    Horizontal = 1,
    Vertical = 2,
    SpanAllColumns = 4,
  }
  public struct ImGuiSettingsHandler
  {
    public unsafe byte* TypeName;
    public uint TypeHash;
    public System.IntPtr ClearAllFn;
    public System.IntPtr ReadInitFn;
    public System.IntPtr ReadOpenFn;
    public System.IntPtr ReadLineFn;
    public System.IntPtr ApplyAllFn;
    public System.IntPtr WriteAllFn;
    public unsafe void* UserData;
  }
  public struct ImGuiSettingsHandlerPtr
  {
    public unsafe ImGuiSettingsHandler* NativePtr { get => default; }
    public ref string TypeName { get => ref __0; }
    public ref uint TypeHash { get => ref __1; }
    public System.IntPtr ClearAllFn { get => default; set { } }
    public System.IntPtr ReadInitFn { get => default; set { } }
    public System.IntPtr ReadOpenFn { get => default; set { } }
    public System.IntPtr ReadLineFn { get => default; set { } }
    public System.IntPtr ApplyAllFn { get => default; set { } }
    public System.IntPtr WriteAllFn { get => default; set { } }
    public System.IntPtr UserData { get => default; set { } }
    public void ImGuiSettingsHandler_destroy() { }
    internal static string __0;
    internal static uint __1;
  }
  public struct ImGuiShrinkWidthItem
  {
    public int Index;
    public float Width;
    public float InitialWidth;
  }
  public struct ImGuiShrinkWidthItemPtr
  {
    public unsafe ImGuiShrinkWidthItem* NativePtr { get => default; }
    public ref int Index { get => ref __0; }
    public ref float Width { get => ref __1; }
    public ref float InitialWidth { get => ref __1; }
    internal static int __0;
    internal static float __1;
  }
  public struct ImGuiSizeCallbackData
  {
    public unsafe void* UserData;
    public UnityEngine.Vector2 Pos;
    public UnityEngine.Vector2 CurrentSize;
    public UnityEngine.Vector2 DesiredSize;
  }
  public struct ImGuiSizeCallbackDataPtr
  {
    public unsafe ImGuiSizeCallbackData* NativePtr { get => default; }
    public System.IntPtr UserData { get => default; set { } }
    public ref UnityEngine.Vector2 Pos { get => ref __0; }
    public ref UnityEngine.Vector2 CurrentSize { get => ref __0; }
    public ref UnityEngine.Vector2 DesiredSize { get => ref __0; }
    internal static UnityEngine.Vector2 __0;
  }
  public enum ImGuiSliderFlags
  {
    None = 0,
    AlwaysClamp = 16,
    Logarithmic = 32,
    NoRoundToFormat = 64,
    NoInput = 128,
    InvalidMask_ = 1879048207,
  }
  public enum ImGuiSliderFlagsPrivate
  {
    Vertical = 1048576,
    ReadOnly = 2097152,
  }
  public enum ImGuiSortDirection
  {
    None = 0,
    Ascending = 1,
    Descending = 2,
  }
  public struct ImGuiStackLevelInfo
  {
    public uint ID;
    public System.SByte QueryFrameCount;
    public byte QuerySuccess;
    public ImGuiDataType DataType;
    public byte Desc_0;
    public byte Desc_1;
    public byte Desc_2;
    public byte Desc_3;
    public byte Desc_4;
    public byte Desc_5;
    public byte Desc_6;
    public byte Desc_7;
    public byte Desc_8;
    public byte Desc_9;
    public byte Desc_10;
    public byte Desc_11;
    public byte Desc_12;
    public byte Desc_13;
    public byte Desc_14;
    public byte Desc_15;
    public byte Desc_16;
    public byte Desc_17;
    public byte Desc_18;
    public byte Desc_19;
    public byte Desc_20;
    public byte Desc_21;
    public byte Desc_22;
    public byte Desc_23;
    public byte Desc_24;
    public byte Desc_25;
    public byte Desc_26;
    public byte Desc_27;
    public byte Desc_28;
    public byte Desc_29;
    public byte Desc_30;
    public byte Desc_31;
    public byte Desc_32;
    public byte Desc_33;
    public byte Desc_34;
    public byte Desc_35;
    public byte Desc_36;
    public byte Desc_37;
    public byte Desc_38;
    public byte Desc_39;
    public byte Desc_40;
    public byte Desc_41;
    public byte Desc_42;
    public byte Desc_43;
    public byte Desc_44;
    public byte Desc_45;
    public byte Desc_46;
    public byte Desc_47;
    public byte Desc_48;
    public byte Desc_49;
    public byte Desc_50;
    public byte Desc_51;
    public byte Desc_52;
    public byte Desc_53;
    public byte Desc_54;
    public byte Desc_55;
    public byte Desc_56;
  }
  public struct ImGuiStackLevelInfoPtr
  {
    public unsafe ImGuiStackLevelInfo* NativePtr { get => default; }
    public ref uint ID { get => ref __0; }
    public ref System.SByte QueryFrameCount { get => ref __1; }
    public ref bool QuerySuccess { get => ref __2; }
    public ref ImGuiDataType DataType { get => ref __3; }
    public RangeAccessor<byte> Desc { get => default; }
    public void ImGuiStackLevelInfo_destroy() { }
    internal static uint __0;
    internal static System.SByte __1;
    internal static bool __2;
    internal static ImGuiDataType __3;
  }
  public struct ImGuiStackSizes
  {
    public short SizeOfIDStack;
    public short SizeOfColorStack;
    public short SizeOfStyleVarStack;
    public short SizeOfFontStack;
    public short SizeOfFocusScopeStack;
    public short SizeOfGroupStack;
    public short SizeOfItemFlagsStack;
    public short SizeOfBeginPopupStack;
    public short SizeOfDisabledStack;
  }
  public struct ImGuiStackSizesPtr
  {
    public unsafe ImGuiStackSizes* NativePtr { get => default; }
    public ref short SizeOfIDStack { get => ref __0; }
    public ref short SizeOfColorStack { get => ref __0; }
    public ref short SizeOfStyleVarStack { get => ref __0; }
    public ref short SizeOfFontStack { get => ref __0; }
    public ref short SizeOfFocusScopeStack { get => ref __0; }
    public ref short SizeOfGroupStack { get => ref __0; }
    public ref short SizeOfItemFlagsStack { get => ref __0; }
    public ref short SizeOfBeginPopupStack { get => ref __0; }
    public ref short SizeOfDisabledStack { get => ref __0; }
    public void CompareWithCurrentState() { }
    public void SetToCurrentState() { }
    public void ImGuiStackSizes_destroy() { }
    internal static short __0;
  }
  public struct ImGuiStackTool
  {
    public int LastActiveFrame;
    public int StackLevel;
    public uint QueryId;
    public ImVector Results;
    public byte CopyToClipboardOnCtrlC;
    public float CopyToClipboardLastTime;
  }
  public struct ImGuiStackToolPtr
  {
    public unsafe ImGuiStackTool* NativePtr { get => default; }
    public ref int LastActiveFrame { get => ref __0; }
    public ref int StackLevel { get => ref __0; }
    public ref uint QueryId { get => ref __1; }
    public ImPtrVector<ImGuiStackLevelInfoPtr> Results { get => default; }
    public ref bool CopyToClipboardOnCtrlC { get => ref __2; }
    public ref float CopyToClipboardLastTime { get => ref __3; }
    public void ImGuiStackTool_destroy() { }
    internal static int __0;
    internal static uint __1;
    internal static bool __2;
    internal static float __3;
  }
  public struct ImGuiStorage
  {
    public ImVector Data;
  }
  public struct ImGuiStoragePtr
  {
    public unsafe ImGuiStorage* NativePtr { get => default; }
    public ImVector<System.IntPtr> Data { get => default; }
    public void BuildSortByKey() { }
    public void Clear() { }
    public bool GetBool(uint key) { return default; }
    public bool GetBool(uint key, bool default_val) { return default; }
    public unsafe byte* GetBoolRef(uint key) { return default; }
    public unsafe byte* GetBoolRef(uint key, bool default_val) { return default; }
    public float GetFloat(uint key) { return default; }
    public float GetFloat(uint key, float default_val) { return default; }
    public unsafe System.Single* GetFloatRef(uint key) { return default; }
    public unsafe System.Single* GetFloatRef(uint key, float default_val) { return default; }
    public int GetInt(uint key) { return default; }
    public int GetInt(uint key, int default_val) { return default; }
    public unsafe System.Int32* GetIntRef(uint key) { return default; }
    public unsafe System.Int32* GetIntRef(uint key, int default_val) { return default; }
    public unsafe void* GetVoidPtr(uint key) { return default; }
    public unsafe void** GetVoidPtrRef(uint key) { return default; }
    public unsafe void** GetVoidPtrRef(uint key, System.IntPtr default_val) { return default; }
    public void SetAllInt(int val) { }
    public void SetBool(uint key, bool val) { }
    public void SetFloat(uint key, float val) { }
    public void SetInt(uint key, int val) { }
    public void SetVoidPtr(uint key, System.IntPtr val) { }
  }
  public struct ImGuiStyle
  {
    public float Alpha;
    public float DisabledAlpha;
    public UnityEngine.Vector2 WindowPadding;
    public float WindowRounding;
    public float WindowBorderSize;
    public UnityEngine.Vector2 WindowMinSize;
    public UnityEngine.Vector2 WindowTitleAlign;
    public ImGuiDir WindowMenuButtonPosition;
    public float ChildRounding;
    public float ChildBorderSize;
    public float PopupRounding;
    public float PopupBorderSize;
    public UnityEngine.Vector2 FramePadding;
    public float FrameRounding;
    public float FrameBorderSize;
    public UnityEngine.Vector2 ItemSpacing;
    public UnityEngine.Vector2 ItemInnerSpacing;
    public UnityEngine.Vector2 CellPadding;
    public UnityEngine.Vector2 TouchExtraPadding;
    public float IndentSpacing;
    public float ColumnsMinSpacing;
    public float ScrollbarSize;
    public float ScrollbarRounding;
    public float GrabMinSize;
    public float GrabRounding;
    public float LogSliderDeadzone;
    public float TabRounding;
    public float TabBorderSize;
    public float TabMinWidthForCloseButton;
    public ImGuiDir ColorButtonPosition;
    public UnityEngine.Vector2 ButtonTextAlign;
    public UnityEngine.Vector2 SelectableTextAlign;
    public UnityEngine.Vector2 DisplayWindowPadding;
    public UnityEngine.Vector2 DisplaySafeAreaPadding;
    public float MouseCursorScale;
    public byte AntiAliasedLines;
    public byte AntiAliasedLinesUseTex;
    public byte AntiAliasedFill;
    public float CurveTessellationTol;
    public float CircleTessellationMaxError;
    public UnityEngine.Vector4 Colors_0;
    public UnityEngine.Vector4 Colors_1;
    public UnityEngine.Vector4 Colors_2;
    public UnityEngine.Vector4 Colors_3;
    public UnityEngine.Vector4 Colors_4;
    public UnityEngine.Vector4 Colors_5;
    public UnityEngine.Vector4 Colors_6;
    public UnityEngine.Vector4 Colors_7;
    public UnityEngine.Vector4 Colors_8;
    public UnityEngine.Vector4 Colors_9;
    public UnityEngine.Vector4 Colors_10;
    public UnityEngine.Vector4 Colors_11;
    public UnityEngine.Vector4 Colors_12;
    public UnityEngine.Vector4 Colors_13;
    public UnityEngine.Vector4 Colors_14;
    public UnityEngine.Vector4 Colors_15;
    public UnityEngine.Vector4 Colors_16;
    public UnityEngine.Vector4 Colors_17;
    public UnityEngine.Vector4 Colors_18;
    public UnityEngine.Vector4 Colors_19;
    public UnityEngine.Vector4 Colors_20;
    public UnityEngine.Vector4 Colors_21;
    public UnityEngine.Vector4 Colors_22;
    public UnityEngine.Vector4 Colors_23;
    public UnityEngine.Vector4 Colors_24;
    public UnityEngine.Vector4 Colors_25;
    public UnityEngine.Vector4 Colors_26;
    public UnityEngine.Vector4 Colors_27;
    public UnityEngine.Vector4 Colors_28;
    public UnityEngine.Vector4 Colors_29;
    public UnityEngine.Vector4 Colors_30;
    public UnityEngine.Vector4 Colors_31;
    public UnityEngine.Vector4 Colors_32;
    public UnityEngine.Vector4 Colors_33;
    public UnityEngine.Vector4 Colors_34;
    public UnityEngine.Vector4 Colors_35;
    public UnityEngine.Vector4 Colors_36;
    public UnityEngine.Vector4 Colors_37;
    public UnityEngine.Vector4 Colors_38;
    public UnityEngine.Vector4 Colors_39;
    public UnityEngine.Vector4 Colors_40;
    public UnityEngine.Vector4 Colors_41;
    public UnityEngine.Vector4 Colors_42;
    public UnityEngine.Vector4 Colors_43;
    public UnityEngine.Vector4 Colors_44;
    public UnityEngine.Vector4 Colors_45;
    public UnityEngine.Vector4 Colors_46;
    public UnityEngine.Vector4 Colors_47;
    public UnityEngine.Vector4 Colors_48;
    public UnityEngine.Vector4 Colors_49;
    public UnityEngine.Vector4 Colors_50;
    public UnityEngine.Vector4 Colors_51;
    public UnityEngine.Vector4 Colors_52;
  }
  public struct ImGuiStylePtr
  {
    public unsafe ImGuiStyle* NativePtr { get => default; }
    public ref float Alpha { get => ref __0; }
    public ref float DisabledAlpha { get => ref __0; }
    public ref UnityEngine.Vector2 WindowPadding { get => ref __1; }
    public ref float WindowRounding { get => ref __0; }
    public ref float WindowBorderSize { get => ref __0; }
    public ref UnityEngine.Vector2 WindowMinSize { get => ref __1; }
    public ref UnityEngine.Vector2 WindowTitleAlign { get => ref __1; }
    public ref ImGuiDir WindowMenuButtonPosition { get => ref __2; }
    public ref float ChildRounding { get => ref __0; }
    public ref float ChildBorderSize { get => ref __0; }
    public ref float PopupRounding { get => ref __0; }
    public ref float PopupBorderSize { get => ref __0; }
    public ref UnityEngine.Vector2 FramePadding { get => ref __1; }
    public ref float FrameRounding { get => ref __0; }
    public ref float FrameBorderSize { get => ref __0; }
    public ref UnityEngine.Vector2 ItemSpacing { get => ref __1; }
    public ref UnityEngine.Vector2 ItemInnerSpacing { get => ref __1; }
    public ref UnityEngine.Vector2 CellPadding { get => ref __1; }
    public ref UnityEngine.Vector2 TouchExtraPadding { get => ref __1; }
    public ref float IndentSpacing { get => ref __0; }
    public ref float ColumnsMinSpacing { get => ref __0; }
    public ref float ScrollbarSize { get => ref __0; }
    public ref float ScrollbarRounding { get => ref __0; }
    public ref float GrabMinSize { get => ref __0; }
    public ref float GrabRounding { get => ref __0; }
    public ref float LogSliderDeadzone { get => ref __0; }
    public ref float TabRounding { get => ref __0; }
    public ref float TabBorderSize { get => ref __0; }
    public ref float TabMinWidthForCloseButton { get => ref __0; }
    public ref ImGuiDir ColorButtonPosition { get => ref __2; }
    public ref UnityEngine.Vector2 ButtonTextAlign { get => ref __1; }
    public ref UnityEngine.Vector2 SelectableTextAlign { get => ref __1; }
    public ref UnityEngine.Vector2 DisplayWindowPadding { get => ref __1; }
    public ref UnityEngine.Vector2 DisplaySafeAreaPadding { get => ref __1; }
    public ref float MouseCursorScale { get => ref __0; }
    public ref bool AntiAliasedLines { get => ref __3; }
    public ref bool AntiAliasedLinesUseTex { get => ref __3; }
    public ref bool AntiAliasedFill { get => ref __3; }
    public ref float CurveTessellationTol { get => ref __0; }
    public ref float CircleTessellationMaxError { get => ref __0; }
    public RangeAccessor<UnityEngine.Vector4> Colors { get => default; }
    public void ScaleAllSizes(float scale_factor) { }
    public void ImGuiStyle_destroy() { }
    internal static float __0;
    internal static UnityEngine.Vector2 __1;
    internal static ImGuiDir __2;
    internal static bool __3;
  }
  public enum ImGuiStyleVar
  {
    Alpha = 0,
    DisabledAlpha = 1,
    WindowPadding = 2,
    WindowRounding = 3,
    WindowBorderSize = 4,
    WindowMinSize = 5,
    WindowTitleAlign = 6,
    ChildRounding = 7,
    ChildBorderSize = 8,
    PopupRounding = 9,
    PopupBorderSize = 10,
    FramePadding = 11,
    FrameRounding = 12,
    FrameBorderSize = 13,
    ItemSpacing = 14,
    ItemInnerSpacing = 15,
    IndentSpacing = 16,
    CellPadding = 17,
    ScrollbarSize = 18,
    ScrollbarRounding = 19,
    GrabMinSize = 20,
    GrabRounding = 21,
    TabRounding = 22,
    ButtonTextAlign = 23,
    SelectableTextAlign = 24,
    COUNT = 25,
  }
  public struct ImGuiTabBar
  {
    public ImVector Tabs;
    public ImGuiTabBarFlags Flags;
    public uint ID;
    public uint SelectedTabId;
    public uint NextSelectedTabId;
    public uint VisibleTabId;
    public int CurrFrameVisible;
    public int PrevFrameVisible;
    public UnityEngine.Rect BarRect;
    public float CurrTabsContentsHeight;
    public float PrevTabsContentsHeight;
    public float WidthAllTabs;
    public float WidthAllTabsIdeal;
    public float ScrollingAnim;
    public float ScrollingTarget;
    public float ScrollingTargetDistToVisibility;
    public float ScrollingSpeed;
    public float ScrollingRectMinX;
    public float ScrollingRectMaxX;
    public uint ReorderRequestTabId;
    public short ReorderRequestOffset;
    public System.SByte BeginCount;
    public byte WantLayout;
    public byte VisibleTabWasSubmitted;
    public byte TabsAddedNew;
    public short TabsActiveCount;
    public short LastTabItemIdx;
    public float ItemSpacingY;
    public UnityEngine.Vector2 FramePadding;
    public UnityEngine.Vector2 BackupCursorPos;
    public ImGuiTextBuffer TabsNames;
  }
  public struct ImGuiTabBarPtr
  {
    public unsafe ImGuiTabBar* NativePtr { get => default; }
    public ImPtrVector<ImGuiTabItemPtr> Tabs { get => default; }
    public ref ImGuiTabBarFlags Flags { get => ref __0; }
    public ref uint ID { get => ref __1; }
    public ref uint SelectedTabId { get => ref __1; }
    public ref uint NextSelectedTabId { get => ref __1; }
    public ref uint VisibleTabId { get => ref __1; }
    public ref int CurrFrameVisible { get => ref __2; }
    public ref int PrevFrameVisible { get => ref __2; }
    public ref UnityEngine.Rect BarRect { get => ref __3; }
    public ref float CurrTabsContentsHeight { get => ref __4; }
    public ref float PrevTabsContentsHeight { get => ref __4; }
    public ref float WidthAllTabs { get => ref __4; }
    public ref float WidthAllTabsIdeal { get => ref __4; }
    public ref float ScrollingAnim { get => ref __4; }
    public ref float ScrollingTarget { get => ref __4; }
    public ref float ScrollingTargetDistToVisibility { get => ref __4; }
    public ref float ScrollingSpeed { get => ref __4; }
    public ref float ScrollingRectMinX { get => ref __4; }
    public ref float ScrollingRectMaxX { get => ref __4; }
    public ref uint ReorderRequestTabId { get => ref __1; }
    public ref short ReorderRequestOffset { get => ref __5; }
    public ref System.SByte BeginCount { get => ref __6; }
    public ref bool WantLayout { get => ref __7; }
    public ref bool VisibleTabWasSubmitted { get => ref __7; }
    public ref bool TabsAddedNew { get => ref __7; }
    public ref short TabsActiveCount { get => ref __5; }
    public ref short LastTabItemIdx { get => ref __5; }
    public ref float ItemSpacingY { get => ref __4; }
    public ref UnityEngine.Vector2 FramePadding { get => ref __8; }
    public ref UnityEngine.Vector2 BackupCursorPos { get => ref __8; }
    public ref ImGuiTextBuffer TabsNames { get => ref __9; }
    public string GetTabName(ImGuiTabItemPtr tab) { return default; }
    public int GetTabOrder(ImGuiTabItemPtr tab) { return default; }
    public void ImGuiTabBar_destroy() { }
    internal static ImGuiTabBarFlags __0;
    internal static uint __1;
    internal static int __2;
    internal static UnityEngine.Rect __3;
    internal static float __4;
    internal static short __5;
    internal static System.SByte __6;
    internal static bool __7;
    internal static UnityEngine.Vector2 __8;
    internal static ImGuiTextBuffer __9;
  }
  public enum ImGuiTabBarFlags
  {
    None = 0,
    Reorderable = 1,
    AutoSelectNewTabs = 2,
    TabListPopupButton = 4,
    NoCloseWithMiddleMouseButton = 8,
    NoTabListScrollingButtons = 16,
    NoTooltip = 32,
    FittingPolicyResizeDown = 64,
    FittingPolicyDefault_ = 64,
    FittingPolicyScroll = 128,
    FittingPolicyMask_ = 192,
  }
  public enum ImGuiTabBarFlagsPrivate
  {
    DockNode = 1048576,
    IsFocused = 2097152,
    SaveSettings = 4194304,
  }
  public struct ImGuiTabItem
  {
    public uint ID;
    public ImGuiTabItemFlags Flags;
    public int LastFrameVisible;
    public int LastFrameSelected;
    public float Offset;
    public float Width;
    public float ContentWidth;
    public float RequestedWidth;
    public int NameOffset;
    public short BeginOrder;
    public short IndexDuringLayout;
    public byte WantClose;
  }
  public struct ImGuiTabItemPtr
  {
    public unsafe ImGuiTabItem* NativePtr { get => default; }
    public ref uint ID { get => ref __0; }
    public ref ImGuiTabItemFlags Flags { get => ref __1; }
    public ref int LastFrameVisible { get => ref __2; }
    public ref int LastFrameSelected { get => ref __2; }
    public ref float Offset { get => ref __3; }
    public ref float Width { get => ref __3; }
    public ref float ContentWidth { get => ref __3; }
    public ref float RequestedWidth { get => ref __3; }
    public ref int NameOffset { get => ref __2; }
    public ref short BeginOrder { get => ref __4; }
    public ref short IndexDuringLayout { get => ref __4; }
    public ref bool WantClose { get => ref __5; }
    public void ImGuiTabItem_destroy() { }
    internal static uint __0;
    internal static ImGuiTabItemFlags __1;
    internal static int __2;
    internal static float __3;
    internal static short __4;
    internal static bool __5;
  }
  public enum ImGuiTabItemFlags
  {
    None = 0,
    UnsavedDocument = 1,
    SetSelected = 2,
    NoCloseWithMiddleMouseButton = 4,
    NoPushId = 8,
    NoTooltip = 16,
    NoReorder = 32,
    Leading = 64,
    Trailing = 128,
  }
  public enum ImGuiTabItemFlagsPrivate
  {
    SectionMask_ = 192,
    NoCloseButton = 1048576,
    Button = 2097152,
  }
  public struct ImGuiTable
  {
    public uint ID;
    public ImGuiTableFlags Flags;
    public unsafe void* RawData;
    public unsafe ImGuiTableTempData* TempData;
    public ImSpan Columns;
    public ImSpan DisplayOrderToIndex;
    public ImSpan RowCellData;
    public ulong EnabledMaskByDisplayOrder;
    public ulong EnabledMaskByIndex;
    public ulong VisibleMaskByIndex;
    public ulong RequestOutputMaskByIndex;
    public ImGuiTableFlags SettingsLoadedFlags;
    public int SettingsOffset;
    public int LastFrameActive;
    public int ColumnsCount;
    public int CurrentRow;
    public int CurrentColumn;
    public short InstanceCurrent;
    public short InstanceInteracted;
    public float RowPosY1;
    public float RowPosY2;
    public float RowMinHeight;
    public float RowTextBaseline;
    public float RowIndentOffsetX;
    public ImGuiTableRowFlags RowFlags;
    public ImGuiTableRowFlags LastRowFlags;
    public int RowBgColorCounter;
    public unsafe fixed uint RowBgColor[2];
    public uint BorderColorStrong;
    public uint BorderColorLight;
    public float BorderX1;
    public float BorderX2;
    public float HostIndentX;
    public float MinColumnWidth;
    public float OuterPaddingX;
    public float CellPaddingX;
    public float CellPaddingY;
    public float CellSpacingX1;
    public float CellSpacingX2;
    public float InnerWidth;
    public float ColumnsGivenWidth;
    public float ColumnsAutoFitWidth;
    public float ColumnsStretchSumWeights;
    public float ResizedColumnNextWidth;
    public float ResizeLockMinContentsX2;
    public float RefScale;
    public UnityEngine.Rect OuterRect;
    public UnityEngine.Rect InnerRect;
    public UnityEngine.Rect WorkRect;
    public UnityEngine.Rect InnerClipRect;
    public UnityEngine.Rect BgClipRect;
    public UnityEngine.Rect Bg0ClipRectForDrawCmd;
    public UnityEngine.Rect Bg2ClipRectForDrawCmd;
    public UnityEngine.Rect HostClipRect;
    public UnityEngine.Rect HostBackupInnerClipRect;
    public unsafe ImGuiWindow* OuterWindow;
    public unsafe ImGuiWindow* InnerWindow;
    public ImGuiTextBuffer ColumnsNames;
    public unsafe ImDrawListSplitter* DrawSplitter;
    public ImGuiTableInstanceData InstanceDataFirst;
    public ImVector InstanceDataExtra;
    public ImGuiTableColumnSortSpecs SortSpecsSingle;
    public ImVector SortSpecsMulti;
    public ImGuiTableSortSpecs SortSpecs;
    public System.SByte SortSpecsCount;
    public System.SByte ColumnsEnabledCount;
    public System.SByte ColumnsEnabledFixedCount;
    public System.SByte DeclColumnsCount;
    public System.SByte HoveredColumnBody;
    public System.SByte HoveredColumnBorder;
    public System.SByte AutoFitSingleColumn;
    public System.SByte ResizedColumn;
    public System.SByte LastResizedColumn;
    public System.SByte HeldHeaderColumn;
    public System.SByte ReorderColumn;
    public System.SByte ReorderColumnDir;
    public System.SByte LeftMostEnabledColumn;
    public System.SByte RightMostEnabledColumn;
    public System.SByte LeftMostStretchedColumn;
    public System.SByte RightMostStretchedColumn;
    public System.SByte ContextPopupColumn;
    public System.SByte FreezeRowsRequest;
    public System.SByte FreezeRowsCount;
    public System.SByte FreezeColumnsRequest;
    public System.SByte FreezeColumnsCount;
    public System.SByte RowCellDataCurrent;
    public byte DummyDrawChannel;
    public byte Bg2DrawChannelCurrent;
    public byte Bg2DrawChannelUnfrozen;
    public byte IsLayoutLocked;
    public byte IsInsideRow;
    public byte IsInitializing;
    public byte IsSortSpecsDirty;
    public byte IsUsingHeaders;
    public byte IsContextPopupOpen;
    public byte IsSettingsRequestLoad;
    public byte IsSettingsDirty;
    public byte IsDefaultDisplayOrder;
    public byte IsResetAllRequest;
    public byte IsResetDisplayOrderRequest;
    public byte IsUnfrozenRows;
    public byte IsDefaultSizingPolicy;
    public byte MemoryCompacted;
    public byte HostSkipItems;
  }
  public struct ImGuiTablePtr
  {
    public unsafe ImGuiTable* NativePtr { get => default; }
    public ref uint ID { get => ref __0; }
    public ref ImGuiTableFlags Flags { get => ref __1; }
    public System.IntPtr RawData { get => default; set { } }
    public ref ImGuiTableTempDataPtr TempData { get => ref __2; }
    public ref ImSpan Columns { get => ref __3; }
    public ref ImSpan DisplayOrderToIndex { get => ref __3; }
    public ref ImSpan RowCellData { get => ref __3; }
    public ref ulong EnabledMaskByDisplayOrder { get => ref __4; }
    public ref ulong EnabledMaskByIndex { get => ref __4; }
    public ref ulong VisibleMaskByIndex { get => ref __4; }
    public ref ulong RequestOutputMaskByIndex { get => ref __4; }
    public ref ImGuiTableFlags SettingsLoadedFlags { get => ref __1; }
    public ref int SettingsOffset { get => ref __5; }
    public ref int LastFrameActive { get => ref __5; }
    public ref int ColumnsCount { get => ref __5; }
    public ref int CurrentRow { get => ref __5; }
    public ref int CurrentColumn { get => ref __5; }
    public ref short InstanceCurrent { get => ref __6; }
    public ref short InstanceInteracted { get => ref __6; }
    public ref float RowPosY1 { get => ref __7; }
    public ref float RowPosY2 { get => ref __7; }
    public ref float RowMinHeight { get => ref __7; }
    public ref float RowTextBaseline { get => ref __7; }
    public ref float RowIndentOffsetX { get => ref __7; }
    public ref ImGuiTableRowFlags RowFlags { get => ref __8; }
    public ref ImGuiTableRowFlags LastRowFlags { get => ref __8; }
    public ref int RowBgColorCounter { get => ref __5; }
    public RangeAccessor<uint> RowBgColor { get => default; }
    public ref uint BorderColorStrong { get => ref __0; }
    public ref uint BorderColorLight { get => ref __0; }
    public ref float BorderX1 { get => ref __7; }
    public ref float BorderX2 { get => ref __7; }
    public ref float HostIndentX { get => ref __7; }
    public ref float MinColumnWidth { get => ref __7; }
    public ref float OuterPaddingX { get => ref __7; }
    public ref float CellPaddingX { get => ref __7; }
    public ref float CellPaddingY { get => ref __7; }
    public ref float CellSpacingX1 { get => ref __7; }
    public ref float CellSpacingX2 { get => ref __7; }
    public ref float InnerWidth { get => ref __7; }
    public ref float ColumnsGivenWidth { get => ref __7; }
    public ref float ColumnsAutoFitWidth { get => ref __7; }
    public ref float ColumnsStretchSumWeights { get => ref __7; }
    public ref float ResizedColumnNextWidth { get => ref __7; }
    public ref float ResizeLockMinContentsX2 { get => ref __7; }
    public ref float RefScale { get => ref __7; }
    public ref UnityEngine.Rect OuterRect { get => ref __9; }
    public ref UnityEngine.Rect InnerRect { get => ref __9; }
    public ref UnityEngine.Rect WorkRect { get => ref __9; }
    public ref UnityEngine.Rect InnerClipRect { get => ref __9; }
    public ref UnityEngine.Rect BgClipRect { get => ref __9; }
    public ref UnityEngine.Rect Bg0ClipRectForDrawCmd { get => ref __9; }
    public ref UnityEngine.Rect Bg2ClipRectForDrawCmd { get => ref __9; }
    public ref UnityEngine.Rect HostClipRect { get => ref __9; }
    public ref UnityEngine.Rect HostBackupInnerClipRect { get => ref __9; }
    public ref ImGuiWindowPtr OuterWindow { get => ref __10; }
    public ref ImGuiWindowPtr InnerWindow { get => ref __10; }
    public ref ImGuiTextBuffer ColumnsNames { get => ref __11; }
    public ref ImDrawListSplitterPtr DrawSplitter { get => ref __12; }
    public ref ImGuiTableInstanceData InstanceDataFirst { get => ref __13; }
    public ImPtrVector<ImGuiTableInstanceDataPtr> InstanceDataExtra { get => default; }
    public ref ImGuiTableColumnSortSpecs SortSpecsSingle { get => ref __14; }
    public ImPtrVector<ImGuiTableColumnSortSpecsPtr> SortSpecsMulti { get => default; }
    public ref ImGuiTableSortSpecs SortSpecs { get => ref __15; }
    public ref System.SByte SortSpecsCount { get => ref __16; }
    public ref System.SByte ColumnsEnabledCount { get => ref __16; }
    public ref System.SByte ColumnsEnabledFixedCount { get => ref __16; }
    public ref System.SByte DeclColumnsCount { get => ref __16; }
    public ref System.SByte HoveredColumnBody { get => ref __16; }
    public ref System.SByte HoveredColumnBorder { get => ref __16; }
    public ref System.SByte AutoFitSingleColumn { get => ref __16; }
    public ref System.SByte ResizedColumn { get => ref __16; }
    public ref System.SByte LastResizedColumn { get => ref __16; }
    public ref System.SByte HeldHeaderColumn { get => ref __16; }
    public ref System.SByte ReorderColumn { get => ref __16; }
    public ref System.SByte ReorderColumnDir { get => ref __16; }
    public ref System.SByte LeftMostEnabledColumn { get => ref __16; }
    public ref System.SByte RightMostEnabledColumn { get => ref __16; }
    public ref System.SByte LeftMostStretchedColumn { get => ref __16; }
    public ref System.SByte RightMostStretchedColumn { get => ref __16; }
    public ref System.SByte ContextPopupColumn { get => ref __16; }
    public ref System.SByte FreezeRowsRequest { get => ref __16; }
    public ref System.SByte FreezeRowsCount { get => ref __16; }
    public ref System.SByte FreezeColumnsRequest { get => ref __16; }
    public ref System.SByte FreezeColumnsCount { get => ref __16; }
    public ref System.SByte RowCellDataCurrent { get => ref __16; }
    public ref byte DummyDrawChannel { get => ref __17; }
    public ref byte Bg2DrawChannelCurrent { get => ref __17; }
    public ref byte Bg2DrawChannelUnfrozen { get => ref __17; }
    public ref bool IsLayoutLocked { get => ref __18; }
    public ref bool IsInsideRow { get => ref __18; }
    public ref bool IsInitializing { get => ref __18; }
    public ref bool IsSortSpecsDirty { get => ref __18; }
    public ref bool IsUsingHeaders { get => ref __18; }
    public ref bool IsContextPopupOpen { get => ref __18; }
    public ref bool IsSettingsRequestLoad { get => ref __18; }
    public ref bool IsSettingsDirty { get => ref __18; }
    public ref bool IsDefaultDisplayOrder { get => ref __18; }
    public ref bool IsResetAllRequest { get => ref __18; }
    public ref bool IsResetDisplayOrderRequest { get => ref __18; }
    public ref bool IsUnfrozenRows { get => ref __18; }
    public ref bool IsDefaultSizingPolicy { get => ref __18; }
    public ref bool MemoryCompacted { get => ref __18; }
    public ref bool HostSkipItems { get => ref __18; }
    public void ImGuiTable_destroy() { }
    internal static uint __0;
    internal static ImGuiTableFlags __1;
    internal static ImGuiTableTempDataPtr __2;
    internal static ImSpan __3;
    internal static ulong __4;
    internal static int __5;
    internal static short __6;
    internal static float __7;
    internal static ImGuiTableRowFlags __8;
    internal static UnityEngine.Rect __9;
    internal static ImGuiWindowPtr __10;
    internal static ImGuiTextBuffer __11;
    internal static ImDrawListSplitterPtr __12;
    internal static ImGuiTableInstanceData __13;
    internal static ImGuiTableColumnSortSpecs __14;
    internal static ImGuiTableSortSpecs __15;
    internal static System.SByte __16;
    internal static byte __17;
    internal static bool __18;
  }
  public enum ImGuiTableBgTarget
  {
    None = 0,
    RowBg0 = 1,
    RowBg1 = 2,
    CellBg = 3,
  }
  public struct ImGuiTableCellData
  {
    public uint BgColor;
    public System.SByte Column;
  }
  public struct ImGuiTableCellDataPtr
  {
    public unsafe ImGuiTableCellData* NativePtr { get => default; }
    public ref uint BgColor { get => ref __0; }
    public ref System.SByte Column { get => ref __1; }
    internal static uint __0;
    internal static System.SByte __1;
  }
  public struct ImGuiTableColumn
  {
    public ImGuiTableColumnFlags Flags;
    public float WidthGiven;
    public float MinX;
    public float MaxX;
    public float WidthRequest;
    public float WidthAuto;
    public float StretchWeight;
    public float InitStretchWeightOrWidth;
    public UnityEngine.Rect ClipRect;
    public uint UserID;
    public float WorkMinX;
    public float WorkMaxX;
    public float ItemWidth;
    public float ContentMaxXFrozen;
    public float ContentMaxXUnfrozen;
    public float ContentMaxXHeadersUsed;
    public float ContentMaxXHeadersIdeal;
    public short NameOffset;
    public System.SByte DisplayOrder;
    public System.SByte IndexWithinEnabledSet;
    public System.SByte PrevEnabledColumn;
    public System.SByte NextEnabledColumn;
    public System.SByte SortOrder;
    public byte DrawChannelCurrent;
    public byte DrawChannelFrozen;
    public byte DrawChannelUnfrozen;
    public byte IsEnabled;
    public byte IsUserEnabled;
    public byte IsUserEnabledNextFrame;
    public byte IsVisibleX;
    public byte IsVisibleY;
    public byte IsRequestOutput;
    public byte IsSkipItems;
    public byte IsPreserveWidthAuto;
    public System.SByte NavLayerCurrent;
    public byte AutoFitQueue;
    public byte CannotSkipItemsQueue;
    public byte SortDirection;
    public byte SortDirectionsAvailCount;
    public byte SortDirectionsAvailMask;
    public byte SortDirectionsAvailList;
  }
  public struct ImGuiTableColumnPtr
  {
    public unsafe ImGuiTableColumn* NativePtr { get => default; }
    public ref ImGuiTableColumnFlags Flags { get => ref __0; }
    public ref float WidthGiven { get => ref __1; }
    public ref float MinX { get => ref __1; }
    public ref float MaxX { get => ref __1; }
    public ref float WidthRequest { get => ref __1; }
    public ref float WidthAuto { get => ref __1; }
    public ref float StretchWeight { get => ref __1; }
    public ref float InitStretchWeightOrWidth { get => ref __1; }
    public ref UnityEngine.Rect ClipRect { get => ref __2; }
    public ref uint UserID { get => ref __3; }
    public ref float WorkMinX { get => ref __1; }
    public ref float WorkMaxX { get => ref __1; }
    public ref float ItemWidth { get => ref __1; }
    public ref float ContentMaxXFrozen { get => ref __1; }
    public ref float ContentMaxXUnfrozen { get => ref __1; }
    public ref float ContentMaxXHeadersUsed { get => ref __1; }
    public ref float ContentMaxXHeadersIdeal { get => ref __1; }
    public ref short NameOffset { get => ref __4; }
    public ref System.SByte DisplayOrder { get => ref __5; }
    public ref System.SByte IndexWithinEnabledSet { get => ref __5; }
    public ref System.SByte PrevEnabledColumn { get => ref __5; }
    public ref System.SByte NextEnabledColumn { get => ref __5; }
    public ref System.SByte SortOrder { get => ref __5; }
    public ref byte DrawChannelCurrent { get => ref __6; }
    public ref byte DrawChannelFrozen { get => ref __6; }
    public ref byte DrawChannelUnfrozen { get => ref __6; }
    public ref bool IsEnabled { get => ref __7; }
    public ref bool IsUserEnabled { get => ref __7; }
    public ref bool IsUserEnabledNextFrame { get => ref __7; }
    public ref bool IsVisibleX { get => ref __7; }
    public ref bool IsVisibleY { get => ref __7; }
    public ref bool IsRequestOutput { get => ref __7; }
    public ref bool IsSkipItems { get => ref __7; }
    public ref bool IsPreserveWidthAuto { get => ref __7; }
    public ref System.SByte NavLayerCurrent { get => ref __5; }
    public ref byte AutoFitQueue { get => ref __6; }
    public ref byte CannotSkipItemsQueue { get => ref __6; }
    public ref byte SortDirection { get => ref __6; }
    public ref byte SortDirectionsAvailCount { get => ref __6; }
    public ref byte SortDirectionsAvailMask { get => ref __6; }
    public ref byte SortDirectionsAvailList { get => ref __6; }
    public void ImGuiTableColumn_destroy() { }
    internal static ImGuiTableColumnFlags __0;
    internal static float __1;
    internal static UnityEngine.Rect __2;
    internal static uint __3;
    internal static short __4;
    internal static System.SByte __5;
    internal static byte __6;
    internal static bool __7;
  }
  public enum ImGuiTableColumnFlags
  {
    None = 0,
    Disabled = 1,
    DefaultHide = 2,
    DefaultSort = 4,
    WidthStretch = 8,
    WidthFixed = 16,
    WidthMask_ = 24,
    NoResize = 32,
    NoReorder = 64,
    NoHide = 128,
    NoClip = 256,
    NoSort = 512,
    NoSortAscending = 1024,
    NoSortDescending = 2048,
    NoHeaderLabel = 4096,
    NoHeaderWidth = 8192,
    PreferSortAscending = 16384,
    PreferSortDescending = 32768,
    IndentEnable = 65536,
    IndentDisable = 131072,
    IndentMask_ = 196608,
    IsEnabled = 16777216,
    IsVisible = 33554432,
    IsSorted = 67108864,
    IsHovered = 134217728,
    StatusMask_ = 251658240,
    NoDirectResize_ = 1073741824,
  }
  public struct ImGuiTableColumnSettings
  {
    public float WidthOrWeight;
    public uint UserID;
    public System.SByte Index;
    public System.SByte DisplayOrder;
    public System.SByte SortOrder;
    public byte SortDirection;
    public byte IsEnabled;
    public byte IsStretch;
  }
  public struct ImGuiTableColumnSettingsPtr
  {
    public unsafe ImGuiTableColumnSettings* NativePtr { get => default; }
    public ref float WidthOrWeight { get => ref __0; }
    public ref uint UserID { get => ref __1; }
    public ref System.SByte Index { get => ref __2; }
    public ref System.SByte DisplayOrder { get => ref __2; }
    public ref System.SByte SortOrder { get => ref __2; }
    public ref byte SortDirection { get => ref __3; }
    public ref byte IsEnabled { get => ref __3; }
    public ref byte IsStretch { get => ref __3; }
    public void ImGuiTableColumnSettings_destroy() { }
    internal static float __0;
    internal static uint __1;
    internal static System.SByte __2;
    internal static byte __3;
  }
  public struct ImGuiTableColumnSortSpecs
  {
    public uint ColumnUserID;
    public short ColumnIndex;
    public short SortOrder;
    public ImGuiSortDirection SortDirection;
  }
  public struct ImGuiTableColumnSortSpecsPtr
  {
    public unsafe ImGuiTableColumnSortSpecs* NativePtr { get => default; }
    public ref uint ColumnUserID { get => ref __0; }
    public ref short ColumnIndex { get => ref __1; }
    public ref short SortOrder { get => ref __1; }
    public ref ImGuiSortDirection SortDirection { get => ref __2; }
    public void ImGuiTableColumnSortSpecs_destroy() { }
    internal static uint __0;
    internal static short __1;
    internal static ImGuiSortDirection __2;
  }
  public enum ImGuiTableFlags
  {
    None = 0,
    Resizable = 1,
    Reorderable = 2,
    Hideable = 4,
    Sortable = 8,
    NoSavedSettings = 16,
    ContextMenuInBody = 32,
    RowBg = 64,
    BordersInnerH = 128,
    BordersOuterH = 256,
    BordersH = 384,
    BordersInnerV = 512,
    BordersInner = 640,
    BordersOuterV = 1024,
    BordersOuter = 1280,
    BordersV = 1536,
    Borders = 1920,
    NoBordersInBody = 2048,
    NoBordersInBodyUntilResize = 4096,
    SizingFixedFit = 8192,
    SizingFixedSame = 16384,
    SizingStretchProp = 24576,
    SizingStretchSame = 32768,
    SizingMask_ = 57344,
    NoHostExtendX = 65536,
    NoHostExtendY = 131072,
    NoKeepColumnsVisible = 262144,
    PreciseWidths = 524288,
    NoClip = 1048576,
    PadOuterX = 2097152,
    NoPadOuterX = 4194304,
    NoPadInnerX = 8388608,
    ScrollX = 16777216,
    ScrollY = 33554432,
    SortMulti = 67108864,
    SortTristate = 134217728,
  }
  public struct ImGuiTableInstanceData
  {
    public float LastOuterHeight;
    public float LastFirstRowHeight;
  }
  public struct ImGuiTableInstanceDataPtr
  {
    public unsafe ImGuiTableInstanceData* NativePtr { get => default; }
    public ref float LastOuterHeight { get => ref __0; }
    public ref float LastFirstRowHeight { get => ref __0; }
    public void ImGuiTableInstanceData_destroy() { }
    internal static float __0;
  }
  public enum ImGuiTableRowFlags
  {
    None = 0,
    Headers = 1,
  }
  public struct ImGuiTableSettings
  {
    public uint ID;
    public ImGuiTableFlags SaveFlags;
    public float RefScale;
    public System.SByte ColumnsCount;
    public System.SByte ColumnsCountMax;
    public byte WantApply;
  }
  public struct ImGuiTableSettingsPtr
  {
    public unsafe ImGuiTableSettings* NativePtr { get => default; }
    public ref uint ID { get => ref __0; }
    public ref ImGuiTableFlags SaveFlags { get => ref __1; }
    public ref float RefScale { get => ref __2; }
    public ref System.SByte ColumnsCount { get => ref __3; }
    public ref System.SByte ColumnsCountMax { get => ref __3; }
    public ref bool WantApply { get => ref __4; }
    public ImGuiTableColumnSettingsPtr GetColumnSettings() { return default; }
    public void ImGuiTableSettings_destroy() { }
    internal static uint __0;
    internal static ImGuiTableFlags __1;
    internal static float __2;
    internal static System.SByte __3;
    internal static bool __4;
  }
  public struct ImGuiTableSortSpecs
  {
    public unsafe ImGuiTableColumnSortSpecs* Specs;
    public int SpecsCount;
    public byte SpecsDirty;
  }
  public struct ImGuiTableSortSpecsPtr
  {
    public unsafe ImGuiTableSortSpecs* NativePtr { get => default; }
    public ref ImGuiTableColumnSortSpecsPtr Specs { get => ref __0; }
    public ref int SpecsCount { get => ref __1; }
    public ref bool SpecsDirty { get => ref __2; }
    public void ImGuiTableSortSpecs_destroy() { }
    internal static ImGuiTableColumnSortSpecsPtr __0;
    internal static int __1;
    internal static bool __2;
  }
  public struct ImGuiTableTempData
  {
    public int TableIndex;
    public float LastTimeActive;
    public UnityEngine.Vector2 UserOuterSize;
    public ImDrawListSplitter DrawSplitter;
    public UnityEngine.Rect HostBackupWorkRect;
    public UnityEngine.Rect HostBackupParentWorkRect;
    public UnityEngine.Vector2 HostBackupPrevLineSize;
    public UnityEngine.Vector2 HostBackupCurrLineSize;
    public UnityEngine.Vector2 HostBackupCursorMaxPos;
    public ImVec1 HostBackupColumnsOffset;
    public float HostBackupItemWidth;
    public int HostBackupItemWidthStackSize;
  }
  public struct ImGuiTableTempDataPtr
  {
    public unsafe ImGuiTableTempData* NativePtr { get => default; }
    public ref int TableIndex { get => ref __0; }
    public ref float LastTimeActive { get => ref __1; }
    public ref UnityEngine.Vector2 UserOuterSize { get => ref __2; }
    public ref ImDrawListSplitter DrawSplitter { get => ref __3; }
    public ref UnityEngine.Rect HostBackupWorkRect { get => ref __4; }
    public ref UnityEngine.Rect HostBackupParentWorkRect { get => ref __4; }
    public ref UnityEngine.Vector2 HostBackupPrevLineSize { get => ref __2; }
    public ref UnityEngine.Vector2 HostBackupCurrLineSize { get => ref __2; }
    public ref UnityEngine.Vector2 HostBackupCursorMaxPos { get => ref __2; }
    public ref ImVec1 HostBackupColumnsOffset { get => ref __5; }
    public ref float HostBackupItemWidth { get => ref __1; }
    public ref int HostBackupItemWidthStackSize { get => ref __0; }
    public void ImGuiTableTempData_destroy() { }
    internal static int __0;
    internal static float __1;
    internal static UnityEngine.Vector2 __2;
    internal static ImDrawListSplitter __3;
    internal static UnityEngine.Rect __4;
    internal static ImVec1 __5;
  }
  public struct ImGuiTextBuffer
  {
    public ImVector Buf;
  }
  public struct ImGuiTextBufferPtr
  {
    public unsafe ImGuiTextBuffer* NativePtr { get => default; }
    public ImVector<byte> Buf { get => default; }
    public void append(string str) { }
    public void append(string str, string str_end) { }
    public void appendf(string fmt) { }
    public void appendfv(string fmt) { }
    public string begin() { return default; }
    public string c_str() { return default; }
    public void clear() { }
    public void ImGuiTextBuffer_destroy() { }
    public bool empty() { return default; }
    public string end() { return default; }
    public void reserve(int capacity) { }
    public int size() { return default; }
  }
  public struct ImGuiTextFilter
  {
    public byte InputBuf_0;
    public byte InputBuf_1;
    public byte InputBuf_2;
    public byte InputBuf_3;
    public byte InputBuf_4;
    public byte InputBuf_5;
    public byte InputBuf_6;
    public byte InputBuf_7;
    public byte InputBuf_8;
    public byte InputBuf_9;
    public byte InputBuf_10;
    public byte InputBuf_11;
    public byte InputBuf_12;
    public byte InputBuf_13;
    public byte InputBuf_14;
    public byte InputBuf_15;
    public byte InputBuf_16;
    public byte InputBuf_17;
    public byte InputBuf_18;
    public byte InputBuf_19;
    public byte InputBuf_20;
    public byte InputBuf_21;
    public byte InputBuf_22;
    public byte InputBuf_23;
    public byte InputBuf_24;
    public byte InputBuf_25;
    public byte InputBuf_26;
    public byte InputBuf_27;
    public byte InputBuf_28;
    public byte InputBuf_29;
    public byte InputBuf_30;
    public byte InputBuf_31;
    public byte InputBuf_32;
    public byte InputBuf_33;
    public byte InputBuf_34;
    public byte InputBuf_35;
    public byte InputBuf_36;
    public byte InputBuf_37;
    public byte InputBuf_38;
    public byte InputBuf_39;
    public byte InputBuf_40;
    public byte InputBuf_41;
    public byte InputBuf_42;
    public byte InputBuf_43;
    public byte InputBuf_44;
    public byte InputBuf_45;
    public byte InputBuf_46;
    public byte InputBuf_47;
    public byte InputBuf_48;
    public byte InputBuf_49;
    public byte InputBuf_50;
    public byte InputBuf_51;
    public byte InputBuf_52;
    public byte InputBuf_53;
    public byte InputBuf_54;
    public byte InputBuf_55;
    public byte InputBuf_56;
    public byte InputBuf_57;
    public byte InputBuf_58;
    public byte InputBuf_59;
    public byte InputBuf_60;
    public byte InputBuf_61;
    public byte InputBuf_62;
    public byte InputBuf_63;
    public byte InputBuf_64;
    public byte InputBuf_65;
    public byte InputBuf_66;
    public byte InputBuf_67;
    public byte InputBuf_68;
    public byte InputBuf_69;
    public byte InputBuf_70;
    public byte InputBuf_71;
    public byte InputBuf_72;
    public byte InputBuf_73;
    public byte InputBuf_74;
    public byte InputBuf_75;
    public byte InputBuf_76;
    public byte InputBuf_77;
    public byte InputBuf_78;
    public byte InputBuf_79;
    public byte InputBuf_80;
    public byte InputBuf_81;
    public byte InputBuf_82;
    public byte InputBuf_83;
    public byte InputBuf_84;
    public byte InputBuf_85;
    public byte InputBuf_86;
    public byte InputBuf_87;
    public byte InputBuf_88;
    public byte InputBuf_89;
    public byte InputBuf_90;
    public byte InputBuf_91;
    public byte InputBuf_92;
    public byte InputBuf_93;
    public byte InputBuf_94;
    public byte InputBuf_95;
    public byte InputBuf_96;
    public byte InputBuf_97;
    public byte InputBuf_98;
    public byte InputBuf_99;
    public byte InputBuf_100;
    public byte InputBuf_101;
    public byte InputBuf_102;
    public byte InputBuf_103;
    public byte InputBuf_104;
    public byte InputBuf_105;
    public byte InputBuf_106;
    public byte InputBuf_107;
    public byte InputBuf_108;
    public byte InputBuf_109;
    public byte InputBuf_110;
    public byte InputBuf_111;
    public byte InputBuf_112;
    public byte InputBuf_113;
    public byte InputBuf_114;
    public byte InputBuf_115;
    public byte InputBuf_116;
    public byte InputBuf_117;
    public byte InputBuf_118;
    public byte InputBuf_119;
    public byte InputBuf_120;
    public byte InputBuf_121;
    public byte InputBuf_122;
    public byte InputBuf_123;
    public byte InputBuf_124;
    public byte InputBuf_125;
    public byte InputBuf_126;
    public byte InputBuf_127;
    public byte InputBuf_128;
    public byte InputBuf_129;
    public byte InputBuf_130;
    public byte InputBuf_131;
    public byte InputBuf_132;
    public byte InputBuf_133;
    public byte InputBuf_134;
    public byte InputBuf_135;
    public byte InputBuf_136;
    public byte InputBuf_137;
    public byte InputBuf_138;
    public byte InputBuf_139;
    public byte InputBuf_140;
    public byte InputBuf_141;
    public byte InputBuf_142;
    public byte InputBuf_143;
    public byte InputBuf_144;
    public byte InputBuf_145;
    public byte InputBuf_146;
    public byte InputBuf_147;
    public byte InputBuf_148;
    public byte InputBuf_149;
    public byte InputBuf_150;
    public byte InputBuf_151;
    public byte InputBuf_152;
    public byte InputBuf_153;
    public byte InputBuf_154;
    public byte InputBuf_155;
    public byte InputBuf_156;
    public byte InputBuf_157;
    public byte InputBuf_158;
    public byte InputBuf_159;
    public byte InputBuf_160;
    public byte InputBuf_161;
    public byte InputBuf_162;
    public byte InputBuf_163;
    public byte InputBuf_164;
    public byte InputBuf_165;
    public byte InputBuf_166;
    public byte InputBuf_167;
    public byte InputBuf_168;
    public byte InputBuf_169;
    public byte InputBuf_170;
    public byte InputBuf_171;
    public byte InputBuf_172;
    public byte InputBuf_173;
    public byte InputBuf_174;
    public byte InputBuf_175;
    public byte InputBuf_176;
    public byte InputBuf_177;
    public byte InputBuf_178;
    public byte InputBuf_179;
    public byte InputBuf_180;
    public byte InputBuf_181;
    public byte InputBuf_182;
    public byte InputBuf_183;
    public byte InputBuf_184;
    public byte InputBuf_185;
    public byte InputBuf_186;
    public byte InputBuf_187;
    public byte InputBuf_188;
    public byte InputBuf_189;
    public byte InputBuf_190;
    public byte InputBuf_191;
    public byte InputBuf_192;
    public byte InputBuf_193;
    public byte InputBuf_194;
    public byte InputBuf_195;
    public byte InputBuf_196;
    public byte InputBuf_197;
    public byte InputBuf_198;
    public byte InputBuf_199;
    public byte InputBuf_200;
    public byte InputBuf_201;
    public byte InputBuf_202;
    public byte InputBuf_203;
    public byte InputBuf_204;
    public byte InputBuf_205;
    public byte InputBuf_206;
    public byte InputBuf_207;
    public byte InputBuf_208;
    public byte InputBuf_209;
    public byte InputBuf_210;
    public byte InputBuf_211;
    public byte InputBuf_212;
    public byte InputBuf_213;
    public byte InputBuf_214;
    public byte InputBuf_215;
    public byte InputBuf_216;
    public byte InputBuf_217;
    public byte InputBuf_218;
    public byte InputBuf_219;
    public byte InputBuf_220;
    public byte InputBuf_221;
    public byte InputBuf_222;
    public byte InputBuf_223;
    public byte InputBuf_224;
    public byte InputBuf_225;
    public byte InputBuf_226;
    public byte InputBuf_227;
    public byte InputBuf_228;
    public byte InputBuf_229;
    public byte InputBuf_230;
    public byte InputBuf_231;
    public byte InputBuf_232;
    public byte InputBuf_233;
    public byte InputBuf_234;
    public byte InputBuf_235;
    public byte InputBuf_236;
    public byte InputBuf_237;
    public byte InputBuf_238;
    public byte InputBuf_239;
    public byte InputBuf_240;
    public byte InputBuf_241;
    public byte InputBuf_242;
    public byte InputBuf_243;
    public byte InputBuf_244;
    public byte InputBuf_245;
    public byte InputBuf_246;
    public byte InputBuf_247;
    public byte InputBuf_248;
    public byte InputBuf_249;
    public byte InputBuf_250;
    public byte InputBuf_251;
    public byte InputBuf_252;
    public byte InputBuf_253;
    public byte InputBuf_254;
    public byte InputBuf_255;
    public ImVector Filters;
    public int CountGrep;
  }
  public struct ImGuiTextFilterPtr
  {
    public unsafe ImGuiTextFilter* NativePtr { get => default; }
    public RangeAccessor<byte> InputBuf { get => default; }
    public ImPtrVector<ImGuiTextRangePtr> Filters { get => default; }
    public ref int CountGrep { get => ref __0; }
    public void Build() { }
    public void Clear() { }
    public bool Draw() { return default; }
    public bool Draw(string label) { return default; }
    public bool Draw(float width) { return default; }
    public bool Draw(string label, float width) { return default; }
    public bool IsActive() { return default; }
    public bool PassFilter(string text) { return default; }
    public bool PassFilter(string text, string text_end) { return default; }
    public void ImGuiTextFilter_destroy() { }
    internal static int __0;
  }
  public enum ImGuiTextFlags
  {
    None = 0,
    NoWidthForLargeClippedText = 1,
  }
  public struct ImGuiTextRange
  {
    public unsafe byte* b;
    public unsafe byte* e;
  }
  public struct ImGuiTextRangePtr
  {
    public unsafe ImGuiTextRange* NativePtr { get => default; }
    public ref string b { get => ref __0; }
    public ref string e { get => ref __0; }
    public void ImGuiTextRange_destroy() { }
    public bool empty() { return default; }
    public void split(byte separator, ImVector @out) { }
    internal static string __0;
  }
  public enum ImGuiTooltipFlags
  {
    None = 0,
    OverridePreviousTooltip = 1,
  }
  public enum ImGuiTreeNodeFlags
  {
    None = 0,
    Selected = 1,
    Framed = 2,
    AllowItemOverlap = 4,
    NoTreePushOnOpen = 8,
    NoAutoOpenOnLog = 16,
    CollapsingHeader = 26,
    DefaultOpen = 32,
    OpenOnDoubleClick = 64,
    OpenOnArrow = 128,
    Leaf = 256,
    Bullet = 512,
    FramePadding = 1024,
    SpanAvailWidth = 2048,
    SpanFullWidth = 4096,
    NavLeftJumpsBackHere = 8192,
  }
  public enum ImGuiTreeNodeFlagsPrivate
  {
    ClipLabelForTrailingButton = 1048576,
  }
  public struct ImGuiViewport
  {
    public ImGuiViewportFlags Flags;
    public UnityEngine.Vector2 Pos;
    public UnityEngine.Vector2 Size;
    public UnityEngine.Vector2 WorkPos;
    public UnityEngine.Vector2 WorkSize;
    public System.IntPtr PlatformHandleRaw;
  }
  public struct ImGuiViewportPtr
  {
    public unsafe ImGuiViewport* NativePtr { get => default; }
    public ref ImGuiViewportFlags Flags { get => ref __0; }
    public ref UnityEngine.Vector2 Pos { get => ref __1; }
    public ref UnityEngine.Vector2 Size { get => ref __1; }
    public ref UnityEngine.Vector2 WorkPos { get => ref __1; }
    public ref UnityEngine.Vector2 WorkSize { get => ref __1; }
    public System.IntPtr PlatformHandleRaw { get => default; set { } }
    public UnityEngine.Vector2 GetCenter() { return default; }
    public UnityEngine.Vector2 GetWorkCenter() { return default; }
    public void ImGuiViewport_destroy() { }
    internal static ImGuiViewportFlags __0;
    internal static UnityEngine.Vector2 __1;
  }
  public enum ImGuiViewportFlags
  {
    None = 0,
    IsPlatformWindow = 1,
    IsPlatformMonitor = 2,
    OwnedByApp = 4,
  }
  public struct ImGuiViewportP
  {
    public ImGuiViewport _ImGuiViewport;
    public unsafe fixed int DrawListsLastFrame[2];
    public unsafe ImDrawList* DrawLists_0;
    public unsafe ImDrawList* DrawLists_1;
    public ImDrawData DrawDataP;
    public ImDrawDataBuilder DrawDataBuilder;
    public UnityEngine.Vector2 WorkOffsetMin;
    public UnityEngine.Vector2 WorkOffsetMax;
    public UnityEngine.Vector2 BuildWorkOffsetMin;
    public UnityEngine.Vector2 BuildWorkOffsetMax;
  }
  public struct ImGuiViewportPPtr
  {
    public unsafe ImGuiViewportP* NativePtr { get => default; }
    public ref ImGuiViewport _ImGuiViewport { get => ref __0; }
    public RangeAccessor<int> DrawListsLastFrame { get => default; }
    public RangeAccessor<ImDrawListPtr> DrawLists { get => default; }
    public ref ImDrawData DrawDataP { get => ref __1; }
    public ref ImDrawDataBuilder DrawDataBuilder { get => ref __2; }
    public ref UnityEngine.Vector2 WorkOffsetMin { get => ref __3; }
    public ref UnityEngine.Vector2 WorkOffsetMax { get => ref __3; }
    public ref UnityEngine.Vector2 BuildWorkOffsetMin { get => ref __3; }
    public ref UnityEngine.Vector2 BuildWorkOffsetMax { get => ref __3; }
    public UnityEngine.Vector2 CalcWorkRectPos(UnityEngine.Vector2 off_min) { return default; }
    public UnityEngine.Vector2 CalcWorkRectSize(UnityEngine.Vector2 off_min, UnityEngine.Vector2 off_max) { return default; }
    public UnityEngine.Rect GetBuildWorkRect() { return default; }
    public UnityEngine.Rect GetMainRect() { return default; }
    public UnityEngine.Rect GetWorkRect() { return default; }
    public void UpdateWorkRect() { }
    public void ImGuiViewportP_destroy() { }
    internal static ImGuiViewport __0;
    internal static ImDrawData __1;
    internal static ImDrawDataBuilder __2;
    internal static UnityEngine.Vector2 __3;
  }
  public struct ImGuiWindow
  {
    public unsafe byte* Name;
    public uint ID;
    public ImGuiWindowFlags Flags;
    public unsafe ImGuiViewportP* Viewport;
    public UnityEngine.Vector2 Pos;
    public UnityEngine.Vector2 Size;
    public UnityEngine.Vector2 SizeFull;
    public UnityEngine.Vector2 ContentSize;
    public UnityEngine.Vector2 ContentSizeIdeal;
    public UnityEngine.Vector2 ContentSizeExplicit;
    public UnityEngine.Vector2 WindowPadding;
    public float WindowRounding;
    public float WindowBorderSize;
    public int NameBufLen;
    public uint MoveId;
    public uint ChildId;
    public UnityEngine.Vector2 Scroll;
    public UnityEngine.Vector2 ScrollMax;
    public UnityEngine.Vector2 ScrollTarget;
    public UnityEngine.Vector2 ScrollTargetCenterRatio;
    public UnityEngine.Vector2 ScrollTargetEdgeSnapDist;
    public UnityEngine.Vector2 ScrollbarSizes;
    public byte ScrollbarX;
    public byte ScrollbarY;
    public byte Active;
    public byte WasActive;
    public byte WriteAccessed;
    public byte Collapsed;
    public byte WantCollapseToggle;
    public byte SkipItems;
    public byte Appearing;
    public byte Hidden;
    public byte IsFallbackWindow;
    public byte IsExplicitChild;
    public byte HasCloseButton;
    public System.SByte ResizeBorderHeld;
    public short BeginCount;
    public short BeginOrderWithinParent;
    public short BeginOrderWithinContext;
    public short FocusOrder;
    public uint PopupId;
    public System.SByte AutoFitFramesX;
    public System.SByte AutoFitFramesY;
    public System.SByte AutoFitChildAxises;
    public byte AutoFitOnlyGrows;
    public ImGuiDir AutoPosLastDirection;
    public System.SByte HiddenFramesCanSkipItems;
    public System.SByte HiddenFramesCannotSkipItems;
    public System.SByte HiddenFramesForRenderOnly;
    public System.SByte DisableInputsFrames;
    public ImGuiCond SetWindowPosAllowFlags;
    public ImGuiCond SetWindowSizeAllowFlags;
    public ImGuiCond SetWindowCollapsedAllowFlags;
    public UnityEngine.Vector2 SetWindowPosVal;
    public UnityEngine.Vector2 SetWindowPosPivot;
    public ImVector IDStack;
    public ImGuiWindowTempData DC;
    public UnityEngine.Rect OuterRectClipped;
    public UnityEngine.Rect InnerRect;
    public UnityEngine.Rect InnerClipRect;
    public UnityEngine.Rect WorkRect;
    public UnityEngine.Rect ParentWorkRect;
    public UnityEngine.Rect ClipRect;
    public UnityEngine.Rect ContentRegionRect;
    public Vector2ih HitTestHoleSize;
    public Vector2ih HitTestHoleOffset;
    public int LastFrameActive;
    public float LastTimeActive;
    public float ItemWidthDefault;
    public ImGuiStorage StateStorage;
    public ImVector ColumnsStorage;
    public float FontWindowScale;
    public int SettingsOffset;
    public unsafe ImDrawList* DrawList;
    public ImDrawList DrawListInst;
    public unsafe ImGuiWindow* ParentWindow;
    public unsafe ImGuiWindow* ParentWindowInBeginStack;
    public unsafe ImGuiWindow* RootWindow;
    public unsafe ImGuiWindow* RootWindowPopupTree;
    public unsafe ImGuiWindow* RootWindowForTitleBarHighlight;
    public unsafe ImGuiWindow* RootWindowForNav;
    public unsafe ImGuiWindow* NavLastChildNavWindow;
    public unsafe fixed uint NavLastIds[2];
    public UnityEngine.Rect NavRectRel_0;
    public UnityEngine.Rect NavRectRel_1;
    public int MemoryDrawListIdxCapacity;
    public int MemoryDrawListVtxCapacity;
    public byte MemoryCompacted;
  }
  public struct ImGuiWindowPtr
  {
    public unsafe ImGuiWindow* NativePtr { get => default; }
    public System.IntPtr Name { get => default; set { } }
    public ref uint ID { get => ref __0; }
    public ref ImGuiWindowFlags Flags { get => ref __1; }
    public ref ImGuiViewportPPtr Viewport { get => ref __2; }
    public ref UnityEngine.Vector2 Pos { get => ref __3; }
    public ref UnityEngine.Vector2 Size { get => ref __3; }
    public ref UnityEngine.Vector2 SizeFull { get => ref __3; }
    public ref UnityEngine.Vector2 ContentSize { get => ref __3; }
    public ref UnityEngine.Vector2 ContentSizeIdeal { get => ref __3; }
    public ref UnityEngine.Vector2 ContentSizeExplicit { get => ref __3; }
    public ref UnityEngine.Vector2 WindowPadding { get => ref __3; }
    public ref float WindowRounding { get => ref __4; }
    public ref float WindowBorderSize { get => ref __4; }
    public ref int NameBufLen { get => ref __5; }
    public ref uint MoveId { get => ref __0; }
    public ref uint ChildId { get => ref __0; }
    public ref UnityEngine.Vector2 Scroll { get => ref __3; }
    public ref UnityEngine.Vector2 ScrollMax { get => ref __3; }
    public ref UnityEngine.Vector2 ScrollTarget { get => ref __3; }
    public ref UnityEngine.Vector2 ScrollTargetCenterRatio { get => ref __3; }
    public ref UnityEngine.Vector2 ScrollTargetEdgeSnapDist { get => ref __3; }
    public ref UnityEngine.Vector2 ScrollbarSizes { get => ref __3; }
    public ref bool ScrollbarX { get => ref __6; }
    public ref bool ScrollbarY { get => ref __6; }
    public ref bool Active { get => ref __6; }
    public ref bool WasActive { get => ref __6; }
    public ref bool WriteAccessed { get => ref __6; }
    public ref bool Collapsed { get => ref __6; }
    public ref bool WantCollapseToggle { get => ref __6; }
    public ref bool SkipItems { get => ref __6; }
    public ref bool Appearing { get => ref __6; }
    public ref bool Hidden { get => ref __6; }
    public ref bool IsFallbackWindow { get => ref __6; }
    public ref bool IsExplicitChild { get => ref __6; }
    public ref bool HasCloseButton { get => ref __6; }
    public ref System.SByte ResizeBorderHeld { get => ref __7; }
    public ref short BeginCount { get => ref __8; }
    public ref short BeginOrderWithinParent { get => ref __8; }
    public ref short BeginOrderWithinContext { get => ref __8; }
    public ref short FocusOrder { get => ref __8; }
    public ref uint PopupId { get => ref __0; }
    public ref System.SByte AutoFitFramesX { get => ref __7; }
    public ref System.SByte AutoFitFramesY { get => ref __7; }
    public ref System.SByte AutoFitChildAxises { get => ref __7; }
    public ref bool AutoFitOnlyGrows { get => ref __6; }
    public ref ImGuiDir AutoPosLastDirection { get => ref __9; }
    public ref System.SByte HiddenFramesCanSkipItems { get => ref __7; }
    public ref System.SByte HiddenFramesCannotSkipItems { get => ref __7; }
    public ref System.SByte HiddenFramesForRenderOnly { get => ref __7; }
    public ref System.SByte DisableInputsFrames { get => ref __7; }
    public ref ImGuiCond SetWindowPosAllowFlags { get => ref __10; }
    public ref ImGuiCond SetWindowSizeAllowFlags { get => ref __10; }
    public ref ImGuiCond SetWindowCollapsedAllowFlags { get => ref __10; }
    public ref UnityEngine.Vector2 SetWindowPosVal { get => ref __3; }
    public ref UnityEngine.Vector2 SetWindowPosPivot { get => ref __3; }
    public ImVector<uint> IDStack { get => default; }
    public ref ImGuiWindowTempData DC { get => ref __11; }
    public ref UnityEngine.Rect OuterRectClipped { get => ref __12; }
    public ref UnityEngine.Rect InnerRect { get => ref __12; }
    public ref UnityEngine.Rect InnerClipRect { get => ref __12; }
    public ref UnityEngine.Rect WorkRect { get => ref __12; }
    public ref UnityEngine.Rect ParentWorkRect { get => ref __12; }
    public ref UnityEngine.Rect ClipRect { get => ref __12; }
    public ref UnityEngine.Rect ContentRegionRect { get => ref __12; }
    public ref Vector2ih HitTestHoleSize { get => ref __13; }
    public ref Vector2ih HitTestHoleOffset { get => ref __13; }
    public ref int LastFrameActive { get => ref __5; }
    public ref float LastTimeActive { get => ref __4; }
    public ref float ItemWidthDefault { get => ref __4; }
    public ref ImGuiStorage StateStorage { get => ref __14; }
    public ImPtrVector<ImGuiOldColumnsPtr> ColumnsStorage { get => default; }
    public ref float FontWindowScale { get => ref __4; }
    public ref int SettingsOffset { get => ref __5; }
    public ref ImDrawListPtr DrawList { get => ref __15; }
    public ref ImDrawList DrawListInst { get => ref __16; }
    public ref ImGuiWindowPtr ParentWindow { get => ref __17; }
    public ref ImGuiWindowPtr ParentWindowInBeginStack { get => ref __17; }
    public ref ImGuiWindowPtr RootWindow { get => ref __17; }
    public ref ImGuiWindowPtr RootWindowPopupTree { get => ref __17; }
    public ref ImGuiWindowPtr RootWindowForTitleBarHighlight { get => ref __17; }
    public ref ImGuiWindowPtr RootWindowForNav { get => ref __17; }
    public ref ImGuiWindowPtr NavLastChildNavWindow { get => ref __17; }
    public RangeAccessor<uint> NavLastIds { get => default; }
    public RangeAccessor<UnityEngine.Rect> NavRectRel { get => default; }
    public ref int MemoryDrawListIdxCapacity { get => ref __5; }
    public ref int MemoryDrawListVtxCapacity { get => ref __5; }
    public ref bool MemoryCompacted { get => ref __6; }
    public float CalcFontSize() { return default; }
    public uint GetID(string str) { return default; }
    public uint GetID(string str, string str_end) { return default; }
    public uint GetID(System.IntPtr ptr) { return default; }
    public uint GetID(int n) { return default; }
    public uint GetIDFromRectangle(UnityEngine.Rect r_abs) { return default; }
    public float MenuBarHeight() { return default; }
    public UnityEngine.Rect MenuBarRect() { return default; }
    public UnityEngine.Rect Rect() { return default; }
    public float TitleBarHeight() { return default; }
    public UnityEngine.Rect TitleBarRect() { return default; }
    public void ImGuiWindow_destroy() { }
    internal static uint __0;
    internal static ImGuiWindowFlags __1;
    internal static ImGuiViewportPPtr __2;
    internal static UnityEngine.Vector2 __3;
    internal static float __4;
    internal static int __5;
    internal static bool __6;
    internal static System.SByte __7;
    internal static short __8;
    internal static ImGuiDir __9;
    internal static ImGuiCond __10;
    internal static ImGuiWindowTempData __11;
    internal static UnityEngine.Rect __12;
    internal static Vector2ih __13;
    internal static ImGuiStorage __14;
    internal static ImDrawListPtr __15;
    internal static ImDrawList __16;
    internal static ImGuiWindowPtr __17;
  }
  public enum ImGuiWindowFlags
  {
    None = 0,
    NoTitleBar = 1,
    NoResize = 2,
    NoMove = 4,
    NoScrollbar = 8,
    NoScrollWithMouse = 16,
    NoCollapse = 32,
    NoDecoration = 43,
    AlwaysAutoResize = 64,
    NoBackground = 128,
    NoSavedSettings = 256,
    NoMouseInputs = 512,
    MenuBar = 1024,
    HorizontalScrollbar = 2048,
    NoFocusOnAppearing = 4096,
    NoBringToFrontOnFocus = 8192,
    AlwaysVerticalScrollbar = 16384,
    AlwaysHorizontalScrollbar = 32768,
    AlwaysUseWindowPadding = 65536,
    NoNavInputs = 262144,
    NoNavFocus = 524288,
    NoNav = 786432,
    NoInputs = 786944,
    UnsavedDocument = 1048576,
    NavFlattened = 8388608,
    ChildWindow = 16777216,
    Tooltip = 33554432,
    Popup = 67108864,
    Modal = 134217728,
    ChildMenu = 268435456,
  }
  public struct ImGuiWindowTempData
  {
    public UnityEngine.Vector2 CursorPos;
    public UnityEngine.Vector2 CursorPosPrevLine;
    public UnityEngine.Vector2 CursorStartPos;
    public UnityEngine.Vector2 CursorMaxPos;
    public UnityEngine.Vector2 IdealMaxPos;
    public UnityEngine.Vector2 CurrLineSize;
    public UnityEngine.Vector2 PrevLineSize;
    public float CurrLineTextBaseOffset;
    public float PrevLineTextBaseOffset;
    public byte IsSameLine;
    public ImVec1 Indent;
    public ImVec1 ColumnsOffset;
    public ImVec1 GroupOffset;
    public UnityEngine.Vector2 CursorStartPosLossyness;
    public ImGuiNavLayer NavLayerCurrent;
    public short NavLayersActiveMask;
    public short NavLayersActiveMaskNext;
    public uint NavFocusScopeIdCurrent;
    public byte NavHideHighlightOneFrame;
    public byte NavHasScroll;
    public byte MenuBarAppending;
    public UnityEngine.Vector2 MenuBarOffset;
    public ImGuiMenuColumns MenuColumns;
    public int TreeDepth;
    public uint TreeJumpToParentOnPopMask;
    public ImVector ChildWindows;
    public unsafe ImGuiStorage* StateStorage;
    public unsafe ImGuiOldColumns* CurrentColumns;
    public int CurrentTableIdx;
    public ImGuiLayoutType LayoutType;
    public ImGuiLayoutType ParentLayoutType;
    public float ItemWidth;
    public float TextWrapPos;
    public ImVector ItemWidthStack;
    public ImVector TextWrapPosStack;
  }
  public struct ImGuiWindowTempDataPtr
  {
    public unsafe ImGuiWindowTempData* NativePtr { get => default; }
    public ref UnityEngine.Vector2 CursorPos { get => ref __0; }
    public ref UnityEngine.Vector2 CursorPosPrevLine { get => ref __0; }
    public ref UnityEngine.Vector2 CursorStartPos { get => ref __0; }
    public ref UnityEngine.Vector2 CursorMaxPos { get => ref __0; }
    public ref UnityEngine.Vector2 IdealMaxPos { get => ref __0; }
    public ref UnityEngine.Vector2 CurrLineSize { get => ref __0; }
    public ref UnityEngine.Vector2 PrevLineSize { get => ref __0; }
    public ref float CurrLineTextBaseOffset { get => ref __1; }
    public ref float PrevLineTextBaseOffset { get => ref __1; }
    public ref bool IsSameLine { get => ref __2; }
    public ref ImVec1 Indent { get => ref __3; }
    public ref ImVec1 ColumnsOffset { get => ref __3; }
    public ref ImVec1 GroupOffset { get => ref __3; }
    public ref UnityEngine.Vector2 CursorStartPosLossyness { get => ref __0; }
    public ref ImGuiNavLayer NavLayerCurrent { get => ref __4; }
    public ref short NavLayersActiveMask { get => ref __5; }
    public ref short NavLayersActiveMaskNext { get => ref __5; }
    public ref uint NavFocusScopeIdCurrent { get => ref __6; }
    public ref bool NavHideHighlightOneFrame { get => ref __2; }
    public ref bool NavHasScroll { get => ref __2; }
    public ref bool MenuBarAppending { get => ref __2; }
    public ref UnityEngine.Vector2 MenuBarOffset { get => ref __0; }
    public ref ImGuiMenuColumns MenuColumns { get => ref __7; }
    public ref int TreeDepth { get => ref __8; }
    public ref uint TreeJumpToParentOnPopMask { get => ref __6; }
    public ImVector<ImGuiWindowPtr> ChildWindows { get => default; }
    public ref ImGuiStoragePtr StateStorage { get => ref __9; }
    public ref ImGuiOldColumnsPtr CurrentColumns { get => ref __10; }
    public ref int CurrentTableIdx { get => ref __8; }
    public ref ImGuiLayoutType LayoutType { get => ref __11; }
    public ref ImGuiLayoutType ParentLayoutType { get => ref __11; }
    public ref float ItemWidth { get => ref __1; }
    public ref float TextWrapPos { get => ref __1; }
    public ImVector<float> ItemWidthStack { get => default; }
    public ImVector<float> TextWrapPosStack { get => default; }
    internal static UnityEngine.Vector2 __0;
    internal static float __1;
    internal static bool __2;
    internal static ImVec1 __3;
    internal static ImGuiNavLayer __4;
    internal static short __5;
    internal static uint __6;
    internal static ImGuiMenuColumns __7;
    internal static int __8;
    internal static ImGuiStoragePtr __9;
    internal static ImGuiOldColumnsPtr __10;
    internal static ImGuiLayoutType __11;
  }
  public struct ImSpanAllocator
  {
  }
  public struct ImSpanAllocatorPtr
  {
    public unsafe ImSpanAllocator* NativePtr { get => default; }
    public int GetArenaSizeInBytes() { return default; }
    public unsafe void* GetSpanPtrBegin(int n) { return default; }
    public unsafe void* GetSpanPtrEnd(int n) { return default; }
    public void Reserve(int n, uint sz) { }
    public void Reserve(int n, uint sz, int a) { }
    public void SetArenaBasePtr(System.IntPtr base_ptr) { }
    public void ImSpanAllocator_destroy() { }
  }
  public struct ImVec1
  {
    public float x;
  }
  public struct ImVec1Ptr
  {
    public unsafe ImVec1* NativePtr { get => default; }
    public ref float x { get => ref __0; }
    public void ImVec1_destroy() { }
    internal static float __0;
  }
  public class ColorExtensions
  {
    public static UnityEngine.Color32 ToColor32(uint rgba) { return default; }
    public static UnityEngine.Color ToColor(uint rgba) { return default; }
    public static uint ToUint(UnityEngine.Color32 c32) { return default; }
    public static uint ToUint(UnityEngine.Color color) { return default; }
  }
  public delegate int ImGuiInputTextSafeCallback(ImGuiInputTextCallbackDataPtr data);
  public delegate void ImGuiSizeSafeCallback(ImGuiSizeCallbackDataPtr data);
  public class ImFreetype
  {
    public static bool BuildFontAtlas(ImFontAtlasPtr atlas, ImFreetype.RasterizerFlags extra_flags) { return default; }
    public enum RasterizerFlags
    {
      None = 0,
      NoHinting = 1,
      NoAutoHint = 2,
      ForceAutoHint = 4,
      LightHinting = 8,
      MonoHinting = 16,
      Bold = 32,
      Oblique = 64,
      MonoChrome = 128,
    }
  }
  public unsafe delegate void ImDrawCallback(ImDrawList* parent_list, ImDrawCmd* cmd);
  public unsafe delegate void ImGuiSizeCallback(ImGuiSizeCallbackData* data);
  public unsafe delegate int ImGuiInputTextCallback(ImGuiInputTextCallbackData* data);
  public struct ImSpan
  {
    public int Size;
    public int Capacity;
    public System.IntPtr Data;
    public ref T Ref<T>(int index) { return ref ImSpan<T>.__0; }
    public System.IntPtr Address<T>(int index) { return default; }
  }
  public struct ImSpan<T>
  {
    public int Size;
    public int Capacity;
    public System.IntPtr Data;
    public ref T Item { get => ref __0; }
    internal static T __0;
  }
  public struct ImPtrSpan<T>
  {
    public int Size;
    public int Capacity;
    public System.IntPtr Data;
    public T Item { get => default; }
  }
  public struct ImVector
  {
    public int Size;
    public int Capacity;
    public System.IntPtr Data;
    public ref T Ref<T>(int index) { return ref ImVector<T>.__0; }
    public System.IntPtr Address<T>(int index) { return default; }
  }
  public struct ImVector<T>
  {
    public int Size;
    public int Capacity;
    public System.IntPtr Data;
    public ref T Item { get => ref __0; }
    internal static T __0;
  }
  public struct ImPtrVector<T>
  {
    public int Size;
    public int Capacity;
    public System.IntPtr Data;
    public T Item { get => default; }
  }
  public class IntPtrEqualityComparer
  {
    public static IntPtrEqualityComparer Instance { get => default; }
    public bool Equals(System.IntPtr p1, System.IntPtr p2) { return default; }
    public int GetHashCode(System.IntPtr ptr) { return default; }
  }
  public struct NullTerminatedString
  {
    public unsafe byte* Data;
  }
  public struct ImGuiStoragePair
  {
    public uint Key;
    public UnionValue Value;
  }
  public struct ImGuiStoragePairPtr
  {
    public unsafe ImGuiStoragePair* NativePtr { get => default; }
  }
  public struct UnionValue
  {
    public int ValueI32;
    public float ValueF32;
    public System.IntPtr ValuePtr;
  }
  public struct RangeAccessor<T>
  {
    public unsafe void* Data;
    public int Count;
    public ref T Item { get => ref __0; }
    internal static T __0;
  }
  public struct RangePtrAccessor<T>
  {
    public unsafe void* Data;
    public int Count;
    public T Item { get => default; }
  }
  public class RangeAccessorExtensions
  {
    public static string GetStringASCII(RangeAccessor<byte> stringAccessor) { return default; }
  }
  public class ImGuiDebug
  {
    public static bool EnableLogging;
    public static bool LogFrame;
    public static bool LogNextFrame;
    public static int LogIndent;
    public static bool LoggingEnabled { get => default; }
    public static string LogPad { get => default; }
    public static void Log(string text) { }
  }
  public struct Vector2ih
  {
    public short x;
    public short y;
  }
  public class MarshalUtils
  {
    public static unsafe System.IntPtr pointer_to_IntPtr(void* inData) { return default; }
    public static unsafe void* IntPtr_to_pointer(System.IntPtr inData) { return default; }
    public static unsafe void** IntPtr_to_pointerPointer(System.IntPtr inData) { return default; }
    public static bool byte_to_bool(byte inByte) { return default; }
    public static byte bool_to_byte(bool inBool) { return default; }
    public static unsafe byte boolPointer_to_byte(System.Boolean* inBoolPointer) { return default; }
    public static unsafe string bytePointer_to_string(byte* inLiteral) { return default; }
    public static int GetByteCount(string inString) { return default; }
  }
  public struct StbTexteditRow
  {
    public float x0;
    public float x1;
    public float baseline_y_delta;
    public float ymin;
    public float ymax;
    public int num_chars;
  }
  public struct StbTexteditRowPtr
  {
    public unsafe StbTexteditRow* NativePtr { get => default; }
    public ref float x0 { get => ref __0; }
    public ref float x1 { get => ref __0; }
    public ref float baseline_y_delta { get => ref __0; }
    public ref float ymin { get => ref __0; }
    public ref float ymax { get => ref __0; }
    public ref int num_chars { get => ref __1; }
    internal static float __0;
    internal static int __1;
  }
  public struct StbUndoRecord
  {
    public int where;
    public int insert_length;
    public int delete_length;
    public int char_storage;
  }
  public struct StbUndoRecordPtr
  {
    public unsafe StbUndoRecord* NativePtr { get => default; }
    public ref int where { get => ref __0; }
    public ref int insert_length { get => ref __0; }
    public ref int delete_length { get => ref __0; }
    public ref int char_storage { get => ref __0; }
    internal static int __0;
  }
}
