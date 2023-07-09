using UnityEngine;

[System.Serializable]
public class StarSlot 
{
    [SerializeField] private string _name;
    [SerializeField] private int _level = 10;
    [SerializeField] private GameObject _prefab;

    public int Level => _level;
    public GameObject Prefab => _prefab;
}
