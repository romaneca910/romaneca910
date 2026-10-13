using TMPro;
using UnityEngine;

// The template defines more panels than this game dresses - five tutorial panels among
// them, carrying 'Lorem Ipsum' and 'HEADER' straight from the base prefab. The panels
// are NOT switched off (controllers address them by index and a missing object breaks
// navigation): their captions are emptied at runtime instead (rule C.15).
public sealed class _0x4e698692 : MonoBehaviour
{
    public void _0x013c948f()
    {
        if (_0x5e1e2fdc.Instance == null || _0x5e1e2fdc.Instance.Panels == null)
            return;
        // Built locally, not as a static field: a static of ours reading another type's
        // statics is the cross-class initializer order that string encryption turns into
        // a dead .cctor (rule C.52).
        int[] _0x18279300 =
        {
            _0xe5719494._0x6888be17.EMPTY,
            _0xe5719494._0x6888be17.TUTORIAL0,
            _0xe5719494._0x6888be17.TUTORIAL1,
            _0xe5719494._0x6888be17.TUTORIAL2,
            _0xe5719494._0x6888be17.TUTORIAL3,
            _0xe5719494._0x6888be17.TUTORIAL4,
            _0xe5719494._0x6888be17.TUTORIAL5,
            _0xe5719494._0x6888be17.TUTORIAL6,
        };
        for (int _0x2b4d4e25 = 0; _0x2b4d4e25 < _0x18279300.Length; _0x2b4d4e25++)
        {
            int _0xd8aa4c69 = _0x18279300[_0x2b4d4e25];
            if (_0xd8aa4c69 < 0 || _0xd8aa4c69 >= _0x5e1e2fdc.Instance.Panels.Count)
                continue;
            _0xe215cc14 _0x43970281 = _0x5e1e2fdc.Instance.Panels[_0xd8aa4c69];
            if (_0x43970281 == null)
                continue;
            TMP_Text[] _0x1809601a = _0x43970281.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x6f16b47e = 0; _0x6f16b47e < _0x1809601a.Length; _0x6f16b47e++)
                if (_0x1809601a[_0x6f16b47e] != null)
                    _0x1809601a[_0x6f16b47e].text = string.Empty;
        }
    }
}