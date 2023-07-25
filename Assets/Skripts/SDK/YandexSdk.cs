using System.Runtime.InteropServices;
using UnityEngine;

public class YandexSdk : MonoBehaviour
{
    private System.Action _action;

    public bool IsReady { get; private set; } = true;

    [DllImport("__Internal")]
    private static extern void ShowAdsExtern();

    public bool ShowRewardAds(System.Action action)
    {
        if (IsReady)
        {
            IsReady = false;
            _action = action;
#if UNITY_WEBGL && !UNITY_EDITOR
         ShowAdsExtern();
#else
            Reward();
            CompliteAds();
#endif
            return true;
        }
        return false;
    }

    public void Reward()
    {
        _action();
    }

    public void CompliteAds()
    {
        IsReady = true;
        Time.timeScale = 1f;
    }
    public void Open()
    {
        Time.timeScale = 0f;
    }
}
