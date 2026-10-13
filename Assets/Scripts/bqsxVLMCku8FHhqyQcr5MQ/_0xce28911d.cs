using TMPro;
using UnityEngine;
using UnityEngine.UI;

// One card of ours inside a template pop. The template's own five content branches are
// switched off in the scene, so this card IS the pop: its wording, its palette, its own
// close cross sprite (the template leaves that Image empty, which Unity paints as a
// white rectangle) and exactly one caption per button (rule C.17).
public sealed class _0xce28911d : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _primaryLabel;
    [SerializeField]
    private TMP_Text _statRight;
    private void _0x1a4da44f()
    {
        if (this._0x4152f731 != null)
            this._0x4152f731._0x7d96a75d(this._0xd27273bb);
    }

    [SerializeField]
    private Button _close;
    // A label with no value is a defect, so an empty string switches its row off
    // instead of leaving a caption hanging with nothing beside it.
    private static void Write(TMP_Text _0x00150d6c, string _0xceb40c52)
    {
        if (_0x00150d6c == null)
            return;
        bool _0x51930109 = !string.IsNullOrEmpty(_0xceb40c52);
        _0x00150d6c.gameObject.SetActive(_0x51930109);
        if (_0x51930109)
            _0x00150d6c.text = _0xceb40c52;
    }

    [SerializeField]
    private Button _secondary;
    [SerializeField]
    private Image _primaryPlate;
    [SerializeField]
    private Button _primary;
    [SerializeField]
    private TMP_Text _bodyTop;
    private int _0xd27273bb;
    [SerializeField]
    private TMP_Text _secondaryLabel;
    private void _0x2465a7c3()
    {
        if (this._0x4152f731 != null)
            this._0x4152f731._0xe53393bf(this._0xd27273bb);
    }

    private _0x940e3959 _0x4152f731;
    [SerializeField]
    private TMP_Text _header;
    [SerializeField]
    private TMP_Text _bodyBottom;
    // Called straight after Instantiate: the pop's Content ships inactive, so Awake and
    // Start would not run until the pop is first raised.
    public void _0xf999ce76(_0x940e3959 _0xa78fa7b9, int _0xb2218e6e)
    {
        this._0x4152f731 = _0xa78fa7b9;
        this._0xd27273bb = _0xb2218e6e;
        _0x978b485d.Shape(this._header, 56f, 86f);
        _0x978b485d.Shape(this._bodyTop, 40f, 54f);
        _0x978b485d.Shape(this._bodyBottom, 40f, 54f);
        _0x978b485d.Shape(this._statLeft, 32f, 44f);
        _0x978b485d.Shape(this._statMiddle, 32f, 44f);
        _0x978b485d.Shape(this._statRight, 32f, 44f);
        _0x978b485d.Shape(this._primaryLabel, 40f, 52f);
        _0x978b485d.Shape(this._secondaryLabel, 36f, 46f);
        _0x978b485d.ApplyOutline(this._header, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._bodyTop, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._bodyBottom, _0xcc07f46d.RoseDeep);
        _0x978b485d.ApplyOutline(this._statLeft, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._statMiddle, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._statRight, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._primaryLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._secondaryLabel, _0xcc07f46d.Ink);
        if (this._primary != null)
            this._primary.onClick.AddListener(() => this._0x4e9e9644());
        if (this._secondary != null)
            this._secondary.onClick.AddListener(() => this._0x2465a7c3());
        if (this._close != null)
            this._close.onClick.AddListener(() => this._0x1a4da44f());
    }

    [SerializeField]
    private TMP_Text _statMiddle;
    public void _0x0a4c04ae(string _0x91b0d1d1, string _0x931372af, string _0xc3708a0b, string _0xe62c240f, string _0x64f25454, string _0xdb2d6cf7, string _0xafa773d9, string _0xbae18c8d, bool _0xeb6cc232)
    {
        Write(this._header, _0x91b0d1d1);
        Write(this._bodyTop, _0x931372af);
        Write(this._bodyBottom, _0xc3708a0b);
        Write(this._statLeft, _0xe62c240f);
        Write(this._statMiddle, _0x64f25454);
        Write(this._statRight, _0xdb2d6cf7);
        Write(this._primaryLabel, _0xafa773d9);
        Write(this._secondaryLabel, _0xbae18c8d);
        if (this._secondary != null)
            this._secondary.gameObject.SetActive(_0xeb6cc232);
    }

    private void _0x4e9e9644()
    {
        if (this._0x4152f731 != null)
            this._0x4152f731._0x92f72dde(this._0xd27273bb);
    }

    public void _0x8ec72bfa(Color _0x15cc422c)
    {
        if (this._primaryPlate != null)
            this._primaryPlate.color = _0x15cc422c;
    }

    [SerializeField]
    private TMP_Text _statLeft;
}