using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The game screen's own readouts. Every one of them is an object of ours: nothing here
// borrows a template HUD slot, so stage 5da can switch the template strip off without
// touching anything the game needs (rule C.2).
public sealed class _0x32b8946e : MonoBehaviour
{
    [SerializeField]
    private Image[] _pips;
    [SerializeField]
    private RectTransform _refundRect;
    [SerializeField]
    private TMP_Text _chapterLabel;
    public void _0x83440c60(int _0xc4e2481e)
    {
        if (this._hintLabel == null)
            return;
        this._hintLabel.text = _0xc4e2481e > 0 ? _0x4389a912._0x50ea9bbb(new byte[5] { 199, 198, 193, 219, 175 }, 143) + _0xc4e2481e : _0x4389a912._0x50ea9bbb(new byte[13] { 83, 82, 61, 85, 84, 83, 73, 78, 61, 81, 88, 91, 73 }, 29);
    }

    [SerializeField]
    private TMP_Text _bloomLabel;
    [SerializeField]
    private TMP_Text _movesValue;
    [SerializeField]
    private TMP_Text _refundFloat;
    [SerializeField]
    private TMP_Text _hintLabel;
    public void _0x4c4147b4(int _0x39b5fc23, float _0xbe494f4e)
    {
        if (this._refundRect == null || this._refundFloat == null)
            return;
        DOTween.Kill(this._refundRect);
        this._refundFloat.text = _0x4389a912._0x50ea9bbb(new byte[1] { 52 }, 31) + _0x39b5fc23 + _0x4389a912._0x50ea9bbb(new byte[6] { 61, 80, 82, 75, 88, 78 }, 29);
        this._refundRect.gameObject.SetActive(true);
        this._refundRect.anchoredPosition = this._0x5a6c8f56;
        this._refundFloat.alpha = 1f;
        this._refundRect.DOAnchorPosY(this._0x5a6c8f56.y + 90f, 0.9f * _0xbe494f4e).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        this._refundFloat.DOFade(0f, 0.9f * _0xbe494f4e).SetLink(this.gameObject);
    }

    // One pip per completed line pair, so the gutter column says how close the mosaic
    // is without a second number competing with the counter.
    public void _0x4e781b6a(int _0x1eeb1e27)
    {
        if (this._pips == null)
            return;
        for (int _0xe443401e = 0; _0xe443401e < this._pips.Length; _0xe443401e++)
        {
            if (this._pips[_0xe443401e] == null)
                continue;
            bool _0xf58abffa = _0xe443401e < _0x1eeb1e27;
            this._pips[_0xe443401e].color = _0xf58abffa ? _0xcc07f46d.Gold : _0xcc07f46d.Fade(_0xcc07f46d.RoseDeep, 0.2f);
        }
    }

    private Vector2 _0x5a6c8f56;
    private void Awake()
    {
        _0x978b485d.Shape(this._chapterLabel, 34f, 48f);
        _0x978b485d.Shape(this._objectiveLabel, 30f, 40f);
        _0x978b485d.Shape(this._bloomLabel, 32f, 44f);
        _0x978b485d.Shape(this._movesValue, 48f, 64f);
        _0x978b485d.Shape(this._movesCaption, 26f, 30f);
        _0x978b485d.Shape(this._hintLabel, 30f, 44f);
        _0x978b485d.Shape(this._hintCaptionTop, 30f, 40f);
        _0x978b485d.Shape(this._hintCaptionBottom, 30f, 40f);
        _0x978b485d.Shape(this._refundFloat, 30f, 42f);
        _0x978b485d.ApplyOutline(this._chapterLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._objectiveLabel, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._bloomLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._movesValue, _0xcc07f46d.RoseDeep);
        _0x978b485d.ApplyOutline(this._movesCaption, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._hintLabel, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._hintCaptionTop, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._hintCaptionBottom, _0xcc07f46d.InkSoft);
        _0x978b485d.ApplyOutline(this._refundFloat, _0xcc07f46d.MintDeep);
        if (this._objectiveLabel != null)
            this._objectiveLabel.text = _0x4389a912._0x50ea9bbb(new byte[18] { 251, 236, 250, 253, 230, 251, 236, 137, 253, 225, 236, 137, 228, 230, 250, 232, 224, 234 }, 169);
        if (this._movesCaption != null)
            this._movesCaption.text = _0x4389a912._0x50ea9bbb(new byte[5] { 23, 21, 12, 31, 9 }, 90);
        if (this._hintCaptionTop != null)
            this._hintCaptionTop.text = _0x4389a912._0x50ea9bbb(new byte[29] { 129, 148, 133, 245, 148, 245, 129, 156, 153, 144, 249, 245, 129, 157, 144, 155, 245, 129, 148, 133, 245, 148, 155, 245, 148, 135, 135, 154, 130 }, 213);
        if (this._hintCaptionBottom != null)
            this._hintCaptionBottom.text = _0x4389a912._0x50ea9bbb(new byte[17] { 118, 115, 116, 127, 105, 26, 109, 104, 123, 106, 26, 123, 104, 117, 111, 116, 126 }, 58);
        if (this._refundRect != null)
        {
            this._0x5a6c8f56 = this._refundRect.anchoredPosition;
            this._refundRect.gameObject.SetActive(false);
        }
    }

    public void _0x49048128(int _0x6aff8fcc)
    {
        if (this._chapterLabel != null)
            this._chapterLabel.text = _0x4389a912._0x50ea9bbb(new byte[8] { 254, 245, 252, 237, 233, 248, 239, 157 }, 189) + (_0x6aff8fcc + 1);
    }

    [SerializeField]
    private TMP_Text _hintCaptionTop;
    [SerializeField]
    private RectTransform _ribbonTrack;
    [SerializeField]
    private TMP_Text _objectiveLabel;
    [SerializeField]
    private TMP_Text _hintCaptionBottom;
    public void _0x526ceec7(int _0x8e706656)
    {
        if (this._movesValue != null)
            this._movesValue.text = _0x8e706656.ToString();
    }

    [SerializeField]
    private RectTransform _ribbonFill;
    [SerializeField]
    private TMP_Text _movesCaption;
    private void OnDestroy()
    {
        if (this._refundRect != null)
            DOTween.Kill(this._refundRect);
        if (this._refundFloat != null)
            DOTween.Kill(this._refundFloat);
    }

    public void _0xf8c18491(int _0x72544cc9, int _0xd21d5252)
    {
        if (this._bloomLabel != null)
            this._bloomLabel.text = _0x4389a912._0x50ea9bbb(new byte[8] { 252, 242, 241, 241, 243, 251, 250, 158 }, 190) + _0x72544cc9 + _0x4389a912._0x50ea9bbb(new byte[3] { 126, 113, 126 }, 94) + _0xd21d5252;
        if (this._ribbonFill != null && this._ribbonTrack != null)
        {
            float width = this._ribbonTrack.rect.width;
            float _0x63a73d8d = _0xd21d5252 <= 0 ? 0f : (float)_0x72544cc9 / _0xd21d5252;
            // Left-anchored fill: the rect grows from the track's left edge, so the
            // inset is the anchored x and the pivot carries the direction.
            this._ribbonFill.anchoredPosition = new Vector2(0f, 0f);
            this._ribbonFill.sizeDelta = new Vector2(Mathf.Max(8f, width * _0x63a73d8d), this._ribbonFill.sizeDelta.y);
        }
    }
}

internal static class _0x4389a912
{
    internal static string _0x50ea9bbb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}