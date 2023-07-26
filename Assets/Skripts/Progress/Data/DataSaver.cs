using UnityEngine;

public class DataSaver : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private InventoryController _invetory;
    [SerializeField] private LevelProgress _progress;
    [SerializeField] private InventoryUpdater _invetoryUpdate;

    private string _data = null;

    public bool IsLoad { get; private set; } = false;

    private void Start()
    {
        Load(_data);
    }

    public void SetData(string data)
    {
        _data = data;
    }

    public string Save()
    {
        var data = new PlayerData();
        data.Progress = _progress.Save();
        data.Invetory = _invetory.Save();
        return JsonUtility.ToJson(data);
    }

    private void Load(string data)
    {
        IsLoad = true;
        if (data != null && data != "")
        {
            var saveData = JsonUtility.FromJson<PlayerData>(data);
            LoadProgress(saveData.Progress);
            LoadInventory(saveData.Invetory);
        }
        else
        {
            _invetoryUpdate.Load(0);
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
