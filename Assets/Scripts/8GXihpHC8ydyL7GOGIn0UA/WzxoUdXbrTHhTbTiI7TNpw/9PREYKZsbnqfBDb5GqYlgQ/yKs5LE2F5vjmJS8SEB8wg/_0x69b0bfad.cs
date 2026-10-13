using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x69b0bfad : MonoBehaviour
{
    public void _0xf713c94d()
    {
        this._0x616de61a();
        bool _0x25ce6429 = _0x40d95fe5;
        this._0x64a9c08f = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x2ff94d37 => this.AnimationSlider.value = _0x2ff94d37, _0x25ce6429 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x40d95fe5 = !_0x40d95fe5;
    }

    public static _0x69b0bfad Instance;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xe5719494._0x232968b9.SCENE_0 && !_0x40d95fe5)
        {
            this._0x975712fb();
        }
        else
        {
            this._0xf713c94d();
        }
    }

    public GameObject Background;
    public void _0xf780e62b()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x64a9c08f?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x40d95fe5 = false;
    }

    public void _0x613135c7()
    {
        this._0x64a9c08f?.Play();
    }

    public void _0x510c02f6()
    {
        this._0x64a9c08f?.Pause();
    }

    private Sequence _0x64a9c08f;
    public float DefaultAnimationTime = 0.4f;
    public float SecondPassSliderValue = 0.5f;
    private void _0x975712fb()
    {
        this.AnimationSlider.value = 0.05f;
        _0x40d95fe5 = !_0x40d95fe5;
        this._0x64a9c08f = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x2ff94d37 => this.AnimationSlider.value = _0x2ff94d37, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xde141cf2._0xdf32a2c3?._0xf0a60d8f();
        });
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x69b0bfad>();
    }

    public Slider AnimationSlider;
    public GameObject Content;
    private static bool _0x40d95fe5 = false;
    public GameObject Error;
    public void _0x616de61a()
    {
        this._0x64a9c08f?.Kill();
        this.AnimationSlider.value = _0x40d95fe5 ? this.SecondPassSliderValue : 0.05f;
    }

    public float FirstAnimationTime = 10.0f;
}