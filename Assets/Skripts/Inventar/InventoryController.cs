using UnityEngine;

public class InventoryController : MonoBehaviour
{ 
    public Slot[,] AdditionalSlots { get; private set; }
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform mainSlotGrid;
    [SerializeField] private Transform additionalSlotGrid;
    private ItemsManager itemsManager;

    private void Awake()
    {
        itemsManager = ItemsManager.InstanceItemManager;
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
        var item = itemsManager.GetItem(itemId);
        slot?.SetItem(new ItemInSlot(item, 64));
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
            }
        }
    }
}
