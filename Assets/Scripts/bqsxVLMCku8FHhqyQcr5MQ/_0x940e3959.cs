using UnityEngine;

// Owns the three template pops by INDEX (win 7, lose 8, pause 6) and dresses each with
// a card of our own. The template's own branches inside those pops are switched off in
// the scene, so nothing of theirs - 'Score:', 'Reward:', 'Time:' or the literal 100 in
// the results row - can reach the screen.
public sealed class _0x940e3959 : MonoBehaviour
{
    public const int RoleWin = 0;
    public void _0x5e819d8d(int _0x6fe8d04e, int _0x29da2f58, int _0x07e36029)
    {
        if (this._0x035081c5 != null)
        {
            this._0x035081c5._0x0a4c04ae(_0x5c984b79._0x17e23565(new byte[13] { 25, 31, 12, 26, 27, 16, 126, 14, 31, 11, 13, 27, 26 }, 94), _0x5c984b79._0x17e23565(new byte[13] { 163, 182, 188, 178, 215, 182, 215, 181, 165, 178, 182, 163, 191 }, 247), _0xa2e487e5.Name(_0x6fe8d04e), _0x5c984b79._0x17e23565(new byte[8] { 184, 179, 186, 171, 175, 190, 169, 219 }, 251) + (_0x6fe8d04e + 1), _0x5c984b79._0x17e23565(new byte[6] { 175, 173, 180, 167, 177, 194 }, 226) + _0x29da2f58, _0x5c984b79._0x17e23565(new byte[12] { 209, 205, 206, 215, 214, 203, 205, 204, 162, 203, 204, 162 }, 130) + _0x07e36029, _0x5c984b79._0x17e23565(new byte[6] { 49, 38, 48, 54, 46, 38 }, 99), _0x5c984b79._0x17e23565(new byte[10] { 176, 182, 165, 179, 178, 185, 215, 186, 182, 167 }, 247), true);
        }

        _0x5612c582.Instance._0x8eecba3f(_0xe5719494._0xb2c1b372.PAUSE);
    }

    [SerializeField]
    private _0xb424dc92 _director;
    public const int RolePause = 2;
    private _0xce28911d _0x31b5f918(_0xff1faaf7 _0xffc06c9a, int _0x34eff0a3)
    {
        if (_0xffc06c9a == null || _0xffc06c9a.Content == null)
            return null;
        _0xce28911d _0x875279f8 = Instantiate(this._cardPrefab, _0xffc06c9a.Content.transform, false);
        _0x875279f8._0xf999ce76(this, _0x34eff0a3);
        _0x875279f8._0x8ec72bfa(_0x34eff0a3 == RoleLose ? _0xcc07f46d.Mint : _0xcc07f46d.Gold);
        return _0x875279f8;
    }

    public void _0x4796052b(int _0xe2cab05e, int _0x12d1751b, int _0x379c3d33)
    {
        if (this._0xdce8647c != null)
        {
            this._0xdce8647c._0x0a4c04ae(_0x5c984b79._0x17e23565(new byte[14] { 255, 234, 251, 238, 227, 252, 143, 253, 234, 252, 251, 230, 225, 232 }, 175), _0x5c984b79._0x17e23565(new byte[19] { 201, 213, 216, 189, 208, 210, 210, 211, 189, 206, 216, 201, 189, 223, 216, 219, 210, 207, 216 }, 157), _0x5c984b79._0x17e23565(new byte[14] { 28, 0, 13, 104, 4, 9, 27, 28, 104, 10, 4, 7, 7, 5 }, 72), _0x5c984b79._0x17e23565(new byte[8] { 106, 100, 103, 103, 101, 109, 108, 8 }, 40) + _0x12d1751b + _0x5c984b79._0x17e23565(new byte[4] { 208, 191, 182, 208 }, 240) + _0x818cf24c.Cells, _0x5c984b79._0x17e23565(new byte[15] { 37, 68, 55, 43, 40, 49, 48, 45, 43, 42, 68, 51, 37, 55, 68 }, 100) + _0x379c3d33, _0x5c984b79._0x17e23565(new byte[8] { 49, 58, 51, 34, 38, 55, 32, 82 }, 114) + (_0xe2cab05e + 1), _0x5c984b79._0x17e23565(new byte[9] { 169, 175, 164, 221, 188, 186, 188, 180, 179 }, 253), _0x5c984b79._0x17e23565(new byte[10] { 230, 224, 243, 229, 228, 239, 129, 236, 224, 241 }, 161), true);
        }

        _0x5612c582.Instance._0x8eecba3f(_0xe5719494._0xb2c1b372.LOSE);
    }

    private _0xce28911d _0xad364c27;
    public void _0xa2acd3c0()
    {
        if (this._0x1df6af3d || this._cardPrefab == null || _0x5612c582.Instance == null)
            return;
        this._0x1df6af3d = true;
        this._0xad364c27 = this._0x31b5f918(_0x5612c582.Instance._0x8bd3c1a7(_0xe5719494._0xb2c1b372.WIN), RoleWin);
        this._0xdce8647c = this._0x31b5f918(_0x5612c582.Instance._0x8bd3c1a7(_0xe5719494._0xb2c1b372.LOSE), RoleLose);
        this._0x035081c5 = this._0x31b5f918(_0x5612c582.Instance._0x8bd3c1a7(_0xe5719494._0xb2c1b372.PAUSE), RolePause);
    }

    public void _0x8d522899(int _0xc28d6fe7, int _0x2a24f6ac, int _0x0272d9bf, int _0x9d110015, bool _0x4ee62673)
    {
        if (this._0xad364c27 != null)
        {
            // On the last chapter there is nowhere to advance to, so the card says so in
            // its own body and ships ONE button. A second button captioned with a
            // sentence rather than an action is a defect, not a flourish.
            this._0xad364c27._0x0a4c04ae(_0x5c984b79._0x17e23565(new byte[15] { 246, 244, 232, 250, 242, 248, 155, 233, 254, 232, 239, 244, 233, 254, 255 }, 187), _0x4ee62673 ? _0x5c984b79._0x17e23565(new byte[21] { 230, 245, 230, 241, 250, 131, 238, 236, 240, 226, 234, 224, 131, 241, 230, 240, 247, 236, 241, 230, 231 }, 163) : _0x5c984b79._0x17e23565(new byte[8] { 98, 105, 96, 113, 117, 100, 115, 1 }, 33) + (_0xc28d6fe7 + 1), _0x4ee62673 ? _0x5c984b79._0x17e23565(new byte[21] { 83, 95, 93, 85, 48, 82, 81, 83, 91, 48, 94, 85, 72, 68, 48, 67, 64, 66, 89, 94, 87 }, 16) : _0xa2e487e5.Name(_0xc28d6fe7), _0x5c984b79._0x17e23565(new byte[8] { 206, 192, 195, 195, 193, 223, 172, 167 }, 140) + _0x0272d9bf, _0x5c984b79._0x17e23565(new byte[11] { 191, 189, 164, 183, 161, 210, 190, 183, 180, 166, 210 }, 242) + _0x2a24f6ac, _0x5c984b79._0x17e23565(new byte[6] { 209, 208, 215, 205, 202, 185 }, 153) + _0x9d110015, _0x4ee62673 ? _0x5c984b79._0x17e23565(new byte[10] { 211, 213, 198, 208, 209, 218, 180, 217, 213, 196 }, 148) : _0x5c984b79._0x17e23565(new byte[12] { 172, 167, 186, 182, 194, 161, 170, 163, 178, 182, 167, 176 }, 226), _0x5c984b79._0x17e23565(new byte[10] { 183, 177, 162, 180, 181, 190, 208, 189, 177, 160 }, 240), !_0x4ee62673);
        }

        _0x5612c582.Instance._0x8eecba3f(_0xe5719494._0xb2c1b372.WIN);
    }

    public const int RoleLose = 1;
    private _0xce28911d _0x035081c5;
    [SerializeField]
    private _0xce28911d _cardPrefab;
    private bool _0x1df6af3d;
    public void _0xe53393bf(int _0x29abbf1f)
    {
        if (this._director != null)
            this._director._0xcc6520fc();
    }

    public void _0x7d96a75d(int _0x5bf23e17)
    {
        if (this._director == null)
            return;
        if (_0x5bf23e17 == RolePause)
            this._director._0xa421cc4d();
        else
            this._director._0xcc6520fc();
    }

    public void _0x92f72dde(int _0x4a51127c)
    {
        if (this._director == null)
            return;
        if (_0x4a51127c == RoleWin)
            this._director._0x5f7a7403();
        else if (_0x4a51127c == RoleLose)
            this._director._0x2ea27ba4();
        else
            this._director._0xa421cc4d();
    }

    private _0xce28911d _0xdce8647c;
}

internal static class _0x5c984b79
{
    internal static string _0x17e23565(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}