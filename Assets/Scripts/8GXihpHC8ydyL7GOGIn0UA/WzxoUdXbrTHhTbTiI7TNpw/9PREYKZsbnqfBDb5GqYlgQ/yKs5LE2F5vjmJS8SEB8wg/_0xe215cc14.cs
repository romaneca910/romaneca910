using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xe215cc14 : MonoBehaviour
{
    private void _0xe55c4e72()
    {
        if (this.OuterBackground != null)
        {
            Image _0x3d19fafd = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x3d19fafd, true);
            _0x3d19fafd.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text MainText;
    public void _0x984b8644()
    {
        this._0xe7e36db1();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x5e1e2fdc.Instance._0x85e1ccb4(_0x5e1e2fdc.Instance.CurrentPanelIndex);
    }

    public Ease Ease = Ease.OutSine;
    private void _0xe7e36db1()
    {
        if (this.OuterBackground != null)
        {
            Image _0x20f6e870 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x20f6e870, true);
            _0x20f6e870.DOFade(1f, 0f);
        }
    }

    private bool _0x8afc1aaf => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void _0x56489c01()
    {
        this._0x6a25f8bd();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public GameObject OuterBackground;
    private void _0x6a25f8bd()
    {
        if (this.OuterBackground != null)
        {
            Image _0x2fe51e47 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x2fe51e47, true);
            _0x2fe51e47.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x9ded29ab()
    {
        if (this.OuterBackground != null)
        {
            Image _0x114ea765 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x114ea765, true);
            _0x114ea765.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public TMP_Text HeaderText;
    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xe55c4e72();
    }

    public void Show()
    {
        this._0x9ded29ab();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x5e1e2fdc.Instance._0x85e1ccb4(_0x5e1e2fdc.Instance.CurrentPanelIndex);
            });
        }
    }

    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
}