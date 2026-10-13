using UnityEngine;

// The one palette of the app (CANDY_SWEET, overridden to the brief's hexes).
// Every entry is a plain literal: no field reads another, so the declaration reordering
// the obfuscator performs cannot build one before its dependency (rule C.52).
// The shared font outline is CREAM, so EVERY text colour here is dark on purpose:
// Ink 12.3:1, InkSoft 6.3:1 and RoseDeep 4.8:1 against that outline.
public static class _0xcc07f46d
{
    public static readonly Color Cream = new Color(1f, 0.964706f, 0.984314f, 1f);
    public static readonly Color Mint = new Color(0.462745f, 0.780392f, 0.717647f, 1f);
    public static readonly Color Ink = new Color(0.211765f, 0.164706f, 0.227451f, 1f);
    public static readonly Color MintDeep = new Color(0.309804f, 0.662745f, 0.603922f, 1f);
    public static Color Dim(Color _0xdca7892d, float _0xacd259dc)
    {
        return new Color(_0xdca7892d.r * _0xacd259dc, _0xdca7892d.g * _0xacd259dc, _0xdca7892d.b * _0xacd259dc, _0xdca7892d.a);
    }

    public static readonly Color Gold = new Color(0.964706f, 0.784314f, 0.372549f, 1f);
    public static readonly Color Surface = new Color(0.992157f, 0.901961f, 0.941176f, 1f);
    public static readonly Color SurfaceDeep = new Color(0.968627f, 0.850980f, 0.909804f, 1f);
    // The loading bar track: a palette dark at a real alpha, so the rose fill reads
    // against it instead of the template default white-on-white.
    public static readonly Color TrackInk = new Color(0.211765f, 0.164706f, 0.227451f, 0.45f);
    public static readonly Color RoseDeep = new Color(0.690196f, 0.290196f, 0.525490f, 1f);
    public static Color Fade(Color _0x7f64592e, float _0xa3083c07)
    {
        return new Color(_0x7f64592e.r, _0x7f64592e.g, _0x7f64592e.b, _0xa3083c07);
    }

    // The five blossom species, in slot order. Distinguishable at tile size even
    // desaturated; COLOR BOOST adds a shape badge for anyone they are not.
    public static readonly Color[] Species =
    {
        new Color(0.905882f, 0.607843f, 0.760784f, 1f), // plum blossom
        new Color(0.850980f, 0.419608f, 0.658824f, 1f), // peony
        new Color(1f, 0.964706f, 0.984314f, 1f), // moonflower
        new Color(0.462745f, 0.780392f, 0.717647f, 1f), // lotus
        new Color(0.964706f, 0.784314f, 0.372549f, 1f), // marigold
    };
    public static readonly Color InkSoft = new Color(0.419608f, 0.329412f, 0.443137f, 1f);
    public static readonly Color Rose = new Color(0.850980f, 0.419608f, 0.658824f, 1f);
    public static readonly Color Paper = new Color(1f, 0.945098f, 0.968627f, 1f);
}