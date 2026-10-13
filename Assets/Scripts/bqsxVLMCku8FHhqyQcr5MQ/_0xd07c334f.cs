using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The Moon Pad: four arrows that shift the selected line one cell. LEFT and RIGHT move
// the selected ROW, UP and DOWN move the selected COLUMN, and the selection survives a
// move so one finger can nudge the same line repeatedly.
public sealed class _0xd07c334f : MonoBehaviour
{
    // The hint pulses the arrow that performs the suggested move in gold, and the hint
    // itself moves nothing - the player taps to confirm.
    public void _0x2ec71371(MosaicMove _0xfb8a0ec3, float _0xec3139e8)
    {
        RectTransform _0x3e4840a7 = this._0x5087e872(_0xfb8a0ec3);
        if (_0x3e4840a7 == null)
            return;
        DOTween.Kill(_0x3e4840a7);
        _0x3e4840a7.localScale = Vector3.one;
        _0x3e4840a7.DOPunchScale(new Vector3(0.16f, 0.16f, 0f), 2.5f * _0xec3139e8, 4, 0.5f).SetLink(_0x3e4840a7.gameObject);
    }

    [SerializeField]
    private _0xb424dc92 _director;
    private void Start()
    {
        if (this._left != null)
            this._left.onClick.AddListener(() => this._0x9bb9fb9a(0, -1));
        if (this._right != null)
            this._right.onClick.AddListener(() => this._0x9bb9fb9a(0, 1));
        if (this._up != null)
            this._up.onClick.AddListener(() => this._0x9bb9fb9a(1, -1));
        if (this._down != null)
            this._down.onClick.AddListener(() => this._0x9bb9fb9a(1, 1));
        this._0xbee3f9e4(false, false, false, false);
    }

    private RectTransform _0x5087e872(MosaicMove _0x7572b3dd)
    {
        Button _0x7baf79a3;
        if (_0x7572b3dd.Axis == 0)
            _0x7baf79a3 = _0x7572b3dd.Step > 0 ? this._right : this._left;
        else
            _0x7baf79a3 = _0x7572b3dd.Step > 0 ? this._down : this._up;
        return _0x7baf79a3 == null ? null : _0x7baf79a3.transform as RectTransform;
    }

    [SerializeField]
    private CanvasGroup _upGroup;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform);
    }

    // With nothing selected the arrows are dim and not interactable; a line that is
    // already uniform disables its own pair, because that move would change nothing.
    public void _0xbee3f9e4(bool _0x04aaaf55, bool _0x6a3ee15e, bool _0x9a16c5c7, bool _0x8e8c8f42)
    {
        Apply(this._left, this._leftGroup, _0x04aaaf55);
        Apply(this._right, this._rightGroup, _0x6a3ee15e);
        Apply(this._up, this._upGroup, _0x9a16c5c7);
        Apply(this._down, this._downGroup, _0x8e8c8f42);
    }

    [SerializeField]
    private CanvasGroup _rightGroup;
    [SerializeField]
    private Button _up;
    [SerializeField]
    private Button _left;
    [SerializeField]
    private Button _right;
    private void _0x9bb9fb9a(int _0x1271ca07, int _0x5708ece7)
    {
        if (this._director != null)
            this._director._0xb100c651(_0x1271ca07, _0x5708ece7);
    }

    [SerializeField]
    private CanvasGroup _leftGroup;
    [SerializeField]
    private Button _down;
    [SerializeField]
    private CanvasGroup _downGroup;
    private static void Apply(Button _0xdea1a06f, CanvasGroup _0xc5ce3944, bool _0x2a4d1114)
    {
        if (_0xdea1a06f != null)
            _0xdea1a06f.interactable = _0x2a4d1114;
        if (_0xc5ce3944 != null)
            _0xc5ce3944.alpha = _0x2a4d1114 ? 1f : 0.35f;
    }
}