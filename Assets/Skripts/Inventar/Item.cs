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
        TripWireSource = 41,
        SmoothStone =42,
        Sand =43,
        IronBlock =44,
        Glass =45,
        HalfBlock =46,
        PressurePlate =47,
        TNT = 48,
        RedstoneTorch = 49,
        Compass = 50,
        Gunpowder =51,
        Hopper =52,
        Trolley =53,
        EchoShard = 54,
        Quartz =55,
        Piston =56,
        StickyPiston =57,
        SlimeBall = 58,
        RecoveryCompass =59,
        TrolleyTNT =60,
        TrolleyStove =61,
        TrolleyChest = 62,
        TrolleyHopper =63,
        Anvil = 64,
        DaylightSensor= 65,
        Distributor =66,
        Ejector = 67,
        Observer = 68,
        MeltingFurnace= 69,
        Smokehouse =70,
        Repeater = 71,
        �omparator =72,
        Rail = 73,
        RailGoldenPowered = 74,
        RailDetectorPowered =75,
        �opperIngot= 76,
        TinIngot = 77,
        SulfurDust = 78,
        SilverIngot = 79,
        SilverDust = 80,
        Silica= 81,
        ObsidianDust = 82,
        LeadIngot = 83,
        LeadDust = 84,
        Latex= 85,
        LapisLazuliDust = 86,
        Iridium = 87,
        EnergyDust = 88,
        DiamondDust = 89,
        CoalDust = 90,
        ClayDust=91
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
            case ItemId.TripWireSource: return "Trip Wire Source";
            case ItemId.SmoothStone: return "Smooth Stone";
            case ItemId.Sand: return "Sand";
            case ItemId.IronBlock: return "Iron Block";
            case ItemId.Glass: return "Glass";
            case ItemId.HalfBlock: return "Half Block";
            case ItemId.PressurePlate: return "Pressure Plate";
            case ItemId.TNT: return "TNT";
            case ItemId.RedstoneTorch: return "Redstone Torch";
            case ItemId.Compass: return "Compass";
            case ItemId.Gunpowder: return "Gunpowder";
            case ItemId.Hopper: return "Hopper";
            case ItemId.Trolley: return "Trolley";
            case ItemId.EchoShard: return "Echo Shard";
            case ItemId.Quartz: return "Quartz";
            case ItemId.Piston: return "Piston";
            case ItemId.StickyPiston: return "Sticky Piston";
            case ItemId.SlimeBall: return "Slime Ball";
            case ItemId.RecoveryCompass: return "Recovery Compass";
            case ItemId.TrolleyTNT: return "Trolley TNT";
            case ItemId.TrolleyStove: return "Trolley Stove";
            case ItemId.TrolleyChest: return "Trolley Chest";
            case ItemId.TrolleyHopper: return "Trolley Hopper";
            case ItemId.Anvil: return "Anvil";
            case ItemId.DaylightSensor: return "Daylight Sensor";
            case ItemId.Distributor: return "Distributor";
            case ItemId.Ejector: return "Ejector";
            case ItemId.Observer: return "Observer";
            case ItemId.MeltingFurnace: return "Melting Furnace";
            case ItemId.Smokehouse: return "Smokehouse";
            case ItemId.Repeater: return "Repeater";
            case ItemId.�omparator: return "�omparator";
            case ItemId.Rail: return "Rail";
            case ItemId.RailGoldenPowered: return "Rail Golden Powered";
            case ItemId.RailDetectorPowered: return "Rail Detector Powered";
            case ItemId.�opperIngot: return "�opper Ingot";
            case ItemId.TinIngot: return "Tin Ingot";
            case ItemId.SulfurDust: return "Sulfur Dust";
            case ItemId.SilverIngot: return "Silver Ingot";
            case ItemId.SilverDust: return "Silver Dust";
            case ItemId.Silica: return "Silica";
            case ItemId.ObsidianDust: return "Obsidian Dust";
            case ItemId.LeadIngot: return "Lead Ingot";
            case ItemId.LeadDust: return "Lead Dust";
            case ItemId.Latex: return "Latex";
            case ItemId.LapisLazuliDust: return "Lapis Lazuli Dust";
            case ItemId.Iridium: return "Iridium";
            case ItemId.EnergyDust: return "Energy Dust";
            case ItemId.DiamondDust: return "Diamond Dust";
            case ItemId.CoalDust: return "Coal Dust";
            case ItemId.ClayDust: return "Clay Dust";

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
            case ItemId.SmoothStone: return ItemsSprite.Instance.SmoothStoneSprite;
            case ItemId.Sand: return ItemsSprite.Instance.SandSprite;
            case ItemId.IronBlock: return ItemsSprite.Instance.IronBlockSprite;
            case ItemId.Glass: return ItemsSprite.Instance.GlassSprite;
            case ItemId.HalfBlock: return ItemsSprite.Instance.HalfBlockSprite;
            case ItemId.PressurePlate: return ItemsSprite.Instance.PressurePlateSprite;
            case ItemId.TNT: return ItemsSprite.Instance.TNTSprite;
            case ItemId.RedstoneTorch: return ItemsSprite.Instance.RedstoneTorchSprite;
            case ItemId.Compass: return ItemsSprite.Instance.CompassSprite;
            case ItemId.Gunpowder: return ItemsSprite.Instance.GunpowderSprite;
            case ItemId.Hopper: return ItemsSprite.Instance.HopperSprite;
            case ItemId.Trolley: return ItemsSprite.Instance.TrolleySprite;
            case ItemId.EchoShard: return ItemsSprite.Instance.EchoShardSprite;
            case ItemId.Quartz: return ItemsSprite.Instance.QuartzSprite;
            case ItemId.Piston: return ItemsSprite.Instance.PistonSprite;
            case ItemId.StickyPiston: return ItemsSprite.Instance.StickyPistonSprite;
            case ItemId.SlimeBall: return ItemsSprite.Instance.SlimeBallSprite;
            case ItemId.RecoveryCompass: return ItemsSprite.Instance.RecoveryCompassSprite;
            case ItemId.TrolleyTNT: return ItemsSprite.Instance.TrolleyTNTSprite;
            case ItemId.TrolleyStove: return ItemsSprite.Instance.TrolleyStoveSprite;
            case ItemId.TrolleyChest: return ItemsSprite.Instance.TrolleyChestSprite;
            case ItemId.TrolleyHopper: return ItemsSprite.Instance.TrolleyHopperSprite;
            case ItemId.Anvil: return ItemsSprite.Instance.AnvilSprite;
            case ItemId.DaylightSensor: return ItemsSprite.Instance.DaylightSensorSprite;
            case ItemId.Distributor: return ItemsSprite.Instance.DistributorSprite;
            case ItemId.Ejector:  return ItemsSprite.Instance.EjectorSprite;
            case ItemId.Observer: return ItemsSprite.Instance.ObserverSprite;
            case ItemId.MeltingFurnace: return ItemsSprite.Instance.MeltingFurnaceSprite;
            case ItemId.Smokehouse: return ItemsSprite.Instance.SmokehouseSprite;
            case ItemId.Repeater: return ItemsSprite.Instance.RepeaterSprite;
            case ItemId.�omparator: return ItemsSprite.Instance.�omparatorSprite;
            case ItemId.Rail: return ItemsSprite.Instance.RailSprite;
            case ItemId.RailGoldenPowered: return ItemsSprite.Instance.RailGoldenPoweredSprite;
            case ItemId.RailDetectorPowered: return ItemsSprite.Instance.RailDetectorPoweredSprite;
            case ItemId.�opperIngot: return ItemsSprite.Instance.�opperIngotSprite;
            case ItemId.TinIngot: return ItemsSprite.Instance.TinIngotSprite;
            case ItemId.SulfurDust: return ItemsSprite.Instance.SulfurDustSprite;
            case ItemId.SilverIngot: return ItemsSprite.Instance.SilverIngotSprite;
            case ItemId.SilverDust: return ItemsSprite.Instance.SilverDustSprite;
            case ItemId.Silica: return ItemsSprite.Instance.SilicaSprite;
            case ItemId.ObsidianDust: return ItemsSprite.Instance.ObsidianDustSprite;
            case ItemId.LeadIngot: return ItemsSprite.Instance.LeadIngotSprite;
            case ItemId.LeadDust: return ItemsSprite.Instance.LeadDustSprite;
            case ItemId.Latex: return ItemsSprite.Instance.LatexSprite;
            case ItemId.LapisLazuliDust: return ItemsSprite.Instance.LapisLazuliDustSprite;
            case ItemId.Iridium: return ItemsSprite.Instance.IridiumSprite;
            case ItemId.EnergyDust: return ItemsSprite.Instance.EnergyDustSprite;
            case ItemId.DiamondDust: return ItemsSprite.Instance.DiamondDustSprite;
            case ItemId.CoalDust: return ItemsSprite.Instance.CoalDustSprite;
            case ItemId.ClayDust: return ItemsSprite.Instance.ClayDustSprite;
        }
    }
}
