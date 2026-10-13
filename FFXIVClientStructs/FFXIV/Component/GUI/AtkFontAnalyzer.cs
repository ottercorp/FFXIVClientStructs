namespace FFXIVClientStructs.FFXIV.Component.GUI;

[StructLayout(LayoutKind.Explicit, Size = 0xDA0)]
public unsafe struct AtkFontAnalyzer {
    [FieldOffset(0x008)] public AtkFontAnalyzerCount AtkFontAnalyzerCount;
    [FieldOffset(0x078)] public AtkFontAnalyzerDrawSize AtkFontAnalyzerDrawSize;
    // CN's renderer uses the larger 21-texture buffers, shifting the following analyzers.
    [FieldOffset(0xA58)] public AtkFontAnalyzerSearchPosition AtkFontAnalyzerSearchPosition;
    [FieldOffset(0xB10)] public AtkFontAnalyzerCRLFCount AtkFontAnalyzerCRLFCount;
    [FieldOffset(0xB78)] public AtkFontAnalyzerCRLFSearch AtkFontAnalyzerCRLFSearch;
    [FieldOffset(0xBE8)] public AtkFontAnalyzerBuildLink AtkFontAnalyzerBuildLink;
    [FieldOffset(0xCA0)] public AtkFontAnalyzerCreateCache AtkFontAnalyzerCreateCache;
    [FieldOffset(0xD10)] public AtkFontAnalyzerCheckStringOnlyNumSymbol AtkFontAnalyzerCheckStringOnlyNumSymbol;
    [FieldOffset(0xD78)] public AtkFontAnalyzerFunctor AtkFontAnalyzerFunctor;
    [FieldOffset(0xD80)] public AtkFontAnalyzerFunctorSelect AtkFontAnalyzerFunctorSelect;
}
