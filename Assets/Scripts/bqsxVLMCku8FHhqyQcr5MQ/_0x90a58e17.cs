using System.Collections.Generic;

// The live solution stack. Its invariant is the whole hint system: replaying the stack
// from the top down on the CURRENT board always reaches the target, so Peek() is a legal
// and correct next move and Count is an honest "a solution from here is N moves".
public sealed class _0x90a58e17
{
    public MosaicMove _0x55acbed4()
    {
        return this._0x83deb459[this._0x83deb459.Count - 1];
    }

    public void _0x0e88db59(MosaicMove _0x9fcf12c3)
    {
        this._0x83deb459.Add(_0x9fcf12c3);
    }

    // A line can go uniform after a player move, which makes the stored move a visible
    // no-op. Dropping those keeps Count honest and keeps the hint from pointing at a
    // tap that changes nothing.
    public void _0x637266e1(_0x818cf24c _0xe19ced5c)
    {
        while (this._0x83deb459.Count > 0 && _0xe19ced5c._0x253ca45d(this._0x55acbed4()))
            this._0x60550945();
    }

    private readonly List<MosaicMove> _0x83deb459;
    public _0x90a58e17()
    {
        this._0x83deb459 = new List<MosaicMove>(64);
    }

    public void _0x3ac8edae()
    {
        this._0x83deb459.Clear();
    }

    public int _0xeeab8362
    {
        get
        {
            return this._0x83deb459.Count;
        }
    }

    // Fold the move the player just made into the stack: if it undid the pending step,
    // drop that step; otherwise the inverse is now the first move back to the target.
    //
    // ORDER MATTERS. Trimming no-ops BEFORE the fold is unsound, and measurably so: when
    // the branch then pushes the inverse, the plan starts one move EARLIER than the board
    // the no-ops were judged against, and a step that looks dead now comes back to life
    // once that inverse is applied. Measured over 18000 seeds: 16 boards lost the
    // invariant. Folding first and trimming afterwards keeps the stack top judged against
    // the board it will really be applied to.
    public void _0x9eb7093a(MosaicMove _0x41600e01, _0x818cf24c _0x4601057a)
    {
        if (this._0x83deb459.Count > 0 && this._0x55acbed4()._0x9a72cbcf(_0x41600e01))
            this._0x60550945();
        else
            this._0x0e88db59(_0x41600e01._0xf37cffaf());
        this._0x637266e1(_0x4601057a);
    }

    public void _0x60550945()
    {
        this._0x83deb459.RemoveAt(this._0x83deb459.Count - 1);
    }
}