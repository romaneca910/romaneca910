// Builds one chapter's target pattern and its scrambled start, and hands back a
// solution stack that is correct BY CONSTRUCTION: the board is scrambled from the
// finished picture with real moves, and the inverse of each move is pushed as it goes.
// There is no solver, no search and no retry budget - replaying the stack always wins.
// Pure logic, no UnityEngine dependency, so the claims can be exercised headlessly.
public sealed class _0xca94471f
{
    // Six mosaic templates, one per chapter, so a chapter is recognisable by its picture.
    // Each holds every slot exactly five times, so the species counts are balanced by
    // construction and no scramble can ever make the board unsolvable.
    private static readonly int[][] _0x4e2c1a78 =
    {
        new[]
        {
            0,
            1,
            2,
            1,
            0,
            1,
            3,
            4,
            3,
            1,
            2,
            4,
            0,
            4,
            2,
            2,
            3,
            4,
            3,
            1,
            0,
            3,
            2,
            4,
            0
        },
        new[]
        {
            0,
            0,
            1,
            0,
            0,
            0,
            2,
            3,
            2,
            3,
            1,
            3,
            4,
            3,
            1,
            2,
            2,
            3,
            2,
            4,
            4,
            1,
            4,
            1,
            4
        },
        new[]
        {
            0,
            0,
            0,
            0,
            0,
            1,
            2,
            1,
            2,
            1,
            3,
            3,
            4,
            3,
            3,
            2,
            1,
            2,
            1,
            2,
            4,
            4,
            3,
            4,
            4
        },
        new[]
        {
            0,
            1,
            2,
            3,
            4,
            1,
            2,
            3,
            4,
            0,
            2,
            3,
            4,
            0,
            1,
            3,
            4,
            0,
            1,
            2,
            4,
            0,
            1,
            2,
            3
        },
        new[]
        {
            2,
            1,
            0,
            3,
            1,
            1,
            3,
            4,
            2,
            0,
            0,
            4,
            3,
            2,
            1,
            0,
            4,
            3,
            2,
            1,
            4,
            2,
            3,
            4,
            0
        },
        new[]
        {
            0,
            1,
            0,
            1,
            0,
            2,
            3,
            2,
            3,
            2,
            4,
            0,
            4,
            0,
            4,
            1,
            2,
            1,
            2,
            1,
            3,
            4,
            3,
            4,
            3
        },
    };
    public _0x818cf24c _0x68afb7fd { get; private set; }
    public _0x818cf24c _0xc0c4501d { get; private set; }

    // The guaranteed layout of rule C.11 point 2: used only if the solved-board guard
    // below cannot find a different start in sixteen tries. Expected never to fire.
    private static readonly int[] _0x7b3074a1 =
    {
        0,
        1,
        2,
        3,
        4,
        2,
        3,
        4,
        0,
        1,
        4,
        0,
        1,
        2,
        3,
        1,
        2,
        3,
        4,
        0,
        3,
        4,
        0,
        1,
        2,
    };
    private static MosaicMove RandomMove(System.Random _0xff0418e2)
    {
        return new MosaicMove(_0xff0418e2.Next(2), _0xff0418e2.Next(_0x818cf24c.Side), _0xff0418e2.Next(2) == 0 ? 1 : -1);
    }

    public int _0xafaae837 { get; private set; }

    private static _0x818cf24c BuildTarget(int _0x6e6a1e4b, System.Random _0xe6392780)
    {
        int[] _0x56d04ca6 = _0x4e2c1a78[((_0x6e6a1e4b % _0x4e2c1a78.Length) + _0x4e2c1a78.Length) % _0x4e2c1a78.Length];
        // One of eight symmetry operations, so the same chapter never opens twice with
        // the identical picture even before the species are permuted.
        int _0xeb0ace66 = _0xe6392780.Next(8);
        bool _0x88cb766c = _0xeb0ace66 >= 4;
        int _0x50ef6d6f = _0xeb0ace66 % 4;
        int[] _0x54542563 =
        {
            0,
            1,
            2,
            3,
            4
        };
        for (int _0xc96f748a = _0x54542563.Length - 1; _0xc96f748a > 0; _0xc96f748a--)
        {
            int _0xa7a34628 = _0xe6392780.Next(_0xc96f748a + 1);
            int _0x9c5e85a9 = _0x54542563[_0xc96f748a];
            _0x54542563[_0xc96f748a] = _0x54542563[_0xa7a34628];
            _0x54542563[_0xa7a34628] = _0x9c5e85a9;
        }

        _0x818cf24c _0xfad21bde = new _0x818cf24c();
        for (int _0xb38790fa = 0; _0xb38790fa < _0x818cf24c.Side; _0xb38790fa++)
        {
            for (int _0x2ed9ec58 = 0; _0x2ed9ec58 < _0x818cf24c.Side; _0x2ed9ec58++)
            {
                int _0xb64f9341 = _0x2ed9ec58;
                int _0x97a6ff28 = _0xb38790fa;
                if (_0x88cb766c)
                    _0xb64f9341 = _0x818cf24c.Side - 1 - _0xb64f9341;
                for (int _0x271b8493 = 0; _0x271b8493 < _0x50ef6d6f; _0x271b8493++)
                {
                    int _0x64551b5c = _0xb64f9341;
                    _0xb64f9341 = _0x97a6ff28;
                    _0x97a6ff28 = _0x818cf24c.Side - 1 - _0x64551b5c;
                }

                _0xfad21bde._0x19a1c4e7(_0x2ed9ec58, _0xb38790fa, _0x54542563[_0x56d04ca6[_0x97a6ff28 * _0x818cf24c.Side + _0xb64f9341]]);
            }
        }

        return _0xfad21bde;
    }

    public void _0xe1f34cff(int _0x5133e87b, int _0x846a7089, int _0xe55220e5)
    {
        this._0xafaae837 = (_0x5133e87b * 7919) ^ (_0x846a7089 * 104729);
        System.Random _0x3a89d53d = new System.Random(this._0xafaae837);
        this._0xc0c4501d = BuildTarget(_0x5133e87b, _0x3a89d53d);
        this._0x68afb7fd = this._0xc0c4501d._0xee9665bf();
        this._0x99695452 = new _0x90a58e17();
        this._0x32589670 = false;
        MosaicMove _0xae45fb2d = new MosaicMove(-1, -1, 0);
        int _0xc86aa017 = 0;
        int _0x3009177d = 0;
        while (_0xc86aa017 < _0xe55220e5 && _0x3009177d++ < _0xe55220e5 * 40)
        {
            MosaicMove _0xd89ca86e = RandomMove(_0x3a89d53d);
            if (this._0x68afb7fd._0x253ca45d(_0xd89ca86e))
                continue;
            if (_0xae45fb2d.Axis >= 0 && _0xd89ca86e._0x48af44ac(_0xae45fb2d) && _0xd89ca86e.Step == -_0xae45fb2d.Step)
                continue; // an immediate undo wastes a move and shortens the real depth
            this._0x68afb7fd._0x2a3e48db(_0xd89ca86e);
            this._0x99695452._0x0e88db59(_0xd89ca86e._0xf37cffaf());
            _0xae45fb2d = _0xd89ca86e;
            _0xc86aa017++;
        }

        // Never open on a solved board. REPLACE the top move, never append one: an extra
        // move would make the solution depth + 1 and quietly falsify the budget.
        int _0xa2a45c3c = 0;
        while (this._0x68afb7fd._0x368e7ead(this._0xc0c4501d) && _0xa2a45c3c++ < 16)
        {
            if (this._0x99695452._0xeeab8362 > 0)
            {
                this._0x68afb7fd._0x2a3e48db(this._0x99695452._0x55acbed4());
                this._0x99695452._0x60550945();
            }

            MosaicMove _0xc1f33c4c = RandomMove(_0x3a89d53d);
            if (this._0x68afb7fd._0x253ca45d(_0xc1f33c4c))
                continue;
            this._0x68afb7fd._0x2a3e48db(_0xc1f33c4c);
            this._0x99695452._0x0e88db59(_0xc1f33c4c._0xf37cffaf());
        }

        if (this._0x68afb7fd._0x368e7ead(this._0xc0c4501d))
        {
            this._0x32589670 = true;
            this._0x68afb7fd = new _0x818cf24c(_0x7b3074a1);
            this._0xc0c4501d = new _0x818cf24c(_0x7b3074a1);
            this._0x99695452._0x3ac8edae();
            _0x818cf24c _0x3a08d46e = this._0x68afb7fd._0xee9665bf();
            for (int _0x0f11bfed = 0; _0x0f11bfed < 6; _0x0f11bfed++)
            {
                MosaicMove _0xc3a106b1 = new MosaicMove(_0x0f11bfed % 2, _0x0f11bfed % _0x818cf24c.Side, _0x0f11bfed % 2 == 0 ? 1 : -1);
                if (_0x3a08d46e._0x253ca45d(_0xc3a106b1))
                    continue;
                _0x3a08d46e._0x2a3e48db(_0xc3a106b1);
                this._0x99695452._0x0e88db59(_0xc3a106b1._0xf37cffaf());
            }

            this._0x68afb7fd = _0x3a08d46e;
        }

        this._0x99695452._0x637266e1(this._0x68afb7fd);
    }

    public _0x90a58e17 _0x99695452 { get; private set; }
    public bool _0x32589670 { get; private set; }
}