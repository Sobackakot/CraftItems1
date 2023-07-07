using TMPro; 
using UnityEngine; 
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    public static InventoryWindow InstanceInventory { get; private set; }


    public CraftController craftController;
    public InventoryController inventoryController; 
    public ItemInSlot CurrentItemInSlot; 
    public Image currentItemImage;
    public TextMeshProUGUI currentItemText;
    
    public bool HasCurrentItem => CurrentItemInSlot != null;
    private void Awake()
    {
        InstanceInventory = this;

        inventoryController.Init();
        craftController.Init(); 
    }
    public void OpenInventoryCraftUI()
    {
        gameObject.SetActive(true); 
    }
    public void SetCurrentItem(ItemInSlot itemInSlot)
    {   
        CurrentItemInSlot = itemInSlot;
        currentItemImage.sprite = CurrentItemInSlot?.Item.GetSpriteItems();
        currentItemText.gameObject.SetActive(true);
        RefreshCurrentItemText();
        currentItemImage.gameObject.SetActive(true);
    }
    public void ResetCurrentItem()
    {
        CurrentItemInSlot = null;
        currentItemImage.sprite = null;
        currentItemText.gameObject.SetActive(false); 
        currentItemImage.gameObject.SetActive(false);
    }

    public void RefreshCurrentItemText()
    {
        currentItemText.text = CurrentItemInSlot?.Amount.ToString();
    }
    public void CheckCurrentItem()
    {
        if (CurrentItemInSlot != null && CurrentItemInSlot.Amount < 1)
            ResetCurrentItem();
    }
    
    private void Update()
    {
        if (CurrentItemInSlot == null)
            return;
        currentItemImage.transform.position = Input.mousePosition;
    }
} 
