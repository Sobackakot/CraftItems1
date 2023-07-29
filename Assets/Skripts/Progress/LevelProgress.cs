using UnityEngine.Events;
using UnityEngine; 
using System.Runtime.InteropServices;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private int _levelSize = 20;
    [Header("Refarence")]
    [SerializeField] private StarSlot[] _slots;
    [SerializeField] private Transform _holder;
    [SerializeField] private CraftResultSlot _result;
    [SerializeField] private InventoryUpdater _invetory;
    [Header("Event")]
    [SerializeField] private UnityEvent _onUpdateLvl;  
    [SerializeField] private GameObject rateGame;
    [SerializeField] private GameObject questsItemsS;

    private int _level = 1;
    private int _countCraft = 0; 
    private Star[] _stars;

    public int LevelSize => _levelSize;

    [DllImport("__Internal")]
    private static extern void MyLiderBoards(int value);

    private void OnValidate()
    {
        _levelSize = _levelSize > 1 ? _levelSize : 1;
    }

    private void Awake()
    {
        _stars = _holder.GetComponentsInChildren<Star>();
        foreach (var star in _stars)
        {
            star.gameObject.SetActive(false);
        } 
    }

    private void OnEnable()
    {
        _result.OnCraft += UpdateProgress;
    }

    private void OnDisable()
    {
        _result.OnCraft -= UpdateProgress;
    }

    public string Save()
    {
        var progress = new ProgressData();
        progress.Level = _level;
        progress.CountCraft = _countCraft;
        progress.Stars = new int[_levelSize];
        for (int i = 0; i < _levelSize; i++)
        { 
            progress.Stars[i] = _stars[i].Level;
        }
        return JsonUtility.ToJson(progress);
    }

    public void Load(ProgressData progress)
    {
        _level = progress.Level;
        _countCraft = progress.CountCraft;
        for (int i = 0; i < progress.Stars.Length; i++)
        {
            if(progress.Stars[i] != 0)
                AddStar(_stars[i], progress.Stars[i]);
        }
    }

    public void UpdateProgress()
    {
        if (_countCraft >= _levelSize)
        {
            _level++;
            _countCraft = 0;
            _onUpdateLvl.Invoke();
        }
        AddStar(_stars[_countCraft], _level);
        _countCraft++;
        _invetory.UpdateItem();
        if(_countCraft == 20)
        {
            questsItemsS.gameObject.SetActive(false);
            rateGame.gameObject.SetActive(true); 
        }
        MyLiderBoards(_countCraft);
    }

    private void AddStar(Star star, int level)
    {
        star.SetStar(level, GetStar(level));
        if (!star.gameObject.activeSelf)
        {
            star.gameObject.SetActive(true);
        }
    }

    private Sprite GetStar(int level)
    {
        foreach (var star in _slots)
        {
            if (star.Level == level)
            {
                return star.Icon;
            }
        }
        return _slots[_slots.Length-1].Icon;
    } 

}
