using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xb53b045a : MonoBehaviour
{
    private void _0xcd55d2ee()
    {
        if (_0xe5a65c4a.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x8ea3133b => _0x8ea3133b.text = $"{this.ScoreCurrent}/{this._0xf0810d51}");
        else
            this.ScoreText.ForEach(_0x8ea3133b => _0x8ea3133b.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> ScoreText = new();
    private int _0xf0810d51 => this.CustomTargetScore + _0x5c5bbf39._0x31526d8a._0xd136dba5 * 10;

    private void _0xf2740592()
    {
        this.TimerText.ForEach(_0x8ea3133b => _0x8ea3133b.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xfac91302._0x23b7f55b(new byte[6] { 96, 96, 81, 55, 126, 126 }, 13)));
    }

    private void _0xebd90836()
    {
        if (this.ScoreCurrent >= this._0xf0810d51)
            this._0x898c4f71();
        else
            this._0x9bde3106();
    }

    private void Awake()
    {
        _0x526c314e = this.gameObject.GetComponent<_0xb53b045a>();
    }

    public void _0x898c4f71()
    {
        if (!this.IsGameEnd)
        {
            this._0x041c015d();
            _0x5c5bbf39.IsAfterLevelComplete = true;
            _0x5c5bbf39.IsAfterLevelFailed = false;
            _0xff1faaf7 _0x04b19dd1 = _0x5612c582.Instance._0x8bd3c1a7(_0xe5719494._0xb2c1b372.WIN).GetComponent<_0xff1faaf7>();
            if (_0xe5a65c4a.Instance.IsCheckScoreEnabled)
                _0x04b19dd1.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xf0810d51}";
            else
                _0x04b19dd1.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xe5a65c4a.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xe5719494._0x14522955._0xc0514330)
                    _0xe5719494._0x14522955._0xc0514330 = this.ScoreCurrent;
                _0x04b19dd1.ContentAdditionalText.text = $"{_0xe5719494._0x14522955._0xc0514330}";
            }
            else
            {
                _0x04b19dd1.ContentAdditionalText.text = $"{this._0x3084ab9d}";
                _0xe5719494._0x14522955._0xc0514330 += this._0x3084ab9d;
            }

            if (_0xe5a65c4a.Instance.IsLevelIncrementOnWin)
                ++_0x5c5bbf39._0x31526d8a._0xd136dba5;
            _0x5612c582.Instance._0x8eecba3f(_0xe5719494._0xb2c1b372.WIN);
        }
    }

    private void _0x041c015d()
    {
        this.IsGameEnd = true;
        _0x5c5bbf39.IsAfterLevelComplete = true;
    }

    public List<Button> HomeButtons = new();
    public int CustomTimeInitial = 30;
    public void _0x0acc4b25(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xcd55d2ee();
            this._0x880eb4ce();
        }
    }

    private static _0xb53b045a _0x526c314e;
    public void _0x9bde3106()
    {
        if (_0xe5a65c4a.Instance.IsOnlyWinGameEndEnabled)
            this._0x898c4f71();
        if (!this.IsGameEnd)
        {
            this._0x041c015d();
            _0x5c5bbf39.IsAfterLevelComplete = false;
            _0x5c5bbf39.IsAfterLevelFailed = true;
            _0xff1faaf7 _0x7b60c9b5 = _0x5612c582.Instance._0x8bd3c1a7(_0xe5719494._0xb2c1b372.LOSE).GetComponent<_0xff1faaf7>();
            if (_0xe5a65c4a.Instance.IsCheckScoreEnabled)
                _0x7b60c9b5.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xf0810d51}";
            else
                _0x7b60c9b5.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x7b60c9b5.ContentAdditionalText.text = $"{0}";
            _0xe5719494._0x14522955._0xc0514330 += 0;
            _0x5612c582.Instance._0x8eecba3f(_0xe5719494._0xb2c1b372.LOSE);
        }
    }

    public void _0xd10c7861()
    {
        _0x5c5bbf39.Instance._0x692bc316(true);
        _0x5c5bbf39.Instance._0x0fbeb264(_0xe5719494._0x232968b9.SCENE_0);
    }

    private void _0x880eb4ce()
    {
        if (this.ScoreCurrent > _0x5c5bbf39._0x31526d8a._0xf8d3773f)
            _0x5c5bbf39._0x31526d8a._0xf8d3773f = this.ScoreCurrent;
        if (_0xe5a65c4a.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xf0810d51)
                this._0x898c4f71();
    }

    public List<Button> PauseButtons = new();
    public List<TMP_Text> TimerText = new();
    public List<TMP_Text> LevelNumberText = new();
    public int CustomTargetScore = 10;
    [HideInInspector]
    public int CurrentGameIndex;
    [HideInInspector]
    public int ScoreCurrent;
    private IEnumerator _0x9388e24f()
    {
        this._0xf2740592();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x5c5bbf39.Instance._0x1ce83e27 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x5c5bbf39.Instance._0x400f44cb)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xf2740592();
            }
        }

        if (!this.IsGameEnd)
            this._0x9bde3106();
    }

    [HideInInspector]
    public int TimeLeft;
    private int _0x55fc7bbb => this.CustomTimeInitial + _0x5c5bbf39._0x31526d8a._0xd136dba5 * 10;
    private int _0x3084ab9d => this.ScoreCurrent;

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x55fc7bbb;
        this.CurrentGameIndex = _0x5c5bbf39.Instance._0x1ce83e27;
        foreach (Button _0xd9dbbad4 in this.HomeButtons)
            _0xd9dbbad4.onClick.AddListener(() =>
            {
                this._0xd10c7861();
            });
        foreach (Button _0xe2d568f2 in this.PauseButtons)
            _0xe2d568f2.onClick.AddListener(() =>
            {
                _0x5c5bbf39.Instance._0x692bc316(false);
                _0x5612c582.Instance._0x8eecba3f(_0xe5719494._0xb2c1b372.PAUSE);
            });
        this._0xcd55d2ee();
        this.LevelNumberText.ForEach(_0x8ea3133b => _0x8ea3133b.text = $"LVL {_0x5c5bbf39._0x31526d8a._0xd136dba5 + 1}");
        if (_0xe5a65c4a.Instance.IsTimerEnabled)
        {
            this._0xf2740592();
            this.StartCoroutine(this._0x9388e24f());
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
}

internal static class _0xfac91302
{
    internal static string _0x23b7f55b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}