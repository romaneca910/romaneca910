using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xe5719494
{
    public static class _0x232968b9
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0xde1c4eeb
    {
        private static readonly _0xde1c4eeb _0x2494ebde = new();
        public static readonly _0xde1c4eeb[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x2494ebde,
            _0x2494ebde,
            _0x2494ebde,
        };
        private int _0x32c5198d => 0;
        private int _0x9dedc1a7 => 10;
        private string _0xeb656e00 => _0xf04b8a04._0x623fe75f(new byte[4] { 57, 17, 26, 1 }, 116);
        private string _0xcd132b6b => _0xf04b8a04._0x623fe75f(new byte[8] { 49, 56, 43, 56, 49, 6, 77, 0 }, 125);

        private int _0xae77df10
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xf04b8a04._0x623fe75f(new byte[25] { 33, 23, 16, 16, 7, 12, 22, 37, 14, 13, 0, 3, 14, 33, 10, 3, 18, 22, 7, 16, 43, 12, 6, 7, 26 }, 98)))
                    PlayerPrefs.SetInt(_0xf04b8a04._0x623fe75f(new byte[25] { 174, 152, 159, 159, 136, 131, 153, 170, 129, 130, 143, 140, 129, 174, 133, 140, 157, 153, 136, 159, 164, 131, 137, 136, 149 }, 237), 0);
                return PlayerPrefs.GetInt(_0xf04b8a04._0x623fe75f(new byte[25] { 35, 21, 18, 18, 5, 14, 20, 39, 12, 15, 2, 1, 12, 35, 8, 1, 16, 20, 5, 18, 41, 14, 4, 5, 24 }, 96));
            }

            set => PlayerPrefs.SetInt(_0xf04b8a04._0x623fe75f(new byte[25] { 66, 116, 115, 115, 100, 111, 117, 70, 109, 110, 99, 96, 109, 66, 105, 96, 113, 117, 100, 115, 72, 111, 101, 100, 121 }, 1), value);
        }

        public int _0xd136dba5
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xeb656e00}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xeb656e00}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xeb656e00}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xeb656e00}CurrentLevelIndex", value);
        }

        public int _0xf8d3773f
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xeb656e00}BestScore"))
                    this._0xf8d3773f = 0;
                return PlayerPrefs.GetInt($"{this._0xeb656e00}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xeb656e00}BestScore", value);
        }

        public bool _0xb52c1d57
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xeb656e00}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xeb656e00}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xeb656e00}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xeb656e00}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x6888be17
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xb2c1b372
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x14522955
    {
        public static int _0xc0514330
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xf04b8a04._0x623fe75f(new byte[5] { 237, 193, 199, 192, 221 }, 174)))
                    PlayerPrefs.SetInt(_0xf04b8a04._0x623fe75f(new byte[5] { 167, 139, 141, 138, 151 }, 228), 0);
                return PlayerPrefs.GetInt(_0xf04b8a04._0x623fe75f(new byte[5] { 66, 110, 104, 111, 114 }, 1));
            }

            set
            {
                PlayerPrefs.SetInt(_0xf04b8a04._0x623fe75f(new byte[5] { 149, 185, 191, 184, 165 }, 214), value);
                _0x5c5bbf39.Instance._0x6f7a8f3c();
            }
        }
    }
}

internal static class _0xf04b8a04
{
    internal static string _0x623fe75f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}