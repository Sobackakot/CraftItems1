using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class MaterialSlot 
{
    [SerializeField] private string _name;
    [SerializeField] private List<Item.ItemId> _item;

    public IReadOnlyList<Item.ItemId> Items => _item;
}
