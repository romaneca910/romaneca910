using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The garden map: six chapter nodes along the stone path, the card for the one that is
// selected, and the two sheets that open over it. The PLAY button itself belongs to the
// template (a LoadSceneButton driver already carries it to scene 1); this view draws its
// face and keeps the card beneath it truthful.
public sealed class _0x6325e58b : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _playLabel;
    [SerializeField]
    private TMP_Text _cardInfo;
    [SerializeField]
    private Sprite[] _blossoms;
    [SerializeField]
    private _0x14aecad3 _album;
    private void _0x6b17257d()
    {
        if (this._settings != null)
            this._settings._0x09f2eccf();
    }

    private void _0xaf453bf9(int _0xb250f731, bool _0xe7e637a6)
    {
        if (this._cardPips == null || _0xb250f731 >= this._cardPips.Length || this._cardPips[_0xb250f731] == null)
            return;
        this._cardPips[_0xb250f731].color = _0xe7e637a6 ? _0xcc07f46d.Gold : _0xcc07f46d.Fade(_0xcc07f46d.RoseDeep, 0.22f);
    }

    public void _0xad04fa9a()
    {
        if (this._progress == null)
            return;
        int _0x5f286901 = this._progress._0x24b43855;
        int _0x6a7cfabe = Mathf.Min(this._progress._0x0bb5c853, _0x5f286901 - 1);
        if (this._hintsLabel != null)
            this._hintsLabel.text = _0xe4471eaf._0x6b42d370(new byte[6] { 113, 112, 119, 109, 106, 25 }, 57) + this._progress._0x00234e15;
        if (this._bloomsLabel != null)
            this._bloomsLabel.text = _0xe4471eaf._0x6b42d370(new byte[7] { 238, 224, 227, 227, 225, 255, 140 }, 172) + this._progress._0x19cfdbdc;
        if (this._nodeButtons != null)
        {
            for (int _0x2c3d751a = 0; _0x2c3d751a < this._nodeButtons.Length; _0x2c3d751a++)
            {
                bool _0xf87096a1 = _0x2c3d751a < _0x5f286901;
                bool _0x140972ab = this._progress._0x623e4808(_0x2c3d751a) >= 0;
                if (this._nodeIcons != null && _0x2c3d751a < this._nodeIcons.Length && this._nodeIcons[_0x2c3d751a] != null)
                {
                    this._nodeIcons[_0x2c3d751a].sprite = _0xf87096a1 ? this._nodeOpenSprite : this._nodeLockedSprite;
                    this._nodeIcons[_0x2c3d751a].preserveAspect = true;
                    this._nodeIcons[_0x2c3d751a].color = _0xf87096a1 ? Color.white : new Color(0.72f, 0.72f, 0.74f, 0.62f);
                }

                if (this._nodeFlowers != null && _0x2c3d751a < this._nodeFlowers.Length && this._nodeFlowers[_0x2c3d751a] != null)
                {
                    this._nodeFlowers[_0x2c3d751a].gameObject.SetActive(_0xf87096a1);
                    if (this._blossoms != null && this._blossoms.Length > 0)
                        this._nodeFlowers[_0x2c3d751a].sprite = this._blossoms[_0x2c3d751a % this._blossoms.Length];
                    this._nodeFlowers[_0x2c3d751a].preserveAspect = true;
                    this._nodeFlowers[_0x2c3d751a].color = _0x140972ab ? Color.white : new Color(1f, 1f, 1f, 0.78f);
                }

                if (this._nodeNumbers != null && _0x2c3d751a < this._nodeNumbers.Length && this._nodeNumbers[_0x2c3d751a] != null)
                {
                    this._nodeNumbers[_0x2c3d751a].gameObject.SetActive(_0xf87096a1);
                    this._nodeNumbers[_0x2c3d751a].text = (_0x2c3d751a + 1).ToString();
                }

                if (this._nodeButtons[_0x2c3d751a] != null)
                    this._nodeButtons[_0x2c3d751a].interactable = _0xf87096a1;
                this._0x11bf9c93(_0x2c3d751a, _0x2c3d751a == _0x6a7cfabe);
            }
        }

        if (this._cardChapter != null)
            this._cardChapter.text = _0xe4471eaf._0x6b42d370(new byte[8] { 225, 234, 227, 242, 246, 231, 240, 130 }, 162) + (_0x6a7cfabe + 1);
        if (this._cardName != null)
            this._cardName.text = _0xa2e487e5.Name(_0x6a7cfabe);
        if (this._cardInfo != null)
            this._cardInfo.text = _0x818cf24c.Cells + _0xe4471eaf._0x6b42d370(new byte[11] { 80, 36, 57, 60, 53, 35, 80, 80, 93, 80, 80 }, 112) + _0xa2e487e5.Budget(_0x6a7cfabe) + _0xe4471eaf._0x6b42d370(new byte[6] { 251, 150, 148, 141, 158, 136 }, 219);
        if (this._cardPips != null)
        {
            bool _0x3004074a = this._progress._0x623e4808(_0x6a7cfabe) >= 0;
            bool _0xeece04e9 = this._progress._0x623e4808(_0x6a7cfabe) >= _0xa2e487e5.BudgetSlack;
            bool _0x7237b91a = this._progress._0x00234e15 >= _0xa2e487e5.HintsAtStart;
            this._0xaf453bf9(0, _0x3004074a);
            this._0xaf453bf9(1, _0xeece04e9);
            this._0xaf453bf9(2, _0x7237b91a);
        }
    }

    [SerializeField]
    private Button _albumButton;
    [SerializeField]
    private Image[] _nodeIcons;
    [SerializeField]
    private Image[] _cardPips;
    // The chapter you are about to play breathes; the rest sit still.
    private void _0x11bf9c93(int _0x9f3ac90b, bool _0x7cb8964a)
    {
        if (this._nodeRings == null || _0x9f3ac90b >= this._nodeRings.Length || this._nodeRings[_0x9f3ac90b] == null)
            return;
        RectTransform _0x8c3d640e = this._nodeRings[_0x9f3ac90b];
        DOTween.Kill(_0x8c3d640e);
        _0x8c3d640e.localScale = Vector3.one;
        _0x8c3d640e.gameObject.SetActive(_0x7cb8964a);
        if (!_0x7cb8964a)
            return;
        if (this._progress != null && this._progress._0x64269987)
            return;
        _0x8c3d640e.DOScale(1.08f, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x8c3d640e.gameObject);
    }

    [SerializeField]
    private RectTransform[] _nodeRings;
    [SerializeField]
    private TMP_Text _cardChapter;
    [SerializeField]
    private Sprite _nodeOpenSprite;
    [SerializeField]
    private Button _settingsButton;
    public void _0x105bdf17(int _0xb98c5eaa)
    {
        if (this._progress == null)
            return;
        if (_0xb98c5eaa >= this._progress._0x24b43855)
            return;
        this._progress._0x0bb5c853 = _0xb98c5eaa;
        this._progress._0x760b43bf();
        this._0xad04fa9a();
    }

    [SerializeField]
    private Image[] _nodeFlowers;
    [SerializeField]
    private TMP_Text _hintsLabel;
    [SerializeField]
    private TMP_Text[] _nodeNumbers;
    private void _0xf8dcaaa8()
    {
        if (this._progress != null && this._progress._0x64269987)
            return;
        RectTransform _0x2b19e3dd = this.transform as RectTransform;
        if (_0x2b19e3dd == null)
            return;
        _0x2b19e3dd.localScale = Vector3.one * 0.985f;
        _0x2b19e3dd.DOScale(1f, 0.32f).SetEase(Ease.OutBack).SetLink(this.gameObject);
    }

    [SerializeField]
    private TMP_Text _bloomsLabel;
    private void _0x7e0f2acf()
    {
        if (this._nodeButtons == null)
            return;
        for (int _0x2994d58e = 0; _0x2994d58e < this._nodeButtons.Length; _0x2994d58e++)
        {
            if (this._nodeButtons[_0x2994d58e] == null)
                continue;
            int _0xef98500f = _0x2994d58e;
            this._nodeButtons[_0x2994d58e].onClick.AddListener(() => this._0x105bdf17(_0xef98500f));
            if (this._nodeNumbers != null && _0x2994d58e < this._nodeNumbers.Length)
            {
                _0x978b485d.Shape(this._nodeNumbers[_0x2994d58e], 26f, 40f);
                _0x978b485d.ApplyOutline(this._nodeNumbers[_0x2994d58e], _0xcc07f46d.Ink);
            }
        }
    }

    [SerializeField]
    private TMP_Text _cardName;
    [SerializeField]
    private Sprite _nodeLockedSprite;
    [SerializeField]
    private TMP_Text _howLabel;
    private void Start()
    {
        _0x978b485d.Shape(this._cardChapter, 40f, 54f);
        _0x978b485d.Shape(this._cardName, 34f, 44f);
        _0x978b485d.Shape(this._cardInfo, 30f, 38f);
        _0x978b485d.Shape(this._hintsLabel, 26f, 36f);
        _0x978b485d.Shape(this._bloomsLabel, 26f, 36f);
        _0x978b485d.Shape(this._playLabel, 44f, 58f);
        _0x978b485d.Shape(this._howLabel, 30f, 40f);
        _0x978b485d.ApplyOutline(this._cardChapter, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._cardName, _0xcc07f46d.RoseDeep);
        _0x978b485d.ApplyOutline(this._cardInfo, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._hintsLabel, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._bloomsLabel, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._playLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._howLabel, _0xcc07f46d.InkSoft);
        if (this._playLabel != null)
            this._playLabel.text = _0xe4471eaf._0x6b42d370(new byte[4] { 234, 246, 251, 227 }, 186);
        if (this._howLabel != null)
            this._howLabel.text = _0xe4471eaf._0x6b42d370(new byte[49] { 47, 58, 43, 91, 58, 91, 47, 50, 55, 62, 91, 91, 86, 91, 91, 47, 58, 43, 91, 58, 53, 91, 58, 41, 41, 52, 44, 91, 91, 86, 91, 91, 55, 50, 53, 62, 40, 91, 44, 41, 58, 43, 91, 58, 41, 52, 46, 53, 63 }, 123);
        this._0x7e0f2acf();
        if (this._albumButton != null)
            this._albumButton.onClick.AddListener(() => this._0x1b915b74());
        if (this._settingsButton != null)
            this._settingsButton.onClick.AddListener(() => this._0x6b17257d());
        this._0xad04fa9a();
        this._0xf8dcaaa8();
    }

    [SerializeField]
    private Button[] _nodeButtons;
    [SerializeField]
    private _0xaafb68af _settings;
    [SerializeField]
    private _0xfc9e8c39 _progress;
    private void _0x1b915b74()
    {
        if (this._album != null)
            this._album._0x358482c0();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
        if (this._nodeRings == null)
            return;
        for (int _0x905d5eb7 = 0; _0x905d5eb7 < this._nodeRings.Length; _0x905d5eb7++)
            if (this._nodeRings[_0x905d5eb7] != null)
                DOTween.Kill(this._nodeRings[_0x905d5eb7]);
    }
}

internal static class _0xe4471eaf
{
    internal static string _0x6b42d370(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}