using UnityEngine;

public class InventoryUpdater : MonoBehaviour
{
    [SerializeField] private MaterialSlot[] _slot; 
    [SerializeField] private InventoryController _inventory;

    private int _index = 0;

    public void Load(int index)
    {
        _index = index;
        UpdateInvetory(_index);
    }

    public void UpdateItem()
    {
        _index++;
        UpdateInvetory(_index);
    }

    private void UpdateInvetory(int index)
    {
        _inventory.Clear();
        foreach (var item in _slot[index].Items)
        {
            _inventory.AddItem(item);
        }
    }
    public void ResetInvetory()
    {
        UpdateInvetory(_index);
    }
}
