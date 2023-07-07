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
    private ItemInSlot currentItem { get; set; }
    private int totalAmountItemInSlot { get; set; } 
    public const int maxItemAmount = 64;
    public bool HasItem => ItemInSlot != null;
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
    // system functions!!!
    public void OnPointerClick(PointerEventData eventData) //IPointerClickHandler - listens to the click
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            LeftMouseClick();
        else
            RightMouseClick();
    }
    public void OnPointerEnter(PointerEventData eventData) // IPointerEnterHandler - Show name item in slot and color slot
    {
        image.color = highlightedColor;
        if (HasItem)
            ShowNameObject.InstanceNameObject.ShowItemName(ItemInSlot?.Item.GetNameItemId());
    }
    public void OnPointerExit(PointerEventData eventData) // IPointerExitHandler - Break show name and color slot
    {
        image.color = defaultColor;
        ShowNameObject.InstanceNameObject.OffOnText();
    }
    // external methods!!!
    public virtual void LeftMouseClick() //OnPointerClick
    {
        currentItem = inventory.CurrentItemInSlot;
        if (HasItem)
        {
            if (currentItem == null)
                PickUpItemsInSlot();
            else if (ItemInSlot.Item != currentItem.Item)
                SwapingDifferentItems();
            else SetItemsInSlot();
        }
        else SetAllItemsInSlot();
    }
    public virtual void RightMouseClick() //OnPointerClick
    {
        if (!inventory.HasCurrentItem && HasItem)
        {
            if (ItemInSlot.Amount <= 1) return;
            GetHalfAmount();
        }
        else if (!HasItem || (inventory.CurrentItemInSlot.Item == ItemInSlot.Item && ItemInSlot.Amount < maxItemAmount))
            IncrementItemInSlot();
    }
    public void SetItem(ItemInSlot item) // Turn on item in the slot
    {
        ItemInSlot = item;
        RefreshUI();
    }
    public void ResetItem() // Turn of item in the slot
    {
        ItemInSlot = null;
        RefreshUI();
    }
    public void RefreshUI() // Update the sprite and text of the item
    {
        itemImage.gameObject.SetActive(HasItem);
        itemImage.sprite = ItemInSlot?.Item.GetSpriteItems();
        itemAmount.gameObject.SetActive(HasItem);
        itemAmount.text = ItemInSlot?.Amount.ToString();
    }
    public void AddItem(ItemInSlot Items, int amountCurrentItem) // Ñalculates and transfers items to the slot from the current
    {
        Items.Amount -= amountCurrentItem;
        if (!HasItem)
            SetItem(new ItemInSlot(Items.Item, amountCurrentItem));
        else if (ItemInSlot.Amount < maxItemAmount)
            SumAmountItemsInSlot(Items, amountCurrentItem);
        else 
            SwapingAmountItems(Items, amountCurrentItem);
    }
    // internal methods!!!
    private void SumAmountItemsInSlot(ItemInSlot Items, int amountCurrentItem) // AddItem - The sum of the addition of items from the slot and the current
    {
        totalAmountItemInSlot = ItemInSlot.Amount + amountCurrentItem;
        if (totalAmountItemInSlot > maxItemAmount)
            SetPartAmountItemsCurrent(Items, amountCurrentItem);
        else SetMaxAmountItemsInSlot(Items, amountCurrentItem);
    }
    private void SwapingAmountItems(ItemInSlot Items, int amountCurrentItem) // AddItem - There is an exchange of the number of items in the slot and in the current
    {
        inventory.SetCurrentItem(ItemInSlot);
        SetItem(new ItemInSlot(Items.Item, amountCurrentItem));
        RefreshUI();
    }
    private void SetMaxAmountItemsInSlot(ItemInSlot Items, int amountCurrentItem) //SumOfAddItem- Increment the amount of items in the slot at the expense of the current item
    {
        ItemInSlot.Amount = totalAmountItemInSlot;
        RefreshUI();
    }
    private void SetPartAmountItemsCurrent(ItemInSlot Items, int amountCurrentItem) //SumOfAddItem - Fills the amount of items in the slot from the current item to the maximum
    {
        int excessAmount = totalAmountItemInSlot - maxItemAmount;
        ItemInSlot.Amount = maxItemAmount;
        inventory.SetCurrentItem(new ItemInSlot(Items.Item, excessAmount));
        RefreshUI();
    } 
    private void PickUpItemsInSlot() //LeftMouseClick - Pick up items from the slot in the current one
    {
        inventory.SetCurrentItem(ItemInSlot);
        ResetItem();
    }
    private void SwapingDifferentItems() //LeftMouseClick - Swapping different items between slot and current one
    {
        inventory.SetCurrentItem(ItemInSlot);
        SetItem(currentItem);
    }
    private void SetItemsInSlot() //LeftMouseClick - Returns some of the items in the slot from the current
    {
        AddItem(currentItem, currentItem.Amount);
        inventory.CheckCurrentItem();
        return;
    }
    private void SetAllItemsInSlot() //LeftMouseClick - Returns all items in the slot from the current
    {
        inventory.ResetCurrentItem();
        if (currentItem != null)
        {
            SetItem(currentItem);
        }
    } 
    private void GetHalfAmount() // RightMouseClick - Takes items from the slot exactly half of the amount into the current items
    {
        int amountHalf = Mathf.CeilToInt(ItemInSlot.Amount * 0.5f);
        ItemInSlot.Amount -= amountHalf;
        inventory.SetCurrentItem(new ItemInSlot(ItemInSlot.Item, amountHalf));
        SetItem(ItemInSlot);
    }

    private void IncrementItemInSlot() // RightMouseClick - Adds one and the same item to the slot in 1 click.
    {
        if (inventory.HasCurrentItem)
        AddItem(inventory.CurrentItemInSlot, 1);
        inventory.CheckCurrentItem();
        inventory.RefreshCurrentItemText();
    }
    
}
