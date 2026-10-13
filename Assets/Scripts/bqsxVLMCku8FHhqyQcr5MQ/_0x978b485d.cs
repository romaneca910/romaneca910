using TMPro;
using UnityEngine;

// Runtime-created captions never reach stage 5c3 (it reads scenes and prefabs), so the
// outline has to be set here, on an INSTANCED material - reading fontMaterial clones it
// and leaves the shared asset alone. This app's shared outline is light cream, so a dark
// face gets that cream outline and a light face would get an ink one instead.
public static class _0x978b485d
{
    public static void ApplyOutline(TMP_Text _0xc3cf43aa, Color _0xee666387)
    {
        if (_0xc3cf43aa == null)
            return;
        _0xc3cf43aa.color = _0xee666387;
        Material _0x09ed4989 = _0xc3cf43aa.fontMaterial;
        if (_0x09ed4989 == null)
            return;
        float _0x56723763 = 0.299f * _0xee666387.r + 0.587f * _0xee666387.g + 0.114f * _0xee666387.b;
        _0x09ed4989.SetColor(ShaderUtilities.ID_OutlineColor, _0x56723763 < 0.5f ? _0xcc07f46d.Cream : _0xcc07f46d.Ink);
        _0x09ed4989.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.22f);
    }

    // Wrapping OFF, breaks by hand, autosize ALWAYS on, minimum at the readability floor
    // (rule C.10 / C.12). A line that will not fit gets another '\n', never a lower floor.
    public static void Shape(TMP_Text _0xec6eeb0e, float _0xd1388b0f, float _0x9a45403e)
    {
        if (_0xec6eeb0e == null)
            return;
        _0xec6eeb0e.textWrappingMode = TextWrappingModes.NoWrap;
        _0xec6eeb0e.overflowMode = TextOverflowModes.Overflow;
        _0xec6eeb0e.enableAutoSizing = true;
        _0xec6eeb0e.fontSizeMin = _0xd1388b0f < 24f ? 24f : _0xd1388b0f;
        _0xec6eeb0e.fontSizeMax = _0x9a45403e;
        _0xec6eeb0e.fontSize = _0x9a45403e;
    }
}