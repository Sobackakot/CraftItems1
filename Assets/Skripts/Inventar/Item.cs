using System.Security.Cryptography;
using UnityEngine; 

public class Item 
{ 
    public ItemId itemId { get; set; }  
    public int Amount { get; set; }

    public CraftRecipe Recipe;
    public bool HasRecipe => Recipe != null;
    public Item(ItemId itemId, CraftRecipe craft = null, int amount = 0)
    {
        this.itemId = itemId;
        Recipe = craft;
        Amount = amount;
    }
    public enum ItemId
    {    
        None,
        Torch = 0, 
        IronBucket = 1, 
        Arrow = 2, 
        Feather = 3, 
        Strings = 4, 
        Cauldron = 5, 
        Lantern = 6,  
        WoodBlock = 7, 
        Boards = 8, 
        DiamondOre = 9, 
        GoldOre = 10, 
        CoalOre = 11, 
        RedstoneOre = 12, 
        Cobblestone = 13, 
        IronOre = 14, 
        DiamondHelmet = 15, 
        DiamondChestplate = 16, 
        DiamondLeggings = 17, 
        DiamondBoots = 18, 
        Shield = 19, 
        DiamondSword = 20, 
        DiamondPickaxe = 21, 
        DiamondAxe = 22, 
        DiamondShovel = 23, 
        DiamondHoe = 24, 
        Bow = 25, 
        FishingRod = 26, 
        Shears = 27, 
        FlintSteel = 28, 
        Crossbow = 29, 
        Coal = 30, 
        Diamond = 31, 
        IronIngot = 32, 
        GoldIngot = 33, 
        Redstone = 34, 
        Flint = 35, 
        IronNugget = 36, 
        Workbench = 37, 
        WoodenChest = 38, 
        Stove = 39, 
        Stick = 40, 
        TripWireSource = 41 
    }
    public string GetNameItemId()
    {     
        switch (itemId)
        {
            case ItemId.Torch: return "Torch";
            case ItemId.IronBucket: return "Iron Bucket";
            case ItemId.Arrow: return "Arrow";
            case ItemId.Feather: return "Feather";
            case ItemId.Strings: return "Strings";
            case ItemId.Cauldron: return "Cauldron";
            case ItemId.Lantern: return "Lantern";
            case ItemId.WoodBlock: return "Wood Block";
            case ItemId.Boards: return "Boards";
            case ItemId.DiamondOre: return "Diamond Ore";
            case ItemId.GoldOre: return "Gold Ore";
            case ItemId.CoalOre: return "Coal Ore";
            case ItemId.RedstoneOre: return "Redstone Ore";
            case ItemId.Cobblestone: return "Cobblestone";
            case ItemId.IronOre: return "Iron Ore";
            case ItemId.DiamondHelmet: return "Diamond Helmet";
            case ItemId.DiamondChestplate: return "Diamond Chestplate";
            case ItemId.DiamondLeggings: return "Diamond Leggings";
            case ItemId.DiamondBoots: return "Diamond Boots";
            case ItemId.Shield: return "Shield";
            case ItemId.DiamondSword: return "Diamond Sword";
            case ItemId.DiamondPickaxe: return "Diamond Pickaxe";
            case ItemId.DiamondAxe: return "Diamond Axe";
            case ItemId.DiamondShovel: return "Diamond Shovel";
            case ItemId.DiamondHoe: return "Diamond Hoe";
            case ItemId.Bow: return "Bow";
            case ItemId.FishingRod: return "Fishing Rod";
            case ItemId.Shears: return "Shears";
            case ItemId.FlintSteel: return "Flint and Steel";
            case ItemId.Crossbow: return "Crossbow";
            case ItemId.Coal: return "Coal";
            case ItemId.Diamond: return "Diamond";
            case ItemId.IronIngot: return "Iron Ingot";
            case ItemId.GoldIngot: return "Gold Ingot";
            case ItemId.Redstone: return "Redstone";
            case ItemId.Flint: return "Flint";
            case ItemId.IronNugget: return "Iron Nugget";
            case ItemId.Workbench: return "Workbench";
            case ItemId.WoodenChest: return "Wooden Chest";
            case ItemId.Stove: return "Stove";
            case ItemId.Stick: return "Stick";
            case ItemId.TripWireSource: return "Tripwire Wire Source";

            default:
                return "Unknown Item";
        }
    }
    public Sprite GetSpriteItems() 
    {
       return GetSpriteItems(itemId);
    }
    public static  Sprite GetSpriteItems(Item.ItemId itemId)
    {
        switch(itemId) {
            default:
            case ItemId.Torch: return ItemsSprite.Instance.TorchSprite;
            case ItemId.IronBucket: return ItemsSprite.Instance.IronBucketSprite;
            case ItemId.Arrow: return ItemsSprite.Instance.ArrowSprite;
            case ItemId.Feather: return ItemsSprite.Instance.FeatherSprite;
            case ItemId.Strings: return ItemsSprite.Instance.StringsSprite;
            case ItemId.Cauldron: return ItemsSprite.Instance.CauldronSprite;
            case ItemId.Lantern: return ItemsSprite.Instance.LanternSprite;
            case ItemId.WoodBlock: return ItemsSprite.Instance.WoodBlockSprite;
            case ItemId.Boards: return ItemsSprite.Instance.BoardsSprite;
            case ItemId.DiamondOre: return ItemsSprite.Instance.DiamondOreSprite;
            case ItemId.GoldOre: return ItemsSprite.Instance.GoldOreSprite;
            case ItemId.CoalOre: return ItemsSprite.Instance.CoalOreSprite;
            case ItemId.RedstoneOre: return ItemsSprite.Instance.RedstoneOreSprite;
            case ItemId.Cobblestone: return ItemsSprite.Instance.CobblestoneSprite;
            case ItemId.IronOre: return ItemsSprite.Instance.IronOreSprite;
            case ItemId.DiamondHelmet: return ItemsSprite.Instance.DiamondHelmetSprite;
            case ItemId.DiamondChestplate: return ItemsSprite.Instance.DiamondChestplateSprite;
            case ItemId.DiamondLeggings: return ItemsSprite.Instance.DiamondLeggingsSprite;
            case ItemId.DiamondBoots: return ItemsSprite.Instance.DiamondBootsSprite;
            case ItemId.Shield: return ItemsSprite.Instance.ShieldSprite; 
            case ItemId.DiamondSword: return ItemsSprite.Instance.DiamondSwordSprite;
            case ItemId.DiamondPickaxe: return ItemsSprite.Instance.DiamondPickaxeSprite;
            case ItemId.DiamondAxe: return ItemsSprite.Instance.DiamondAxeSprite;
            case ItemId.DiamondShovel: return ItemsSprite.Instance.DiamondShovelSprite;
            case ItemId.DiamondHoe: return ItemsSprite.Instance.DiamondHoeSprite;
            case ItemId.Bow: return ItemsSprite.Instance.BowSprite;
            case ItemId.FishingRod: return ItemsSprite.Instance.FishingRodSprite;
            case ItemId.Shears: return ItemsSprite.Instance.ShearsSprite;
            case ItemId.FlintSteel: return ItemsSprite.Instance.FlintSteelSprite;
            case ItemId.Crossbow: return ItemsSprite.Instance.CrossbowSprite;
            case ItemId.Coal: return ItemsSprite.Instance.CoalSprite;
            case ItemId.Diamond: return ItemsSprite.Instance.DiamondSprite;
            case ItemId.IronIngot: return ItemsSprite.Instance.IronIngotSprite;
            case ItemId.GoldIngot: return ItemsSprite.Instance.GoldIngotSprite;
            case ItemId.Redstone: return ItemsSprite.Instance.RedstoneSprite;
            case ItemId.Flint: return ItemsSprite.Instance.FlintSprite;
            case ItemId.IronNugget: return ItemsSprite.Instance.IronNuggetSprite;
            case ItemId.Workbench: return ItemsSprite.Instance.WorkbenchSprite;
            case ItemId.WoodenChest: return ItemsSprite.Instance.WoodenChestSprite;
            case ItemId.Stove: return ItemsSprite.Instance.StoveSprite;
            case ItemId.Stick: return ItemsSprite.Instance.StickSprite;
            case ItemId.TripWireSource: return ItemsSprite.Instance.TripWireSourceSprite; 
        }
    }
}
