using UnityEngine;

// The menu scene's only scene-root object of ours. It hangs the generated screens
// inside the template's own panels, addressed by INDEX - never by name - so panel
// navigation keeps working exactly as the template drives it.
public sealed class _0x5c7e005b : MonoBehaviour
{
    [SerializeField]
    private GameObject _splashPrefab;
    private void Start()
    {
        if (_0x5e1e2fdc.Instance == null)
            return;
        _0xe215cc14 _0x880722b8 = _0x5e1e2fdc.Instance.Panels[_0xe5719494._0x6888be17.SPLASH];
        if (_0x880722b8 != null && _0x880722b8.Content != null && this._splashPrefab != null)
        {
            GameObject _0x2b0c14de = Instantiate(this._splashPrefab, _0x880722b8.Content.transform, false);
            // First sibling, so the template's loading bar keeps drawing on top of it.
            _0x2b0c14de.transform.SetAsFirstSibling();
        }

        _0xe215cc14 _0x0f2fe845 = _0x5e1e2fdc.Instance.Panels[_0xe5719494._0x6888be17.DEFAULT];
        if (_0x0f2fe845 != null && _0x0f2fe845.Content != null && this._menuPrefab != null)
            Instantiate(this._menuPrefab, _0x0f2fe845.Content.transform, false);
        if (this._sweeper != null)
            this._sweeper._0x013c948f();
    }

    [SerializeField]
    private GameObject _menuPrefab;
    [SerializeField]
    private _0x4e698692 _sweeper;
}