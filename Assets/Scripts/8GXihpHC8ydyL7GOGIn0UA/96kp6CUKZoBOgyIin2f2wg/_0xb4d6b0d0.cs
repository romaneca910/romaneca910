using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xb4d6b0d0 : MonoBehaviour
{
    private bool _0x62dd9fc2(Touch? _0xd363854a, Bounds _0xd2c1e195, TouchPhase _0x96ac429c)
    {
        if (!_0x5c5bbf39.Instance._0x400f44cb)
        {
            _0xd363854a = null;
            return false;
        }

        if (_0xd363854a != null)
            if (_0xd363854a.Value.phase == _0x96ac429c)
            {
                Vector3 _0xc8046aea = Camera.main.ScreenToWorldPoint(_0xd363854a.Value.screenPosition);
                Vector3 _0xaa0d78b9 = new(_0xc8046aea.x, _0xc8046aea.y, _0xd2c1e195.center.z);
                if (_0xd2c1e195.Contains(_0xaa0d78b9) && this._0x5b12214a(_0xd363854a.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x7fea4bfa()
    {
        if (!_0x5c5bbf39.Instance._0x400f44cb)
            return null;
        foreach (Touch _0x0cbaabf9 in Touch.activeTouches)
            if (_0x0cbaabf9.ended)
                if (this._0x5b12214a(_0x0cbaabf9))
                    return _0x0cbaabf9;
        return null;
    }

    private Touch? _0x25e02233()
    {
        if (!_0x5c5bbf39.Instance._0x400f44cb)
            return null;
        foreach (Touch _0xe679f863 in Touch.activeTouches)
            if (!_0xe679f863.ended)
                if (this._0x5b12214a(_0xe679f863))
                    return _0xe679f863;
        return null;
    }

    private bool _0x5b12214a(Touch? _0x7bae5b6b)
    {
        if (!_0x7bae5b6b.HasValue)
            return false;
        Vector3 _0xe34e1b45 = Camera.main.ScreenToWorldPoint(_0x7bae5b6b.Value.screenPosition);
        Vector3 _0x85d059d9 = _0xe34e1b45;
        _0x85d059d9.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x85d059d9))
            return true;
        _0x7bae5b6b = null;
        return false;
    }

    private static _0xb4d6b0d0 _0x1116077d;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x1116077d = this.gameObject.GetComponent<_0xb4d6b0d0>();
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x68cfc36a(Bounds _0x917772c9)
    {
        if (!_0x5c5bbf39.Instance._0x400f44cb)
            return null;
        foreach (Touch _0xc4ee85cf in Touch.activeTouches)
            if (_0xc4ee85cf.ended)
            {
                Vector3 _0xb90466b4 = Camera.main.ScreenToWorldPoint(_0xc4ee85cf.screenPosition);
                Vector3 _0xdc420c97 = new(_0xb90466b4.x, _0xb90466b4.y, _0x917772c9.center.z);
                if (_0x917772c9.Contains(_0xdc420c97) && this._0x5b12214a(_0xc4ee85cf))
                    return _0xc4ee85cf;
            }

        return null;
    }

    private Touch? _0xf58ea784(Bounds _0x2563b30c, TouchPhase _0x7586ed50)
    {
        if (!_0x5c5bbf39.Instance._0x400f44cb)
            return null;
        foreach (Touch _0x0e90132b in Touch.activeTouches)
            if (_0x0e90132b.phase == _0x7586ed50)
            {
                Vector3 _0x0744a239 = Camera.main.ScreenToWorldPoint(_0x0e90132b.screenPosition);
                Vector3 _0x0219f597 = new(_0x0744a239.x, _0x0744a239.y, _0x2563b30c.center.z);
                if (_0x2563b30c.Contains(_0x0219f597) && this._0x5b12214a(_0x0e90132b))
                    return _0x0e90132b;
            }

        return null;
    }

    private void _0x5ba21cbf(Touch? _0x33dcd976)
    {
        if (!_0x5c5bbf39.Instance._0x400f44cb)
        {
            _0x33dcd976 = null;
            return;
        }

        int _0x4409d9ed = _0x33dcd976.Value.touchId;
        _0x33dcd976 = Touch.activeTouches.FirstOrDefault(_0xdb0cb47b => _0xdb0cb47b.touchId == _0x4409d9ed);
        if (!this._0x5b12214a(_0x33dcd976.Value))
            _0x33dcd976 = null;
    }

    private Touch? _0xb35246c7(Bounds _0xf265258a)
    {
        if (!_0x5c5bbf39.Instance._0x400f44cb)
            return null;
        foreach (Touch _0x67deebde in Touch.activeTouches)
            if (!_0x67deebde.ended)
            {
                Vector3 _0x0e34842a = Camera.main.ScreenToWorldPoint(_0x67deebde.screenPosition);
                Vector3 _0x4fbfa34f = new(_0x0e34842a.x, _0x0e34842a.y, _0xf265258a.center.z);
                if (_0xf265258a.Contains(_0x4fbfa34f) && this._0x5b12214a(_0x67deebde))
                    return _0x67deebde;
            }

        return null;
    }
}