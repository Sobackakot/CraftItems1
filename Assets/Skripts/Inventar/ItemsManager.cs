using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    public static ItemsManager InstanceItemManager { get; private set; }
    public List<Item> Items; 
    
    public void Awake()
    {
        InstanceItemManager = this;
        RecipeItems();
    }

    public Item GetItem(Item.ItemId type)
    {
        foreach (var item in Items)
        {
            if (item.itemId == type)
                return item;
        }
        return null;
    }

    private void RecipeItems()
    {
        Items = new List<Item>(); 
        // wood 0
        Items.Add(new Item(Item.ItemId.WoodBlock));
        //Wooden Planks 1
        var woodenPlanksRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.WoodBlock}
        };
        Items.Add(new Item(Item.ItemId.Boards,  new CraftRecipe(woodenPlanksRecipe, 4)));

        //Wooden Stick 2
        var woodenStickRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards},
            {Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.Stick, new CraftRecipe(woodenStickRecipe, 4)));
        //CoalOre 3
        Items.Add(new Item(Item.ItemId.CoalOre));
        //Coal 4
        var coalRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CoalOre}
        };
        Items.Add(new Item(Item.ItemId.Coal, new CraftRecipe(coalRecipe, 4)));
        //"DiamondOre" 5
        Items.Add(new Item(Item.ItemId.DiamondOre));
        //Diamond 6
        var DiamondRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.DiamondOre}
        };
        Items.Add(new Item(Item.ItemId.Diamond, new CraftRecipe(DiamondRecipe, 4)));
        //GoldOre 7
        Items.Add(new Item(Item.ItemId.GoldOre));
        //Gold 8
        var GoldRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GoldOre}
        };
        Items.Add(new Item(Item.ItemId.GoldIngot, new CraftRecipe(GoldRecipe, 4)));
        //RedstoneOre 9
        Items.Add(new Item(Item.ItemId.RedstoneOre));
        //Redstone 10
        var redstonRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.RedstoneOre }
        };
        Items.Add(new Item(Item.ItemId.Redstone, new CraftRecipe(redstonRecipe, 4))); 
        //Iron Ore 11
        Items.Add(new Item(Item.ItemId.IronOre));
        //Iron 12
        var IronRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronOre}
        };
        Items.Add(new Item(Item.ItemId.IronIngot, new CraftRecipe(IronRecipe, 4)));
        //Iron Block 13
        var IronBlockRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot }
        };
        Items.Add(new Item(Item.ItemId.IronBlock, new CraftRecipe(IronBlockRecipe, 1)));
        //flint 14
        Items.Add(new Item(Item.ItemId.Flint));
        //feather 15
        Items.Add(new Item(Item.ItemId.Feather));
        //string 16
        Items.Add(new Item(Item.ItemId.Strings));
        //Cobblestone 17
        Items.Add(new Item(Item.ItemId.Cobblestone));
        //Smooth Stone 18
        Items.Add(new Item(Item.ItemId.SmoothStone));
        //Sand 19
        Items.Add(new Item(Item.ItemId.Sand));
        //SlimeBall 20
        Items.Add(new Item(Item.ItemId.SlimeBall));
        //EchoShard 21
        Items.Add(new Item(Item.ItemId.EchoShard));
        //Quartz 22
        Items.Add(new Item(Item.ItemId.Quartz));
        //Iron Nugget 23
        var IronNuggetRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.IronIngot}
        };
        Items.Add(new Item(Item.ItemId.IronNugget, new CraftRecipe(IronNuggetRecipe, 9)));
        //Half Block 24
        var HalfBlockRecipe = new Item.ItemId[,]
        {

            {Item.ItemId.Boards, Item.ItemId.Boards, Item.ItemId.Boards }
        };
        Items.Add(new Item(Item.ItemId.HalfBlock, new CraftRecipe(HalfBlockRecipe, 6)));
        //Pressure Plate 25
        var PressurePlateRecipe = new Item.ItemId[,]
        {

            {Item.ItemId.SmoothStone, Item.ItemId.SmoothStone}
        };
        Items.Add(new Item(Item.ItemId.PressurePlate, new CraftRecipe(PressurePlateRecipe, 1)));
        //Glass 26
        var GlassRecipe = new Item.ItemId[,]
        {

            {Item.ItemId.Sand}
        };
        Items.Add(new Item(Item.ItemId.Glass, new CraftRecipe(GlassRecipe, 4)));
        //RedstoneTorch 27
        var RedstoneTorchRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Redstone},
            {Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.RedstoneTorch, new CraftRecipe(RedstoneTorchRecipe, 1)));


        //Torch 28
        var torchRecipe = new Item.ItemId[,] 
        {
            {Item.ItemId.Coal},
            {Item.ItemId.Stick}, 
        };
        Items.Add(new Item(Item.ItemId.Torch, new CraftRecipe(torchRecipe, 1)));
        //Diamond Axe 29
        var diamondAxeRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.Diamond},
            {Item.ItemId.Diamond, Item.ItemId.Stick},
            {Item.ItemId.None, Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondAxe, new CraftRecipe(diamondAxeRecipe, 1)));
        //Diamond pickaxe 30
        var diamondPickaxeRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.Diamond, Item.ItemId.Diamond},
            {Item.ItemId.None, Item.ItemId.Stick, Item.ItemId.None},
            {Item.ItemId.None, Item.ItemId.Stick, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.DiamondPickaxe, new CraftRecipe(diamondPickaxeRecipe, 1)));
        //Diamond shovel 31
        var diamondShovelRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond},
            {Item.ItemId.Stick},
            {Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondShovel, new CraftRecipe(diamondShovelRecipe, 1)));
        //diamond_hoe 32
        var diamondHoeRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.Diamond},
            {Item.ItemId.None, Item.ItemId.Stick},
            {Item.ItemId.None, Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondHoe, new CraftRecipe(diamondHoeRecipe, 1)));
        //diamond_sword 33
        var diamondSwordRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond},
            {Item.ItemId.Diamond},
            {Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondSword, new CraftRecipe(diamondSwordRecipe, 1)));
        //diamond_helmet 34
        var diamond_helmetRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond,Item.ItemId.Diamond,Item.ItemId.Diamond},
            {Item.ItemId.Diamond, Item.ItemId.None ,Item.ItemId.Diamond}

        };
        Items.Add(new Item(Item.ItemId.DiamondHelmet, new CraftRecipe(diamond_helmetRecipe, 1)));
        //diamond_chestplate 35
        var diamond_chestplateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond,Item.ItemId.None,Item.ItemId.Diamond},
            {Item.ItemId.Diamond, Item.ItemId.Diamond ,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.Diamond,Item.ItemId.Diamond} 
        };
        Items.Add(new Item(Item.ItemId.DiamondChestplate, new CraftRecipe(diamond_chestplateRecipe, 1)));
        //diamond_leggings 36
        var diamond_leggingsRecipe = new Item.ItemId[,] 
        {
            {Item.ItemId.Diamond,Item.ItemId.Diamond,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.None ,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.None,Item.ItemId.Diamond} 
        };
        Items.Add(new Item(Item.ItemId.DiamondLeggings, new CraftRecipe(diamond_leggingsRecipe, 1)));
        //diamond_boots 37
        var diamond_bootsRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.None ,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.None,Item.ItemId.Diamond}
        };
        Items.Add(new Item(Item.ItemId.DiamondBoots, new CraftRecipe(diamond_bootsRecipe, 1)));
        
        //Iron Bucket 38
        var iron_BucketRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.None ,Item.ItemId.IronIngot},
            {Item.ItemId.None,Item.ItemId.IronIngot,Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.IronBucket, new CraftRecipe(iron_BucketRecipe, 1)));


        // Arrow 39
        var arrowRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.Flint},
            {Item.ItemId.Stick},
            {Item.ItemId.Feather}
        };
        Items.Add(new Item(Item.ItemId.Arrow, new CraftRecipe(arrowRecipe, 4)));
        
        //bow 40
        var bowRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings},
            {Item.ItemId.Stick,Item.ItemId.None,Item.ItemId.Strings},
            {Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings}
        };
        Items.Add(new Item(Item.ItemId.Bow, new CraftRecipe(bowRecipe, 1)));
        //fishing_rod 41
        var fishing_rodRecipe = new Item.ItemId[,] 
        {
            { Item.ItemId.None, Item.ItemId.None,Item.ItemId.Stick},
            { Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings},
            {Item.ItemId.Stick, Item.ItemId.None,Item.ItemId.Strings}
        };
        Items.Add(new Item(Item.ItemId.FishingRod, new CraftRecipe(fishing_rodRecipe, 1)));
        //shears 42
        var shearsRecipe = new Item.ItemId[,] 
        {
            {Item.ItemId.Stick,Item.ItemId.None,Item.ItemId.IronIngot},
            {Item.ItemId.None,Item.ItemId.IronIngot,Item.ItemId.None},
            {Item.ItemId.Stick,Item.ItemId.None, Item.ItemId.IronIngot}
        };
        Items.Add(new Item(Item.ItemId.Shears, new CraftRecipe(shearsRecipe, 1)));
        //flint_and_steel 43
        var flint_and_steelRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot,Item.ItemId.Flint}
        };
        Items.Add(new Item(Item.ItemId.FlintSteel, new CraftRecipe(flint_and_steelRecipe, 1)));
       
        //Workbench 44
        var WorkbenchRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards, Item.ItemId.Boards},
            {Item.ItemId.Boards, Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.Workbench, new CraftRecipe(WorkbenchRecipe, 1)));
        //Wooden Chest 45
        var WoodenChestRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards,Item.ItemId.Boards,Item.ItemId.Boards},
            {Item.ItemId.Boards,Item.ItemId.None,Item.ItemId.Boards},
            {Item.ItemId.Boards,Item.ItemId.Boards,Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.WoodenChest, new CraftRecipe(WoodenChestRecipe, 1)));
        
        //Stove 46
        var StoveRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Cobblestone,Item.ItemId.Cobblestone,Item.ItemId.Cobblestone},
            {Item.ItemId.Cobblestone,Item.ItemId.None ,Item.ItemId.Cobblestone },
            {Item.ItemId.Cobblestone,Item.ItemId.Cobblestone,Item.ItemId.Cobblestone }
        };
        Items.Add(new Item(Item.ItemId.Stove, new CraftRecipe(StoveRecipe, 1)));
        //Shield 47
        var ShieldRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards, Item.ItemId.IronIngot, Item.ItemId.Boards},
            {Item.ItemId.Boards,Item.ItemId.Boards, Item.ItemId.Boards },
            {Item.ItemId.None, Item.ItemId.Boards,Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Shield, new CraftRecipe(ShieldRecipe, 1)));
        //Cauldron 48
        var CauldronRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot },
             {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot},
              {Item.ItemId.IronIngot,Item.ItemId.IronIngot, Item.ItemId.IronIngot }

        };
        Items.Add(new Item(Item.ItemId.Cauldron, new CraftRecipe(CauldronRecipe,1)));
       
        //Lantern 49
        var LanternRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronNugget, Item.ItemId.IronNugget, Item.ItemId.IronNugget },
            {Item.ItemId.IronNugget, Item.ItemId.Torch, Item.ItemId.IronNugget },
            {Item.ItemId.IronNugget, Item.ItemId.IronNugget, Item.ItemId.IronNugget }
        };
        Items.Add(new Item(Item.ItemId.Lantern, new CraftRecipe(LanternRecipe, 1))); 
        //Compass 50
        var CompassRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.IronIngot, Item.ItemId.None },
            {Item.ItemId.IronIngot, Item.ItemId.Redstone, Item.ItemId.IronIngot },
            {Item.ItemId.None, Item.ItemId.IronIngot, Item.ItemId.None }
        };
        Items.Add(new Item(Item.ItemId.Compass, new CraftRecipe(CompassRecipe, 1)));
        //Gunpowder 51
        Items.Add(new Item(Item.ItemId.Gunpowder));
        //TNT 52
        var TNTRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Gunpowder, Item.ItemId.Sand, Item.ItemId.Gunpowder },
            {Item.ItemId.Sand, Item.ItemId.Gunpowder, Item.ItemId.Sand   },
            {Item.ItemId.Gunpowder, Item.ItemId.Sand, Item.ItemId.Gunpowder }
        };
        Items.Add(new Item(Item.ItemId.TNT, new CraftRecipe(TNTRecipe, 1)));
        //Hopper 53 
        var HopperRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.WoodenChest, Item.ItemId.IronIngot   },
            {Item.ItemId.None, Item.ItemId.IronIngot, Item.ItemId.None }
        };
        Items.Add(new Item(Item.ItemId.Hopper, new CraftRecipe(HopperRecipe, 1)));
        //Trolley 54
        var TrolleyRecipe = new Item.ItemId[,]
       {
            {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot   }
            
       };
        Items.Add(new Item(Item.ItemId.Trolley, new CraftRecipe(TrolleyRecipe, 1)));
        
        //Piston 55
        var PistonRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards, Item.ItemId.Boards, Item.ItemId.Boards },
            {Item.ItemId.Cobblestone, Item.ItemId.IronIngot, Item.ItemId.Cobblestone  },
            {Item.ItemId.Cobblestone, Item.ItemId.Redstone, Item.ItemId.Cobblestone }
        };
        Items.Add(new Item(Item.ItemId.Piston, new CraftRecipe(PistonRecipe, 1)));
        //StickyPiston 56
        var StickyPistonRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.SlimeBall},
            {Item.ItemId.Piston}
        };
        Items.Add(new Item(Item.ItemId.StickyPiston, new CraftRecipe(StickyPistonRecipe, 1)));
         

        //RecoveryCompass 57
        var RecoveryCompassRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.EchoShard, Item.ItemId.EchoShard, Item.ItemId.EchoShard },
            {Item.ItemId.EchoShard, Item.ItemId.Compass, Item.ItemId.EchoShard },
            {Item.ItemId.EchoShard, Item.ItemId.EchoShard, Item.ItemId.EchoShard }
        };
        Items.Add(new Item(Item.ItemId.RecoveryCompass, new CraftRecipe(RecoveryCompassRecipe, 1)));
        //TrolleyTNT 58
        var TrolleyTNTRecipe = new Item.ItemId[,]
        { 
            {Item.ItemId.TNT, Item.ItemId.Trolley }
        };
        Items.Add(new Item(Item.ItemId.TrolleyTNT, new CraftRecipe(TrolleyTNTRecipe, 1)));
        //TrolleyStove 59
        var TrolleyStoveRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Stove, Item.ItemId.Trolley }
        };
        Items.Add(new Item(Item.ItemId.TrolleyStove, new CraftRecipe(TrolleyStoveRecipe, 1)));
        //TrolleyChest 60
        var TrolleyChestRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.WoodenChest, Item.ItemId.Trolley }
        };
        Items.Add(new Item(Item.ItemId.TrolleyChest, new CraftRecipe(TrolleyChestRecipe, 1)));
        //TrolleyHopper 61
        var TrolleyHopperRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Hopper, Item.ItemId.Trolley }
        };
        Items.Add(new Item(Item.ItemId.TrolleyHopper, new CraftRecipe(TrolleyHopperRecipe, 1)));
        //Anvil 62
        var AnvilRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronBlock, Item.ItemId.IronBlock, Item.ItemId.IronBlock },
            {Item.ItemId.None, Item.ItemId.IronIngot, Item.ItemId.None },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot }
        };
        Items.Add(new Item(Item.ItemId.Anvil, new CraftRecipe(AnvilRecipe, 1)));
        //DaylightSensor 63
        var DaylightSensorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Glass, Item.ItemId.Glass, Item.ItemId.Glass },
            {Item.ItemId.Quartz, Item.ItemId.Quartz, Item.ItemId.Quartz },
            {Item.ItemId.HalfBlock, Item.ItemId.HalfBlock, Item.ItemId.HalfBlock }
        };
        Items.Add(new Item(Item.ItemId.DaylightSensor, new CraftRecipe(DaylightSensorRecipe, 1)));
        //Distributor 64
        var DistributorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Cobblestone, Item.ItemId.Cobblestone, Item.ItemId.Cobblestone },
            {Item.ItemId.Cobblestone, Item.ItemId.Bow, Item.ItemId.Cobblestone },
            {Item.ItemId.Cobblestone, Item.ItemId.Redstone, Item.ItemId.Cobblestone}
        };
        Items.Add(new Item(Item.ItemId.Distributor, new CraftRecipe(DistributorRecipe, 1)));
        //Ejector 65
        var EjectorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Cobblestone, Item.ItemId.Cobblestone, Item.ItemId.Cobblestone },
            {Item.ItemId.Cobblestone, Item.ItemId.None, Item.ItemId.Cobblestone },
            {Item.ItemId.Cobblestone, Item.ItemId.Redstone, Item.ItemId.Cobblestone}
        };
        Items.Add(new Item(Item.ItemId.Ejector, new CraftRecipe(EjectorRecipe, 1)));
        //Observer 66
        var ObserverRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Cobblestone, Item.ItemId.Cobblestone, Item.ItemId.Cobblestone },
            {Item.ItemId.Redstone, Item.ItemId.Redstone, Item.ItemId.Quartz },
            {Item.ItemId.Cobblestone, Item.ItemId.Cobblestone, Item.ItemId.Cobblestone}
        };
        Items.Add(new Item(Item.ItemId.Observer, new CraftRecipe(ObserverRecipe, 1)));
        //MeltingFurnace 67
        var MeltingFurnaceRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.Stove, Item.ItemId.IronIngot },
            {Item.ItemId.SmoothStone, Item.ItemId.SmoothStone, Item.ItemId.SmoothStone}
        };
        Items.Add(new Item(Item.ItemId.MeltingFurnace, new CraftRecipe(MeltingFurnaceRecipe, 1)));
        //Smokehouse 68
        var SmokehouseRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.WoodBlock, Item.ItemId.None },
            {Item.ItemId.WoodBlock, Item.ItemId.Stove, Item.ItemId.WoodBlock},
            {Item.ItemId.None, Item.ItemId.WoodBlock, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Smokehouse, new CraftRecipe(SmokehouseRecipe, 1)));
        //Repeater 69
        var RepeaterRecipe = new Item.ItemId[,]
        { 
            {Item.ItemId.RedstoneTorch, Item.ItemId.Redstone, Item.ItemId.RedstoneTorch},
            {Item.ItemId.SmoothStone, Item.ItemId.SmoothStone, Item.ItemId.SmoothStone}
        };
        Items.Add(new Item(Item.ItemId.Repeater, new CraftRecipe(RepeaterRecipe, 1)));
        //Ñomparator 70
        var ÑomparatorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.RedstoneTorch, Item.ItemId.None},
            {Item.ItemId.RedstoneTorch, Item.ItemId.Quartz, Item.ItemId.RedstoneTorch},
            {Item.ItemId.SmoothStone, Item.ItemId.SmoothStone, Item.ItemId.SmoothStone}
        };
        Items.Add(new Item(Item.ItemId.Ñomparator, new CraftRecipe(ÑomparatorRecipe, 1)));
        //Rail 71
        var RailRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.Stick, Item.ItemId.IronIngot},
            {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot}
        };
        Items.Add(new Item(Item.ItemId.Rail, new CraftRecipe(RailRecipe, 1)));
        //Rail Golden Powered 72
        var RailGoldenPoweredRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GoldIngot, Item.ItemId.None, Item.ItemId.GoldIngot },
            {Item.ItemId.GoldIngot, Item.ItemId.Stick, Item.ItemId.GoldIngot},
            {Item.ItemId.GoldIngot, Item.ItemId.Redstone, Item.ItemId.GoldIngot }
        };
        Items.Add(new Item(Item.ItemId.RailGoldenPowered, new CraftRecipe(RailGoldenPoweredRecipe, 1)));
        //RailDetectorPowered 73
        var RailDetectorPoweredRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.PressurePlate, Item.ItemId.IronIngot},
            {Item.ItemId.IronIngot, Item.ItemId.Redstone, Item.ItemId.IronIngot}
        };
        Items.Add(new Item(Item.ItemId.RailDetectorPowered, new CraftRecipe(RailDetectorPoweredRecipe, 1)));
        //Trip Wire Source 74
        var Trip_Wire_SourceRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot},
            {Item.ItemId.Stick},
            {Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.TripWireSource, new CraftRecipe(Trip_Wire_SourceRecipe, 2)));
        //Ñrossbow 75
        var ÑrossbowRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Stick, Item.ItemId.IronIngot, Item.ItemId.Stick},
            {Item.ItemId.Strings, Item.ItemId.TripWireSource, Item.ItemId.Strings },
            {Item.ItemId.None, Item.ItemId.Stick,Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Crossbow, new CraftRecipe(ÑrossbowRecipe, 1)));
    }
}

