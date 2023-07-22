using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

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

    private int _level = 1;
    private int _countCraft = 40; //test
    private Star[] _stars;

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
        _result.OnCraft += UpdateProgress;
    }

    public void UpdateProgress()
    {
        if (_countCraft >= _levelSize)
        {
            _level++;
            _countCraft = 0;
            _onUpdateLvl.Invoke();
        }
        AddStar(_stars[_countCraft]);
        _countCraft++;
        _invetory.UpdateItem();
    }

    private void AddStar(Star star)
    {
        star.SetStar(GetStar());
        if (!star.gameObject.activeSelf)
        {
            star.gameObject.SetActive(true);
        }
    }


    private Sprite GetStar()
    {
        foreach (var star in _slots)
        {
            if (star.Level == _level)
            {
                return star.Icon;
            }
        }
        return _slots[_slots.Length-1].Icon;
    }

}
