using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The seasonal album: thirty cards, one per flower pressed by completing a line. The
// empty state is mandatory - with nothing pressed the grid is replaced by a worded
// block, never by a blank sheet.
public sealed class _0x14aecad3 : MonoBehaviour
{
    private bool _0xc2e0cdd7;
    [SerializeField]
    private TMP_Text _emptyBottom;
    [SerializeField]
    private TMP_Text _title;
    [SerializeField]
    private Sprite[] _blossoms;
    private void Start()
    {
        _0x978b485d.Shape(this._title, 40f, 56f);
        _0x978b485d.Shape(this._footer, 32f, 44f);
        _0x978b485d.Shape(this._emptyTop, 32f, 42f);
        _0x978b485d.Shape(this._emptyBottom, 32f, 42f);
        _0x978b485d.ApplyOutline(this._title, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._footer, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._emptyTop, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._emptyBottom, _0xcc07f46d.InkSoft);
        if (this._title != null)
            this._title.text = _0x49455056._0x69d6bc08(new byte[12] { 142, 132, 135, 159, 141, 154, 232, 137, 132, 138, 157, 133 }, 200);
        if (this._emptyTop != null)
            this._emptyTop.text = _0x49455056._0x69d6bc08(new byte[21] { 111, 110, 1, 99, 109, 110, 110, 108, 114, 1, 113, 115, 100, 114, 114, 100, 101, 1, 120, 100, 117 }, 33);
        if (this._emptyBottom != null)
            this._emptyBottom.text = _0x49455056._0x69d6bc08(new byte[32] { 245, 250, 253, 250, 224, 251, 147, 242, 147, 255, 250, 253, 246, 147, 231, 252, 147, 224, 231, 242, 225, 231, 147, 231, 251, 246, 147, 242, 255, 241, 230, 254 }, 179);
        if (this._close != null)
            this._close.onClick.AddListener(() => this._0x106a06ae());
        if (this._gate != null)
            this._gate._0x96c1aad5();
    }

    public void _0x358482c0()
    {
        this._0x367416ce();
        this._0xccfdeda3();
        if (this._gate != null)
            this._gate.Show(0.22f);
    }

    [SerializeField]
    private GameObject _emptyBlock;
    [SerializeField]
    private RectTransform _grid;
    private readonly _0xb66a9795[] _0xe2d96b5c = new _0xb66a9795[_0xa2e487e5.AlbumCards];
    [SerializeField]
    private _0x25f9e005 _gate;
    [SerializeField]
    private _0xb66a9795 _cardPrefab;
    [SerializeField]
    private TMP_Text _emptyTop;
    private void _0x367416ce()
    {
        if (this._0xc2e0cdd7 || this._cardPrefab == null || this._grid == null)
            return;
        this._0xc2e0cdd7 = true;
        const int _0x8fd1264e = 5;
        const float _0xc71f2c59 = 180f;
        const float _0xd3acce75 = 220f;
        const float _0x373fe4c6 = 24f;
        float _0x3452e584 = -(_0x8fd1264e - 1) * (_0xc71f2c59 + _0x373fe4c6) * 0.5f;
        int _0x6273f441 = _0xa2e487e5.AlbumCards / _0x8fd1264e;
        float _0xa80769b4 = (_0x6273f441 - 1) * (_0xd3acce75 + _0x373fe4c6) * 0.5f;
        for (int _0x2384cda2 = 0; _0x2384cda2 < _0xa2e487e5.AlbumCards; _0x2384cda2++)
        {
            _0xb66a9795 _0x54680e63 = Instantiate(this._cardPrefab, this._grid, false);
            RectTransform _0x5f040e08 = _0x54680e63.transform as RectTransform;
            if (_0x5f040e08 != null)
            {
                _0x5f040e08.anchorMin = new Vector2(0.5f, 0.5f);
                _0x5f040e08.anchorMax = new Vector2(0.5f, 0.5f);
                _0x5f040e08.sizeDelta = new Vector2(_0xc71f2c59, _0xd3acce75);
                _0x5f040e08.anchoredPosition = new Vector2(_0x3452e584 + _0x2384cda2 % _0x8fd1264e * (_0xc71f2c59 + _0x373fe4c6), _0xa80769b4 - _0x2384cda2 / _0x8fd1264e * (_0xd3acce75 + _0x373fe4c6));
            }

            this._0xe2d96b5c[_0x2384cda2] = _0x54680e63;
        }
    }

    [SerializeField]
    private TMP_Text _footer;
    [SerializeField]
    private Button _close;
    private void _0xccfdeda3()
    {
        if (this._progress == null)
            return;
        int _0x2a946e11 = this._progress._0x30438acf();
        bool _0x1d8486a6 = _0x2a946e11 > 0;
        if (this._grid != null)
            this._grid.gameObject.SetActive(_0x1d8486a6);
        if (this._emptyBlock != null)
            this._emptyBlock.SetActive(!_0x1d8486a6);
        if (this._footer != null)
            this._footer.text = _0x49455056._0x69d6bc08(new byte[8] { 201, 203, 220, 202, 202, 220, 221, 185 }, 153) + _0x2a946e11 + _0x49455056._0x69d6bc08(new byte[3] { 224, 239, 224 }, 192) + _0xa2e487e5.AlbumCards;
        if (!_0x1d8486a6)
            return;
        for (int _0xb7c031dd = 0; _0xb7c031dd < this._0xe2d96b5c.Length; _0xb7c031dd++)
        {
            if (this._0xe2d96b5c[_0xb7c031dd] == null)
                continue;
            int _0xe92a95d0 = _0xb7c031dd % _0xcc07f46d.Species.Length;
            Sprite _0x3cffdc61 = this._blossoms != null && _0xe92a95d0 < this._blossoms.Length ? this._blossoms[_0xe92a95d0] : null;
            this._0xe2d96b5c[_0xb7c031dd]._0xbd642200(this._progress._0x6b001ad8(_0xb7c031dd), _0x3cffdc61, this._silhouette, _0xcc07f46d.Species[_0xe92a95d0], _0xa2e487e5.SpeciesNames[_0xe92a95d0], _0x49455056._0x69d6bc08(new byte[3] { 9, 2, 106 }, 74) + (_0xb7c031dd / 5 + 1));
        }
    }

    [SerializeField]
    private Sprite _silhouette;
    public void _0x106a06ae()
    {
        if (this._gate != null)
            this._gate._0x96c1aad5();
    }

    [SerializeField]
    private _0xfc9e8c39 _progress;
}

internal static class _0x49455056
{
    internal static string _0x69d6bc08(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}