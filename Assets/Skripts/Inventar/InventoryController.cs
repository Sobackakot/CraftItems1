using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public Slot[,] MainSlots { get; private set; }
    public  Slot[,] AdditionalSlots { get; private set; }
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
    private void InitTestInventory()
    {
        MainSlots = new Slot[1,9];  
        AdditionalSlots = new Slot[3,9];
        CreateSlotsPrefabs();
        MainSlots[0, 0].SetItem(new ItemInSlot(itemsManager.Items[0], 64)); 
        MainSlots[0, 1].SetItem(new ItemInSlot(itemsManager.Items[3], 63)); 
        MainSlots[0, 2].SetItem(new ItemInSlot(itemsManager.Items[5], 62)); 
        MainSlots[0, 3].SetItem(new ItemInSlot(itemsManager.Items[7], 61)); 
        MainSlots[0, 4].SetItem(new ItemInSlot(itemsManager.Items[11], 60));
        MainSlots[0, 5].SetItem(new ItemInSlot(itemsManager.Items[14], 59));
        MainSlots[0, 6].SetItem(new ItemInSlot(itemsManager.Items[16], 61));
        MainSlots[0, 7].SetItem(new ItemInSlot(itemsManager.Items[17], 60));
        MainSlots[0, 8].SetItem(new ItemInSlot(itemsManager.Items[15], 59));
    }
    private void CreateSlotsPrefabs()
    {
        for(int i =0; i < MainSlots.GetLength(1); i++)
        {
            var slot = Instantiate(slotPrefab, mainSlotGrid, false);
            MainSlots[0,i] = slot.AddComponent<Slot>();
        }
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
