using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FocusSoundController : MonoBehaviour
{
    private bool IsPlayingReclam = true;
    private void OnApplicationFocus(bool hasFocus)
    {
        Silence(!hasFocus);
    }
    private void OnApplicationPause(bool isPaused)
    {
        Silence(isPaused);
    }
    private void Silence(bool silence)
    {
        AudioListener.pause = silence;
        // Or / And
        AudioListener.volume = silence ? 0 : 1;
    }
    private IEnumerator PouseMusicCoroutine()
    {
        while (IsPlayingReclam)
        {
            PouseMusic();
            yield return null;
        }
        PlayingMusic();
    }
    public void SwitchMusicButton()
    {
        IsPlayingReclam = true;
        StartCoroutine(PouseMusicCoroutine()); 
    }
    public void PouseMusic()
    {
        Silence(true);
        IsPlayingReclam = true;
    }
    public void PlayingMusic()
    { 
        Silence(false);
        IsPlayingReclam = false;
    }
}
