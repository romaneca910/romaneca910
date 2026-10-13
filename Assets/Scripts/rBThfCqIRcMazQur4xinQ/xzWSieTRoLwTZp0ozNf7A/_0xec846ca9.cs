using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xec846ca9 : MonoBehaviour
{
    private List<string> _0x7c0b8cdd = new();
    private float _0x833a629e = 1.5f;
    private TMP_Text _0x0e20a118;
    private float _0x86f6e0d1 = 0.6f;
    private float _0x98f1a168;
    private float _0xacc1cc2c = 4;
    private AspectRatioFitter _0x672150df;
    private void Update()
    {
        int _0x0895699f = 1;
        if (this._0x7c0b8cdd.Count > 0)
        {
            string _0x3cb10db0 = this._0x0e20a118.text;
            foreach (string _0xf090f7f1 in this._0x7c0b8cdd)
                while (_0x3cb10db0.Contains(_0xf090f7f1))
                    _0x3cb10db0 = _0x3cb10db0.Replace(_0xf090f7f1, "");
            _0x0895699f = _0x3cb10db0.Length;
        }
        else
        {
            _0x0895699f = this._0x0e20a118.text.Length;
        }

        float _0xf8056347 = Mathf.Clamp(this._0x98f1a168 + this._0x86f6e0d1 * _0x0895699f, this._0x833a629e, this._0xacc1cc2c);
        if (!Mathf.Approximately(this._0x672150df.aspectRatio, _0xf8056347))
            this._0x672150df.aspectRatio = _0xf8056347;
    }
}