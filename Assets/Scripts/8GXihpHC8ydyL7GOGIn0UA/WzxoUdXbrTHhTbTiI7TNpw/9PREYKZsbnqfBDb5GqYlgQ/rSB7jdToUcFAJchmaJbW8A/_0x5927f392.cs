using UnityEngine;
using UnityEngine.UI;

public class _0x5927f392 : MonoBehaviour
{
    private Button _0x3e88dff0;
    private void Start()
    {
        if (this._0xf02bc144)
            this._0x3e88dff0.onClick.AddListener(() => _0x5e1e2fdc.Instance._0x229498fc());
        else
            this._0x3e88dff0.onClick.AddListener(() => _0x5e1e2fdc.Instance._0xbd172a36(this._0x22730649));
    }

    private void Awake()
    {
        if (this._0x3e88dff0 == null)
            if (!this.TryGetComponent(out this._0x3e88dff0))
                this._0x3e88dff0 = this.GetComponentInChildren<Button>();
    }

    private bool _0xf02bc144;
    private int _0x22730649;
}