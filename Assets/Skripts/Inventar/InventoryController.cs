using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{ 
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform additionalSlotGrid; 
    private ItemsManager itemsManager;
    private List<Slot> _slots = new List<Slot>();
    
    public Slot[,] AdditionalSlots { get; private set; }

    private void Awake()
    {
        itemsManager = ItemsManager.InstanceItemManager;
    }

    public string Save()
    {
        var data = new InvetoryData();
        data.SlotId = new SlotData [_slots.Count];
        for (int i = 0; i < _slots.Count; i++)
        {
            if (_slots[i].ItemInSlot != null)
            {
                data.SlotId[i] = new SlotData();
                data.SlotId[i].Item = _slots[i].ItemInSlot.Item.itemId;
                data.SlotId[i].Amount = _slots[i].ItemInSlot.Amount;
            }
            else
            {
                data.SlotId[i] = null;
            }
        }
        return JsonUtility.ToJson(data);
    }

    public void Load(InvetoryData invetoryData)
    {
        for (int i = 0; i < _slots.Count; i++)
        {
            if (invetoryData.SlotId[i].Item != Item.ItemId.None)
            {
                SetItem(invetoryData.SlotId[i].Item, _slots[i], invetoryData.SlotId[i].Amount);
            }
            else
            {
                _slots[i].ResetItem();
            }
        }
    }

    public void Init()
    {
        InitTestInventory();
    }

    public void Clear()
    {
        foreach (var item in AdditionalSlots)
        {
            item.ResetItem();
        }
    }

    public void AddItem(Item.ItemId itemId)
    {
        var slot = GetSlot();
        SetItem(itemId, slot);
    }

    private void SetItem(Item.ItemId itemid, Slot slot, int count = 64)
    {   
        var item = itemsManager.GetItem(itemid);
        if (Item.ItemId.Hammer == itemid || Item.ItemId.WireCutters == itemid)
            slot?.SetItem(new ItemInSlot(item, 1));
        else
            slot?.SetItem(new ItemInSlot(item, count));
    }

    private Slot GetSlot()
    {
        for (int i = AdditionalSlots.GetLength(0)-1; i > 0; i--)
        {
            for (int j = AdditionalSlots.GetLength(1)-1; j > 0; j--)
            {
                if (!AdditionalSlots[i,j].HasItem) return AdditionalSlots[i, j];
            }
        }
        return null; 
    }

    private void InitTestInventory()
    {  
        AdditionalSlots = new Slot[9,9];
        CreateSlotsPrefabs(); 
    }
    private void CreateSlotsPrefabs()
    { 
        for(int i = 0; i <AdditionalSlots.GetLength(0); i++)
        {
            for(int j = 0; j <AdditionalSlots.GetLength(1); j++)
            {
                var slot = Instantiate(slotPrefab, additionalSlotGrid, false);
                AdditionalSlots[i,j] = slot.AddComponent<Slot>();
                _slots.Add(AdditionalSlots[i, j]);
            }
        }
    }
}
