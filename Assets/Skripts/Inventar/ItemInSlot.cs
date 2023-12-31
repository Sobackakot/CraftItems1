using System;
using UnityEngine;

public class ItemInSlot
{
    public Action<Sprite> getSpriteItems;
    public Item Item{ get; private set; }
    public int Amount { get; set; }
    public ItemInSlot(Item item, int amount)
    {
        Item = item;
        Amount = amount;
    }
}
