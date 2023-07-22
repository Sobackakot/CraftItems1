using UnityEngine;

public class DataSaver : MonoBehaviour
{
    [SerializeField] private string _key;
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

    public void Save()
    {
        PlayerPrefs.SetString(_key, _progress.Save());
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey(_key))
        {
            var progress = JsonUtility.FromJson<ProgressData>(PlayerPrefs.GetString(_key));
            _progress.Load(progress);
            int index = (progress.Level - 1) * _progress.LevelSize + progress.CountCraft;
            ShowChallenge.InstanceChallenge.Load(index);
            _invetoryUpdate.Load(index);
        }
    }


}
