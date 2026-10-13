// The 5x5 species board and the only operation the game performs on it: a cyclic
// shift of one line. Lines wrap, which is what makes every scramble reversible.
// Pure logic, no UnityEngine dependency.
public sealed class _0x818cf24c
{
    public bool _0x368e7ead(_0x818cf24c _0x659bcc9a)
    {
        for (int _0xb88993cd = 0; _0xb88993cd < Cells; _0xb88993cd++)
            if (this._0x3b53d780[_0xb88993cd] != _0x659bcc9a._0x3b53d780[_0xb88993cd])
                return false;
        return true;
    }

    public bool _0xdc411e2a(_0x818cf24c _0x75c99a89, int _0x481d661c)
    {
        for (int _0x4c2bf778 = 0; _0x4c2bf778 < Side; _0x4c2bf778++)
            if (this._0x38c066ed(_0x4c2bf778, _0x481d661c) != _0x75c99a89._0x38c066ed(_0x4c2bf778, _0x481d661c))
                return false;
        return true;
    }

    public bool _0xce390ea6(_0x818cf24c _0x84a4a04a, int _0x9a7dee11)
    {
        for (int _0x417f414a = 0; _0x417f414a < Side; _0x417f414a++)
            if (this._0x38c066ed(_0x9a7dee11, _0x417f414a) != _0x84a4a04a._0x38c066ed(_0x9a7dee11, _0x417f414a))
                return false;
        return true;
    }

    // A move is a visible no-op when every cell of the line already holds the same
    // species: the board would not change and the player would read it as a dead tap.
    public bool _0x253ca45d(MosaicMove _0x9f6ad3ce)
    {
        int _0xf53f2245 = _0x9f6ad3ce.Axis == 0 ? this._0x38c066ed(0, _0x9f6ad3ce.Index) : this._0x38c066ed(_0x9f6ad3ce.Index, 0);
        for (int _0xea5cc536 = 1; _0xea5cc536 < Side; _0xea5cc536++)
        {
            int _0xafa817ff = _0x9f6ad3ce.Axis == 0 ? this._0x38c066ed(_0xea5cc536, _0x9f6ad3ce.Index) : this._0x38c066ed(_0x9f6ad3ce.Index, _0xea5cc536);
            if (_0xafa817ff != _0xf53f2245)
                return false;
        }

        return true;
    }

    public void _0x19a1c4e7(int _0x7666135a, int _0x7dfd97d6, int _0x0459abd5)
    {
        this._0x3b53d780[_0x7dfd97d6 * Side + _0x7666135a] = _0x0459abd5;
    }

    public string _0x8d760820()
    {
        char[] _0x850b57ce = new char[Cells];
        for (int _0x12bf9249 = 0; _0x12bf9249 < Cells; _0x12bf9249++)
            _0x850b57ce[_0x12bf9249] = (char)('0' + this._0x3b53d780[_0x12bf9249]);
        return new string (_0x850b57ce);
    }

    public int _0x38c066ed(int _0xa39b4f15, int _0xd970f859)
    {
        return this._0x3b53d780[_0xd970f859 * Side + _0xa39b4f15];
    }

    public _0x818cf24c _0xee9665bf()
    {
        return new _0x818cf24c(this._0x3b53d780);
    }

    public int _0xfa629f0a(_0x818cf24c _0x3417ca51)
    {
        int _0x91580e04 = 0;
        for (int _0xa792c51d = 0; _0xa792c51d < Cells; _0xa792c51d++)
            if (this._0x3b53d780[_0xa792c51d] == _0x3417ca51._0x3b53d780[_0xa792c51d])
                _0x91580e04++;
        return _0x91580e04;
    }

    public void _0x2a3e48db(MosaicMove _0xe9783fe6)
    {
        int[] _0x0a5d2ec5 = new int[Side];
        for (int _0xdfb3440c = 0; _0xdfb3440c < Side; _0xdfb3440c++)
            _0x0a5d2ec5[_0xdfb3440c] = _0xe9783fe6.Axis == 0 ? this._0x38c066ed(_0xdfb3440c, _0xe9783fe6.Index) : this._0x38c066ed(_0xe9783fe6.Index, _0xdfb3440c);
        int[] _0xd1f2aba0 = new int[Side];
        for (int _0x21833b9f = 0; _0x21833b9f < Side; _0x21833b9f++)
        {
            int _0xafb823df = ((_0x21833b9f - _0xe9783fe6.Step) % Side + Side) % Side;
            _0xd1f2aba0[_0x21833b9f] = _0x0a5d2ec5[_0xafb823df];
        }

        for (int _0x788d7512 = 0; _0x788d7512 < Side; _0x788d7512++)
        {
            if (_0xe9783fe6.Axis == 0)
                this._0x19a1c4e7(_0x788d7512, _0xe9783fe6.Index, _0xd1f2aba0[_0x788d7512]);
            else
                this._0x19a1c4e7(_0xe9783fe6.Index, _0x788d7512, _0xd1f2aba0[_0x788d7512]);
        }
    }

    public const int Side = 5;
    public const int Cells = 25;
    public bool _0x59a92d61(_0x818cf24c _0x0e56308a, int _0xa0006148)
    {
        return this._0x3b53d780[_0xa0006148] == _0x0e56308a._0x3b53d780[_0xa0006148];
    }

    public void _0x0bd834d5(_0x818cf24c _0xd63b2193)
    {
        for (int _0x5eb18e76 = 0; _0x5eb18e76 < Cells; _0x5eb18e76++)
            this._0x3b53d780[_0x5eb18e76] = _0xd63b2193._0x3b53d780[_0x5eb18e76];
    }

    public _0x818cf24c(int[] _0x5f0053a1)
    {
        this._0x3b53d780 = new int[Cells];
        for (int _0x7a2f7998 = 0; _0x7a2f7998 < Cells; _0x7a2f7998++)
            this._0x3b53d780[_0x7a2f7998] = _0x5f0053a1[_0x7a2f7998];
    }

    private readonly int[] _0x3b53d780;
    public _0x818cf24c()
    {
        this._0x3b53d780 = new int[Cells];
    }

    public int this[int _0xc70a9714]
    {
        get
        {
            return this._0x3b53d780[_0xc70a9714];
        }

        set
        {
            this._0x3b53d780[_0xc70a9714] = value;
        }
    }
}