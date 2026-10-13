// Chapter data: the mosaic template each chapter is built from, how deeply it is
// scrambled and the move budget that follows from it. Budget is depth + 14; the slack
// recovers a wasted quarter of the budget in full and still loses a wasted third, so
// the limit keeps meaning something.
// Plain literal arrays only - no field here reads another, so Plana's declaration
// reordering cannot build one before its dependency (rule C.52).
public static class _0xa2e487e5
{
    public const int RefundCap = 10;
    public static readonly int[] Depths =
    {
        6,
        8,
        10,
        12,
        14,
        16
    };
    public static int Depth(int _0x7e308755)
    {
        if (_0x7e308755 < 0)
            _0x7e308755 = 0;
        if (_0x7e308755 >= Count)
            _0x7e308755 = Count - 1;
        return Depths[_0x7e308755];
    }

    public const int BudgetSlack = 14;
    public const int Count = 6;
    public const int HintsAtStart = 3;
    public const int LineRefund = 2;
    public static readonly string[] SpeciesNames =
    {
        _0xd0c3dfaf._0x932dbfc3(new byte[12] { 176, 172, 181, 173, 192, 162, 172, 175, 179, 179, 175, 173 }, 224),
        _0xd0c3dfaf._0x932dbfc3(new byte[5] { 242, 231, 237, 236, 251 }, 162),
        _0xd0c3dfaf._0x932dbfc3(new byte[10] { 47, 45, 45, 44, 36, 46, 45, 53, 39, 48 }, 98),
        _0xd0c3dfaf._0x932dbfc3(new byte[5] { 190, 189, 166, 167, 161 }, 242),
        _0xd0c3dfaf._0x932dbfc3(new byte[8] { 134, 138, 153, 130, 140, 132, 135, 143 }, 203),
    };
    public static string Name(int _0x853a39df)
    {
        if (_0x853a39df < 0)
            _0x853a39df = 0;
        if (_0x853a39df >= Count)
            _0x853a39df = Count - 1;
        return Names[_0x853a39df];
    }

    public static readonly string[] Names =
    {
        _0xd0c3dfaf._0x932dbfc3(new byte[11] { 214, 216, 219, 219, 217, 180, 215, 198, 219, 199, 199 }, 148),
        _0xd0c3dfaf._0x932dbfc3(new byte[11] { 238, 251, 234, 255, 242, 158, 236, 247, 240, 249, 237 }, 190),
        _0xd0c3dfaf._0x932dbfc3(new byte[12] { 29, 16, 31, 5, 20, 3, 31, 113, 3, 30, 6, 2 }, 81),
        _0xd0c3dfaf._0x932dbfc3(new byte[13] { 95, 82, 90, 92, 84, 85, 90, 87, 59, 73, 90, 82, 85 }, 27),
        _0xd0c3dfaf._0x932dbfc3(new byte[13] { 93, 95, 95, 94, 48, 83, 66, 85, 67, 83, 85, 94, 68 }, 16),
        _0xd0c3dfaf._0x932dbfc3(new byte[13] { 29, 5, 28, 15, 4, 106, 9, 2, 15, 9, 1, 15, 24 }, 74),
    };
    public static int Budget(int _0x157f4774)
    {
        return Depth(_0x157f4774) + BudgetSlack;
    }

    public const int AlbumCards = 30;
    public const int HintsCap = 5;
}

internal static class _0xd0c3dfaf
{
    internal static string _0x932dbfc3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}