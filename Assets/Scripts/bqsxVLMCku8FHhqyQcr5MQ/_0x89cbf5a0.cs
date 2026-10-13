using UnityEngine;

// The game scene's only scene-root object of ours. Same shape as the menu's: the
// generated screen goes inside the template's DefaultPanel, the splash gets the same
// brand, and every address is a SETTINGS index.
public sealed class _0x89cbf5a0 : MonoBehaviour
{
    [SerializeField]
    private GameObject _gamePrefab;
    private void Start()
    {
        if (_0x5e1e2fdc.Instance == null)
            return;
        _0xe215cc14 _0xc2e0c49b = _0x5e1e2fdc.Instance.Panels[_0xe5719494._0x6888be17.SPLASH];
        if (_0xc2e0c49b != null && _0xc2e0c49b.Content != null && this._splashPrefab != null)
        {
            GameObject _0x64075115 = Instantiate(this._splashPrefab, _0xc2e0c49b.Content.transform, false);
            _0x64075115.transform.SetAsFirstSibling();
        }

        _0xe215cc14 _0x92b51429 = _0x5e1e2fdc.Instance.Panels[_0xe5719494._0x6888be17.DEFAULT];
        if (_0x92b51429 != null && _0x92b51429.Content != null && this._gamePrefab != null)
            Instantiate(this._gamePrefab, _0x92b51429.Content.transform, false);
        if (this._sweeper != null)
            this._sweeper._0x013c948f();
    }

    [SerializeField]
    private _0x4e698692 _sweeper;
    [SerializeField]
    private GameObject _splashPrefab;
}