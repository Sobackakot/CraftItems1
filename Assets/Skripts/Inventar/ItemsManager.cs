
using System;
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
    {   //EngineBooster
        //Diamond
        Items = new List<Item>(); 
        // wood 0
        Items.Add(new Item(Item.ItemId.WoodBlock));
        //Wooden Planks 1
        var woodenPlanksRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.WoodBlock}
        };
        Items.Add(new Item(Item.ItemId.Boards,  new CraftRecipe(woodenPlanksRecipe, 4)));
        //Faucet
        var FaucetRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.Boards, Item.ItemId.None},
            {Item.ItemId.Boards, Item.ItemId.Boards, Item.ItemId.Boards},
            {Item.ItemId.Boards, Item.ItemId.None, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Faucet, new CraftRecipe(FaucetRecipe, 1)));
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
        //GoldIngot 8
        var GoldIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GoldOre}
        };
        Items.Add(new Item(Item.ItemId.GoldIngot, new CraftRecipe(GoldIngotRecipe, 4)));
        //GoldPlate
        var GoldPlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GoldIngot,Item.ItemId.Hammer}
        }; 
        Items.Add(new Item(Item.ItemId.GoldPlate, new CraftRecipe(GoldPlateRecipe, 1))); 
        //GoldenShell
        var GoldenShellRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GoldPlate,Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.GoldenShell, new CraftRecipe(GoldenShellRecipe, 2)));
        //GoldenWire
        var GoldenWireRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GoldPlate,Item.ItemId.WireCutters}
        };
        Items.Add(new Item(Item.ItemId.GoldenWire, new CraftRecipe(GoldenWireRecipe, 4)));
        //DoubleInsulatedGoldWire
        var DoubleInsulatedGoldWireRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Rubber,Item.ItemId.Rubber, Item.ItemId.GoldenWire}
        };
        Items.Add(new Item(Item.ItemId.DoubleInsulatedGoldWire, new CraftRecipe(DoubleInsulatedGoldWireRecipe, 1)));
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
        //IronIngot 12
        var IronIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronOre}
        };
        Items.Add(new Item(Item.ItemId.IronIngot, new CraftRecipe(IronIngotRecipe, 4)));
        //IronPlate
        var IronPlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot,Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.IronPlate, new CraftRecipe(IronPlateRecipe, 1)));
        //IronShell
        var IronShellRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronPlate,Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.IronShell, new CraftRecipe(IronShellRecipe, 2)));
        //Iron Block 13
        var IronBlockRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot }
        };
        Items.Add(new Item(Item.ItemId.IronBlock, new CraftRecipe(IronBlockRecipe, 1)));
        // IronBars
        var IronBarsRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot },
            {Item.ItemId.IronIngot, Item.ItemId.IronIngot, Item.ItemId.IronIngot }
        };
        Items.Add(new Item(Item.ItemId.IronBars, new CraftRecipe(IronBarsRecipe, 1)));
        //IronTurningMold
        var IronTurningMoldRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronIngot, Item.ItemId.IronShell, Item.ItemId.IronIngot }
        };
        Items.Add(new Item(Item.ItemId.IronTurningMold, new CraftRecipe(IronTurningMoldRecipe, 1)));
        //Iron Nugget 23
        var IronNuggetRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.IronIngot}
        };
        Items.Add(new Item(Item.ItemId.IronNugget, new CraftRecipe(IronNuggetRecipe, 9)));
        //CoolingCore
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

        //Hammer
        Items.Add(new Item(Item.ItemId.Hammer));
        //WireCutters
        Items.Add(new Item(Item.ItemId.WireCutters));
        //Latex
        Items.Add(new Item(Item.ItemId.Latex));
        //HeatIntensiveReactorPlate
        //Rubber
        var RubberRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Latex}
        };
        Items.Add(new Item(Item.ItemId.Rubber, new CraftRecipe(RubberRecipe, 4)));
        //ClayBlock
        Items.Add(new Item(Item.ItemId.ClayBlock));
        
        //GlowingStone
        Items.Add(new Item(Item.ItemId.GlowingStone));
        //GlowstoneDust
        var GlowstoneDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GlowingStone}
        };
        Items.Add(new Item(Item.ItemId.GlowstoneDust, new CraftRecipe(GlowstoneDustRecipe, 4)));
        //LapisLazuliOre
        Items.Add(new Item(Item.ItemId.LapisLazuliOre));
        
        //Obsidian
        Items.Add(new Item(Item.ItemId.Obsidian));
        //ObsidianDust
        var ObsidianDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Obsidian}
        };
        Items.Add(new Item(Item.ItemId.ObsidianDust, new CraftRecipe(ObsidianDustRecipe, 4)));
        
        //HardenedIronBar
        Items.Add(new Item(Item.ItemId.HardenedIronBar));
        //HardenedIronPlate
        var HardenedIronPlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.HardenedIronBar, Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.HardenedIronPlate, new CraftRecipe(HardenedIronPlateRecipe, 1)));
        //HighVoltageWire
        var HighVoltageWireRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.HardenedIronBar, Item.ItemId.HardenedIronBar,Item.ItemId.HardenedIronBar}
        };
        Items.Add(new Item(Item.ItemId.HighVoltageWire, new CraftRecipe(HighVoltageWireRecipe, 12)));
        //HighVoltageWireInsulated
        var HighVoltageWireInsulatedRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Rubber,Item.ItemId.Rubber,Item.ItemId.HighVoltageWire}
        };
        Items.Add(new Item(Item.ItemId.HighVoltageWireInsulated, new CraftRecipe(HighVoltageWireInsulatedRecipe, 1)));
        //HighVoltageDoubleInsulatedWire
        var HighVoltageDoubleInsulatedWireRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Rubber,Item.ItemId.HighVoltageWireInsulated}
        };
        Items.Add(new Item(Item.ItemId.HighVoltageDoubleInsulatedWire, new CraftRecipe(HighVoltageDoubleInsulatedWireRecipe, 1)));
        //CopperOre
        Items.Add(new Item(Item.ItemId.CopperOre));
        //ÑopperIngot
        var ÑopperIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperOre}
        };
        Items.Add(new Item(Item.ItemId.CopperIngot, new CraftRecipe(ÑopperIngotRecipe, 4)));
        //ÑopperPlate
        var ÑopperPlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperIngot,Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.CopperPlate, new CraftRecipe(ÑopperPlateRecipe, 1)));
        //ÑopperShell
        var ÑopperShellRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperPlate,Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.CopperShell, new CraftRecipe(ÑopperShellRecipe, 2)));
        //ÑopperWire
        var ÑopperWireRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperPlate,Item.ItemId.WireCutters}
        };
        Items.Add(new Item(Item.ItemId.CopperWire, new CraftRecipe(ÑopperWireRecipe, 2)));
        //ÑopperWireIsolated
        var ÑopperWireIsolatedRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Rubber,Item.ItemId.CopperWire}
        };
        Items.Add(new Item(Item.ItemId.CopperWireIsolated, new CraftRecipe(ÑopperWireIsolatedRecipe, 1)));
        //TinOre
        Items.Add(new Item(Item.ItemId.TinOre));
        //TinIngot
        var TinIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TinOre}
        };
        Items.Add(new Item(Item.ItemId.TinIngot, new CraftRecipe(TinIngotRecipe, 4)));
        //TinPlate
        var TinPlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TinIngot, Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.TinPlate, new CraftRecipe(TinPlateRecipe, 1)));
        //TinShell
        var TinShellRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TinPlate, Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.TinShell, new CraftRecipe(TinShellRecipe, 2)));
        //TinDust
        var TinDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TinIngot}
        };
        Items.Add(new Item(Item.ItemId.TinDust, new CraftRecipe(TinDustRecipe, 1)));
        //TinWire
        var TinWireRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TinPlate, Item.ItemId.WireCutters}
        };
        Items.Add(new Item(Item.ItemId.TinWire, new CraftRecipe(TinWireRecipe, 3)));
        //TinWireIsolated
        var TinWireIsolatedRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Rubber, Item.ItemId.TinWire}
        };
        Items.Add(new Item(Item.ItemId.TinWireIsolated, new CraftRecipe(TinWireIsolatedRecipe, 1)));
        //SilverOre
        Items.Add(new Item(Item.ItemId.SilverOre));
        //SilverIngot 
        var SilverIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.SilverOre}
        };
        Items.Add(new Item(Item.ItemId.SilverIngot, new CraftRecipe(SilverIngotRecipe, 4)));
        //SilverDust
        var SilverDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.SilverIngot }
        };
        Items.Add(new Item(Item.ItemId.SilverDust, new CraftRecipe(SilverDustRecipe, 1)));
        //BronzeIngot
        var BronzeIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperIngot,Item.ItemId.CopperIngot},
            {Item.ItemId.CopperIngot,Item.ItemId.TinIngot}
        };
        Items.Add(new Item(Item.ItemId.BronzeIngot, new CraftRecipe(BronzeIngotRecipe, 4)));
        //BronzePlate
        var BronzePlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.BronzeIngot,Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.BronzePlate, new CraftRecipe(BronzePlateRecipe, 1)));
        //BronzeShell
        var BronzeShellRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.BronzePlate,Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.BronzeShell, new CraftRecipe(BronzeShellRecipe, 2)));
        //LeadOre
        Items.Add(new Item(Item.ItemId.LeadOre));
        //LeadIngot
        var LeadIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LeadOre}
        };
        Items.Add(new Item(Item.ItemId.LeadIngot, new CraftRecipe(LeadIngotRecipe, 4)));
        //LeadPlate
        var LeadPlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LeadIngot, Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.LeadPlate, new CraftRecipe(LeadPlateRecipe, 1)));
        //LeadSheath
        var LeadSheathRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LeadPlate, Item.ItemId.Hammer}
        };
        Items.Add(new Item(Item.ItemId.LeadSheath, new CraftRecipe(LeadSheathRecipe, 1)));
        //ThickLeadPlate
        var ThickLeadPlateRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.LeadPlate, Item.ItemId.LeadPlate, Item.ItemId.LeadPlate},
            {Item.ItemId.LeadPlate, Item.ItemId.LeadPlate, Item.ItemId.LeadPlate},
            {Item.ItemId.LeadPlate, Item.ItemId.LeadPlate, Item.ItemId.LeadPlate}
        };
        Items.Add(new Item(Item.ItemId.ThickLeadPlate, new CraftRecipe(ThickLeadPlateRecipe, 1)));
        //LeadDust
        var LeadDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LeadIngot}
        };
        Items.Add(new Item(Item.ItemId.LeadDust, new CraftRecipe(LeadDustRecipe, 1)));
        //ReactorShell
        var ReactorShellRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LeadPlate, Item.ItemId.Composite}
        };
        Items.Add(new Item(Item.ItemId.ReactorShell, new CraftRecipe(ReactorShellRecipe, 1)));
        //SulfurDust
        var SulfurDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Gunpowder }
        };
        Items.Add(new Item(Item.ItemId.SulfurDust, new CraftRecipe(SulfurDustRecipe, 1)));
        //ClayDust
        var ClayDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.ClayBlock }
        };
        Items.Add(new Item(Item.ItemId.ClayDust, new CraftRecipe(ClayDustRecipe, 4)));
        //Silica
        var SilicaRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.ClayDust}
        };
        Items.Add(new Item(Item.ItemId.Silica, new CraftRecipe(SilicaRecipe, 1)));
        //CoalDust
        var CoalDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Coal}
        };
        Items.Add(new Item(Item.ItemId.CoalDust, new CraftRecipe(CoalDustRecipe, 4)));
        //ÑarbonFiber
        var ÑarbonFiberRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.CoalDust, Item.ItemId.CoalDust},
             {Item.ItemId.CoalDust, Item.ItemId.CoalDust} 
        };
        Items.Add(new Item(Item.ItemId.CarbonFiber, new CraftRecipe(ÑarbonFiberRecipe, 1))); 
        //ÑarbonFiberFabric
        var ÑarbonFiberFabricRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.CarbonFiber, Item.ItemId.CarbonFiber} 
        };
        Items.Add(new Item(Item.ItemId.CarbonFiberFabric, new CraftRecipe(ÑarbonFiberFabricRecipe, 1)));
        //CarbonFiberPlastic
        var CarbonFiberPlasticRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.CarbonFiberFabric, Item.ItemId.CarbonFiberFabric}
        };
        Items.Add(new Item(Item.ItemId.CarbonFiberPlastic, new CraftRecipe(CarbonFiberPlasticRecipe, 1)));
        //DiamondDust
        var DiamondDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond}
        };
        Items.Add(new Item(Item.ItemId.DiamondDust, new CraftRecipe(DiamondDustRecipe, 1)));
        //Iridium
        Items.Add(new Item(Item.ItemId.Iridium));
        //ReinforcedIridiumPlate
        var ReinforcedIridiumPlateRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.Iridium, Item.ItemId.Iridium, Item.ItemId.Iridium},
            {Item.ItemId.Composite, Item.ItemId.Diamond, Item.ItemId.Composite},
            {Item.ItemId.Iridium, Item.ItemId.Iridium, Item.ItemId.Iridium}
        };
        Items.Add(new Item(Item.ItemId.ReinforcedIridiumPlate, new CraftRecipe(ReinforcedIridiumPlateRecipe, 1)));
        //LapisLazuli
        var LapisLazuliRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LapisLazuliOre}
        };
        Items.Add(new Item(Item.ItemId.LapisLazuli, new CraftRecipe(LapisLazuliRecipe, 4)));
        //LapisLazuliDust
        var LapisLazuliDustRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LapisLazuli}
        };
        
        Items.Add(new Item(Item.ItemId.LapisLazuliDust, new CraftRecipe(LapisLazuliDustRecipe, 1)));
        //LapisLazuliPlate
        var LapisLazuliPlateRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.LapisLazuli, Item.ItemId.Hammer} 
        };
        Items.Add(new Item(Item.ItemId.LapisLazuliPlate, new CraftRecipe(LapisLazuliPlateRecipe, 1)));
       
        //EnergyDust
        var EnergyDustRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.Redstone, Item.ItemId.DiamondDust, Item.ItemId.Redstone},
            {Item.ItemId.DiamondDust, Item.ItemId.Redstone, Item.ItemId.DiamondDust},
            {Item.ItemId.Redstone, Item.ItemId.DiamondDust, Item.ItemId.Redstone}
        };
        Items.Add(new Item(Item.ItemId.EnergyDust, new CraftRecipe(EnergyDustRecipe, 9)));
        //CompositeIngot
        var CompositeIngotRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronPlate, Item.ItemId.IronPlate, Item.ItemId.IronPlate},
            {Item.ItemId.BronzePlate, Item.ItemId.BronzePlate, Item.ItemId.BronzePlate},
            {Item.ItemId.TinPlate, Item.ItemId.TinPlate, Item.ItemId.TinPlate}
        };
        Items.Add(new Item(Item.ItemId.CompositeIngot, new CraftRecipe(CompositeIngotRecipe, 2)));
        //Composite
        var CompositeRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.CompositeIngot, Item.ItemId.Hammer}
             
        };
        Items.Add(new Item(Item.ItemId.Composite, new CraftRecipe(CompositeRecipe, 1)));
        //FiberglassWire
        var FiberglassWireRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.Glass, Item.ItemId.Glass, Item.ItemId.Glass},
            {Item.ItemId.EnergyDust, Item.ItemId.SilverDust, Item.ItemId.EnergyDust},
            {Item.ItemId.Glass, Item.ItemId.Glass, Item.ItemId.Glass}
        };
        Items.Add(new Item(Item.ItemId.FiberglassWire, new CraftRecipe(FiberglassWireRecipe, 6)));
        //AdvancedBattery
        var AdvancedBatteryRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.CopperWireIsolated, Item.ItemId.BronzeShell, Item.ItemId.CopperWireIsolated},
            {Item.ItemId.BronzeShell, Item.ItemId.SulfurDust, Item.ItemId.BronzeShell},
            {Item.ItemId.BronzeShell, Item.ItemId.LeadDust, Item.ItemId.BronzeShell}
        };
        Items.Add(new Item(Item.ItemId.AdvancedBattery, new CraftRecipe(AdvancedBatteryRecipe, 1)));
        //NotChargedBattery
        var NotChargedBatteryRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.None, Item.ItemId.TinWireIsolated, Item.ItemId.None},
            {Item.ItemId.TinShell, Item.ItemId.Redstone, Item.ItemId.TinShell},
            {Item.ItemId.TinShell, Item.ItemId.Redstone, Item.ItemId.TinShell}
        };
        Items.Add(new Item(Item.ItemId.NotChargedBattery, new CraftRecipe(NotChargedBatteryRecipe, 1)));
        //Coil
        var CoilRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.CopperWire, Item.ItemId.CopperWire, Item.ItemId.CopperWire},
            {Item.ItemId.CopperWire, Item.ItemId.IronIngot, Item.ItemId.CopperWire},
            {Item.ItemId.CopperWire, Item.ItemId.CopperWire, Item.ItemId.CopperWire}
        };
        Items.Add(new Item(Item.ItemId.Coil, new CraftRecipe(CoilRecipe, 1)));
        //ElectricLamp
        var ElectricLampRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.IronShell, Item.ItemId.CopperWireIsolated, Item.ItemId.IronShell},
            {Item.ItemId.Glass, Item.ItemId.TinWire, Item.ItemId.Glass},
            {Item.ItemId.Glass, Item.ItemId.Glass, Item.ItemId.Glass}
        };
        Items.Add(new Item(Item.ItemId.ElectricLamp, new CraftRecipe(ElectricLampRecipe, 8)));
        //EnergyCrystal
        var EnergyCrystalRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.EnergyDust, Item.ItemId.EnergyDust, Item.ItemId.EnergyDust},
            {Item.ItemId.EnergyDust, Item.ItemId.EnergyDust, Item.ItemId.EnergyDust},
            {Item.ItemId.EnergyDust, Item.ItemId.EnergyDust, Item.ItemId.EnergyDust}
        };
        Items.Add(new Item(Item.ItemId.EnergyCrystal, new CraftRecipe(EnergyCrystalRecipe, 1)));
        //FortifiedStone
        var FortifiedStoneRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.SmoothStone, Item.ItemId.SmoothStone, Item.ItemId.SmoothStone},
            {Item.ItemId.SmoothStone, Item.ItemId.Composite, Item.ItemId.SmoothStone},
            {Item.ItemId.SmoothStone, Item.ItemId.SmoothStone, Item.ItemId.SmoothStone}
        };
        Items.Add(new Item(Item.ItemId.FortifiedStone, new CraftRecipe(FortifiedStoneRecipe, 1)));
        //Heat-IntensiveReactorPlate
        var HeatIntensiveReactorPlateRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.CopperPlate, Item.ItemId.CopperPlate, Item.ItemId.CopperPlate},
            {Item.ItemId.CopperPlate, Item.ItemId.ReactorShell, Item.ItemId.CopperPlate},
            {Item.ItemId.CopperPlate, Item.ItemId.CopperPlate, Item.ItemId.CopperPlate}
        };
        Items.Add(new Item(Item.ItemId.HeatIntensiveReactorPlate, new CraftRecipe(HeatIntensiveReactorPlateRecipe, 1)));
        //NeutronReflector
        var NeutronReflectorRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.TinDust, Item.ItemId.CoalDust, Item.ItemId.TinDust},
            {Item.ItemId.CoalDust, Item.ItemId.CopperPlate, Item.ItemId.CoalDust},
            {Item.ItemId.TinDust, Item.ItemId.CoalDust, Item.ItemId.TinDust}
        };
        Items.Add(new Item(Item.ItemId.NeutronReflector, new CraftRecipe(NeutronReflectorRecipe, 1)));
        //RefrigerantCapsule
        var RefrigerantCapsuleRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.None, Item.ItemId.TinPlate, Item.ItemId.None},
            {Item.ItemId.TinPlate, Item.ItemId.LapisLazuliDust, Item.ItemId.TinPlate},
            {Item.ItemId.None, Item.ItemId.TinPlate, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.RefrigerantCapsule, new CraftRecipe(RefrigerantCapsuleRecipe, 1)));
        //ReinforcedGlass
        var ReinforcedGlassRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.Glass, Item.ItemId.Composite, Item.ItemId.Glass},
            {Item.ItemId.Glass, Item.ItemId.Glass, Item.ItemId.Glass},
            {Item.ItemId.Glass, Item.ItemId.Composite, Item.ItemId.Glass}
        };
        Items.Add(new Item(Item.ItemId.ReinforcedGlass, new CraftRecipe(ReinforcedGlassRecipe, 7)));
        //SuperConductorInsulation
        var SuperConductorInsulationRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.Composite, Item.ItemId.ReinforcedIridiumPlate, Item.ItemId.Composite},
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.CarbonFiberPlastic, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.Composite, Item.ItemId.ReinforcedIridiumPlate, Item.ItemId.Composite}
        };
        Items.Add(new Item(Item.ItemId.SuperConductorInsulation, new CraftRecipe(SuperConductorInsulationRecipe, 3)));
        //UnfiredMemoryCrystal
        var UnfiredMemoryCrystalRecipe = new Item.ItemId[,]
        {
             {Item.ItemId.Silica, Item.ItemId.ObsidianDust, Item.ItemId.Silica},
            {Item.ItemId.ObsidianDust, Item.ItemId.Silica, Item.ItemId.ObsidianDust},
            {Item.ItemId.Silica, Item.ItemId.ObsidianDust, Item.ItemId.Silica}
        };
        Items.Add(new Item(Item.ItemId.UnfiredMemoryCrystal, new CraftRecipe(UnfiredMemoryCrystalRecipe, 1)));
        //MemoryCrystal
        var MemoryCrystalRecipe = new Item.ItemId[,]
        { 
            {Item.ItemId.UnfiredMemoryCrystal}
        };
        Items.Add(new Item(Item.ItemId.MemoryCrystal, new CraftRecipe(MemoryCrystalRecipe, 1)));
        //UniversalLiquidCapsule
        var UniversalLiquidCapsuleRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.TinShell, Item.ItemId.None},
            {Item.ItemId.TinShell, Item.ItemId.GlassPanel, Item.ItemId.TinShell},
            {Item.ItemId.None, Item.ItemId.TinShell, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.UniversalLiquidCapsule, new CraftRecipe(UniversalLiquidCapsuleRecipe, 1)));
        //WiringDiagram
        var WiringDiagramRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperWireIsolated, Item.ItemId.CopperWireIsolated, Item.ItemId.CopperWireIsolated},
            {Item.ItemId.Redstone, Item.ItemId.IronPlate, Item.ItemId.Redstone},
            {Item.ItemId.CopperWireIsolated, Item.ItemId.CopperWireIsolated, Item.ItemId.CopperWireIsolated}
        };
        Items.Add(new Item(Item.ItemId.WiringDiagram, new CraftRecipe(WiringDiagramRecipe, 1)));
        //AdvancedWiringDiagram
        var AdvancedWiringDiagramRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Redstone, Item.ItemId.GlowstoneDust, Item.ItemId.Redstone},
            {Item.ItemId.LapisLazuli, Item.ItemId.WiringDiagram, Item.ItemId.LapisLazuli},
            {Item.ItemId.Redstone, Item.ItemId.GlowstoneDust, Item.ItemId.Redstone}
        };
        Items.Add(new Item(Item.ItemId.AdvancedWiringDiagram, new CraftRecipe(AdvancedWiringDiagramRecipe, 1)));
        //AzuretronCrystal
        var AzuretronCrystalRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LapisLazuliDust, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.LapisLazuliDust},
            {Item.ItemId.LapisLazuliDust, Item.ItemId.EnergyCrystal, Item.ItemId.LapisLazuliDust},
            {Item.ItemId.LapisLazuliDust, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.LapisLazuliDust}
        };
        Items.Add(new Item(Item.ItemId.AzuretronCrystal, new CraftRecipe(AzuretronCrystalRecipe, 1)));
        //CoolingRod
        var CoolingRodRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.TinPlate, Item.ItemId.None},
            {Item.ItemId.TinPlate, Item.ItemId.RefrigerantCapsule, Item.ItemId.TinPlate},
            {Item.ItemId.None, Item.ItemId.TinPlate, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.CoolingRod, new CraftRecipe(CoolingRodRecipe, 1)));
        //CoolingRods
        var CoolingRodsRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TinPlate, Item.ItemId.TinPlate, Item.ItemId.TinPlate},
            {Item.ItemId.CoolingRod, Item.ItemId.CoolingRod, Item.ItemId.CoolingRod},
            {Item.ItemId.TinPlate, Item.ItemId.TinPlate, Item.ItemId.TinPlate}
        };
        Items.Add(new Item(Item.ItemId.CoolingRods, new CraftRecipe(CoolingRodsRecipe, 1)));
        //HeatExchanger
        var HeatExchangerRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperPlate, Item.ItemId.WiringDiagram, Item.ItemId.CopperPlate},
            {Item.ItemId.TinPlate, Item.ItemId.CopperPlate, Item.ItemId.TinPlate},
            {Item.ItemId.CopperPlate, Item.ItemId.TinPlate, Item.ItemId.CopperPlate}
        };
        Items.Add(new Item(Item.ItemId.HeatExchanger, new CraftRecipe(HeatExchangerRecipe, 1)));
        //ImprovedHeatExchanger
        var ImprovedHeatExchangerRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.LapisLazuliPlate, Item.ItemId.WiringDiagram, Item.ItemId.LapisLazuliPlate},
            {Item.ItemId.HeatExchanger, Item.ItemId.CopperPlate, Item.ItemId.HeatExchanger},
            {Item.ItemId.LapisLazuliPlate, Item.ItemId.WiringDiagram, Item.ItemId.LapisLazuliPlate}
        };
        Items.Add(new Item(Item.ItemId.ImprovedHeatExchanger, new CraftRecipe(ImprovedHeatExchangerRecipe, 1)));
        //CoolingCore
        var CoolingCoreRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.DoubleCoolingRods, Item.ItemId.ImprovedHeatExchanger, Item.ItemId.DoubleCoolingRods},
            {Item.ItemId.HeatIntensiveReactorPlate, Item.ItemId.ReinforcedIridiumPlate, Item.ItemId.HeatIntensiveReactorPlate},
            {Item.ItemId.DoubleCoolingRods, Item.ItemId.ImprovedHeatExchanger, Item.ItemId.DoubleCoolingRods}
        };
        Items.Add(new Item(Item.ItemId.CoolingCore, new CraftRecipe(CoolingCoreRecipe, 1)));
        //DoubleCoolingRods
        var DoubleCoolingRodsRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TinPlate, Item.ItemId.CoolingRods, Item.ItemId.TinPlate},
            {Item.ItemId.TinPlate, Item.ItemId.IronPlate, Item.ItemId.TinPlate},
            {Item.ItemId.TinPlate, Item.ItemId.CoolingRods, Item.ItemId.TinPlate}
        };
        Items.Add(new Item(Item.ItemId.DoubleCoolingRods, new CraftRecipe(DoubleCoolingRodsRecipe, 1)));
        //ElectricMotor
        var ElectricMotorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.TinShell, Item.ItemId.None},
            {Item.ItemId.Coil, Item.ItemId.IronIngot, Item.ItemId.Coil},
            {Item.ItemId.None, Item.ItemId.TinShell, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.ElectricMotor, new CraftRecipe(ElectricMotorRecipe, 1)));
        //FrequencyBinder
        var FrequencyBinderRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.WiringDiagram, Item.ItemId.CopperWireIsolated}
        };
        Items.Add(new Item(Item.ItemId.FrequencyBinder, new CraftRecipe(FrequencyBinderRecipe, 1)));
        //HeatSink
        var HeatSinkRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronBars, Item.ItemId.IronPlate, Item.ItemId.IronBars},
            {Item.ItemId.IronPlate, Item.ItemId.ElectricMotor, Item.ItemId.IronPlate},
            {Item.ItemId.IronBars, Item.ItemId.IronPlate, Item.ItemId.IronBars}
        };
        Items.Add(new Item(Item.ItemId.HeatSink, new CraftRecipe(HeatSinkRecipe, 1)));
        //ImprovedHeatDissipation
        var ImprovedHeatDissipationRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Diamond, Item.ItemId.HeatSink, Item.ItemId.Diamond},
            {Item.ItemId.IronBars, Item.ItemId.ReactorShell, Item.ItemId.IronBars},
            {Item.ItemId.Diamond, Item.ItemId.HeatSink, Item.ItemId.Diamond}
        };
        Items.Add(new Item(Item.ItemId.ImprovedHeatDissipation, new CraftRecipe(ImprovedHeatDissipationRecipe, 1)));
        //MainMachineBody
        var MainMachineBodyRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronPlate, Item.ItemId.IronPlate, Item.ItemId.IronPlate},
            {Item.ItemId.IronPlate, Item.ItemId.None, Item.ItemId.IronPlate},
            {Item.ItemId.IronPlate, Item.ItemId.IronPlate, Item.ItemId.IronPlate}
        };
        Items.Add(new Item(Item.ItemId.MainMachineBody, new CraftRecipe(MainMachineBodyRecipe, 1)));
        //ImprovedMachineBody
        var ImprovedMachineBodyRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.HardenedIronPlate, Item.ItemId.CarbonFiberPlastic, Item.ItemId.HardenedIronPlate},
            {Item.ItemId.Composite, Item.ItemId.MainMachineBody, Item.ItemId.Composite},
            {Item.ItemId.HardenedIronPlate, Item.ItemId.CarbonFiberPlastic, Item.ItemId.HardenedIronPlate}
        };
        Items.Add(new Item(Item.ItemId.ImprovedMachineBody, new CraftRecipe(ImprovedMachineBodyRecipe, 1)));
        //ThickenedNeutronReflector
        var ThickenedNeutronReflectorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperPlate, Item.ItemId.NeutronReflector, Item.ItemId.CopperPlate},
            {Item.ItemId.NeutronReflector, Item.ItemId.CopperPlate, Item.ItemId.NeutronReflector},
            {Item.ItemId.CopperPlate, Item.ItemId.NeutronReflector, Item.ItemId.CopperPlate}
        };
        Items.Add(new Item(Item.ItemId.ThickenedNeutronReflector, new CraftRecipe(ThickenedNeutronReflectorRecipe, 1)));
        //TeslaCoil
        var TeslaCoilRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Redstone, Item.ItemId.Redstone, Item.ItemId.Redstone},
            {Item.ItemId.Redstone, Item.ItemId.MediumVoltageTransformer, Item.ItemId.Redstone},
            {Item.ItemId.IronShell, Item.ItemId.WiringDiagram, Item.ItemId.IronShell}
        };
        Items.Add(new Item(Item.ItemId.TeslaCoil, new CraftRecipe(TeslaCoilRecipe, 1)));
        //EngineBooster
        var EngineBoosterRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GlowstoneDust, Item.ItemId.Composite, Item.ItemId.GlowstoneDust},
            {Item.ItemId.AdvancedWiringDiagram, Item.ItemId.Accelerator, Item.ItemId.AdvancedWiringDiagram},
            {Item.ItemId.Composite, Item.ItemId.ImprovedHeatDissipation, Item.ItemId.Composite}
        };
        Items.Add(new Item(Item.ItemId.EngineBooster, new CraftRecipe(EngineBoosterRecipe, 1)));
        //Superconductor
        var SuperconductorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.SuperConductorInsulation, Item.ItemId.SuperConductorInsulation, Item.ItemId.SuperConductorInsulation},
            {Item.ItemId.FiberglassWire, Item.ItemId.GoldIngot, Item.ItemId.FiberglassWire},
            {Item.ItemId.SuperConductorInsulation, Item.ItemId.SuperConductorInsulation, Item.ItemId.SuperConductorInsulation}
        };
        Items.Add(new Item(Item.ItemId.Superconductor, new CraftRecipe(SuperconductorRecipe, 3)));
        //GravityEngine
        var GravityEngineRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.TeslaCoil, Item.ItemId.Superconductor, Item.ItemId.TeslaCoil},
            {Item.ItemId.CoolingCore, Item.ItemId.HighVoltageTransformer, Item.ItemId.CoolingCore},
            {Item.ItemId.TeslaCoil, Item.ItemId.Superconductor, Item.ItemId.TeslaCoil}
        };
        Items.Add(new Item(Item.ItemId.GravityEngine, new CraftRecipe(GravityEngineRecipe, 1)));
        //ElectricFurnace
        var ElectricFurnaceRecipe = new Item.ItemId[,]
        { 
            {Item.ItemId.None, Item.ItemId.WiringDiagram, Item.ItemId.None},
            {Item.ItemId.Redstone, Item.ItemId.IronFurnace, Item.ItemId.Redstone}
        };
        Items.Add(new Item(Item.ItemId.ElectricFurnace, new CraftRecipe(ElectricFurnaceRecipe, 1)));
        //EnergyStorage
        var EnergyStorageRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Boards, Item.ItemId.TinWireIsolated, Item.ItemId.Boards},
            {Item.ItemId.NotChargedBattery, Item.ItemId.NotChargedBattery, Item.ItemId.NotChargedBattery},
            {Item.ItemId.Boards, Item.ItemId.Boards, Item.ItemId.Boards}
        };
        Items.Add(new Item(Item.ItemId.EnergyStorage, new CraftRecipe(EnergyStorageRecipe, 1)));
        //Generator
        var GeneratorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.NotChargedBattery, Item.ItemId.None},
            {Item.ItemId.IronPlate, Item.ItemId.IronPlate, Item.ItemId.IronPlate},
            {Item.ItemId.None, Item.ItemId.IronFurnace, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Generator, new CraftRecipe(GeneratorRecipe, 1)));
        //IronFurnace
        var IronFurnaceRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.IronPlate, Item.ItemId.None},
            {Item.ItemId.IronPlate, Item.ItemId.None, Item.ItemId.IronPlate},
            {Item.ItemId.IronPlate, Item.ItemId.Stove, Item.ItemId.IronPlate}
        };
        Items.Add(new Item(Item.ItemId.IronFurnace, new CraftRecipe(IronFurnaceRecipe, 1)));
        //HighVoltageTransformer
        var HighVoltageTransformerRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.DoubleInsulatedGoldWire, Item.ItemId.None},
            {Item.ItemId.WiringDiagram, Item.ItemId.MediumVoltageTransformer, Item.ItemId.AdvancedBattery},
            {Item.ItemId.None, Item.ItemId.DoubleInsulatedGoldWire, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.HighVoltageTransformer, new CraftRecipe(HighVoltageTransformerRecipe, 1)));
        //MediumVoltageTransformer
        var MediumVoltageTransformerRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperWireIsolated},
            {Item.ItemId.MainMachineBody},
            {Item.ItemId.CopperWireIsolated}
        };
        Items.Add(new Item(Item.ItemId.MediumVoltageTransformer, new CraftRecipe(MediumVoltageTransformerRecipe, 1)));
        //MultifunctionalEnergySaver
        var MultifunctionalEnergySaverRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.EnergyCrystal, Item.ItemId.DoubleInsulatedGoldWire, Item.ItemId.EnergyCrystal},
            {Item.ItemId.DoubleInsulatedGoldWire, Item.ItemId.MainMachineBody, Item.ItemId.DoubleInsulatedGoldWire},
            {Item.ItemId.EnergyCrystal, Item.ItemId.DoubleInsulatedGoldWire, Item.ItemId.EnergyCrystal}
        };
        Items.Add(new Item(Item.ItemId.MultifunctionalEnergySaver, new CraftRecipe(MultifunctionalEnergySaverRecipe, 1)));
        //ReactorChamber
        var ReactorChamberRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.ReactorShell, Item.ItemId.LeadPlate, Item.ItemId.ReactorShell},
            {Item.ItemId.LeadPlate, Item.ItemId.MainMachineBody, Item.ItemId.LeadPlate},
            {Item.ItemId.ReactorShell, Item.ItemId.LeadPlate, Item.ItemId.ReactorShell}
        };
        Items.Add(new Item(Item.ItemId.ReactorChamber, new CraftRecipe(ReactorChamberRecipe, 1)));
        //Teleport
        var TeleportRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.AdvancedWiringDiagram, Item.ItemId.FrequencyBinder, Item.ItemId.AdvancedWiringDiagram},
            {Item.ItemId.FiberglassWire, Item.ItemId.ImprovedMachineBody, Item.ItemId.FiberglassWire},
            {Item.ItemId.AdvancedWiringDiagram, Item.ItemId.Diamond, Item.ItemId.AdvancedWiringDiagram}
        };
        Items.Add(new Item(Item.ItemId.Teleport, new CraftRecipe(TeleportRecipe, 1)));
        //MiningLaser
        var MiningLaserRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Redstone, Item.ItemId.Redstone, Item.ItemId.EnergyCrystal},
            {Item.ItemId.Composite, Item.ItemId.Composite, Item.ItemId.AdvancedWiringDiagram},
            {Item.ItemId.None, Item.ItemId.IronTurningMold, Item.ItemId.Composite}
        };
        Items.Add(new Item(Item.ItemId.MiningLaser, new CraftRecipe(MiningLaserRecipe, 1)));
        //ElectricJetpack
        var ElectricJetpackRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronShell, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.IronShell},
            {Item.ItemId.IronShell, Item.ItemId.EnergyStorage, Item.ItemId.IronShell},
            {Item.ItemId.GlowstoneDust, Item.ItemId.None, Item.ItemId.GlowstoneDust}
        };
        Items.Add(new Item(Item.ItemId.ElectricJetpack, new CraftRecipe(ElectricJetpackRecipe, 1)));
        //EnergyPack
        var EnergyPackRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.AdvancedWiringDiagram, Item.ItemId.IronShell, Item.ItemId.AdvancedWiringDiagram},
            {Item.ItemId.EnergyCrystal, Item.ItemId.IronShell, Item.ItemId.EnergyCrystal},
            {Item.ItemId.IronShell, Item.ItemId.None, Item.ItemId.IronShell}
        };
        Items.Add(new Item(Item.ItemId.EnergyPack, new CraftRecipe(EnergyPackRecipe, 1)));
        //ImprovedLappack
        var ImprovedLappackRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.EnergyPack},
            {Item.ItemId.AdvancedWiringDiagram},
            {Item.ItemId.AzuretronCrystal}
        };
        Items.Add(new Item(Item.ItemId.ImprovedLappack, new CraftRecipe(ImprovedLappackRecipe, 1)));
        //NightVisionDevice
        var NightVisionDeviceRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.ImprovedHeatExchanger, Item.ItemId.AdvancedBattery, Item.ItemId.ImprovedHeatExchanger},
            {Item.ItemId.ElectricLamp, Item.ItemId.ReinforcedGlass, Item.ItemId.ElectricLamp},
            {Item.ItemId.Rubber, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.Rubber}
        };
        Items.Add(new Item(Item.ItemId.NightVisionDevice, new CraftRecipe(NightVisionDeviceRecipe, 1)));
        //UltimateLappack
        var UltimateLappackRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.AzuretronCrystal, Item.ItemId.ReinforcedIridiumPlate, Item.ItemId.AzuretronCrystal},
            {Item.ItemId.AzuretronCrystal, Item.ItemId.EnergyPack, Item.ItemId.AzuretronCrystal},
            {Item.ItemId.AzuretronCrystal, Item.ItemId.Superconductor, Item.ItemId.AzuretronCrystal}
        };
        Items.Add(new Item(Item.ItemId.UltimateLappack, new CraftRecipe(UltimateLappackRecipe, 1)));
        //QuantumVest
        var QuantumVestRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Composite, Item.ItemId.NanofiberVest, Item.ItemId.Composite},
            {Item.ItemId.ReinforcedIridiumPlate, Item.ItemId.AzuretronCrystal, Item.ItemId.ReinforcedIridiumPlate},
            {Item.ItemId.ReinforcedIridiumPlate, Item.ItemId.ElectricJetpack, Item.ItemId.ReinforcedIridiumPlate}
        };
        Items.Add(new Item(Item.ItemId.QuantumVest, new CraftRecipe(QuantumVestRecipe, 1)));
        // Accelerator
        var AcceleratorRecipe = new Item.ItemId[,]
        { 
            {Item.ItemId.CoolingRod, Item.ItemId.CoolingRod, Item.ItemId.CoolingRod},
            {Item.ItemId.CopperWireIsolated, Item.ItemId.WiringDiagram, Item.ItemId.CopperWireIsolated}
        };
        Items.Add(new Item(Item.ItemId.Accelerator, new CraftRecipe(AcceleratorRecipe, 2)));
        //TinWires






        //SolarBattery
        var SolarBatteryRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CoalDust, Item.ItemId.Glass, Item.ItemId.CoalDust},
            {Item.ItemId.Glass, Item.ItemId.CoalDust, Item.ItemId.Glass},
            {Item.ItemId.WiringDiagram, Item.ItemId.Generator, Item.ItemId.WiringDiagram}
        };
        Items.Add(new Item(Item.ItemId.SolarBattery, new CraftRecipe(SolarBatteryRecipe, 1)));
        //Compressor
        var CompressorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.SmoothStone, Item.ItemId.None, Item.ItemId.SmoothStone},
            {Item.ItemId.SmoothStone, Item.ItemId.MainMachineBody, Item.ItemId.SmoothStone},
            {Item.ItemId.SmoothStone, Item.ItemId.WiringDiagram, Item.ItemId.SmoothStone}
        };
        Items.Add(new Item(Item.ItemId.Compressor, new CraftRecipe(CompressorRecipe, 1)));
        //Crusher
        var CrusherRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Flint, Item.ItemId.Flint, Item.ItemId.Flint},
            {Item.ItemId.Cobblestone, Item.ItemId.MainMachineBody, Item.ItemId.Cobblestone},
            {Item.ItemId.None, Item.ItemId.WiringDiagram, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.Crusher, new CraftRecipe(CrusherRecipe, 1)));
        //ExtraHighVoltageTransformer
        var ExtraHighVoltageTransformerRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.None, Item.ItemId.HighVoltageDoubleInsulatedWire, Item.ItemId.None},
            {Item.ItemId.AdvancedWiringDiagram, Item.ItemId.HighVoltageTransformer, Item.ItemId.AzuretronCrystal},
            {Item.ItemId.None, Item.ItemId.HighVoltageDoubleInsulatedWire, Item.ItemId.None}
        };
        Items.Add(new Item(Item.ItemId.ExtraHighVoltageTransformer, new CraftRecipe(ExtraHighVoltageTransformerRecipe, 1)));
        //Extractor
        var ExtractorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Faucet, Item.ItemId.MainMachineBody, Item.ItemId.Faucet},
            {Item.ItemId.Faucet, Item.ItemId.WiringDiagram, Item.ItemId.Faucet} 
        };
        Items.Add(new Item(Item.ItemId.Extractor, new CraftRecipe(ExtractorRecipe, 1)));
        //GeothermalGenerator
        var GeothermalGeneratorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Glass, Item.ItemId.UniversalLiquidCapsule, Item.ItemId.Glass},
            {Item.ItemId.Glass, Item.ItemId.UniversalLiquidCapsule, Item.ItemId.Glass},
            {Item.ItemId.IronShell, Item.ItemId.Generator, Item.ItemId.IronShell}
        };
        Items.Add(new Item(Item.ItemId.GeothermalGenerator, new CraftRecipe(GeothermalGeneratorRecipe, 1)));
        //InductionOven
        var InductionOvenRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CopperIngot, Item.ItemId.CopperIngot, Item.ItemId.CopperIngot},
            {Item.ItemId.CopperIngot, Item.ItemId.ElectricFurnace, Item.ItemId.CopperIngot},
            {Item.ItemId.CopperIngot, Item.ItemId.ImprovedMachineBody, Item.ItemId.CopperIngot}
        };
        Items.Add(new Item(Item.ItemId.InductionOven, new CraftRecipe(InductionOvenRecipe, 1)));
        //MatterProducer
        var MatterProducerRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.GlowstoneDust, Item.ItemId.WiringDiagram, Item.ItemId.GlowstoneDust},
            {Item.ItemId.ImprovedMachineBody, Item.ItemId.AzuretronCrystal, Item.ItemId.ImprovedMachineBody},
            {Item.ItemId.GlowstoneDust, Item.ItemId.WiringDiagram, Item.ItemId.GlowstoneDust}
        };
        Items.Add(new Item(Item.ItemId.MatterProducer, new CraftRecipe(MatterProducerRecipe, 1)));
        //MultiFunctionalStorageUnit
        var MultiFunctionalStorageUnitRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.AzuretronCrystal, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.AzuretronCrystal},
            {Item.ItemId.AzuretronCrystal, Item.ItemId.MultifunctionalEnergySaver, Item.ItemId.AzuretronCrystal},
            {Item.ItemId.AzuretronCrystal, Item.ItemId.ImprovedMachineBody, Item.ItemId.AzuretronCrystal}
        };
        Items.Add(new Item(Item.ItemId.MultiFunctionalStorageUnit, new CraftRecipe(MultiFunctionalStorageUnitRecipe, 1)));
        //NuclearBomb
        var NuclearBombRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.ThickenedNeutronReflector, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.ThickenedNeutronReflector},
            {Item.ItemId.ThickenedNeutronReflector, Item.ItemId.ImprovedMachineBody, Item.ItemId.ThickenedNeutronReflector},
            {Item.ItemId.ThickenedNeutronReflector, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.ThickenedNeutronReflector}
        };
        Items.Add(new Item(Item.ItemId.NuclearBomb, new CraftRecipe(NuclearBombRecipe, 1)));
        //NuclearReactor
        var NuclearReactorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.ThickLeadPlate, Item.ItemId.ImprovedMachineBody, Item.ItemId.ThickLeadPlate},
            {Item.ItemId.ReactorChamber, Item.ItemId.ReactorChamber, Item.ItemId.ReactorChamber},
            {Item.ItemId.ThickLeadPlate, Item.ItemId.GeothermalGenerator, Item.ItemId.ThickLeadPlate}
        };
        Items.Add(new Item(Item.ItemId.NuclearReactor, new CraftRecipe(NuclearReactorRecipe, 1)));
        //Replicator
        var ReplicatorRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.FortifiedStone, Item.ItemId.ReinforcedGlass, Item.ItemId.FortifiedStone},
            {Item.ItemId.Teleport, Item.ItemId.Teleport, Item.ItemId.Teleport},
            {Item.ItemId.HighVoltageTransformer, Item.ItemId.MultifunctionalEnergySaver, Item.ItemId.HighVoltageTransformer}
        };
        Items.Add(new Item(Item.ItemId.Replicator, new CraftRecipe(ReplicatorRecipe, 1)));
        //Scanner
        var ScannerRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.IronPlate, Item.ItemId.ReinforcedGlass, Item.ItemId.IronPlate},
            {Item.ItemId.ElectricMotor, Item.ItemId.ElectricLamp, Item.ItemId.ElectricMotor},
            {Item.ItemId.AdvancedWiringDiagram, Item.ItemId.ImprovedMachineBody, Item.ItemId.AdvancedWiringDiagram}
        };
        Items.Add(new Item(Item.ItemId.Scanner, new CraftRecipe(ScannerRecipe, 1)));
        //TemplateGuardian
        var TemplateGuardianRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.FortifiedStone, Item.ItemId.FortifiedStone, Item.ItemId.FortifiedStone},
            {Item.ItemId.MemoryCrystal, Item.ItemId.ImprovedMachineBody, Item.ItemId.MemoryCrystal},
            {Item.ItemId.MiningLaser, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.MiningLaser}
        };
        Items.Add(new Item(Item.ItemId.TemplateGuardian, new CraftRecipe(TemplateGuardianRecipe, 1))); 
        //NanofiberVest
        var NanofiberVestRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.None, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.EnergyCrystal, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.CarbonFiberPlastic, Item.ItemId.CarbonFiberPlastic}
        };
        Items.Add(new Item(Item.ItemId.NanofiberVest, new CraftRecipe(NanofiberVestRecipe, 1)));
        //NanoLeggings
        var NanoLeggingsRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.EnergyCrystal, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.None, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.None, Item.ItemId.CarbonFiberPlastic}
        };
        Items.Add(new Item(Item.ItemId.NanoLeggings, new CraftRecipe(NanoLeggingsRecipe, 1)));
        //NanoHelmet
        var NanoHelmetRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.EnergyCrystal, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.NightVisionDevice, Item.ItemId.CarbonFiberPlastic}
        };
        Items.Add(new Item(Item.ItemId.NanoHelmet, new CraftRecipe(NanoHelmetRecipe, 1)));
        //NanoBoots
        var NanoBootsRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.None, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.EnergyCrystal, Item.ItemId.CarbonFiberPlastic}
        };
        Items.Add(new Item(Item.ItemId.NanoBoots, new CraftRecipe(NanoBootsRecipe, 1)));
        //ImprovedElectricJetpack
        var ImprovedElectricJetpackRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.CarbonFiberPlastic, Item.ItemId.ElectricJetpack, Item.ItemId.CarbonFiberPlastic},
            {Item.ItemId.EngineBooster, Item.ItemId.ImprovedLappack, Item.ItemId.EngineBooster},
            {Item.ItemId.FiberglassWire, Item.ItemId.AdvancedWiringDiagram, Item.ItemId.FiberglassWire}
        };
        Items.Add(new Item(Item.ItemId.ImprovedElectricJetpack, new CraftRecipe(ImprovedElectricJetpackRecipe, 1)));
        //GraviChestPlate
        var GraviChestPlateRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Superconductor, Item.ItemId.QuantumVest, Item.ItemId.Superconductor},
            {Item.ItemId.GravityEngine, Item.ItemId.HighVoltageTransformer, Item.ItemId.GravityEngine},
            {Item.ItemId.Superconductor, Item.ItemId.UltimateLappack, Item.ItemId.Superconductor}
        };
        Items.Add(new Item(Item.ItemId.GraviChestPlate, new CraftRecipe(GraviChestPlateRecipe, 1))); 

        //Reinfor
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
        //GlassPanel
        var GlassPanelRecipe = new Item.ItemId[,]
        { 
            {Item.ItemId.Glass , Item.ItemId.Glass , Item.ItemId.Glass },
            {Item.ItemId.Glass, Item.ItemId.Glass , Item.ItemId.Glass }
        };
        Items.Add(new Item(Item.ItemId.GlassPanel, new CraftRecipe(GlassPanelRecipe, 16)));
        //RedstoneTorch 27
        var RedstoneTorchRecipe = new Item.ItemId[,]
        {
            {Item.ItemId.Redstone},
            {Item.ItemId.Stick}
        };
        Items.Add(new Item(Item.ItemId.RedstoneTorch, new CraftRecipe(RedstoneTorchRecipe, 1)));
        

        //Torch 28
        var TorchRecipe = new Item.ItemId[,] 
        {
            {Item.ItemId.Coal},
            {Item.ItemId.Stick}, 
        };
        Items.Add(new Item(Item.ItemId.Torch, new CraftRecipe(TorchRecipe, 1)));
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
        
        //Bow 40
        var BowRecipe = new Item.ItemId[,]
        {
            { Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings},
            {Item.ItemId.Stick,Item.ItemId.None,Item.ItemId.Strings},
            {Item.ItemId.None,Item.ItemId.Stick,Item.ItemId.Strings}
        };
        Items.Add(new Item(Item.ItemId.Bow, new CraftRecipe(BowRecipe, 1)));
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
       
        //Lantern
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
        Items.Add(new Item(Item.ItemId.Comparator, new CraftRecipe(ÑomparatorRecipe, 1)));
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

