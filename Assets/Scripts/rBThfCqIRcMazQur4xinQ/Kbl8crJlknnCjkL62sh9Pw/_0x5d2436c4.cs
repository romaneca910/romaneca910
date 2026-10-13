using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x5d2436c4 : MonoBehaviour
{
    private static bool _0x7a06d9e6;
    private Canvas _0xc7cd51af;
    private static Vector2 _0x6ce8de3b = Vector2.zero;
    private static void ApplySafeAreaToAll()
    {
        for (int _0xad896e4b = 0; _0xad896e4b < _0x29b9778f.Count; _0xad896e4b++)
            _0x29b9778f[_0xad896e4b]._0x2aa2d1b9();
    }

    private static void OrientationChanged()
    {
        _0xe6505e67 = Screen.orientation;
        _0x6ce8de3b.x = Screen.width;
        _0x6ce8de3b.y = Screen.height;
        _0x03abb8c4 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xf3265d74.Invoke();
    }

    private static ScreenOrientation _0xe6505e67 = ScreenOrientation.LandscapeLeft;
    private void Update()
    {
        if (_0x29b9778f.Count == 0 || _0x29b9778f[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xe6505e67)
            OrientationChanged();
        if (Screen.safeArea != _0x03abb8c4)
            SafeAreaChanged();
        if (Screen.width != _0x6ce8de3b.x || Screen.height != _0x6ce8de3b.y)
            ResolutionChanged();
    }

    private static UnityEvent _0xf3265d74 = new();
    private Vector2 _0xf250bd0b;
    private void OnDestroy()
    {
        if (_0x29b9778f != null && _0x29b9778f.Contains(this))
            _0x29b9778f.Remove(this);
    }

    private void Start()
    {
    }

    private CanvasScaler _0x3a42a833;
    private RectTransform _0x4552f092;
    private static void SafeAreaChanged()
    {
        _0x03abb8c4 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static Rect _0x03abb8c4 = Rect.zero;
    private void _0x2aa2d1b9()
    {
        if (this._0x4552f092 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x233059c4 = Screen.safeArea;
        Vector2 _0xdda45537 = _0x233059c4.position;
        Vector2 _0xa64b01f0 = _0x233059c4.position + _0x233059c4.size;
        _0xdda45537.x /= screenWidth;
        _0xdda45537.y /= screenHeight;
        _0xa64b01f0.x /= screenWidth;
        _0xa64b01f0.y /= screenHeight;
        this._0x4552f092.anchorMin = _0xdda45537;
        this._0x4552f092.anchorMax = _0xa64b01f0;
        this._0x4552f092.offsetMin = Vector2.zero;
        this._0x4552f092.offsetMax = Vector2.zero;
        if (this._0x3a42a833 == null)
            return;
        Vector2 _0x2bc94d7b = _0xa64b01f0 - _0xdda45537;
        float _0x5a9485e1 = 2f - _0x2bc94d7b.x;
        float _0x98aafb56 = 2f - _0x2bc94d7b.y;
        this._0x3a42a833.referenceResolution = this._0xf250bd0b * new Vector2(_0x5a9485e1, _0x98aafb56);
    }

    private static void ResolutionChanged()
    {
        _0x6ce8de3b.x = Screen.width;
        _0x6ce8de3b.y = Screen.height;
        _0x03abb8c4 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xf3265d74.Invoke();
    }

    private static readonly List<_0x5d2436c4> _0x29b9778f = new();
    private RectTransform _0x1def7d92;
    private void Awake()
    {
        if (!_0x29b9778f.Contains(this))
            _0x29b9778f.Add(this);
        this._0xc7cd51af = this.GetComponent<Canvas>();
        this._0x3a42a833 = this.GetComponent<CanvasScaler>();
        if (this._0x3a42a833 != null)
            this._0xf250bd0b = this._0x3a42a833.referenceResolution;
        this._0x1def7d92 = this.GetComponent<RectTransform>();
        this._0x4552f092 = this.transform.Find(_0x6e863972._0x8f7e4e78(new byte[8] { 193, 243, 244, 247, 211, 224, 247, 243 }, 146)) as RectTransform;
        if (!_0x7a06d9e6)
        {
            _0xe6505e67 = Screen.orientation;
            _0x6ce8de3b.x = Screen.width;
            _0x6ce8de3b.y = Screen.height;
            _0x03abb8c4 = Screen.safeArea;
            _0x7a06d9e6 = true;
        }

        this._0x2aa2d1b9();
    }
}

internal static class _0x6e863972
{
    internal static string _0x8f7e4e78(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}