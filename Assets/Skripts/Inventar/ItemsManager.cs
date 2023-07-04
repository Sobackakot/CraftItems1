using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    public static ItemsManager InstanceItemManager { get; private set; }
    public List<Item> Items;
    public Sprite[] ItemSprites;
    public Sprite[] BlockSprites;
    public Sprite[] ArmorSprites;
    public Sprite[] ToolsSprites;
    public Sprite[] ResourceSprites;
    public Sprite[] MechanismsSprites;
    public Sprite[] AccessoriesSprites;
    private int Wood = 0;
    private int WoodenPlanks= 1;
    private int WoodenStick  = 2;
    private int Coal = 4;
    private int Diamont = 6;
    private int Iron = 22;
    private int Stringi = 27;
    
    public void Awake()
    {
        InstanceItemManager = this;
        RecipeItems();
    } 
    private void RecipeItems()
    {
        Items = new List<Item>(); 
        // wood 0
        Items.Add(new Item("Wood", BlockSprites[0]));
        //Wooden Planks 1
        var woodenPlanksRecipe = new Item[,]
        {
            {Items[Wood]}
        };
        Items.Add(new Item("Wooden Planks", BlockSprites[1], new CraftRecipe(woodenPlanksRecipe, 4)));

        //Wooden Stick 2
        var woodenStickRecipe = new Item[,]
        {
            {Items[WoodenPlanks]},
            {Items[WoodenPlanks]}
        };
        Items.Add(new Item("Wooden Stick", AccessoriesSprites[0], new CraftRecipe(woodenStickRecipe, 4)));
        //CoalOre 3
        Items.Add(new Item("Coal Ore", BlockSprites[4]));
        //Coal 4
        var coalRecipe = new Item[,]
        {
            {Items[3] }
        };
        Items.Add(new Item("Coal", ResourceSprites[0], new CraftRecipe(coalRecipe, 4)));
        //"DiamondOre" 5
        Items.Add(new Item("Diamond Ore", BlockSprites[2]));
        //Diamond 6
        var DiamondRecipe = new Item[,]
        {
            {Items[5]}
        };
        Items.Add(new Item("Diamond", ResourceSprites[1], new CraftRecipe(DiamondRecipe, 4)));
        //GoldOre 7
        Items.Add(new Item("Gold Ore", BlockSprites[3]));
        //Gold 8
        var GoldRecipe = new Item[,]
        {
            {Items[7] }
        };
        Items.Add(new Item("Gold", ResourceSprites[3], new CraftRecipe(GoldRecipe, 4)));
        //RedstoneOre 9
        Items.Add(new Item("Redstone Ore", BlockSprites[5]));
        //Redstone 10
        var redstonRecipe = new Item[,]
        {
            {Items[9] }
        };
        Items.Add(new Item("Redstone", ResourceSprites[4], new CraftRecipe(redstonRecipe, 4)));

        //Torch 11
        var torchRecipe = new Item[,] // does not recognize recipe
        {
            {Items[Coal]},
            {Items[WoodenStick]}, 
        };
        Items.Add(new Item("Torch", ItemSprites[0], new CraftRecipe(torchRecipe, 4)));
        //Diamond Axe 12
        var diamondAxeRecipe = new Item[,]
        {
            {Items[Diamont], Items[Diamont]},
            {Items[Diamont], Items[WoodenStick]},
            {null, Items[WoodenStick]}
        };
        Items.Add(new Item("Diamond Axe", ToolsSprites[2], new CraftRecipe(diamondAxeRecipe, 1)));
        //Diamond pickaxe 13
        var diamondPickaxeRecipe = new Item[,]
        {
            {Items[Diamont], Items[Diamont], Items[Diamont]},
            {null, Items[WoodenStick], null},
            {null, Items[WoodenStick], null}
        };
        Items.Add(new Item("Diamond Pickaxe", ToolsSprites[1], new CraftRecipe(diamondPickaxeRecipe, 1)));
        //Diamond shovel 14
        var diamondShovelRecipe = new Item[,]
        {
            {Items[Diamont]},
            {Items[WoodenStick]},
            {Items[WoodenStick]}
        };
        Items.Add(new Item("Diamond Shovel", ToolsSprites[3], new CraftRecipe(diamondShovelRecipe, 1)));
        //diamond_hoe 15
        var diamondHoeRecipe = new Item[,]
        {
            {Items[Diamont], Items[Diamont]},
            {null, Items[WoodenStick]},
            {null, Items[WoodenStick]}
        };
        Items.Add(new Item("Diamond Hoe", ToolsSprites[4], new CraftRecipe(diamondHoeRecipe, 1)));
        //diamond_sword 16
        var diamondSwordRecipe = new Item[,]
        {
            {Items[Diamont]},
            {Items[Diamont]},
            {Items[WoodenStick]}
        };
        Items.Add(new Item("Diamond Sword", ToolsSprites[0], new CraftRecipe(diamondSwordRecipe, 1)));
        //diamond_helmet 17 
        var diamond_helmetRecipe = new Item[,]
        {
            {Items[Diamont],Items[Diamont],Items[Diamont]},
            {Items[Diamont], null ,Items[Diamont]}

        };
        Items.Add(new Item("Diamond Helmet", ArmorSprites[0], new CraftRecipe(diamond_helmetRecipe, 1)));
        //diamond_chestplate 18
        var diamond_chestplateRecipe = new Item[,]
        {
            {Items[Diamont],null,Items[Diamont]},
            {Items[Diamont], Items[Diamont] ,Items[Diamont]},
            {Items[Diamont],Items[Diamont],Items[Diamont]}


        };
        Items.Add(new Item("Diamond Chestplate", ArmorSprites[1], new CraftRecipe(diamond_chestplateRecipe, 1)));
        //diamond_leggings 19
        var diamond_leggingsRecipe = new Item[,] // does not recognize recipe
        {
            {Items[Diamont],Items[Diamont],Items[Diamont]},
            {Items[Diamont], null ,Items[Diamont]},
            {Items[Diamont],null,Items[Diamont]} 
        };
        Items.Add(new Item("Diamond Leggings", ArmorSprites[2], new CraftRecipe(diamond_leggingsRecipe, 1)));
        //diamond_boots 20
        var diamond_bootsRecipe = new Item[,]
        {
            {Items[Diamont], null ,Items[Diamont]},
            {Items[Diamont],null,Items[Diamont]}
        };
        Items.Add(new Item("Diamond Boots", ArmorSprites[3], new CraftRecipe(diamond_bootsRecipe, 1)));
        //Iron Ore 21
        Items.Add(new Item("Iron Ore", BlockSprites[7]));
        //Iron 22
        var IronRecipe = new Item[,]
        {
            {Items[21] }
        };
        Items.Add(new Item("Iron", ResourceSprites[2], new CraftRecipe(IronRecipe,4)));
        //Iron Bucket 23
        var iron_BucketRecipe = new Item[,]
        {
            {Items[Iron], null ,Items[Iron]},
            {null,Items[Iron],null}
        };
        Items.Add(new Item("Iron Bucket", ItemSprites[1], new CraftRecipe(iron_BucketRecipe, 1)));
        //flint 24
        Items.Add(new Item("Flint", ResourceSprites[5]));
        //feather 25
        Items.Add(new Item("Feather", ItemSprites[3]));
        // Arrow 26
        var arrowRecipe = new Item[,]
        {
            { Items[24]},
            { Items[WoodenStick]},
            {Items[25]}
        };
        Items.Add(new Item("Arrow", ItemSprites[2], new CraftRecipe(arrowRecipe, 4)));
        //string 27
        Items.Add(new Item("String", ItemSprites[4]));
        //bow 28
        var bowRecipe = new Item[,]
        {
            { null,Items[WoodenStick],Items[Stringi ]},
            {Items[WoodenStick],null,Items[Stringi ]},
            {null,Items[WoodenStick],Items[Stringi ]}
        };
        Items.Add(new Item("Bow", ToolsSprites[5], new CraftRecipe(bowRecipe, 1)));
        //fishing_rod 29
        var fishing_rodRecipe = new Item[,] //does not recognize recipe
        {
            { null, null,Items[WoodenStick]},
            { null, Items[WoodenStick],Items[Stringi ]},
            {Items[WoodenStick], null, Items[Stringi ]}
        };
        Items.Add(new Item("Fishing Rod", ToolsSprites[6], new CraftRecipe(fishing_rodRecipe, 1)));
        //shears 30
        var shearsRecipe = new Item[,] //does not recognize recipe
        {
            {Items[WoodenStick],null, Items[Iron]},
            {null,Items[Iron],null},
            {Items[WoodenStick],null, Items[Iron]}
        };
        Items.Add(new Item("Shears", ToolsSprites[7], new CraftRecipe(shearsRecipe, 1)));
        //flint_and_steel 31
        var flint_and_steelRecipe = new Item[,]
        {
            {Items[Iron],Items[24]}
        };
        Items.Add(new Item("Flint and Steel", ToolsSprites[8], new CraftRecipe(flint_and_steelRecipe, 1)));
        //Trip Wire Source 32
        var Trip_Wire_SourceRecipe = new Item[,]
        {
            {Items[Iron]},
            {Items[WoodenStick]},
            {Items[WoodenPlanks]}
        };
        Items.Add(new Item("Trip Wire Source", AccessoriesSprites[1], new CraftRecipe(Trip_Wire_SourceRecipe, 2)));
        //Ñrossbow 33
        var ÑrossbowRecipe = new Item[,]
        {
            {Items[WoodenStick], Items[Iron], Items[WoodenStick]},
            {Items[Stringi], Items[32], Items[Stringi]},
            {null, Items[WoodenStick], null}
        };
        Items.Add(new Item("Ñrossbow", ToolsSprites[9], new CraftRecipe(ÑrossbowRecipe, 1)));
        //Workbench 34
        var WorkbenchRecipe = new Item[,]
        {
            {Items[WoodenPlanks], Items[WoodenPlanks]},
            {Items[WoodenPlanks], Items[WoodenPlanks]}
        };
        Items.Add(new Item("Workbench", MechanismsSprites[0], new CraftRecipe(WorkbenchRecipe, 1)));
        //Wooden Chest 35
        var WoodenChestRecipe = new Item[,]
        {
            {Items[WoodenPlanks],Items[WoodenPlanks],Items[WoodenPlanks]},
            {Items[WoodenPlanks],null,Items[WoodenPlanks]},
            {Items[WoodenPlanks],Items[WoodenPlanks],Items[WoodenPlanks]}
        };
        Items.Add(new Item("Wooden Chest", MechanismsSprites[1], new CraftRecipe(WoodenChestRecipe, 1)));
        //Cobblestone 36
        Items.Add(new Item("Cobblestone", BlockSprites[6]));
        //Stove 37
        var StoveRecipe = new Item[,]
        {
            {Items[36],Items[36],Items[36] },
            {Items[36],null,Items[36] },
            {Items[36],Items[36],Items[36] },
        };
        Items.Add(new Item("Stove", MechanismsSprites[2], new CraftRecipe(StoveRecipe, 1)));
        //Shield 38
        var ShieldRecipe = new Item[,]
        {
            {Items[WoodenPlanks], Items[Iron], Items[WoodenPlanks] },
            {Items[WoodenPlanks], Items[WoodenPlanks], Items[WoodenPlanks] },
            {null, Items[WoodenPlanks],null }
        };
        Items.Add(new Item("Shield", ArmorSprites[4], new CraftRecipe(ShieldRecipe, 1)));
        //Cauldron 39
        var CauldronRecipe = new Item[,]
        {
            {Items[Iron], null, Items[Iron] },
             {Items[Iron], null, Items[Iron] },
              {Items[Iron],Items[Iron], Items[Iron] }

        };
        Items.Add(new Item("Cauldron", ItemSprites[5], new CraftRecipe(CauldronRecipe,1)));
        //Iron Nugget 40
        var IronNuggetRecipe = new Item[,]
        {
            { Items[Iron] }
        };
        Items.Add(new Item("Iron Nugget", ResourceSprites[6], new CraftRecipe(IronNuggetRecipe,9)));
        //Lantern
        var LanternRecipe = new Item[,]
        {
            {Items[40], Items[40], Items[40] },
            {Items[40], Items[11], Items[40] },
            {Items[40], Items[40], Items[40] },
        };
        Items.Add(new Item("Lantern", ItemSprites[6], new CraftRecipe(LanternRecipe, 1)));
    }
}
