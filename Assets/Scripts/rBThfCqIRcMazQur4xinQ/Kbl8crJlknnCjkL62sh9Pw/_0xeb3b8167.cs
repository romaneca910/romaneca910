using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xeb3b8167 : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0x521e80da = Screen.orientation;
        _0xd4e2e2d9.x = Screen.width;
        _0xd4e2e2d9.y = Screen.height;
        _0x1808cbd6.Invoke();
    }

    private static Rect _0x67d6d850 = Rect.zero;
    private static void ResolutionChanged()
    {
        _0xd4e2e2d9.x = Screen.width;
        _0xd4e2e2d9.y = Screen.height;
        _0x1808cbd6.Invoke();
    }

    private static bool _0x4161daab;
    private static void SafeAreaChanged()
    {
        _0x67d6d850 = Screen.safeArea;
        for (int _0xfc6bd964 = 0; _0xfc6bd964 < _0x42ec8df9.Count; _0xfc6bd964++)
            _0x42ec8df9[_0xfc6bd964]._0xea9b6e81();
    }

    private static Vector2 _0xd4e2e2d9 = Vector2.zero;
    private RectTransform _0x3032753c;
    private Canvas _0x7bbf62d4;
    private static readonly List<_0xeb3b8167> _0x42ec8df9 = new();
    private static ScreenOrientation _0x521e80da = ScreenOrientation.LandscapeLeft;
    private void OnDestroy()
    {
        if (_0x42ec8df9 != null && _0x42ec8df9.Contains(this))
            _0x42ec8df9.Remove(this);
    }

    private void Update()
    {
        if (_0x42ec8df9[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x521e80da)
            OrientationChanged();
        if (Screen.safeArea != _0x67d6d850)
            SafeAreaChanged();
        if (Screen.width != _0xd4e2e2d9.x || Screen.height != _0xd4e2e2d9.y)
            ResolutionChanged();
    }

    private RectTransform _0x2c1f7bab;
    private static UnityEvent _0x1808cbd6 = new();
    private void _0xea9b6e81()
    {
        if (this._0x3032753c == null)
            return;
        Rect _0xe621a223 = Screen.safeArea;
        Vector2 _0xafef5d36 = _0xe621a223.position;
        Vector2 _0x108356d7 = _0xe621a223.position + _0xe621a223.size;
        _0xafef5d36.x /= this._0x7bbf62d4.pixelRect.width;
        _0xafef5d36.y /= this._0x7bbf62d4.pixelRect.height;
        _0x108356d7.x /= this._0x7bbf62d4.pixelRect.width;
        _0x108356d7.y /= this._0x7bbf62d4.pixelRect.height;
        this._0x3032753c.anchorMin = _0xafef5d36;
        this._0x3032753c.anchorMax = _0x108356d7;
    }

    private void Awake()
    {
        if (!_0x42ec8df9.Contains(this))
            _0x42ec8df9.Add(this);
        this._0x7bbf62d4 = this.GetComponent<Canvas>();
        this._0x2c1f7bab = this.GetComponent<RectTransform>();
        this._0x3032753c = this.transform.Find(_0xcb8460db._0x717a2b16(new byte[8] { 252, 206, 201, 202, 238, 221, 202, 206 }, 175)) as RectTransform;
        if (!_0x4161daab)
        {
            _0x521e80da = Screen.orientation;
            _0xd4e2e2d9.x = Screen.width;
            _0xd4e2e2d9.y = Screen.height;
            _0x67d6d850 = Screen.safeArea;
            _0x4161daab = true;
        }

        this._0xea9b6e81();
    }
}

internal static class _0xcb8460db
{
    internal static string _0x717a2b16(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}