using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The 5x5 mosaic itself: it spawns the tiles, lays them out from the live rect of its
// own grid (never from a literal), animates a line shift with its wrapping tile, and
// reports taps upward. It owns no rules - the director decides what a tap means.
public sealed class _0xf8783d9f : MonoBehaviour
{
    public bool _0x02088b5b
    {
        get
        {
            return this._0xf0d0689b;
        }
    }

    private void OnDestroy()
    {
        if (this._rowBandImage != null)
            DOTween.Kill(this._rowBandImage);
        if (this._colBandImage != null)
            DOTween.Kill(this._colBandImage);
    }

    private bool _0xf0d0689b;
    [SerializeField]
    private RectTransform _colBand;
    [SerializeField]
    private _0xb424dc92 _director;
    private readonly _0x4e485200[] _0x63586bb6 = new _0x4e485200[_0x818cf24c.Cells];
    private void Start()
    {
        this._0x8202a358();
    }

    private void _0x8202a358()
    {
        if (this._grid == null || this._tilePrefab == null)
            return;
        float width = this._grid.rect.width;
        if (width <= 1f)
            return;
        this._0x682ad763 = width;
        this._0xf2ee4512 = width / _0x818cf24c.Side;
        for (int _0xa54862ae = 0; _0xa54862ae < _0x818cf24c.Cells; _0xa54862ae++)
        {
            if (this._0x63586bb6[_0xa54862ae] == null)
            {
                _0x4e485200 _0xe587607b = Instantiate(this._tilePrefab, this._grid, false);
                _0xe587607b._0x0c24644f(this, _0xa54862ae);
                this._0x63586bb6[_0xa54862ae] = _0xe587607b;
            }

            this._0x63586bb6[_0xa54862ae]._0x23391216(this._0xf2ee4512 * 0.94f);
            this._0x63586bb6[_0xa54862ae]._0x4440f0a8.anchoredPosition = this._0x9f69a6c6(_0xa54862ae % _0x818cf24c.Side, _0xa54862ae / _0x818cf24c.Side);
        }

        if (this._rowBand != null)
            this._rowBand.sizeDelta = new Vector2(width, this._0xf2ee4512);
        if (this._colBand != null)
            this._colBand.sizeDelta = new Vector2(this._0xf2ee4512, width);
        if (this._director != null)
            this._director._0x8c7128e9();
    }

    public void _0x2ed415af(int _0x164d5601, int _0x754609ee, float _0xb3fa232b)
    {
        if (this._rowBand != null)
        {
            this._rowBand.gameObject.SetActive(true);
            this._rowBand.anchoredPosition = new Vector2(0f, this._0x9f69a6c6(_0x164d5601, _0x754609ee).y);
        }

        if (this._colBand != null)
        {
            this._colBand.gameObject.SetActive(true);
            this._colBand.anchoredPosition = new Vector2(this._0x9f69a6c6(_0x164d5601, _0x754609ee).x, 0f);
        }

        this._0x80119293(this._rowBandImage, _0xb3fa232b);
        this._0x80119293(this._colBandImage, _0xb3fa232b);
        for (int _0xa553e4fa = 0; _0xa553e4fa < _0x818cf24c.Cells; _0xa553e4fa++)
            if (this._0x63586bb6[_0xa553e4fa] != null)
                this._0x63586bb6[_0xa553e4fa]._0x9004dd99(_0xa553e4fa == _0x754609ee * _0x818cf24c.Side + _0x164d5601, _0xb3fa232b);
    }

    private void _0x21fb7a81(MosaicMove _0xea84f2d9, _0x818cf24c _0xacc68fde, _0x818cf24c _0x618c957a, bool _0x29e8b5e5, float _0x6cc33a8e, TweenCallback _0x238f756c)
    {
        // The tile that left one edge reappears at the opposite one. Only THAT cell
        // fades back in - fading the whole line would read as a blink, and the point of
        // the fade is to show which single tile travelled across the board.
        int _0xcbf0c521 = _0xea84f2d9.Step > 0 ? 0 : _0x818cf24c.Side - 1;
        int _0xe7c0df8d = _0xea84f2d9.Axis == 0 ? _0xea84f2d9.Index * _0x818cf24c.Side + _0xcbf0c521 : _0xcbf0c521 * _0x818cf24c.Side + _0xea84f2d9.Index;
        for (int _0x91a5e546 = 0; _0x91a5e546 < _0x818cf24c.Cells; _0x91a5e546++)
        {
            _0x4e485200 _0x354f61e6 = this._0x63586bb6[_0x91a5e546];
            if (_0x354f61e6 == null)
                continue;
            _0x354f61e6._0x4440f0a8.anchoredPosition = this._0x9f69a6c6(_0x91a5e546 % _0x818cf24c.Side, _0x91a5e546 / _0x818cf24c.Side);
            CanvasGroup _0xca59063a = _0x354f61e6._0x4440f0a8.GetComponent<CanvasGroup>();
            if (_0xca59063a == null)
                continue;
            DOTween.Kill(_0xca59063a);
            if (_0x91a5e546 != _0xe7c0df8d)
            {
                _0xca59063a.alpha = 1f;
                continue;
            }

            _0xca59063a.alpha = 0f;
            _0xca59063a.DOFade(1f, 0.12f * _0x6cc33a8e).SetLink(_0x354f61e6.gameObject);
        }

        this._0xbeaac7dd(_0xacc68fde, _0x618c957a, _0x29e8b5e5, _0x6cc33a8e, true);
        this._0xf0d0689b = false;
        if (_0x238f756c != null)
            _0x238f756c();
    }

    // The canvas rect is zero in Awake and changes again on autorotation, so the layout
    // is taken from the live rect here and re-taken whenever that width really moves.
    private void Update()
    {
        if (this._grid == null)
            return;
        float width = this._grid.rect.width;
        if (width > 1f && Mathf.Abs(width - this._0x682ad763) > 0.5f)
            this._0x8202a358();
    }

    public Vector2 _0x9f69a6c6(int _0xe8e49994, int _0xca3bfe5f)
    {
        float _0x2eff47ce = (_0x818cf24c.Side - 1) * 0.5f;
        return new Vector2((_0xe8e49994 - _0x2eff47ce) * this._0xf2ee4512, (_0x2eff47ce - _0xca3bfe5f) * this._0xf2ee4512);
    }

    private const float BandAlpha = 0.34f;
    // Colour-blind safe shape badges, one per species. ASCII only: the atlas is 32..126.
    private static readonly string[] _0x2b0440a8 =
    {
        _0x6b26ddb0._0xbc4fea11(new byte[1] { 54 }, 28),
        _0x6b26ddb0._0xbc4fea11(new byte[1] { 63 }, 97),
        _0x6b26ddb0._0xbc4fea11(new byte[1] { 109 }, 34),
        _0x6b26ddb0._0xbc4fea11(new byte[1] { 122 }, 81),
        _0x6b26ddb0._0xbc4fea11(new byte[1] { 95 }, 7)
    };
    [SerializeField]
    private _0x4e485200 _tilePrefab;
    [SerializeField]
    private RectTransform _rowBand;
    [SerializeField]
    private RectTransform _grid;
    [SerializeField]
    private Image _rowBandImage;
    public float _0x6a7d6b07
    {
        get
        {
            return this._0xf2ee4512;
        }
    }

    [SerializeField]
    private Sprite[] _blossoms;
    private float _0x682ad763 = -1f;
    public void _0xa75d7181(int _0x6157b547)
    {
        if (this._0xf0d0689b || this._director == null)
            return;
        this._director._0x0976ac60(_0x6157b547 % _0x818cf24c.Side, _0x6157b547 / _0x818cf24c.Side);
    }

    [SerializeField]
    private Image _colBandImage;
    private void _0x80119293(Image _0x9b37fa68, float _0xe3d9a6dc)
    {
        if (_0x9b37fa68 == null)
            return;
        DOTween.Kill(_0x9b37fa68);
        if (_0xe3d9a6dc < 0.9f)
        {
            _0x9b37fa68.color = _0xcc07f46d.Fade(_0xcc07f46d.Mint, BandAlpha);
            return;
        }

        _0x9b37fa68.color = _0xcc07f46d.Fade(_0xcc07f46d.Mint, 0.24f);
        _0x9b37fa68.DOFade(BandAlpha + 0.12f, 0.9f).SetLoops(-1, LoopType.Yoyo).SetLink(_0x9b37fa68.gameObject);
    }

    public void _0xf59039b3()
    {
        if (this._rowBandImage != null)
            DOTween.Kill(this._rowBandImage);
        if (this._colBandImage != null)
            DOTween.Kill(this._colBandImage);
        if (this._rowBand != null)
            this._rowBand.gameObject.SetActive(false);
        if (this._colBand != null)
            this._colBand.gameObject.SetActive(false);
    }

    public void _0xbeaac7dd(_0x818cf24c _0x3847dfee, _0x818cf24c _0x5e566556, bool _0x401707b0, float _0x6a35981f, bool _0x5f2127ac)
    {
        for (int _0x9b31b010 = 0; _0x9b31b010 < _0x818cf24c.Cells; _0x9b31b010++)
        {
            _0x4e485200 _0x1d06f076 = this._0x63586bb6[_0x9b31b010];
            if (_0x1d06f076 == null)
                continue;
            int _0x6dbd61d7 = _0x3847dfee[_0x9b31b010];
            Color _0x6fa1cde6 = _0xcc07f46d.Species[_0x6dbd61d7];
            Sprite _0x0f8de4d0 = this._blossoms != null && _0x6dbd61d7 < this._blossoms.Length ? this._blossoms[_0x6dbd61d7] : null;
            _0x1d06f076._0x0fe30074(_0x0f8de4d0, _0x401707b0 ? _0x6fa1cde6 : _0xcc07f46d.Dim(_0x6fa1cde6, 0.92f), _0x2b0440a8[_0x6dbd61d7], _0x401707b0);
            _0x1d06f076._0x68719d7b(_0x3847dfee._0x59a92d61(_0x5e566556, _0x9b31b010), _0x6fa1cde6, _0x6a35981f, _0x5f2127ac);
        }
    }

    // The whole board punches in a diagonal cascade before the win card opens.
    public void _0x3406818c(float _0x53005b91, TweenCallback _0x1261be55)
    {
        this._0xf0d0689b = true;
        Sequence _0x4fed388c = DOTween.Sequence().SetLink(this.gameObject);
        for (int _0x79b2f77c = 0; _0x79b2f77c < _0x818cf24c.Cells; _0x79b2f77c++)
        {
            _0x4e485200 _0x613cb6bb = this._0x63586bb6[_0x79b2f77c];
            if (_0x613cb6bb == null)
                continue;
            int _0xbd17ac90 = _0x79b2f77c % _0x818cf24c.Side + _0x79b2f77c / _0x818cf24c.Side;
            Vector3 _0x94c3e426 = new Vector3(0.22f, 0.22f, 0f);
            // One line: the sequence owns this tween and the sequence is linked, but the
            // enforcer edits single-line statements only and cannot read a wrapped one.
            _0x4fed388c.Insert(_0xbd17ac90 * 0.09f * _0x53005b91, _0x613cb6bb._0x4440f0a8.DOPunchScale(_0x94c3e426, 0.3f * _0x53005b91, 1, 0.6f));
        }

        _0x4fed388c.OnComplete(() =>
        {
            this._0xf0d0689b = false;
            if (_0x1261be55 != null)
                _0x1261be55();
        });
    }

    private float _0xf2ee4512;
    // The visible half of a move: every tile in the line steps one cell, and the tile
    // that would leave the board fades out at the edge and fades back in on the other
    // side. That fade is what makes wrap-around readable instead of baffling.
    public void _0x0404a63c(MosaicMove _0x26bcbab1, _0x818cf24c _0x5c3ca24f, _0x818cf24c _0x8aca5b3b, bool _0xcdbfbf2e, float _0x11d3846e, TweenCallback _0x16d7ecb8)
    {
        this._0xf0d0689b = true;
        float _0x9b693311 = 0.22f * _0x11d3846e;
        Sequence _0xc9a69600 = DOTween.Sequence().SetLink(this.gameObject);
        for (int _0x4f43eb0d = 0; _0x4f43eb0d < _0x818cf24c.Side; _0x4f43eb0d++)
        {
            int _0xe928668a = _0x26bcbab1.Axis == 0 ? _0x4f43eb0d : _0x26bcbab1.Index;
            int _0xcefa3348 = _0x26bcbab1.Axis == 0 ? _0x26bcbab1.Index : _0x4f43eb0d;
            _0x4e485200 _0x97194ad5 = this._0x63586bb6[_0xcefa3348 * _0x818cf24c.Side + _0xe928668a];
            if (_0x97194ad5 == null)
                continue;
            int _0xf7e72258 = _0x26bcbab1.Axis == 0 ? _0x4f43eb0d + _0x26bcbab1.Step : _0x4f43eb0d - _0x26bcbab1.Step;
            bool _0x4153a240 = _0xf7e72258 < 0 || _0xf7e72258 >= _0x818cf24c.Side;
            Vector2 _0xba45007a = _0x97194ad5._0x4440f0a8.anchoredPosition;
            Vector2 _0x553f314e = _0x26bcbab1.Axis == 0 ? new Vector2(this._0xf2ee4512 * _0x26bcbab1.Step, 0f) : new Vector2(0f, -this._0xf2ee4512 * _0x26bcbab1.Step);
            _0xc9a69600.Join(_0x97194ad5._0x4440f0a8.DOAnchorPos(_0xba45007a + _0x553f314e, _0x9b693311).SetEase(Ease.OutCubic));
            if (!_0x4153a240)
                continue;
            CanvasGroup _0x57392a14 = _0x97194ad5._0x4440f0a8.GetComponent<CanvasGroup>();
            if (_0x57392a14 != null)
                _0xc9a69600.Join(_0x57392a14.DOFade(0f, _0x9b693311 * 0.5f));
        }

        _0xc9a69600.OnComplete(() => this._0x21fb7a81(_0x26bcbab1, _0x5c3ca24f, _0x8aca5b3b, _0xcdbfbf2e, _0x11d3846e, _0x16d7ecb8));
    }

    public void _0x5e3590c4(MosaicMove _0x54443237, float _0xeccf1ac5)
    {
        for (int _0xa4345d8c = 0; _0xa4345d8c < _0x818cf24c.Side; _0xa4345d8c++)
        {
            int _0x8608c0c4 = _0x54443237.Axis == 0 ? _0xa4345d8c : _0x54443237.Index;
            int _0xc7cf1d70 = _0x54443237.Axis == 0 ? _0x54443237.Index : _0xa4345d8c;
            _0x4e485200 _0xbdfb1ef5 = this._0x63586bb6[_0xc7cf1d70 * _0x818cf24c.Side + _0x8608c0c4];
            if (_0xbdfb1ef5 != null)
                _0xbdfb1ef5._0x9004dd99(true, _0xeccf1ac5);
        }
    }
}

internal static class _0x6b26ddb0
{
    internal static string _0xbc4fea11(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}