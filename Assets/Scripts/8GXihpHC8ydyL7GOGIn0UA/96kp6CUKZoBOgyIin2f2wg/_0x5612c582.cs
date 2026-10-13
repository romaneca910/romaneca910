using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xe5719494;

public class _0x5612c582 : MonoBehaviour
{
    private void _0xcfec704c(bool _0x75fa360b = false)
    {
        for (int _0xf1e1970b = 0; _0xf1e1970b < this.Pops.Count; ++_0xf1e1970b)
            if (this.Pops[_0xf1e1970b] != null && !(_0xf1e1970b == this.CurrentPopIndex && _0x75fa360b))
                this.Pops[_0xf1e1970b]._0xe247fe48();
    }

    public void _0x4220315f()
    {
        this.LastPopIndexes.RemoveAll(_0x1d28526c => _0x1d28526c == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xdc86637d();
        else
            this._0x8eecba3f(this.LastPopIndexes.Last());
    }

    public float ScaleDuration = 0.4f;
    public GameObject BlurBackground;
    public static _0x5612c582 Instance;
    public int CurrentPopIndex;
    public _0xff1faaf7 _0x8bd3c1a7(int _0xb96440ef)
    {
        return this.Pops[_0xb96440ef];
    }

    public List<_0xff1faaf7> Pops;
    public List<int> LastPopIndexes = new();
    public void _0xdc86637d()
    {
        this.LastPopIndexes.Clear();
        this._0xcfec704c();
        foreach (GameObject _0xda478694 in this.GameObjectsToHide)
            if (_0xda478694 != null)
                _0xda478694.SetActive(true);
        this._0x26131c66();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5612c582>();
    }

    private void _0x5f9e8f8a()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<GameObject> GameObjectsToHide;
    public void _0x8eecba3f(int _0xe8b98967)
    {
        this.CurrentPopIndex = _0xe8b98967;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xcfec704c(true);
        this._0x5f9e8f8a();
        this.Pops[_0xe8b98967].Show();
        foreach (GameObject _0x268be741 in this.GameObjectsToHide)
            _0x268be741.SetActive(false);
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xff1faaf7 _0xcc3ddbc3 in this.Pops)
            if (_0xcc3ddbc3 != null)
                _0xcc3ddbc3.gameObject.SetActive(true);
    }

    private void _0x26131c66()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }
}