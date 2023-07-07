using UnityEngine;

public class CraftRecipe 
{
    public Item.ItemId[,] RecipeItem { get; private set; }
    public  int Amount { get;  set; } 
    public Item.ItemId[] RecipeItemOrder { get; private set; }  
    public CraftRecipe(Item.ItemId[,] itemsId, int amount)
    {
        RecipeItem = itemsId;
        Amount = amount;
        RecipeItemOrder = new Item.ItemId[RecipeItem.Length];
        for (int orderId = 0, i = 0; i < RecipeItem.GetLength(0); i++)
        {
            for(int j = 0; j < RecipeItem.GetLength(1); j++)
            {
                RecipeItemOrder[orderId++]= RecipeItem[i,j];
            }
        }
    }
}   
