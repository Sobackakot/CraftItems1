using UnityEngine; 

public class CraftResultSlot : Slot
{   
    public event System.Action OnCraft;
    private  InventoryWindow inventoryWindow;
    private ShowChallenge challenge; 
    bool HasCurrentItems { get; set; }
    bool HasResultItems { get; set; }    
    int CurrentItemAmount { get; set; }
    int ItemInSlotAmount {get; set; }
    int totalAmount { get; set; }
    int excessAmount { get; set; }
    public void Start()
    {
        inventoryWindow = InventoryWindow.InstanceInventory;
        challenge = ShowChallenge.InstanceChallenge;
    }
    public void Clear()
    {
        if (HasItem)
            ResetItem();
    }
    public override void LeftMouseClick() //Takes items from the result slot completely at a time
    {
        GetAmountHasItem();
        if (inventoryWindow.HasCurrentItem || !HasResultItems) return;
        else SetAmountCurrentItem(ItemInSlot);
        SetNewStar();
    }

    public override void RightMouseClick() //Takes items from the result slot one at a time
    {
        GetAmountHasItem();
        if (HasCurrentItems && !inventoryWindow.craftController.HasResultItem)
            return;
        else if (HasCurrentItems && (inventoryWindow.CurrentItemInSlot.Item != ItemInSlot.Item))
            return;
        if (!HasCurrentItems)
        {
            SetAmountCurrentItem(ItemInSlot);
            SetNewStar(); 
        } 
        else if (maxItemAmount > CurrentItemAmount && HasCurrentItems)
        {
             IncrementAmountCurrentItem();
             SetMaxAmountCurrentItem();
        }
    }
    
    // internal methods!!!
    private void SetNewStar() // RightMouseClick, LeftMouseClick()
    {
        if (inventoryWindow.craftController.IsQuestCraft)
        {
            OnCraft?.Invoke();
            inventoryWindow.craftController.IsQuestCraft = false;
        }
    }
    //Increase the number of items one by one for each mouse click on an item
    //from the ready items slot to the current item, until the maximum number of current items is reached.
    private void IncrementAmountCurrentItem() //RightMouseClick
    {
        totalAmount = ItemInSlotAmount + CurrentItemAmount;
        if (totalAmount <= maxItemAmount && ItemInSlotAmount >= 1)
        {
            CurrentItemAmount += ItemInSlotAmount;
            SetAmountCurrentItem(new ItemInSlot(ItemInSlot.Item, CurrentItemAmount));
            return;
        }
    }

    //So that there is no overflow of the current stack,
    //the overflow difference is calculated and this value is assigned back to the slot,
    //and the current stack receives the maximum value.
    private void SetMaxAmountCurrentItem() //RightMouseClick
    {   
        if(totalAmount > maxItemAmount)
        {
            excessAmount = totalAmount - maxItemAmount;
            inventoryWindow.craftController.craftResultSlot.ItemInSlot.Amount = excessAmount;
            SetItem(ItemInSlot);
            SetAmountCurrentItem(new ItemInSlot(ItemInSlot.Item, maxItemAmount));
            return;
        } 
    }
    private void SetAmountCurrentItem(ItemInSlot itemInSlot) //RightMouseClick, LeftMouseClick
    {
        inventoryWindow.SetCurrentItem(itemInSlot);
        ResetItem();
        inventoryWindow.craftController.CraftItem();
        inventoryWindow.RefreshCurrentItemText();
        challenge.ShowNextChalleng();
    }
    private void GetAmountHasItem() //RightMouseClick ,LeftMouseClick
    {
        HasCurrentItems = inventoryWindow.HasCurrentItem;
        HasResultItems = inventoryWindow.craftController.HasResultItem;
        CurrentItemAmount = inventoryWindow.CurrentItemInSlot?.Amount ?? 0;
        ItemInSlotAmount = inventoryWindow.craftController.craftResultSlot.ItemInSlot?.Amount ?? 0;
    }
}

