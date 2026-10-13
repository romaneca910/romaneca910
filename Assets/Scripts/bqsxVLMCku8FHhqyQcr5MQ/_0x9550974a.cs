using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x9550974a : MonoBehaviour
{
    private readonly List<TMP_Text> _0xb44e394e = new List<TMP_Text>();
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xbf450cc3;
    private static float Ratio(Color _0x5287626e, Color _0x840a5c7f)
    {
        float _0xfc4dc9dc = Luminance(_0x5287626e);
        float _0x9f2beeb7 = Luminance(_0x840a5c7f);
        return (Mathf.Max(_0xfc4dc9dc, _0x9f2beeb7) + 0.05f) / (Mathf.Min(_0xfc4dc9dc, _0x9f2beeb7) + 0.05f);
    }

    private static void Fix(TMP_Text _0xe673de2e)
    {
        if (_0xe673de2e == null || !_0xe673de2e.isActiveAndEnabled)
            return;
        Material _0xb0eb9996 = _0xe673de2e.fontSharedMaterial;
        if (_0xb0eb9996 == null || !_0xb0eb9996.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xb0eb9996.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xb0eb9996.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x6a1c29fd = _0xe673de2e.color;
        if (_0x6a1c29fd.a <= 0f)
            return;
        Color _0xe0790bba = _0xb0eb9996.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x6a1c29fd, _0xe0790bba) >= MinRatio)
            return;
        Color _0x6da3ba24 = Luminance(_0xe0790bba) < 0.5f ? Color.white : Color.black;
        Color _0x911eaac4;
        if (Ratio(_0x6da3ba24, _0xe0790bba) < TargetRatio)
        {
            _0x911eaac4 = _0x6da3ba24;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x230877ed = 0f;
            float _0x13f70369 = 1f;
            for (int _0xfcd48f56 = 0; _0xfcd48f56 < 20; _0xfcd48f56++)
            {
                float _0x17ca1cee = (_0x230877ed + _0x13f70369) * 0.5f;
                if (Ratio(Color.Lerp(_0x6a1c29fd, _0x6da3ba24, _0x17ca1cee), _0xe0790bba) >= TargetRatio)
                    _0x13f70369 = _0x17ca1cee;
                else
                    _0x230877ed = _0x17ca1cee;
            }

            _0x911eaac4 = Color.Lerp(_0x6a1c29fd, _0x6da3ba24, _0x13f70369);
        }

        _0x911eaac4.a = _0x6a1c29fd.a;
        _0xe673de2e.color = _0x911eaac4;
    }

    private void OnDisable()
    {
        if (this._0xbf450cc3 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xbf450cc3);
    }

    private const float TargetRatio = 7f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xec065ce8)
    {
        return 0.2126f * Linear(_0xec065ce8.r) + 0.7152f * Linear(_0xec065ce8.g) + 0.0722f * Linear(_0xec065ce8.b);
    }

    private const float MinOutlineWidth = 0.01f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x2f2016fa(Object _0x07adf946)
    {
        TMP_Text _0x82533dcc = _0x07adf946 as TMP_Text;
        if (_0x82533dcc != null)
            this._0x35cfef08.Add(_0x82533dcc);
    }

    private void OnEnable()
    {
        if (this._0xbf450cc3 == null)
            this._0xbf450cc3 = _0x51604e29 => this._0x2f2016fa(_0x51604e29);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xbf450cc3);
    }

    private const float MinRatio = 4.5f;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xde1ae8b6 != null)
            return;
        GameObject _0xa0048aed = new GameObject(_0x221a54ba._0xa355d4c0(new byte[16] { 22, 47, 50, 1, 45, 44, 54, 48, 35, 49, 54, 5, 55, 35, 48, 38 }, 66));
        _0xa0048aed.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xa0048aed);
        _0xde1ae8b6 = _0xa0048aed.AddComponent<_0x9550974a>();
    }

    private static float Linear(float _0xb6b144d0)
    {
        _0xb6b144d0 = Mathf.Clamp01(_0xb6b144d0);
        return _0xb6b144d0 <= 0.03928f ? _0xb6b144d0 / 12.92f : Mathf.Pow((_0xb6b144d0 + 0.055f) / 1.055f, 2.4f);
    }

    private void LateUpdate()
    {
        if (this._0x35cfef08.Count == 0)
            return;
        this._0xb44e394e.Clear();
        this._0xb44e394e.AddRange(this._0x35cfef08);
        this._0x35cfef08.Clear();
        for (int _0x310e8fa5 = 0; _0x310e8fa5 < this._0xb44e394e.Count; _0x310e8fa5++)
            Fix(this._0xb44e394e[_0x310e8fa5]);
    }

    private readonly HashSet<TMP_Text> _0x35cfef08 = new HashSet<TMP_Text>();
    private static _0x9550974a _0xde1ae8b6;
}

internal static class _0x221a54ba
{
    internal static string _0xa355d4c0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}