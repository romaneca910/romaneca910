using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The splash: an abstract mark - a cream crescent holding five petals - breathing over
// a blush wash, a single functional caption, drifting petals, and the template loading
// bar themed so it is actually visible. No name, no title, no tagline anywhere here.
public sealed class _0x9dde8968 : MonoBehaviour
{
    [SerializeField]
    private RectTransform[] _petals;
    // The template ships the bar white on a track at alpha 0.004 - invisible at any
    // size. The root is given a real height well clear of the Fill Area's own 30-unit
    // inset, the inner rects are re-stretched so that inset cannot apply twice, and the
    // two colours are taken from the palette.
    private void _0x1fe28e3f()
    {
        if (_0x5e1e2fdc.Instance == null)
            return;
        _0xe215cc14 _0xb23a1f43 = _0x5e1e2fdc.Instance.Panels[_0xe5719494._0x6888be17.SPLASH];
        if (_0xb23a1f43 == null || _0xb23a1f43.Content == null)
            return;
        Slider _0x159cc634 = _0xb23a1f43.Content.GetComponentInChildren<Slider>(true);
        if (_0x159cc634 == null)
            return;
        RectTransform _0x12744efc = _0x159cc634.transform.parent != null ? _0x159cc634.transform.parent.parent as RectTransform : null;
        if (_0x12744efc != null)
            _0x12744efc.sizeDelta = new Vector2(BarWidth, BarHeight);
        Stretch(_0x159cc634.transform.parent as RectTransform);
        Stretch(_0x159cc634.transform as RectTransform);
        RectTransform _0x632d0aa5 = _0x159cc634.fillRect != null ? _0x159cc634.fillRect.parent as RectTransform : null;
        Stretch(_0x632d0aa5);
        Image _0xfe8758bf = _0x632d0aa5 != null ? _0x632d0aa5.GetComponent<Image>() : null;
        Image _0xa1d5e0c4 = _0x159cc634.fillRect != null ? _0x159cc634.fillRect.GetComponent<Image>() : null;
        if (_0xfe8758bf != null)
        {
            _0xfe8758bf.color = _0xcc07f46d.TrackInk;
            _0xfe8758bf.pixelsPerUnitMultiplier = 0.5f;
        }

        if (_0xa1d5e0c4 != null)
        {
            _0xa1d5e0c4.color = _0xcc07f46d.Rose;
            _0xa1d5e0c4.pixelsPerUnitMultiplier = 0.5f;
        }
    }

    // Anchors 0..1 with explicit offsets: the prefab's own inset cannot shrink a rect
    // that has been re-stretched, and the Fill itself is left alone because
    // Slider.UpdateVisuals rewrites its anchors every frame.
    private static void Stretch(RectTransform _0x63b0f947)
    {
        if (_0x63b0f947 == null)
            return;
        _0x63b0f947.anchorMin = Vector2.zero;
        _0x63b0f947.anchorMax = Vector2.one;
        _0x63b0f947.offsetMin = Vector2.zero;
        _0x63b0f947.offsetMax = Vector2.zero;
    }

    private void _0xabd9fdff()
    {
        if (this._mark == null || this._markGroup == null)
            return;
        this._markGroup.alpha = 0f;
        this._mark.localScale = Vector3.one * 0.86f;
        this._markGroup.DOFade(1f, 0.35f).SetLink(this._mark.gameObject);
        this._mark.DOScale(1f, 0.35f).SetEase(Ease.OutBack).SetLink(this._mark.gameObject);
        this._mark.DOScale(1.04f, 2.2f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetDelay(0.4f).SetLink(this._mark.gameObject);
    }

    private void _0xdb37b469()
    {
        if (this._petals == null)
            return;
        for (int _0x90a3f5a6 = 0; _0x90a3f5a6 < this._petals.Length; _0x90a3f5a6++)
        {
            RectTransform _0xfd794438 = this._petals[_0x90a3f5a6];
            if (_0xfd794438 == null)
                continue;
            float _0x8929ff92 = 1500f + _0x90a3f5a6 * 160f;
            float _0x55b60c2d = _0xfd794438.anchoredPosition.y;
            _0xfd794438.anchoredPosition = new Vector2(_0xfd794438.anchoredPosition.x, _0x55b60c2d);
            _0xfd794438.DOAnchorPosY(_0x55b60c2d - _0x8929ff92, 9f + _0x90a3f5a6 * 1.1f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetLink(_0xfd794438.gameObject);
        }
    }

    private void Start()
    {
        _0x978b485d.Shape(this._caption, 32f, 44f);
        _0x978b485d.ApplyOutline(this._caption, _0xcc07f46d.InkSoft);
        if (this._caption != null)
            this._caption.text = _0x6cb668d4._0xe4a08bc0(new byte[20] { 25, 27, 12, 25, 8, 27, 0, 7, 14, 105, 29, 1, 12, 105, 14, 8, 27, 13, 12, 7 }, 73);
        this._0xabd9fdff();
        this._0xdb37b469();
        this._0x1fe28e3f();
    }

    private const float BarWidth = 640f;
    private const float BarHeight = 48f;
    [SerializeField]
    private RectTransform _mark;
    [SerializeField]
    private TMP_Text _caption;
    private void OnDestroy()
    {
        if (this._mark != null)
            DOTween.Kill(this._mark);
        if (this._markGroup != null)
            DOTween.Kill(this._markGroup);
        if (this._petals == null)
            return;
        for (int _0xc0d77fe0 = 0; _0xc0d77fe0 < this._petals.Length; _0xc0d77fe0++)
            if (this._petals[_0xc0d77fe0] != null)
                DOTween.Kill(this._petals[_0xc0d77fe0]);
    }

    [SerializeField]
    private CanvasGroup _markGroup;
}

internal static class _0x6cb668d4
{
    internal static string _0xe4a08bc0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}