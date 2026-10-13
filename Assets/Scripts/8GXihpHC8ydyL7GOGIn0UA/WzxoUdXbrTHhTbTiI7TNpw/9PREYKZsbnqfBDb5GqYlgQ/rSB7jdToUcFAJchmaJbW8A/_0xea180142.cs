using UnityEngine;
using UnityEngine.UI;

public class _0xea180142 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x5c5bbf39.Instance._0x692bc316(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public bool IsPhysicsRunOnClick;
}