using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xe5719494;

public class _0x5c5bbf39 : MonoBehaviour
{
    public Button DeleteProgressDataButton;
    public void _0xdaf01239()
    {
        _0x31526d8a._0xb52c1d57 = true;
    }

    public static _0xde1c4eeb _0x31526d8a => _0xde1c4eeb.ALL_SCENES_SETTING_SINGLETONS[Instance._0x1ce83e27];

    private static _0xde1c4eeb GAME_INDEX_SETTINGS(int _0xe7ee0ecb)
    {
        return _0xde1c4eeb.ALL_SCENES_SETTING_SINGLETONS[_0xe7ee0ecb];
    }

    private static void MakeGrid(List<RectTransform> _0xdc4566d6, AspectRatioFitter _0x1669f5a8, float _0x173f7da8, int _0xc5f3b117, int _0x4d3a464a)
    {
        _0x1669f5a8.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x1669f5a8.aspectRatio = _0x173f7da8;
        foreach (RectTransform _0xab2b346b in _0xdc4566d6)
        {
            int _0x3198e3d9 = _0xab2b346b.transform.GetSiblingIndex();
            _0xab2b346b.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x3198e3d9 % _0xc5f3b117) * (1f / _0xc5f3b117), (_0x4d3a464a - (Mathf.FloorToInt((float)_0x3198e3d9 / _0xc5f3b117) % _0x4d3a464a + 1f)) * (1f / _0x4d3a464a));
            _0xab2b346b.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x3198e3d9 % _0xc5f3b117 + 1f) * (1f / _0xc5f3b117), (_0x4d3a464a - Mathf.FloorToInt((float)_0x3198e3d9 / _0xc5f3b117) % _0x4d3a464a) * (1f / _0x4d3a464a));
            _0xab2b346b.offsetMin = Vector2.zero;
            _0xab2b346b.offsetMax = Vector2.zero;
        }
    }

    public void _0x2d4ee699()
    {
        this._0x0fbeb264(SceneManager.GetActiveScene().buildIndex);
    }

    private void _0x70b064ba(bool _0x30a0f9c8)
    {
        Rigidbody2D[] _0x98de92ed = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xc3d8710f in _0x98de92ed)
            if (_0x30a0f9c8)
                _0xc3d8710f.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xc3d8710f.constraints = RigidbodyConstraints2D.None;
    }

    public int _0x1ce83e27 => SceneManager.GetActiveScene().buildIndex;

    public void _0x6f7a8f3c()
    {
        foreach (_0xd121ceae _0x6300578b in this.MoneyCountContainers)
            _0x6300578b._0x3e2193e4();
    }

    public static _0x5c5bbf39 Instance;
    [HideInInspector]
    public List<_0xd121ceae> MoneyCountContainers = new();
    private void Start()
    {
        if (this._0x1ce83e27 != _0x232968b9.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x0fbeb264(_0x232968b9.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x31526d8a._0xb52c1d57 = false;
            _0x5612c582.Instance._0xdc86637d();
            _0x5e1e2fdc.Instance._0xbd172a36(_0x6888be17.TUTORIAL0);
        });
    }

    private void _0xfb58750b(Transform _0xb6e14de6)
    {
        Transform[] _0x32044b8c = _0xb6e14de6.GetComponentsInChildren<Transform>();
        foreach (Transform _0x498855e9 in _0x32044b8c)
            if (_0x498855e9 != null && DOTween.IsTweening(_0x498855e9))
            {
                if (this._0x400f44cb)
                    DOTween.Play(_0x498855e9);
                else
                    DOTween.Pause(_0x498855e9);
            }
    }

    public Canvas MainCanvas;
    private IEnumerator _0xefa0362e(int _0xeae055f8)
    {
        _0x5e1e2fdc.Instance._0xbd172a36(_0x6888be17.SPLASH);
        AsyncOperation _0xe67ce17e = SceneManager.LoadSceneAsync(_0xeae055f8);
        while (!_0xe67ce17e.isDone)
            yield return null;
    }

    private IEnumerator _0xa47bf85c(string _0x8f6319e3)
    {
        _0x5e1e2fdc.Instance._0xbd172a36(_0x6888be17.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x63b82382 = SceneManager.LoadSceneAsync(_0x8f6319e3);
        while (!_0x63b82382.isDone)
            yield return null;
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public Transform Environment;
    public bool _0x400f44cb { get; private set; }

    private void _0x4307cd20()
    {
        IsAfterLevelComplete = true;
        Instance._0x0fbeb264(_0x232968b9.SCENE_0);
    }

    public Transform EnvironmentWithTweensToToggle;
    public void _0x692bc316(bool _0xec485fe8)
    {
        this._0x400f44cb = _0xec485fe8;
        this._0x70b064ba(!this._0x400f44cb);
        Physics2D.simulationMode = this._0x400f44cb ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xfb58750b(this.EnvironmentWithTweensToToggle);
    }

    private static _0xde1c4eeb _0xd6d47eee => _0xde1c4eeb.ALL_SCENES_SETTING_SINGLETONS[0];

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5c5bbf39>();
        this.RootGameObject = GameObject.FindWithTag(_0x0dfba442._0x9d1ff108(new byte[4] { 251, 198, 198, 221 }, 169));
        if (this._0x1ce83e27 == _0x232968b9.SCENE_0)
            this._0x692bc316(true);
        else
            this._0x692bc316(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xd121ceae>(true).ToList();
    }

    public static bool IsAfterLevelComplete;
    public Button ShowResetTutorialButton;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static bool IsAfterLevelFailed = false;
    public void _0x0fbeb264(int _0x79961aad)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xefa0362e(_0x79961aad));
    }
}

internal static class _0x0dfba442
{
    internal static string _0x9d1ff108(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}