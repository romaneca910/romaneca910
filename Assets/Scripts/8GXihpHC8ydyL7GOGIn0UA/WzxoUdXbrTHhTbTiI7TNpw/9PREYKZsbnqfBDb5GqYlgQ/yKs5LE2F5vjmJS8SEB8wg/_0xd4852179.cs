using UnityEngine;
using UnityEngine.UI;

public class _0xd4852179 : MonoBehaviour
{
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x5e1e2fdc.Instance._0xbd172a36(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x5c5bbf39.Instance._0xdaf01239());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x5e1e2fdc.Instance._0xbd172a36(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x5e1e2fdc.Instance._0xbd172a36(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x5c5bbf39.Instance._0xdaf01239());
        }
    }
}