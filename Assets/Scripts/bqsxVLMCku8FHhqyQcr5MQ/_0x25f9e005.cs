using DG.Tweening;
using UnityEngine;

// Show/hide for a sheet of our own. Codegen reliably controls only what it created
// itself (rule C.2), so overlays are gated through a serialized reference to their own
// content object, never by reaching into a template panel.
public sealed class _0x25f9e005 : MonoBehaviour
{
    public void Show(float _0xfe8a5ce9)
    {
        if (this._content == null)
            return;
        this._content.SetActive(true);
        if (this._group == null)
            return;
        this._group.alpha = 0f;
        this._group.blocksRaycasts = true;
        this._group.DOFade(1f, _0xfe8a5ce9).SetEase(Ease.OutCubic).SetLink(this.gameObject);
    }

    [SerializeField]
    private GameObject _content;
    private void OnDestroy()
    {
        if (this._group != null)
            DOTween.Kill(this._group);
    }

    public bool _0xfe62b1fc
    {
        get
        {
            return this._content != null && this._content.activeSelf;
        }
    }

    public void _0x96c1aad5()
    {
        if (this._content == null)
            return;
        if (this._group != null)
        {
            this._group.alpha = 1f;
            this._group.blocksRaycasts = false;
        }

        this._content.SetActive(false);
    }

    [SerializeField]
    private CanvasGroup _group;
}