using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xeea09108 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x5c5bbf39.Instance._0x0fbeb264(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x5c5bbf39.Instance._0x0fbeb264(this.LoadSceneId));
    }

    public int LoadSceneId;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
}