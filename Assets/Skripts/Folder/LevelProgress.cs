using System.Collections.Generic;
using UnityEngine;

public class LevelProgress : MonoBehaviour
{
    [Header("Refarence")]
    [SerializeField] private GameObject _starPrefab;
    [SerializeField] private Transform _holder;
    [SerializeField] private CraftResultSlot _result;

    private List<GameObject> _stars = new List<GameObject>();
    private List<GameObject> _pool = new List<GameObject>();

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
        _result.OnCraft += AddStar;
    }

    private void OnDisable()
    {
        _result.OnCraft += AddStar;
    }

    public void AddStar()
    {
        _stars.Add(CreateStar());
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
            return Instantiate(_starPrefab, transform);
        }
    }

}
