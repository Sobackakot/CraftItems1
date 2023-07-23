using UnityEngine;

public class DataSaver : MonoBehaviour
{
    [SerializeField] private string _key;
    [SerializeField] private InventoryController _invetory;
    [SerializeField] private LevelProgress _progress;
    [SerializeField] private InventoryUpdater _invetoryUpdate;

    private void Start()
    {
        Load();
    }

    private void OnApplicationQuit()
    {
        Save();
    }
    public void RemoveSave()
    {
        PlayerPrefs.DeleteKey(_key);
    }
    public void Save()
    {
        var data = new PlayerData();
        data.Progress = _progress.Save();
        data.Invetory = _invetory.Save();
        PlayerPrefs.SetString(_key, JsonUtility.ToJson(data));
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey(_key))
        {
            var data = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString(_key));
            LoadProgress(data.Progress);
            LoadInventory(data.Invetory);
        }
        else
        {
            _invetoryUpdate.Load(40);
        }
    }

    private void LoadProgress(string data)
    {
        if (data != null)
        {
            var progress = JsonUtility.FromJson<ProgressData>(data);
            _progress.Load(progress);
            int index = (progress.Level - 1) * _progress.LevelSize + progress.CountCraft;
            ShowChallenge.InstanceChallenge.Load(index);
            _invetoryUpdate.Load(index);
        }
    }

    private void LoadInventory(string data)
    {
        if (data != null)
            _invetory.Load(JsonUtility.FromJson<InvetoryData>(data));
    }

}
