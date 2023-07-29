
using System.Collections;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Yandex : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private RawImage playerImage; 

    [DllImport("__Internal")]
    private static extern void GetPlayerData();
    [DllImport("__Internal")]
    private static extern void RateGame();
    [DllImport("__Internal")]
    private static extern void ShowReclama(); 
    public void ShowReclamaInUnity()
    {
        Time.timeScale = 0f;
        StartCoroutine(ReclamaCoroutine());
        ShowReclama();
    }
    public void RateGameButton()
    { 
        RateGame(); 
    }
    public void ShowPlayerDataButton()
    {
        GetPlayerData();
    }
    public void SetNamePlayer(string namePlayer)
    {
        playerName.text = namePlayer;
    }
    public void SetImagePlayer(string urlImage)
    {
        StartCoroutine(DownloadPlayerImage(urlImage));
    }
    private IEnumerator DownloadPlayerImage(string urlImage)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(urlImage);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            Debug.Log(request.error);
        else playerImage.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
    }
    private IEnumerator ReclamaCoroutine()
    {
        yield return new WaitForSeconds(20);
        Time.timeScale = 1f;
    }

}