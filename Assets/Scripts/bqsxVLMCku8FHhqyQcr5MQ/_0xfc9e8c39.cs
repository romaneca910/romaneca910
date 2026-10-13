using UnityEngine;

// All PlayerPrefs traffic for the garden, and the only place the key strings exist.
// They are instance-level consts read only from instance methods: a cross-class static
// dependency is exactly what turns into a dead .cctor after string encryption (C.52).
// Local only - no network, no account, nothing to sign in to.
public sealed class _0xfc9e8c39 : MonoBehaviour
{
    public bool _0x4678db12
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBoost, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyBoost, value ? 1 : 0);
        }
    }

    // One multiplier every tween duration in the game is scaled by.
    public float _0xfd7036ed
    {
        get
        {
            return this._0x64269987 ? 0.4f : 1f;
        }
    }

    private static readonly string KeyBest = _0x686da837._0x26832bd2(new byte[9] { 13, 29, 11, 32, 29, 26, 12, 11, 32 }, 127);
    private static readonly string KeySelected = _0x686da837._0x26832bd2(new byte[12] { 64, 80, 70, 109, 65, 87, 94, 87, 81, 70, 87, 86 }, 50);
    // Total blossoms pressed. Also mirrored into the template's own counter mechanism
    // (SETTINGS.PlayerSYSTEM.Coins), which is what MoneyCount renders wherever it exists.
    public int _0x19cfdbdc
    {
        get
        {
            return Mathf.Max(0, PlayerPrefs.GetInt(KeyBlooms, 0));
        }

        set
        {
            int _0x72db7cea = Mathf.Max(0, value);
            PlayerPrefs.SetInt(KeyBlooms, _0x72db7cea);
            _0xe5719494._0x14522955._0xc0514330 = _0x72db7cea;
        }
    }

    private static readonly string KeyBlooms = _0x686da837._0x26832bd2(new byte[10] { 6, 22, 0, 43, 22, 24, 27, 27, 25, 7 }, 116);
    private static readonly string KeyMotion = _0x686da837._0x26832bd2(new byte[10] { 215, 199, 209, 250, 200, 202, 209, 204, 202, 203 }, 165);
    public int _0x623e4808(int _0x6143591a)
    {
        return PlayerPrefs.GetInt(KeyBest + _0x6143591a, -1);
    }

    public int _0x30438acf()
    {
        int _0xa541ed4e = PlayerPrefs.GetInt(KeyAlbum, 0);
        int _0x6e4b6142 = 0;
        for (int _0x6bf248fb = 0; _0x6bf248fb < _0xa2e487e5.AlbumCards; _0x6bf248fb++)
            if ((_0xa541ed4e & (1 << _0x6bf248fb)) != 0)
                _0x6e4b6142++;
        return _0x6e4b6142;
    }

    private static readonly string KeyBoost = _0x686da837._0x26832bd2(new byte[9] { 11, 27, 13, 38, 27, 22, 22, 10, 13 }, 121);
    public void _0x760b43bf()
    {
        PlayerPrefs.Save();
    }

    private static readonly string KeyHints = _0x686da837._0x26832bd2(new byte[9] { 49, 33, 55, 28, 43, 42, 45, 55, 48 }, 67);
    public void _0xfef572b8()
    {
        PlayerPrefs.DeleteKey(KeyUnlocked);
        PlayerPrefs.DeleteKey(KeySelected);
        PlayerPrefs.DeleteKey(KeyHints);
        PlayerPrefs.DeleteKey(KeyBlooms);
        PlayerPrefs.DeleteKey(KeyAlbum);
        for (int _0x593e1ba7 = 0; _0x593e1ba7 < _0xa2e487e5.Count; _0x593e1ba7++)
            PlayerPrefs.DeleteKey(KeyBest + _0x593e1ba7);
        _0xe5719494._0x14522955._0xc0514330 = 0;
        PlayerPrefs.Save();
    }

    public bool _0x64269987
    {
        get
        {
            return PlayerPrefs.GetInt(KeyMotion, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyMotion, value ? 1 : 0);
        }
    }

    private static readonly string KeyAlbum = _0x686da837._0x26832bd2(new byte[9] { 29, 13, 27, 48, 14, 3, 13, 26, 2 }, 111);
    private static readonly string KeyUnlocked = _0x686da837._0x26832bd2(new byte[12] { 140, 156, 138, 161, 139, 144, 146, 145, 157, 149, 155, 154 }, 254);
    public void _0x039bba86(int _0xd1e0c4ad)
    {
        if (_0xd1e0c4ad + 2 > this._0x24b43855)
            this._0x24b43855 = _0xd1e0c4ad + 2;
    }

    public bool _0x6b001ad8(int _0xae632763)
    {
        return (PlayerPrefs.GetInt(KeyAlbum, 0) & (1 << _0xae632763)) != 0;
    }

    public int _0x00234e15
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyHints, _0xa2e487e5.HintsAtStart), 0, _0xa2e487e5.HintsCap);
        }

        set
        {
            PlayerPrefs.SetInt(KeyHints, Mathf.Clamp(value, 0, _0xa2e487e5.HintsCap));
        }
    }

    public int _0x24b43855
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyUnlocked, 1), 1, _0xa2e487e5.Count);
        }

        set
        {
            PlayerPrefs.SetInt(KeyUnlocked, Mathf.Clamp(value, 1, _0xa2e487e5.Count));
        }
    }

    public int _0x0bb5c853
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeySelected, 0), 0, _0xa2e487e5.Count - 1);
        }

        set
        {
            PlayerPrefs.SetInt(KeySelected, Mathf.Clamp(value, 0, _0xa2e487e5.Count - 1));
        }
    }

    public void _0xfd30ec8c(int _0x3b905118, int _0x8d5e0b10)
    {
        if (_0x8d5e0b10 > this._0x623e4808(_0x3b905118))
            PlayerPrefs.SetInt(KeyBest + _0x3b905118, _0x8d5e0b10);
    }

    // Pressing a flower into the album: the first card still closed is filled, so the
    // album fills in order and the count on the footer always matches the grid.
    public int _0x1b391815(int _0x8a05f746)
    {
        int _0x226fc47c = PlayerPrefs.GetInt(KeyAlbum, 0);
        int _0x6b67545c = Mathf.Clamp(_0x8a05f746 * 5, 0, _0xa2e487e5.AlbumCards - 1);
        for (int _0x039c5467 = 0; _0x039c5467 < _0xa2e487e5.AlbumCards; _0x039c5467++)
        {
            int _0x58c6b8e9 = (_0x6b67545c + _0x039c5467) % _0xa2e487e5.AlbumCards;
            if ((_0x226fc47c & (1 << _0x58c6b8e9)) != 0)
                continue;
            PlayerPrefs.SetInt(KeyAlbum, _0x226fc47c | (1 << _0x58c6b8e9));
            return _0x58c6b8e9;
        }

        return -1;
    }
}

internal static class _0x686da837
{
    internal static string _0x26832bd2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}