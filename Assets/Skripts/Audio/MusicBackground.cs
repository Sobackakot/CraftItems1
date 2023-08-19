using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBackground : MonoBehaviour
{
    public static MusicBackground InstanceMusick { get; private set; }
    [HideInInspector]public AudioSource m_AudioSource;
    [SerializeField] private AudioClip[] audioArray;
    private int index = 0;
    private bool isPlaying = false;
    private Coroutine _corotine;
    
    private void Awake()
    { 
        if (InstanceMusick == null)
        {
            InstanceMusick = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
            return;
        }
        m_AudioSource = GetComponent<AudioSource>();
    }
     
    private IEnumerator Start()
    {
        if (!isPlaying)
            PlayNextMusic();
        yield return null;
    }

    private void PlayNextMusic()
    { 
        m_AudioSource.clip = audioArray[index];
        m_AudioSource.Play();
        _corotine = StartCoroutine(WaitForMusicToFinish());
    }

    private IEnumerator WaitForMusicToFinish()
    {
        isPlaying = true;

        while (m_AudioSource.isPlaying)
        {
            yield return null;
        }

        isPlaying = false;
        index++;
        if (index >= audioArray.Length)
            index = 0;
        PlayNextMusic();
    }

    public void TurnOnMusic()
    {
        if (!isPlaying)
            m_AudioSource.Play();
    }

    public void TurnOffMusic()
    {
        m_AudioSource.Stop();
        if (_corotine != null)
        {
            StopCoroutine(_corotine);
            _corotine = null;
        }
        StopAllCoroutines();
        isPlaying = false;
    }
}  

