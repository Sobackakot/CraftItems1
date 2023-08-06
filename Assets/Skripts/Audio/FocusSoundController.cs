using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FocusSoundController : MonoBehaviour
{
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
        while (true)
        {
            PouseMusic();
            yield return null;
        }
    }
    public void SwitchMusicButton()
    {
        StartCoroutine(PouseMusicCoroutine());
    }
    public void PouseMusic()
    {
        Silence(true);
    }
    public void PlayingMusic()
    {
        StopCoroutine(PouseMusicCoroutine());
        Silence(false); 
    }
}
