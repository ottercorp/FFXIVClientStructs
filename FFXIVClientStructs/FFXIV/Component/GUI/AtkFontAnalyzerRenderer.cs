namespace FFXIVClientStructs.FFXIV.Component.GUI;

// Component::GUI::AtkFontAnalyzerRenderer
//   Component::GUI::AtkFontAnalyzerBase
//   Component::GUI::AtkFontAnalyzerRenderCount
[GenerateInterop]
[Inherits<AtkFontAnalyzerBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x940)]
[VirtualTable("48 8D 05 ?? ?? ?? ?? 48 89 83 18 01 00 00 48 8D 05 ?? ?? ?? ?? 48 89 BB ?? ?? ?? ??", 3)]
public partial struct AtkFontAnalyzerRenderer {
    [FieldOffset(0x1E0)] public AtkFontAnalyzerRenderCount AtkFontAnalyzerRenderCount;
}
