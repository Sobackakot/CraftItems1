using System.Runtime.InteropServices;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    [SerializeField] private string _key;
    [SerializeField] private DataSaver _dataSaver;

    [DllImport("__Internal")]
    private static extern void SaveExtern(string data);
    [DllImport("__Internal")]
    private static extern void LoadExtern();

    public void Awake()
    {
        Load();
    }

    public void OnApplicationQuit()
    {
        if(_dataSaver.IsLoad)
            Save();
    }

    public void Save()
    {
#if !UNITY_WEBGL || UNITY_EDITOR
        PlayerPrefs.SetString(_key, _dataSaver.Save());
#else

        SaveExtern(_dataSaver.Save());
#endif
    }

    public void RemoveSave()
    {
#if !UNITY_WEBGL || UNITY_EDITOR
        PlayerPrefs.DeleteKey(_key);
#endif
    }

    public void Load()
    {
#if !UNITY_WEBGL || UNITY_EDITOR
        if (PlayerPrefs.HasKey(_key))
        {
            Load(PlayerPrefs.GetString(_key));
        }
#else
        LoadExtern();
#endif
    }

    public void Load(string data)
    {
        _dataSaver.SetData(data);
    }

}
