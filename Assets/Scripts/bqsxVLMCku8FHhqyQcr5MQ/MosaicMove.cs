// One cyclic shift of a single line of the mosaic by one cell.
// Pure data: no UnityEngine dependency, so the generator can be exercised headlessly.
public struct MosaicMove
{
    public int Axis; // 0 = row (shifts left/right), 1 = column (shifts up/down)
    public int Index; // 0..4
    public int Step; // +1 or -1
    public MosaicMove(int _0x5bd805b1, int _0xaa55383b, int _0x10026067)
    {
        this.Axis = _0x5bd805b1;
        this.Index = _0xaa55383b;
        this.Step = _0x10026067;
    }

    public MosaicMove _0xf37cffaf()
    {
        return new MosaicMove(this.Axis, this.Index, -this.Step);
    }

    public bool _0x48af44ac(MosaicMove _0x38b4b042)
    {
        return this.Axis == _0x38b4b042.Axis && this.Index == _0x38b4b042.Index;
    }

    public bool _0x9a72cbcf(MosaicMove _0xf12679b4)
    {
        return this._0x48af44ac(_0xf12679b4) && this.Step == _0xf12679b4.Step;
    }
}