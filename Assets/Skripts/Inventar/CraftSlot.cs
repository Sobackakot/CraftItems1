using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CraftSlot : Slot
{ 
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
        ItemInSlot.Amount -= amount;
        if(ItemInSlot.Amount < 1)
        ResetItem();
        RefreshUI();
    }
}
