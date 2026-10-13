using TMPro;
using UnityEngine;
using UnityEngine.UI;

// One card of the seasonal album. Closed cards keep a silhouette and say so, so the
// grid never shows an unexplained blank tile.
public sealed class _0xb66a9795 : MonoBehaviour
{
    public void _0xbd642200(bool _0xa71b61df, Sprite _0x91ea176c, Sprite _0x3f00b1d5, Color _0xcc36c297, string _0xd10ab063, string _0x21a138ee)
    {
        _0x978b485d.Shape(this._name, 26f, 32f);
        _0x978b485d.Shape(this._chip, 26f, 28f);
        _0x978b485d.ApplyOutline(this._name, _0xcc07f46d.Ink);
        _0x978b485d.ApplyOutline(this._chip, _0xcc07f46d.InkSoft);
        if (this._plate != null)
            this._plate.color = _0xa71b61df ? _0xcc07f46d.Fade(_0xcc36c297, 0.18f) : _0xcc07f46d.Fade(_0xcc07f46d.SurfaceDeep, 0.5f);
        if (this._flower != null)
        {
            this._flower.sprite = _0xa71b61df ? _0x91ea176c : _0x3f00b1d5;
            this._flower.preserveAspect = true;
            this._flower.color = _0xa71b61df ? Color.white : new Color(0.6f, 0.56f, 0.64f, 0.3f);
        }

        if (this._name != null)
            this._name.text = _0xa71b61df ? _0xd10ab063 : _0x637154fa._0x6b0fa073(new byte[11] { 136, 137, 146, 230, 150, 148, 131, 149, 149, 131, 130 }, 198);
        if (this._chip != null)
        {
            this._chip.gameObject.SetActive(_0xa71b61df);
            this._chip.text = _0x21a138ee;
        }
    }

    [SerializeField]
    private TMP_Text _name;
    [SerializeField]
    private Image _plate;
    [SerializeField]
    private TMP_Text _chip;
    [SerializeField]
    private Image _flower;
}

internal static class _0x637154fa
{
    internal static string _0x6b0fa073(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}