using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The rules of the round. Nothing chases the player: there is no clock and no draining
// meter, so a run in which nobody taps lasts for ever and the review capture always
// photographs gameplay rather than a defeat card.
public sealed class _0xb424dc92 : MonoBehaviour
{
    private void _0xd4d6eb29()
    {
        if (this._hintRabbit == null || this._hintRabbitGroup == null)
            return;
        DOTween.Kill(this._hintRabbitGroup);
        DOTween.Kill(this._hintRabbit);
        this._hintRabbitGroup.alpha = 0f;
        this._hintRabbit.localScale = Vector3.one * 0.86f;
        this._hintRabbitGroup.DOFade(1f, 0.25f * this._0x6ca90cfb).SetLink(this.gameObject);
        this._hintRabbit.DOScale(1f, 0.32f * this._0x6ca90cfb).SetEase(Ease.OutBack).SetLink(this.gameObject);
    }

    public void _0xa421cc4d()
    {
        _0x5612c582.Instance._0xdc86637d();
        _0x5c5bbf39.Instance._0x692bc316(true);
    }

    private bool _0xda4f2f5a
    {
        get
        {
            return this._progress != null && this._progress._0x4678db12;
        }
    }

    [SerializeField]
    private CanvasGroup _hintRabbitGroup;
    private void _0xcfb86ab2()
    {
        if (this._0xc3eed0d6 || this._pops == null)
            return;
        this._0x081e4f20._0x637266e1(this._0x7ddbe1e4);
        _0x5c5bbf39.Instance._0x692bc316(false);
        this._pops._0x5e819d8d(this._0xd1850638, this._0xe5c26384, this._0x081e4f20._0xeeab8362);
    }

    public void _0xc565b8de()
    {
        if (this._0xc3eed0d6 || this._board == null || this._board._0x02088b5b || this._progress == null)
            return;
        if (this._progress._0x00234e15 <= 0)
            return;
        this._0x081e4f20._0x637266e1(this._0x7ddbe1e4);
        if (this._0x081e4f20._0xeeab8362 == 0)
            return;
        MosaicMove _0xfa703ff2 = this._0x081e4f20._0x55acbed4();
        this._progress._0x00234e15 = this._progress._0x00234e15 - 1;
        if (this._hud != null)
            this._hud._0x83440c60(this._progress._0x00234e15);
        // Three confirmations at once: the counter drops, the rabbit pops in beside the
        // board and the line flashes, then the arrow that performs the move pulses gold.
        this._0xd4d6eb29();
        int _0xc51caea2 = this._0x8b537c92 < 0 ? _0x818cf24c.Side / 2 : this._0x8b537c92;
        int _0x03acbf54 = this._0x687632ea < 0 ? _0x818cf24c.Side / 2 : this._0x687632ea;
        if (_0xfa703ff2.Axis == 0)
            this._0x0976ac60(_0xc51caea2, _0xfa703ff2.Index);
        else
            this._0x0976ac60(_0xfa703ff2.Index, _0x03acbf54);
        this._board._0x5e3590c4(_0xfa703ff2, this._0x6ca90cfb);
        if (this._pad != null)
            this._pad._0x2ec71371(_0xfa703ff2, this._0x6ca90cfb);
    }

    [SerializeField]
    private RectTransform _hintRabbit;
    [SerializeField]
    private _0xf8783d9f _board;
    private readonly _0xca94471f _0xc7cb2ff3 = new _0xca94471f();
    private void OnDestroy()
    {
        if (this._hintRabbitGroup != null)
            DOTween.Kill(this._hintRabbitGroup);
        if (this._hintRabbit != null)
            DOTween.Kill(this._hintRabbit);
    }

    private _0x90a58e17 _0x081e4f20;
    private int _0xf2306795;
    private void _0x1fda95b9()
    {
        this._0xc3eed0d6 = true;
        if (this._board != null)
            this._board._0xf59039b3();
        this._0xadfe3712();
        if (this._progress != null)
            this._progress._0x760b43bf();
        if (this._pops != null)
            this._pops._0x4796052b(this._0xd1850638, this._0x7ddbe1e4._0xfa629f0a(this._0x7610808b), this._0x081e4f20._0xeeab8362);
    }

    // Arrows are dim with nothing selected, and a uniform line disables its own pair:
    // that move would be a visible no-op and reads as a dead button.
    private void _0xadfe3712()
    {
        if (this._pad == null)
            return;
        if (this._0xc3eed0d6 || this._0x8b537c92 < 0 || this._0x7ddbe1e4 == null)
        {
            this._pad._0xbee3f9e4(false, false, false, false);
            return;
        }

        bool _0xd47cb1c5 = !this._0x7ddbe1e4._0x253ca45d(new MosaicMove(0, this._0x687632ea, 1));
        bool _0xf64a2f73 = !this._0x7ddbe1e4._0x253ca45d(new MosaicMove(1, this._0x8b537c92, 1));
        this._pad._0xbee3f9e4(_0xd47cb1c5, _0xd47cb1c5, _0xf64a2f73, _0xf64a2f73);
    }

    private void _0x8be8bb74(bool _0xe01f3577)
    {
        if (this._board == null || this._0x7ddbe1e4 == null)
            return;
        this._board._0xbeaac7dd(this._0x7ddbe1e4, this._0x7610808b, this._0xda4f2f5a, this._0x6ca90cfb, _0xe01f3577);
        if (this._hud != null)
        {
            this._hud._0xf8c18491(this._0x7ddbe1e4._0xfa629f0a(this._0x7610808b), _0x818cf24c.Cells);
            this._hud._0x4e781b6a(this._0xf2306795 / _0xa2e487e5.LineRefund);
        }
    }

    private void _0xee335860(int _0x10b74d81, int _0x9ef1cf63)
    {
        this._0xd1850638 = Mathf.Clamp(_0x10b74d81, 0, _0xa2e487e5.Count - 1);
        int _0x58833aeb = _0xa2e487e5.Depth(this._0xd1850638);
        this._0xc7cb2ff3._0xe1f34cff(this._0xd1850638, _0x9ef1cf63, _0x58833aeb);
        this._0x7ddbe1e4 = this._0xc7cb2ff3._0x68afb7fd;
        this._0x7610808b = this._0xc7cb2ff3._0xc0c4501d;
        this._0x081e4f20 = this._0xc7cb2ff3._0x99695452;
        this._0xe5c26384 = _0xa2e487e5.Budget(this._0xd1850638);
        this._0xf2306795 = 0;
        this._0xc3eed0d6 = false;
        this._0x8b537c92 = -1;
        this._0x687632ea = -1;
        // A scrambled board can open with a line already in place. Those are marked
        // claimed up front and pay nothing: the refund is for a line the PLAYER
        // completed, and handing out free moves at the first tap would make the budget
        // mean less than it says.
        for (int _0xdb2db9dc = 0; _0xdb2db9dc < _0x818cf24c.Side; _0xdb2db9dc++)
        {
            this._0x2c6faabb[_0xdb2db9dc] = this._0x7ddbe1e4._0xdc411e2a(this._0x7610808b, _0xdb2db9dc);
            this._0x2c6faabb[_0x818cf24c.Side + _0xdb2db9dc] = this._0x7ddbe1e4._0xce390ea6(this._0x7610808b, _0xdb2db9dc);
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xbec484ae._0x4891ddca(new byte[14] { 92, 106, 104, 116, 102, 110, 100, 90, 39, 116, 98, 98, 99, 58 }, 7) + this._0xc7cb2ff3._0xafaae837 + _0xbec484ae._0x4891ddca(new byte[9] { 125, 62, 53, 60, 45, 41, 56, 47, 96 }, 93) + this._0xd1850638 + _0xbec484ae._0x4891ddca(new byte[7] { 14, 74, 75, 94, 90, 70, 19 }, 46) + _0x58833aeb + _0xbec484ae._0x4891ddca(new byte[10] { 99, 48, 44, 47, 54, 55, 42, 44, 45, 126 }, 67) + this._0x081e4f20._0xeeab8362 + _0xbec484ae._0x4891ddca(new byte[10] { 161, 231, 224, 237, 237, 227, 224, 226, 234, 188 }, 129) + this._0xc7cb2ff3._0x32589670);
            }
#endif
        }

        if (this._hud != null)
        {
            this._hud._0x49048128(this._0xd1850638);
            this._hud._0x526ceec7(this._0xe5c26384);
            this._hud._0x83440c60(this._progress != null ? this._progress._0x00234e15 : 0);
        }

        if (this._board != null)
            this._board._0xf59039b3();
        if (this._0xa77b5c30)
            this._0x8be8bb74(false);
        this._0xadfe3712();
    }

    // The board view reports its real cell size once the canvas has a rect; the first
    // paint happens then, not in Awake, where that rect is still zero.
    public void _0x8c7128e9()
    {
        this._0xa77b5c30 = true;
        this._0x8be8bb74(false);
    }

    private bool _0xc3eed0d6;
    private void _0x06cc1bf2()
    {
        int _0x8f585085 = this._0x9d22b567();
        if (this._hud != null)
        {
            this._hud._0xf8c18491(this._0x7ddbe1e4._0xfa629f0a(this._0x7610808b), _0x818cf24c.Cells);
            this._hud._0x4e781b6a(this._0xf2306795 / _0xa2e487e5.LineRefund);
            this._hud._0x526ceec7(this._0xe5c26384);
            if (_0x8f585085 > 0)
                this._hud._0x4c4147b4(_0x8f585085, this._0x6ca90cfb);
        }

        if (this._0x7ddbe1e4._0x368e7ead(this._0x7610808b))
        {
            this._0x4c485eb5();
            return;
        }

        if (this._0xe5c26384 <= 0)
        {
            this._0x1fda95b9();
            return;
        }

        if (this._0x8b537c92 >= 0)
            this._board._0x2ed415af(this._0x8b537c92, this._0x687632ea, this._0x6ca90cfb);
        this._0xadfe3712();
    }

    public void _0x0976ac60(int _0xea3264fa, int _0x9c3ab824)
    {
        if (this._0xc3eed0d6 || this._board == null || this._board._0x02088b5b)
            return;
        this._0x8b537c92 = _0xea3264fa;
        this._0x687632ea = _0x9c3ab824;
        this._board._0x2ed415af(_0xea3264fa, _0x9c3ab824, this._0x6ca90cfb);
        this._0xadfe3712();
    }

    [SerializeField]
    private _0x940e3959 _pops;
    private void _0x4c485eb5()
    {
        this._0xc3eed0d6 = true;
        if (this._board != null)
            this._board._0xf59039b3();
        this._0xadfe3712();
        int _0x8b0a2d29 = this._0xf2306795 / _0xa2e487e5.LineRefund;
        if (this._progress != null)
        {
            this._progress._0xfd30ec8c(this._0xd1850638, this._0xe5c26384);
            this._progress._0x039bba86(this._0xd1850638);
            this._progress._0x00234e15 = this._progress._0x00234e15 + 1;
            this._progress._0x760b43bf();
        }

        bool _0x5df27bc9 = this._0xd1850638 >= _0xa2e487e5.Count - 1;
        int _0xfeb8a3fb = this._progress != null ? this._progress._0x00234e15 : 0;
        int _0xc1172c6c = this._0xe5c26384;
        if (this._board == null)
        {
            if (this._pops != null)
                this._pops._0x8d522899(this._0xd1850638, _0xc1172c6c, _0x8b0a2d29, _0xfeb8a3fb, _0x5df27bc9);
            return;
        }

        this._board._0x3406818c(this._0x6ca90cfb, () =>
        {
            if (this._pops != null)
                this._pops._0x8d522899(this._0xd1850638, _0xc1172c6c, _0x8b0a2d29, _0xfeb8a3fb, _0x5df27bc9);
        });
    }

    public void _0x5f7a7403()
    {
        if (this._progress == null)
        {
            this._0xcc6520fc();
            return;
        }

        if (this._0xd1850638 >= _0xa2e487e5.Count - 1)
        {
            this._0xcc6520fc();
            return;
        }

        this._progress._0x0bb5c853 = this._0xd1850638 + 1;
        this._progress._0x760b43bf();
        _0x5612c582.Instance._0xdc86637d();
        _0x5c5bbf39.Instance._0x692bc316(true);
        this._0xee335860(this._0xd1850638 + 1, Mathf.Abs(Time.frameCount) % 997);
    }

    [SerializeField]
    private Button _backButton;
    [SerializeField]
    private _0xfc9e8c39 _progress;
    public void _0x2ea27ba4()
    {
        _0x5612c582.Instance._0xdc86637d();
        _0x5c5bbf39.Instance._0x692bc316(true);
        this._0xee335860(this._0xd1850638, Mathf.Abs(Time.frameCount) % 997 + 1);
    }

    private int _0xd1850638;
    [SerializeField]
    private _0x32b8946e _hud;
    private _0x818cf24c _0x7610808b;
    private bool _0xa77b5c30;
    // Completing a whole row or column that matches the pattern lights a lantern,
    // presses one flower into the album and refunds two moves, capped at ten so the
    // budget stays a budget.
    private int _0x9d22b567()
    {
        int _0x28ffb0e9 = 0;
        for (int _0xbada1581 = 0; _0xbada1581 < _0x818cf24c.Side; _0xbada1581++)
        {
            if (this._0x2c6faabb[_0xbada1581] || !this._0x7ddbe1e4._0xdc411e2a(this._0x7610808b, _0xbada1581))
                continue;
            this._0x2c6faabb[_0xbada1581] = true;
            _0x28ffb0e9 += this._0xad325a02();
        }

        for (int _0x45c12a64 = 0; _0x45c12a64 < _0x818cf24c.Side; _0x45c12a64++)
        {
            int _0x890a9344 = _0x818cf24c.Side + _0x45c12a64;
            if (this._0x2c6faabb[_0x890a9344] || !this._0x7ddbe1e4._0xce390ea6(this._0x7610808b, _0x45c12a64))
                continue;
            this._0x2c6faabb[_0x890a9344] = true;
            _0x28ffb0e9 += this._0xad325a02();
        }

        return _0x28ffb0e9;
    }

    private int _0xad325a02()
    {
        if (this._progress != null)
        {
            this._progress._0x1b391815(this._0xd1850638);
            this._progress._0x19cfdbdc = this._progress._0x19cfdbdc + 1;
        }

        if (this._0xf2306795 >= _0xa2e487e5.RefundCap)
            return 0;
        this._0xf2306795 += _0xa2e487e5.LineRefund;
        this._0xe5c26384 += _0xa2e487e5.LineRefund;
        return _0xa2e487e5.LineRefund;
    }

    private int _0x687632ea = -1;
    public void _0xcc6520fc()
    {
        if (this._progress != null)
            this._progress._0x760b43bf();
        _0x5c5bbf39.Instance._0x692bc316(true);
        _0x5c5bbf39.Instance._0x0fbeb264(_0xe5719494._0x232968b9.SCENE_0);
    }

    [SerializeField]
    private Button _pauseButton;
    private int _0xe5c26384;
    private float _0x6ca90cfb
    {
        get
        {
            return this._progress != null ? this._progress._0xfd7036ed : 1f;
        }
    }

    [SerializeField]
    private _0xd07c334f _pad;
    public void _0xb100c651(int _0x1e557370, int _0x2aeb6e81)
    {
        if (this._0xc3eed0d6 || this._0x8b537c92 < 0 || this._board == null || this._board._0x02088b5b)
            return;
        MosaicMove _0xa75fd1b5 = new MosaicMove(_0x1e557370, _0x1e557370 == 0 ? this._0x687632ea : this._0x8b537c92, _0x2aeb6e81);
        if (this._0x7ddbe1e4._0x253ca45d(_0xa75fd1b5))
            return;
        this._0x7ddbe1e4._0x2a3e48db(_0xa75fd1b5);
        this._0x081e4f20._0x9eb7093a(_0xa75fd1b5, this._0x7ddbe1e4);
        this._0xe5c26384--;
        if (this._pad != null)
            this._pad._0xbee3f9e4(false, false, false, false);
        this._board._0x0404a63c(_0xa75fd1b5, this._0x7ddbe1e4, this._0x7610808b, this._0xda4f2f5a, this._0x6ca90cfb, () => this._0x06cc1bf2());
    }

    private _0x818cf24c _0x7ddbe1e4;
    [SerializeField]
    private Button _hintButton;
    private void Start()
    {
        if (this._backButton != null)
            this._backButton.onClick.AddListener(() => this._0xcc6520fc());
        if (this._pauseButton != null)
            this._pauseButton.onClick.AddListener(() => this._0xcfb86ab2());
        if (this._hintButton != null)
            this._hintButton.onClick.AddListener(() => this._0xc565b8de());
        if (this._pops != null)
            this._pops._0xa2acd3c0();
        if (this._hintRabbitGroup != null)
            this._hintRabbitGroup.alpha = 0f;
        this._0xee335860(this._progress != null ? this._progress._0x0bb5c853 : 0, 0);
    }

    private readonly bool[] _0x2c6faabb = new bool[_0x818cf24c.Side * 2];
    private int _0x8b537c92 = -1;
}

internal static class _0xbec484ae
{
    internal static string _0x4891ddca(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}