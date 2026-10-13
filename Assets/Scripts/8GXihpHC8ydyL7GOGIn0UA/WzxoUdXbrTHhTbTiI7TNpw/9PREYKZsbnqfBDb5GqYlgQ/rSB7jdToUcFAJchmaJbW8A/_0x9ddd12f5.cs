using UnityEngine;
using UnityEngine.UI;

public class _0x9ddd12f5 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public bool IsHideAllPops;
    public bool IsShowLastPop;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x5612c582.Instance._0x4220315f();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x5612c582.Instance._0xdc86637d());
        else
            this.Button.onClick.AddListener(() => _0x5612c582.Instance._0x8eecba3f(this.PopToShowIndex));
    }

    public int PopToShowIndex;
}