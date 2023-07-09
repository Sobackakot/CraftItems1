using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private int _levelSize = 10;
    [Header("Refarence")]
    [SerializeField] private StarSlot[] _slots;
    [SerializeField] private Transform _holder;
    [SerializeField] private CraftResultSlot _result;
    [Header("Event")]
    [SerializeField] private UnityEvent _onUpdateLvl;

    private int _level = 1;
    private int _countCraft = 0;

    private List<GameObject> _stars = new List<GameObject>();
    private List<GameObject> _pool = new List<GameObject>();

    private void OnValidate()
    {
        _levelSize = _levelSize > 1 ? _levelSize : 1;
    }

    public void Reset()
    {
        foreach (var star in _stars)
        {
            if (!_pool.Contains(star))
                _pool.Add(star);
        }
        _stars.Clear();
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
        _countCraft++;
        AddStar();
        if (_countCraft >= _levelSize)
        {
            _level++;
            _onUpdateLvl.Invoke();
        }
    }

    private void AddStar()
    {
        var star = CreateStar();
        star.transform.SetAsFirstSibling();
        if (_stars.Count >= _levelSize)
        {
            var oldStar = _stars[0];
            _stars.Remove(oldStar);
            Destroy(oldStar);
        }
        _stars.Add(star);
    }

    private GameObject CreateStar()
    {
        if (_pool.Count > 0)
        {
            var star = _pool[0];
            star.SetActive(true);
            _pool.Remove(star);
            return star;
        }
        else
        {
            return Instantiate(GetStar(), transform);
        }
    }

    private GameObject GetStar()
    {
        foreach (var star in _slots)
        {
            if (star.Level == _level)
            {
                return star.Prefab;
            }
        }
        return _slots[_slots.Length-1].Prefab;
    }

}
