using TMPro; 
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    private Image image;
    private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemAmount;
    private InventoryWindow inventory;

    private Color defaultColor = new Color(140f / 255f, 140f / 255f, 140f / 255f, 1f);
    private Color highlightedColor = new Color(120f / 255f, 120f / 255f, 120f / 255f, 1f);
    public ItemInSlot ItemInSlot { get; private set; }
    public bool HasItem => ItemInSlot != null;
    public const int maxItemAmount = 64;
    public void Awake()
    {
        image = GetComponent<Image>();
        itemImage = transform.GetChild(0).GetComponent<Image>();
        itemAmount = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        itemImage.preserveAspect = true;
        inventory = InventoryWindow.InstanceInventory; 
    }
    public void Update()
    {
        if (HasItem)
        {
            ShowNameObject.InstanceNameObject.showName.transform.position = Input.mousePosition;
        }
    }
    public void AddItem(ItemInSlot Items, int amountCurrentItem)
    {
        Items.Amount -= amountCurrentItem; 
        if (!HasItem)
            SetItem(new ItemInSlot(Items.Item, amountCurrentItem));
        else if(ItemInSlot.Amount < maxItemAmount)
        {
            int totalAmount = ItemInSlot.Amount + amountCurrentItem;
            if (totalAmount <= maxItemAmount)
            {
                ItemInSlot.Amount = totalAmount;
                RefreshUI();
                inventory.CheckCurrentItem();
                Debug.Log(totalAmount);
            }
            else if (totalAmount > maxItemAmount)
            {
                int excessAmount = totalAmount - maxItemAmount;
                ItemInSlot.Amount = maxItemAmount; 
                ItemInSlot excessItem = new ItemInSlot(Items.Item, excessAmount);
                inventory.SetCurrentItem(excessItem);
                RefreshUI();
            }
        }
        else
        { 
            inventory.SetCurrentItem(ItemInSlot);
            ItemInSlot newItemsSpwap = new ItemInSlot(Items.Item, amountCurrentItem);
            SetItem(newItemsSpwap);
            RefreshUI(); 
        }
    } 
    public void SetItem(ItemInSlot item)
    {
        ItemInSlot = item;
        RefreshUI();
    }
    public void ResetItem()       
    {
        ItemInSlot = null;
        RefreshUI();
    }
    public void RefreshUI()
    {
        itemImage.gameObject.SetActive(HasItem);
        itemImage.sprite = ItemInSlot?.Item.Sprite;
        itemAmount.gameObject.SetActive(HasItem && ItemInSlot.Amount > 1);
        itemAmount.text = ItemInSlot?.Amount.ToString();
    } 

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            LeftMouseClick();
        else
            RightMouseClick();
    }
    public virtual void LeftMouseClick()
    {
        var currentItem = inventory.CurrentItemInSlot;
        if (HasItem && ItemInSlot.Amount <= maxItemAmount)
        {
            if (currentItem == null)
            {
                inventory.SetCurrentItem(ItemInSlot);
                ResetItem();
            }
            else if (ItemInSlot.Item != currentItem.Item)
            {
                inventory.SetCurrentItem(ItemInSlot);
                SetItem(currentItem);
            }
            else
            {
                AddItem(currentItem, currentItem.Amount);
                inventory.CheckCurrentItem();
                return;
            }
        }
        else  
        {
            inventory.ResetCurrentItem();
            if (currentItem != null)
            {
                SetItem(currentItem);
            }
        } 
    }
    public virtual void RightMouseClick()
    {
        if (!inventory.HasCurrentItem && HasItem && (ItemInSlot.Amount >= 1))
        {
            if (ItemInSlot.Amount < 1)
                ResetItem();

            if (HasItem && ItemInSlot.Amount >= 2)
            {
                if (ItemInSlot.Amount % 2 == 0)
                {
                    int amountToTransfer = ItemInSlot.Amount / 2;
                    ItemInSlot.Amount -= amountToTransfer;
                    inventory.SetCurrentItem(new ItemInSlot(ItemInSlot.Item, amountToTransfer));
                    SetItem(ItemInSlot);
                    RefreshUI();
                }
                else
                {
                    int amountHalf = Mathf.CeilToInt(ItemInSlot.Amount * 0.5f);
                    ItemInSlot.Amount -= amountHalf;
                    inventory.SetCurrentItem(new ItemInSlot(ItemInSlot.Item, amountHalf));
                    SetItem(ItemInSlot);
                    RefreshUI(); ;
                } 
            }
            inventory.CheckCurrentItem();
            inventory.RefreshCurrentItemText();
        } 
        else if (!inventory.HasCurrentItem) return;  
        else if (!HasItem || (inventory.CurrentItemInSlot.Item == ItemInSlot.Item && ItemInSlot.Amount < maxItemAmount))
        {
            AddItem(inventory.CurrentItemInSlot, 1);
            InventoryWindow.InstanceInventory.CheckCurrentItem();
            inventory.RefreshCurrentItemText();
        }   
    } 
    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = highlightedColor;
        if (HasItem)
        {
            ShowNameObject.InstanceNameObject.ShowItemName(ItemInSlot.Item.Name);
            Debug.Log(ItemInSlot.Item.Name);
        } 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = defaultColor;
        ShowNameObject.InstanceNameObject.OffOnText();
    }
}
