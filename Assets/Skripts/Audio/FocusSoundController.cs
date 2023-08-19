using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FocusSoundController : MonoBehaviour
{ 
    private MusicBackground musick;
    private void Start()
    {
        musick = MusicBackground.InstanceMusick;
        enabled = false;
    }
    private void OnApplicationFocus(bool hasFocus) //metod unity
    {
        Silence(!hasFocus);
    }
    private void OnApplicationPause(bool isPaused) //metod unity
    {
        Silence(isPaused);
    }
    private void Silence(bool silence)
    {
        AudioListener.pause = silence;
        // Or / And
        AudioListener.volume = silence ? 0 : 1;
    }
    
    public void PouseMusic()
    {
        musick.m_AudioSource.Stop();
        enabled = true; 
    }
    public void PlayingMusic()
    {    
        enabled = false;
        musick.m_AudioSource.Play();
    }
}
