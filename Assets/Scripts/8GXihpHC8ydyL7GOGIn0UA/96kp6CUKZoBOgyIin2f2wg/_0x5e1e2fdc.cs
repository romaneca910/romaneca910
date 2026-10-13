using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xe5719494;

public class _0x5e1e2fdc : MonoBehaviour
{
    private void SwitchSplash()
    {
        if (_0xe5a65c4a.Instance.IsTutorialEnabled && !_0x5c5bbf39._0x31526d8a._0xb52c1d57)
            this._0xbd172a36(_0x6888be17.TUTORIAL0);
        else
            this._0xbd172a36(_0x6888be17.DEFAULT);
    }

    private void _0xff919333(int _0x0546eed7)
    {
        this.LastPanelIndexes.Add(_0x0546eed7);
        this.CurrentPanelIndex = _0x0546eed7;
        for (int _0x6b123227 = 0; _0x6b123227 < this.Panels.Count; _0x6b123227++)
            if (_0x6b123227 != _0x0546eed7 && this.Panels[_0x6b123227] != null)
                this.Panels[_0x6b123227]._0x56489c01();
    }

    private void Start()
    {
        this._0x90ce9a2e();
    }

    public static _0x5e1e2fdc Instance;
    private void _0x963cc879(int _0xbf8655e7)
    {
        this._0xf2db9068(_0xbf8655e7);
        this._0x0047f9d3(_0xbf8655e7);
        this.CurrentPanelIndex = _0xbf8655e7;
        this.Panels[_0xbf8655e7]._0x984b8644();
    }

    public void _0x229498fc()
    {
        this.LastPanelIndexes.RemoveAll(_0x1d28526c => _0x1d28526c == this.CurrentPanelIndex);
        int _0xe668863e = this.LastPanelIndexes.Last();
        this._0x0047f9d3(_0xe668863e);
        this._0xff919333(_0xe668863e);
        this.CurrentPanelIndex = _0xe668863e;
        this.Panels[_0xe668863e].Show();
    }

    public void _0x85e1ccb4(int _0xe1a1483e)
    {
        if (_0xe1a1483e == _0x6888be17.SPLASH && _0x5c5bbf39.Instance._0x1ce83e27 != _0x232968b9.SCENE_0)
            _0x69b0bfad.Instance._0xf713c94d();
        if (_0x5c5bbf39.Instance._0x1ce83e27 != _0x232968b9.SCENE_0)
        {
            if (_0xe1a1483e == _0x6888be17.SPLASH || _0xe1a1483e == _0x6888be17.TUTORIAL0)
                _0x5c5bbf39.Instance._0x692bc316(false);
            else if (_0xe1a1483e == _0x6888be17.DEFAULT)
                _0x5c5bbf39.Instance._0x692bc316(true);
        }
    }

    public List<_0xe215cc14> Panels;
    private void _0x0047f9d3(int _0x36298d96)
    {
        if (_0x36298d96 == _0x6888be17.SPLASH)
            _0x69b0bfad.Instance._0x616de61a();
        if (_0x5c5bbf39.Instance._0x1ce83e27 == _0x232968b9.SCENE_0)
        {
        }
    }

    private void _0x90ce9a2e()
    {
        this._0x963cc879(_0x6888be17.SPLASH);
        if (_0x5c5bbf39.Instance._0x1ce83e27 == _0x232968b9.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x69b0bfad.Instance.DefaultAnimationTime);
        }
    }

    private _0xe215cc14 _0x115cb7bb(int _0x8e872aba)
    {
        return this.Panels[_0x8e872aba];
    }

    public int CurrentPanelIndex;
    public bool IsShowSplashOnStart = true;
    public float ScaleDuration = 0.4f;
    private void _0xf2db9068(int _0xeab0a69b)
    {
        this.LastPanelIndexes.Add(_0xeab0a69b);
        this.CurrentPanelIndex = _0xeab0a69b;
        for (int _0x37664195 = 0; _0x37664195 < this.Panels.Count; _0x37664195++)
            if (_0x37664195 != _0xeab0a69b && this.Panels[_0x37664195] != null)
                this.Panels[_0x37664195]._0x56489c01();
    }

    public void _0xbd172a36(int _0x7bb1f14a)
    {
        this._0xf2db9068(_0x7bb1f14a);
        this._0x0047f9d3(_0x7bb1f14a);
        this.CurrentPanelIndex = _0x7bb1f14a;
        this.Panels[_0x7bb1f14a].Show();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5e1e2fdc>();
    }

    public float StaticBlurMaterialInitialValue;
}