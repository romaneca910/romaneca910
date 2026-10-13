using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// One cell of the mosaic: ceramic plate, blossom, bloom wreath and the colour-blind
// shape badge. Taps come through the EventSystem, which this template drives with
// InputSystemUIInputModule, so no legacy input and no touch plumbing of our own.
public sealed class _0x4e485200 : MonoBehaviour, IPointerClickHandler
{
    // A tile that has landed on its place in the pattern stays bright and keeps its
    // wreath; one that is shifted off it dims again. Both read at a glance.
    public void _0x68719d7b(bool _0xab1740e5, Color _0x1cbce6c5, float _0x88d56028, bool _0xd90c60ae)
    {
        bool _0x0bb09e92 = _0xab1740e5 != this._0x28f21ab1;
        this._0x28f21ab1 = _0xab1740e5;
        if (this._plate != null)
            this._plate.color = _0xcc07f46d.Fade(_0x1cbce6c5, _0xab1740e5 ? 0.85f : 0.30f);
        if (this._flower != null)
            this._flower.color = _0xab1740e5 ? Color.white : new Color(0.82f, 0.78f, 0.82f, 0.92f);
        if (this._ring != null)
        {
            DOTween.Kill(this._ring);
            if (_0xd90c60ae && _0x0bb09e92)
                this._ring.DOFade(_0xab1740e5 ? 0.75f : 0f, 0.18f * _0x88d56028).SetLink(this.gameObject);
            else
                this._ring.color = _0xcc07f46d.Fade(_0xcc07f46d.Gold, _0xab1740e5 ? 0.75f : 0f);
        }

        if (_0xd90c60ae && _0x0bb09e92 && _0xab1740e5 && this._rect != null)
        {
            DOTween.Kill(this._rect);
            this._rect.localScale = Vector3.one;
            this._rect.DOPunchScale(new Vector3(0.18f, 0.18f, 0f), 0.34f * _0x88d56028, 1, 0.6f).SetLink(this.gameObject);
        }
    }

    public void _0x23391216(float _0xae15263f)
    {
        if (this._rect != null)
            this._rect.sizeDelta = new Vector2(_0xae15263f, _0xae15263f);
        if (this._flower != null)
            this._flower.rectTransform.sizeDelta = new Vector2(_0xae15263f * 0.70f, _0xae15263f * 0.70f);
        if (this._ring != null)
            this._ring.rectTransform.sizeDelta = new Vector2(_0xae15263f * 1.02f, _0xae15263f * 1.02f);
    }

    [SerializeField]
    private TMP_Text _badge;
    [SerializeField]
    private RectTransform _rect;
    public void _0x9004dd99(bool _0x6c2aabf4, float _0x32259a8a)
    {
        if (this._plate == null)
            return;
        DOTween.Kill(this._plate.transform);
        if (!_0x6c2aabf4)
        {
            this._plate.transform.localScale = Vector3.one;
            return;
        }

        this._plate.transform.localScale = Vector3.one;
        this._plate.transform.DOScale(1.06f, 0.16f * _0x32259a8a).SetLoops(2, LoopType.Yoyo).SetLink(this.gameObject);
    }

    public void _0x0fe30074(Sprite _0xba2e98ef, Color _0xe5bcb47a, string _0x2ecb20b3, bool _0x8eb77f1c)
    {
        if (this._flower != null)
        {
            this._flower.sprite = _0xba2e98ef;
            this._flower.preserveAspect = true;
            this._flower.color = Color.white;
        }

        if (this._plate != null)
            this._plate.color = _0xcc07f46d.Fade(_0xe5bcb47a, 0.34f);
        if (this._badge != null)
        {
            this._badge.gameObject.SetActive(_0x8eb77f1c);
            this._badge.text = _0x2ecb20b3;
            _0x978b485d.ApplyOutline(this._badge, _0xcc07f46d.Ink);
        }
    }

    private int _0xc7df7578;
    public void OnPointerClick(PointerEventData _0xc76c4565)
    {
        if (this._0x44ce84c2 != null)
            this._0x44ce84c2._0xa75d7181(this._0xc7df7578);
    }

    public void _0x0c24644f(_0xf8783d9f _0x2aaefab4, int _0xf222ca97)
    {
        this._0x44ce84c2 = _0x2aaefab4;
        this._0xc7df7578 = _0xf222ca97;
        if (this._ring != null)
            this._ring.color = _0xcc07f46d.Fade(_0xcc07f46d.Gold, 0f);
        if (this._badge != null)
            _0x978b485d.Shape(this._badge, 24f, 34f);
    }

    [SerializeField]
    private Image _flower;
    private void OnDestroy()
    {
        if (this._ring != null)
            DOTween.Kill(this._ring);
        if (this._rect != null)
            DOTween.Kill(this._rect);
        if (this._plate != null)
            DOTween.Kill(this._plate.transform);
    }

    private _0xf8783d9f _0x44ce84c2;
    public int _0x82149d31
    {
        get
        {
            return this._0xc7df7578;
        }
    }

    public RectTransform _0x4440f0a8
    {
        get
        {
            return this._rect;
        }
    }

    private bool _0x28f21ab1;
    [SerializeField]
    private Image _ring;
    [SerializeField]
    private Image _plate;
}