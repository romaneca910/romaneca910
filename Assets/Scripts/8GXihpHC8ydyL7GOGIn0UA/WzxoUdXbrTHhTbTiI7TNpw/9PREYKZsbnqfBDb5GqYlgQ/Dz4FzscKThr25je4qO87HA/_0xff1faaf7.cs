using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xff1faaf7 : MonoBehaviour
{
    public void _0xe247fe48()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public float scaleDuration = 0.4f;
    public bool IsScaledDownOnAwake = true;
    public static void HideAllPops()
    {
        _0x5612c582.Instance._0xdc86637d();
    }

    private void _0x8de371fe()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public GameObject Content;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x8de371fe();
    }

    public TMP_Text ContentHeaderText;
    public TMP_Text ContentMainText;
    private bool _0x1038d9de => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public bool IsOnlyYScale;
    public TMP_Text ContentAdditionalText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public Image ContentImage;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public Ease ease = Ease.OutSine;
}