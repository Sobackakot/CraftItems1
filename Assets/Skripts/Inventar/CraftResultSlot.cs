using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEditor.Progress;

public class CraftResultSlot : Slot
{ 
    public event System.Action OnCraft; 
    public override void LeftMouseClick()
    {
        if (InventoryWindow.InstanceInventory.HasCurrentItem || !InventoryWindow.InstanceInventory.craftController.HasResultItem)
            return;
        else
            InventoryWindow.InstanceInventory.SetCurrentItem(ItemInSlot);
        ResetItem();
        InventoryWindow.InstanceInventory.craftController.CraftItem();
        InventoryWindow.InstanceInventory.RefreshCurrentItemText();  
        ShowChallenge.InstanceChallenge.ShowNextChalleng();
        if (InventoryWindow.InstanceInventory.craftController.IsQuestCraft)
        {
            OnCraft?.Invoke();
            InventoryWindow.InstanceInventory.craftController.IsQuestCraft = false;
        }
    }

    public override void RightMouseClick()
    {
        if (InventoryWindow.InstanceInventory.HasCurrentItem && !InventoryWindow.InstanceInventory.craftController.HasResultItem)
            return;
        else if (InventoryWindow.InstanceInventory.HasCurrentItem && InventoryWindow.InstanceInventory.CurrentItemInSlot.Item != ItemInSlot.Item)
            return;
        if (!InventoryWindow.InstanceInventory.HasCurrentItem)
        {
            InventoryWindow.InstanceInventory.SetCurrentItem(ItemInSlot);
            ResetItem();
            InventoryWindow.InstanceInventory.craftController.CraftItem();
            InventoryWindow.InstanceInventory.RefreshCurrentItemText(); 
            ShowChallenge.InstanceChallenge.ShowNextChalleng();
            if (InventoryWindow.InstanceInventory.craftController.IsQuestCraft)
            {
                OnCraft?.Invoke();
                InventoryWindow.InstanceInventory.craftController.IsQuestCraft = false;
            }
        }
        else if (maxItemAmount > InventoryWindow.InstanceInventory.CurrentItemInSlot.Amount)
        {
            int totalAmount = InventoryWindow.InstanceInventory.craftController.craftResultSlot.ItemInSlot.Amount + InventoryWindow.InstanceInventory.CurrentItemInSlot.Amount;
            if (totalAmount <= maxItemAmount && InventoryWindow.InstanceInventory.craftController.craftResultSlot.ItemInSlot.Amount >= 1)
            {
                InventoryWindow.InstanceInventory.CurrentItemInSlot.Amount += InventoryWindow.InstanceInventory.craftController.craftResultSlot.ItemInSlot.Amount;
                int currentAmount = InventoryWindow.InstanceInventory.CurrentItemInSlot.Amount;
                InventoryWindow.InstanceInventory.SetCurrentItem(new ItemInSlot(ItemInSlot.Item, currentAmount));
                ResetItem();
                InventoryWindow.InstanceInventory.craftController.CraftItem();
                InventoryWindow.InstanceInventory.RefreshCurrentItemText(); 
            }
            else if (totalAmount > maxItemAmount)
            {
                int excessAmount = totalAmount - maxItemAmount;
                InventoryWindow.InstanceInventory.craftController.craftResultSlot.ItemInSlot.Amount = excessAmount;
                ItemInSlot excessItem = new ItemInSlot(ItemInSlot.Item, maxItemAmount);
                InventoryWindow.InstanceInventory.SetCurrentItem(excessItem);
                SetItem(ItemInSlot);
                InventoryWindow.InstanceInventory.craftController.CraftItem();
                InventoryWindow.InstanceInventory.RefreshCurrentItemText(); 
            }
        }
    }
}

