using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8b30b9aa : MonoBehaviour
{
    private void _0xd303cc48()
    {
        if (this._0x0e47a496.canvasRenderer.GetColor() != this._0x6b5be7f7.canvasRenderer.GetColor())
            this._0x6b5be7f7.canvasRenderer.SetColor(this._0x0e47a496.canvasRenderer.GetColor());
    }

    private TMP_Text _0x6b5be7f7;
    private Image _0x0e47a496;
    private void Update()
    {
        this._0xd303cc48();
    }
}