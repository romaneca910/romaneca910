using TMPro;
using UnityEngine;
using static _0xe5719494;

public class _0xd121ceae : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x4aba2777;
            if (this.gameObject.TryGetComponent(out _0x4aba2777))
                this.MoneyCountText = _0x4aba2777;
        }

        this._0x3e2193e4();
    }

    public void _0x3e2193e4()
    {
        this.MoneyCountText.text = _0x14522955._0xc0514330.ToString();
    }
}