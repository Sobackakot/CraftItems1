using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class ItemsManager : MonoBehaviour
{
    public static ItemsManager InstanceItemManager { get; private set; }
    public List<Item> Items; 
    
    public void Awake()
    {
        InstanceItemManager = this;
        RecipeItems();
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

        //Torch 11
        var torchRecipe = new Item.ItemId[,] 
        {
            {Item.ItemId.Coal},
            {Item.ItemId.Stick}, 
        };
        Items.Add(new Item(Item.ItemId.Torch, new CraftRecipe(torchRecipe, 1)));
        //Diamond Axe 12
        var diamondAxeRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.Diamond},
            {Item.ItemId.Diamond, Item.ItemId.Stick},
            {Item.ItemId.None, Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondAxe, new CraftRecipe(diamondAxeRecipe, 1)));
        //Diamond pickaxe 13
        var diamondPickaxeRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.Diamond, Item.ItemId.Diamond},
            {Item.ItemId.None, Item.ItemId.Stick, Item.ItemId.None},
            {Item.ItemId.None, Item.ItemId.Stick, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.DiamondPickaxe, new CraftRecipe(diamondPickaxeRecipe, 1)));
        //Diamond shovel 14
        var diamondShovelRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond},
            {Item.ItemId.Stick},
            {Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondShovel, new CraftRecipe(diamondShovelRecipe, 1)));
        //diamond_hoe 15
        var diamondHoeRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.Diamond},
            {Item.ItemId.None, Item.ItemId.Stick},
            {Item.ItemId.None, Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondHoe, new CraftRecipe(diamondHoeRecipe, 1)));
        //diamond_sword 16
        var diamondSwordRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond},
            {Item.ItemId.Diamond},
            {Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.DiamondSword, new CraftRecipe(diamondSwordRecipe, 1)));
        //diamond_helmet 17 
        var diamond_helmetRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond,Item.ItemId.Diamond,Item.ItemId.Diamond},
            {Item.ItemId.Diamond, Item.ItemId.None ,Item.ItemId.Diamond}

        };
        Items.Add(new Item(Item.ItemId.DiamondHelmet, new CraftRecipe(diamond_helmetRecipe, 1)));
        //diamond_chestplate 18
        var diamond_chestplateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond,Item.ItemId.None,Item.ItemId.Diamond},
            {Item.ItemId.Diamond, Item.ItemId.Diamond ,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.Diamond,Item.ItemId.Diamond}


        };
        Items.Add(new Item(Item.ItemId.DiamondChestplate, new CraftRecipe(diamond_chestplateRecipe, 1)));
        //diamond_leggings 19
        var diamond_leggingsRecipe = new Item.ItemId[,] 
        {
            {Item.ItemId.Diamond,Item.ItemId.Diamond,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.None ,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.None,Item.ItemId.Diamond} 
        };
        Items.Add(new Item(Item.ItemId.DiamondLeggings, new CraftRecipe(diamond_leggingsRecipe, 1)));
        //diamond_boots 20
        var diamond_bootsRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.None ,Item.ItemId.Diamond},
            {Item.ItemId.Diamond,Item.ItemId.None,Item.ItemId.Diamond}
        };
        Items.Add(new Item(Item.ItemId.DiamondBoots, new CraftRecipe(diamond_bootsRecipe, 1)));
        //Iron Ore 21
        Items.Add(new Item(Item.ItemId.IronOre));
        //Iron 22
        var IronRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronOre}
        };
        Items.Add(new Item(Item.ItemId.IronIngot, new CraftRecipe(IronRecipe,4)));
        //Iron Bucket 23
        var iron_BucketRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.None ,Item.ItemId.IronIngot},
            {Item.ItemId.None,Item.ItemId.IronIngot,Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.IronBucket, new CraftRecipe(iron_BucketRecipe, 1)));
        //flint 24
        Items.Add(new Item(Item.ItemId.Flint));
        //feather 25
        Items.Add(new Item(Item.ItemId.Feather));
        // Arrow 26
        var arrowRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.Flint},
            {Item.ItemId.Stick},
            {Item.ItemId.Feather}
        };
        Items.Add(new Item(Item.ItemId.Arrow, new CraftRecipe(arrowRecipe, 4)));
        //string 27
        Items.Add(new Item(Item.ItemId.Strings));
        //bow 28
        var bowRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings},
            {Item.ItemId.Stick,Item.ItemId.None,Item.ItemId.Strings},
            {Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings}
        };
        Items.Add(new Item(Item.ItemId.Bow, new CraftRecipe(bowRecipe, 1)));
        //fishing_rod 29
        var fishing_rodRecipe = new Item.ItemId[,] 
        {
            { Item.ItemId.None, Item.ItemId.None,Item.ItemId.Stick},
            { Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings},
            {Item.ItemId.Stick, Item.ItemId.None,Item.ItemId.Strings}
        };
        Items.Add(new Item(Item.ItemId.FishingRod, new CraftRecipe(fishing_rodRecipe, 1)));
        //shears 30
        var shearsRecipe = new Item.ItemId[,] 
        {
            {Item.ItemId.Stick,Item.ItemId.None,Item.ItemId.IronIngot},
            {Item.ItemId.None,Item.ItemId.IronIngot,Item.ItemId.None},
            {Item.ItemId.Stick,Item.ItemId.None, Item.ItemId.IronIngot}
        };
        Items.Add(new Item(Item.ItemId.Shears, new CraftRecipe(shearsRecipe, 1)));
        //flint_and_steel 31
        var flint_and_steelRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot,Item.ItemId.Flint}
        };
        Items.Add(new Item(Item.ItemId.FlintSteel, new CraftRecipe(flint_and_steelRecipe, 1)));
        //Trip Wire Source 32
        var Trip_Wire_SourceRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot},
            {Item.ItemId.Stick},
            {Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.TripWireSource, new CraftRecipe(Trip_Wire_SourceRecipe, 2)));
        //Ñrossbow 33
        var ÑrossbowRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Stick, Item.ItemId.IronIngot, Item.ItemId.Stick},
            {Item.ItemId.Strings, Item.ItemId.TripWireSource, Item.ItemId.Strings },
            {Item.ItemId.None, Item.ItemId.Stick,Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Crossbow, new CraftRecipe(ÑrossbowRecipe, 1)));
        //Workbench 34
        var WorkbenchRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards, Item.ItemId.Boards},
            {Item.ItemId.Boards, Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.Workbench, new CraftRecipe(WorkbenchRecipe, 1)));
        //Wooden Chest 35
        var WoodenChestRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards,Item.ItemId.Boards,Item.ItemId.Boards},
            {Item.ItemId.Boards,Item.ItemId.None,Item.ItemId.Boards},
            {Item.ItemId.Boards,Item.ItemId.Boards,Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.WoodenChest, new CraftRecipe(WoodenChestRecipe, 1)));
        //Cobblestone 36
        Items.Add(new Item(Item.ItemId.Cobblestone));
        //Stove 37
        var StoveRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Cobblestone,Item.ItemId.Cobblestone,Item.ItemId.Cobblestone},
            {Item.ItemId.Cobblestone,Item.ItemId.None ,Item.ItemId.Cobblestone },
            {Item.ItemId.Cobblestone,Item.ItemId.Cobblestone,Item.ItemId.Cobblestone }
        };
        Items.Add(new Item(Item.ItemId.Stove, new CraftRecipe(StoveRecipe, 1)));
        //Shield 38
        var ShieldRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards, Item.ItemId.IronIngot, Item.ItemId.Boards},
            {Item.ItemId.Boards,Item.ItemId.Boards, Item.ItemId.Boards },
            {Item.ItemId.None, Item.ItemId.Boards,Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Shield, new CraftRecipe(ShieldRecipe, 1)));
        //Cauldron 39
        var CauldronRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot },
             {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot},
              {Item.ItemId.IronIngot,Item.ItemId.IronIngot, Item.ItemId.IronIngot }

        };
        Items.Add(new Item(Item.ItemId.Cauldron, new CraftRecipe(CauldronRecipe,1)));
        //Iron Nugget 40
        var IronNuggetRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.IronIngot}
        };
        Items.Add(new Item(Item.ItemId.IronNugget, new CraftRecipe(IronNuggetRecipe,9)));
        //Lantern 41
        var LanternRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronNugget, Item.ItemId.IronNugget, Item.ItemId.IronNugget },
            {Item.ItemId.IronNugget, Item.ItemId.Torch, Item.ItemId.IronNugget },
            {Item.ItemId.IronNugget, Item.ItemId.IronNugget, Item.ItemId.IronNugget }
        };
        Items.Add(new Item(Item.ItemId.Lantern, new CraftRecipe(LanternRecipe, 1)));
        //Iron Block 42
        var IronBlockRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot }, 
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot }
        };
        Items.Add(new Item(Item.ItemId.IronBlock, new CraftRecipe(IronBlockRecipe, 1)));
        //Half Block 43
        var HalfBlockRecipe = new Item.ItemId[,]
        {
            
            {Item.ItemId.Boards, Item.ItemId.Boards, Item.ItemId.Boards }
        };
        Items.Add(new Item(Item.ItemId.HalfBlock, new CraftRecipe(HalfBlockRecipe, 6)));
        //Pressure Plate 44
        var PressurePlateRecipe = new Item.ItemId[,]
        {

            {Item.ItemId.SmoothStone, Item.ItemId.SmoothStone}
        };
        Items.Add(new Item(Item.ItemId.PressurePlate, new CraftRecipe(PressurePlateRecipe, 1)));
        //Glass 45
        var GlassRecipe = new Item.ItemId[,]
        {

            {Item.ItemId.Sand}
        };
        Items.Add(new Item(Item.ItemId.Glass, new CraftRecipe(GlassRecipe, 4)));
        //RedstoneTorch 46
        var RedstoneTorchRecipe = new Item.ItemId[,]
        { 
            {Item.ItemId.Redstone},
            {Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.RedstoneTorch, new CraftRecipe(RedstoneTorchRecipe, 1)));
        //Compass 47
        var CompassRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.IronIngot, Item.ItemId.None },
            {Item.ItemId.IronIngot, Item.ItemId.Redstone, Item.ItemId.IronIngot },
            {Item.ItemId.None, Item.ItemId.IronIngot, Item.ItemId.None }
        };
        Items.Add(new Item(Item.ItemId.Compass, new CraftRecipe(CompassRecipe, 1)));
        //Gunpowder 48
        Items.Add(new Item(Item.ItemId.Gunpowder));
        //TNT 49
        var TNTRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Gunpowder, Item.ItemId.Sand, Item.ItemId.Gunpowder },
            {Item.ItemId.Sand, Item.ItemId.Gunpowder, Item.ItemId.Sand   },
            {Item.ItemId.Gunpowder, Item.ItemId.Sand, Item.ItemId.Gunpowder }
        };
        Items.Add(new Item(Item.ItemId.TNT, new CraftRecipe(TNTRecipe, 1)));
        //Hopper 50 
        var HopperRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.WoodenChest, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot   },
            {Item.ItemId.None, Item.ItemId.IronIngot, Item.ItemId.None }
        };
        Items.Add(new Item(Item.ItemId.Hopper, new CraftRecipe(HopperRecipe, 1)));
        //Trolley 51
        var TrolleyRecipe = new Item.ItemId[,]
       {
            {Item.ItemId.IronIngot, Item.ItemId.None, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot   }
            
       };
        Items.Add(new Item(Item.ItemId.Trolley, new CraftRecipe(TrolleyRecipe, 1)));
        //Smooth Stone 52
        Items.Add(new Item(Item.ItemId.SmoothStone));
        //Sand 53
        Items.Add(new Item(Item.ItemId.Sand));
    }
}

