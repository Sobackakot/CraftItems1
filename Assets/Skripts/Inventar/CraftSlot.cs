using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftSlot : Slot
{   
    List<Item.ItemId> items = new List<Item.ItemId>() { Item.ItemId.Hammer, Item.ItemId.WireCutters }; 
    public override void LeftMouseClick()
    {
        base.LeftMouseClick();
        InventoryWindow.InstanceInventory.craftController.CheckCraft();
    }
    public override void RightMouseClick()
    {
        base.RightMouseClick();
        InventoryWindow.InstanceInventory.craftController.CheckCraft();  
    }
    public void DecreaseItemAmount(int amount)
    {
        if (items.Contains(ItemInSlot.Item.itemId))
            return;
        ItemInSlot.Amount -= amount; 
        if(ItemInSlot.Amount < 1)
        ResetItem();
        RefreshUI();
    }
}
