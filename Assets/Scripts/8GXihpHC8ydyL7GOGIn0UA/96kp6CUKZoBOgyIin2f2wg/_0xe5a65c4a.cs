using UnityEngine;

public class _0xe5a65c4a : MonoBehaviour
{
    public bool IsCheckScoreEnabled;
    public bool IsSkipSplashEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xe5a65c4a>();
            DontDestroyOnLoad(this.gameObject);
            this._0x5a9daa6e();
        }
        else
        {
            this._0xde5e1113();
            Destroy(this.gameObject);
        }
    }

    public bool IsLevelSelectorEnabled;
    public bool IsBestScoreEnabled;
    public bool IsStoryEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsLevelIncrementOnWin;
    private void _0x5a9daa6e()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTimerEnabled;
    public static _0xe5a65c4a Instance;
    private void _0xde5e1113()
    {
    }

    public bool IsTutorialEnabled;
}