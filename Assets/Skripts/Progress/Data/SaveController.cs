using System.Collections; 
using UnityEngine;

public class SaveController : MonoBehaviour
{
    [SerializeField] private string _key;
    [SerializeField] private DataSaver _dataSaver;

    private void Awake()
    {
        Load();
    }

    public void StartMetod()
    {
        StartCoroutine(SaveGames());
    }

    public void OnApplicationQuit()
    {
        if(_dataSaver.IsLoad)
            Save();
    }

    public void Save()
    {
        PlayerPrefs.SetString(_key, _dataSaver.Save());
    }

    public void RemoveSave()
    {
        PlayerPrefs.DeleteKey(_key);
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey(_key))
        {
            Load(PlayerPrefs.GetString(_key));
        }
    }
     
    public void Load(string data)
    {
        _dataSaver.SetData(data);
    }
    public IEnumerator SaveGames()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Save();
        }
    }
    public void Restart()
    {
        PlayerPrefs.SetString(_key, "");
    }

}
