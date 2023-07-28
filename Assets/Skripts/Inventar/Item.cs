
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
        Comparator =72,
        Rail = 73,
        RailGoldenPowered = 74,
        RailDetectorPowered =75,
        CopperIngot= 76,
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
        ClayDust=91,
        ClayBlock = 92,
        CopperOre = 93,
        LeadOre =94,
        Obsidian =95,
        TinOre =96,
        Hammer = 97,
        WireCutters =98,
        BronzeIngot= 99,
        BronzePlate = 100,
        BronzeShell = 101, 
        CompositeIngot = 103,
        Composite = 104,
        DoubleInsulatedGoldWire = 105,
        Faucet = 106,
        FiberglassWire =107,
        GlassPanel = 108,
        GoldPlate = 109,
        GoldenShell =110,
        GoldenWireIsolated =111,
        GoldenWire = 112,
        HardenedIronPlate=113,
        HighVoltageDoubleInsulatedWire =114,
        HighVoltageWireInsulated = 115,
        HighVoltageWire = 116,
        IronPlate = 117,
        IronShell = 118,
        IronTurningMold = 119,
        LapisLazuliPlate = 120,
        LeadPlate = 121,
        LeadSheath =122,
        ReactorShell = 123,
        ReinforcedIridiumPlate = 124,
        Rubber = 125,
        SolidBronzePlate = 126,
        ThickCopperPlate = 127,
        ThickGoldPlate = 128,
        ThickLeadPlate = 129,
        TinPlate = 130,
        TinShell = 131,
        TinWireIsolated = 132,
        TinWire = 133,
        CarbonFiberFabric = 134,
        CarbonFiber = 135,
        CopperPlate = 136,
        CopperShell = 137,
        CopperWireIsolated = 138,
        CopperWire = 139,
        AdvancedBattery = 140,
        AdvancedWiringDiagram = 141,
        AzuretronCrystal = 142,
        CarbonFiberPlastic  = 143,
        Coil = 144,
        CoolingCore = 145,
        CoolingRod = 146,
        CoolingRods = 147,
        DoubleCoolingRods = 148,
        ElectricLamp = 149,
        ElectricMotor = 150,
        EnergyCrystal = 151,
        EngineBooster = 152,
        FortifiedStone = 153,
        FrequencyBinder = 154,
        GravityEngine = 155,
        HeatIntensiveReactorPlate = 156,
        HeatCapacityReactor = 157,
        HeatExchanger =158,
        HeatSink = 159,
        ImprovedHeatDissipation = 160,
        ImprovedHeatExchanger = 161,
        MainMachineBody = 162,
        MemoryCrystal = 163,
        NeutronReflector = 164,
        NotChargedBattery = 165,
        RefrigerantCapsule = 166,
        ReinforcedGlass = 167,
        SuperConductorInsulation = 168,
        Superconductor = 169,
        ThickenedNeutronReflector = 170,
        UnfiredMemoryCrystal = 171,
        UniversalLiquidCapsule = 172,
        WiringDiagram = 173,
        MiningLaser = 174,
        SolarBattery = 175,
        Crusher = 176,
        Compressor =177,
        Extractor = 178,
        InductionOven = 179,
        GeothermalGenerator  = 180,
        NuclearReactor = 181,
        NuclearBomb = 182,
        IronFurnace = 183,
        Generator = 184,
        ElectricFurnace = 185,
        EnergyStorage = 186,
        MediumVoltageTransformer = 187,
        HighVoltageTransformer = 188,
        MultifunctionalEnergySaver = 189,
        Teleport = 190,
        MultiFunctionalStorageUnit = 191,
        ExtraHighVoltageTransformer = 192,
        MatterProducer = 193,
        Replicator = 194,
        Scanner = 195,
        TemplateGuardian = 196,
        EnergyPack = 197,
        ElectricJetpack = 198,
        ImprovedLappack = 199,
        UltimateLappack = 200,
        NightVisionDevice = 201,
        NanoHelmet = 202,
        NanofiberVest = 203,
        NanoLeggings = 204,
        NanoBoots = 205,
        ImprovedElectricJetpack = 206,
        QuantumVest= 207,
        GraviChestPlate = 208,
        TinDust = 209,
        GlowingStone = 210,
        LapisLazuliOre= 211,
        TeslaCoil = 212,
        IronBars = 213,
        ReactorChamber = 214,
        ImprovedMachineBody =215,
        HardenedIronBar =216,
        SilverOre =217,
        GlowstoneDust = 218,
        LapisLazuli = 219,
        Accelerator = 220
    }
    public string GetNameItemId()
    {     
        switch (itemId)
        { 
            case ItemId.Torch: return "�����";
            case ItemId.IronBucket: return "�������� �����";
            case ItemId.Arrow: return "������";
            case ItemId.Feather: return "����";
            case ItemId.Strings: return "����";
            case ItemId.Cauldron: return "�����";
            case ItemId.Lantern: return "������";
            case ItemId.WoodBlock: return "���������";
            case ItemId.Boards: return "�����";
            case ItemId.DiamondOre: return "�������� ����";
            case ItemId.GoldOre: return "������� ����";
            case ItemId.CoalOre: return "�������� ����";
            case ItemId.RedstoneOre: return "������� ����";
            case ItemId.Cobblestone: return "��������";
            case ItemId.IronOre: return "�������� ����";
            case ItemId.DiamondHelmet: return "�������� ����";
            case ItemId.DiamondChestplate: return "�������� ���������";
            case ItemId.DiamondLeggings: return "�������� ������";
            case ItemId.DiamondBoots: return "�������� �������";
            case ItemId.Shield: return "���";
            case ItemId.DiamondSword: return "�������� ���";
            case ItemId.DiamondPickaxe: return "�������� �����";
            case ItemId.DiamondAxe: return "�������� �����";
            case ItemId.DiamondShovel: return "�������� ������";
            case ItemId.DiamondHoe: return "�������� ������";
            case ItemId.Bow: return "���";
            case ItemId.FishingRod: return "������";
            case ItemId.Shears: return "�������";
            case ItemId.FlintSteel: return "������";
            case ItemId.Crossbow: return "�������";
            case ItemId.Coal: return "�����";
            case ItemId.Diamond: return "�����";
            case ItemId.IronIngot: return "�������� ������";
            case ItemId.GoldIngot: return "������� ������";
            case ItemId.Redstone: return "������� ����";
            case ItemId.Flint: return "�������";
            case ItemId.IronNugget: return "�������� ���������";
            case ItemId.Workbench: return "�������";
            case ItemId.WoodenChest: return "���������� ������";
            case ItemId.Stove: return "�����";
            case ItemId.Stick: return "�����";
            case ItemId.TripWireSource: return "�����";
            case ItemId.SmoothStone: return "������� ������";
            case ItemId.Sand: return "�����";
            case ItemId.IronBlock: return "�������� ����";
            case ItemId.Glass: return "������";
            case ItemId.HalfBlock: return "��������";
            case ItemId.PressurePlate: return "�������� �����";
            case ItemId.TNT: return "���";
            case ItemId.RedstoneTorch: return "������� �����";
            case ItemId.Compass: return "������";
            case ItemId.Gunpowder: return "�����";
            case ItemId.Hopper: return "�������";
            case ItemId.Trolley: return "���������";
            case ItemId.EchoShard: return "������� ���";
            case ItemId.Quartz: return "�����";
            case ItemId.Piston: return "�������";
            case ItemId.StickyPiston: return "������ �������";
            case ItemId.SlimeBall: return "����� �����";
            case ItemId.RecoveryCompass: return "������ ��������������";
            case ItemId.TrolleyTNT: return "��������� � ���";
            case ItemId.TrolleyStove: return "��������� � ������";
            case ItemId.TrolleyChest: return "��������� � �������";
            case ItemId.TrolleyHopper: return "��������� � ��������";
            case ItemId.Anvil: return "����������";
            case ItemId.DaylightSensor: return "������ �������� �����";
            case ItemId.Distributor: return "���������";
            case ItemId.Ejector: return "�������������";
            case ItemId.Observer: return "�����������";
            case ItemId.MeltingFurnace: return "���������� ����";
            case ItemId.Smokehouse: return "���������";
            case ItemId.Repeater: return "�����������";
            case ItemId.Comparator: return "����������";
            case ItemId.Rail: return "������";
            case ItemId.RailGoldenPowered: return "������������ �������";
            case ItemId.RailDetectorPowered: return "������������ � ����������";
            case ItemId.CopperIngot: return "������ ����";
            case ItemId.TinIngot: return "��������� ������";
            case ItemId.SulfurDust: return "������ ����";
            case ItemId.SilverIngot: return "���������� ������";
            case ItemId.SilverDust: return "���������� ����";
            case ItemId.Silica: return "������� �������";
            case ItemId.ObsidianDust: return "������������ ����";
            case ItemId.LeadIngot: return "������ ������";
            case ItemId.LeadDust: return "��������� ����";
            case ItemId.Latex: return "������";
            case ItemId.LapisLazuliDust: return "����������� ����";
            case ItemId.Iridium: return "�������";
            case ItemId.EnergyDust: return "�������������� ����";
            case ItemId.DiamondDust: return "�������� ����";
            case ItemId.CoalDust: return "�������� ����";
            case ItemId.ClayDust: return "�������� ����";
            case ItemId.ClayBlock: return "�������� ����";
            case ItemId.CopperOre: return "������ ����";
            case ItemId.LeadOre: return "��������� ����";
            case ItemId.Obsidian: return "��������";
            case ItemId.TinOre: return "��������� ����";
            case ItemId.Hammer: return "�������";
            case ItemId.WireCutters: return "�������";
            case ItemId.BronzeIngot: return "��������� ������";
            case ItemId.BronzePlate: return "��������� ��������";
            case ItemId.BronzeShell: return "��������� ��������";
            case ItemId.CompositeIngot: return "����������� ������";
            case ItemId.Composite: return "��������";
            case ItemId.DoubleInsulatedGoldWire: return "������� ������ � ������� ���������";
            case ItemId.Faucet: return "����";
            case ItemId.FiberglassWire: return "���������������� ���������";
            case ItemId.GlassPanel: return "���������� ������";
            case ItemId.GoldPlate: return "������� ��������";
            case ItemId.GoldenShell: return "������� ��������";
            case ItemId.GoldenWireIsolated: return "������� ������ ����������";
            case ItemId.HardenedIronPlate: return "�������� ��������";
            case ItemId.HighVoltageDoubleInsulatedWire: return "�������������� ������ � ������� ���������";
            case ItemId.HighVoltageWireInsulated: return "�������������� ������ � ���������";
            case ItemId.HighVoltageWire: return "�������������� ������";
            case ItemId.IronPlate: return "�������� ��������";
            case ItemId.IronShell: return "�������� ��������";
            case ItemId.IronTurningMold: return "�������� �������� �����";
            case ItemId.LapisLazuliPlate: return "����������� ��������";
            case ItemId.LeadPlate: return "��������� ��������";
            case ItemId.LeadSheath: return "��������� ��������";
            case ItemId.ReactorShell: return "�������� ��������";
            case ItemId.ReinforcedIridiumPlate: return "��������� ��������� ��������";
            case ItemId.Rubber: return "������";
            case ItemId.SolidBronzePlate: return "������� ��������� ��������";
            case ItemId.ThickCopperPlate: return "������� ������ ��������";
            case ItemId.ThickGoldPlate: return "������� ������� ��������";
            case ItemId.ThickLeadPlate: return "������� ��������� ��������";
            case ItemId.TinPlate: return "�������� ��������";
            case ItemId.TinShell: return "�������� ��������";
            case ItemId.TinWireIsolated: return "��������� ��������� �����������";
            case ItemId.TinWire: return "�������� ���������";
            case ItemId.TinDust: return "��������� ����";
            case ItemId.CarbonFiberFabric: return "����� �� ����������� �������";
            case ItemId.CarbonFiber: return "���������� �������";
            case ItemId.CopperPlate: return "������ ��������";
            case ItemId.CopperShell: return "������ ��������";
            case ItemId.CopperWireIsolated: return "������������� ������ ������";
            case ItemId.CopperWire: return "������ ������";
            case ItemId.AdvancedBattery: return "���������� �����������";
            case ItemId.AdvancedWiringDiagram: return "���������� ������������";
            case ItemId.AzuretronCrystal: return "�������� ����������";
            case ItemId.Coil: return "�������";
            case ItemId.CoolingCore: return "����������� ����";
            case ItemId.CoolingRod: return "����������� ��������";
            case ItemId.CoolingRods: return "����������� �������";
            case ItemId.DoubleCoolingRods: return "������� ����������� �������";
            case ItemId.ElectricLamp: return "������������� �����";
            case ItemId.ElectricMotor: return "����������������";
            case ItemId.EnergyCrystal: return "�������� �������";
            case ItemId.EngineBooster: return "��������� ���������";
            case ItemId.FortifiedStone: return "����������� ������";
            case ItemId.FrequencyBinder: return "���������";
            case ItemId.GravityEngine: return "�������������� ���������";
            case ItemId.HeatIntensiveReactorPlate: return "���������� ���������� �����";
            case ItemId.HeatExchanger: return "�������������";
            case ItemId.HeatSink: return "��������";
            case ItemId.ImprovedHeatDissipation: return "���������� ����������";
            case ItemId.ImprovedHeatExchanger: return "���������� �������������";
            case ItemId.MainMachineBody: return "�������� ������ ���������";
            case ItemId.MemoryCrystal: return "�������� ������";
            case ItemId.NeutronReflector: return "���������� ����������";
            case ItemId.NotChargedBattery: return "������� �����������";
            case ItemId.RefrigerantCapsule: return "������� ����������";
            case ItemId.ReinforcedGlass: return "������������ ������";
            case ItemId.SuperConductorInsulation: return "�������� ���������������"; 
            case ItemId.Superconductor: return "��������������"; 
            case ItemId.ThickenedNeutronReflector: return "���������� ���������� ���������";
            case ItemId.UnfiredMemoryCrystal: return "������ ��������� ������";
            case ItemId.UniversalLiquidCapsule: return "������������� ������ �������";
            case ItemId.WiringDiagram: return "������������";
            case ItemId.MiningLaser: return "���������� �����";
            case ItemId.IronFurnace: return "�������� ����";
            case ItemId.Generator: return "���������";
            case ItemId.ElectricFurnace: return "������������� ����";
            case ItemId.EnergyStorage: return "��������� �������";
            case ItemId.MediumVoltageTransformer: return "������������� �������� ����������";
            case ItemId.HighVoltageTransformer: return "�������������� �������������";
            case ItemId.MultifunctionalEnergySaver: return "������������������� ����������������";
            case ItemId.Teleport: return "��������";
            case ItemId.NightVisionDevice: return "������ ������� �������";
            case ItemId.EnergyPack: return "���������";
            case ItemId.ElectricJetpack: return "������������� ���������� �����";
            case ItemId.ImprovedLappack: return "���������� ������";
            case ItemId.UltimateLappack: return "�������� ������";
            case ItemId.QuantumVest: return "��������� �����";
            case ItemId.GlowingStone: return "���������� ������";
            case ItemId.LapisLazuliOre: return "����������� ����";
            case ItemId.TeslaCoil: return "������� �����";
            case ItemId.IronBars: return "�������� �������";
            case ItemId.ReactorChamber: return "���������� ������";
            case ItemId.ImprovedMachineBody: return "���������� ������ ���������";
            case ItemId.HardenedIronBar: return "��������� �����";
            case ItemId.SilverOre: return "���������� ����";
            case ItemId.GlowstoneDust: return "���������� ����";
            case ItemId.LapisLazuli: return "�������";
            case ItemId.CarbonFiberPlastic: return "������� �� ����������� �������";
            case ItemId.Accelerator: return "����������";
            case ItemId.SolarBattery: return "��������� �������";
            case ItemId.Crusher: return "���������";
            case ItemId.Compressor: return "����������";
            case ItemId.Extractor: return "����������";
            case ItemId.InductionOven: return "������������ ����";
            case ItemId.GeothermalGenerator: return "������������� ���������";
            case ItemId.NuclearReactor: return "������� �������";
            case ItemId.NuclearBomb: return "������� �����";
            case ItemId.MultiFunctionalStorageUnit: return "������������������� ���������";
            case ItemId.ExtraHighVoltageTransformer: return "������������� ������������� ����������";
            case ItemId.MatterProducer: return "������������� �������";
            case ItemId.Replicator: return "����������";
            case ItemId.Scanner: return "������";
            case ItemId.TemplateGuardian: return "��������� ��������";
            case ItemId.NanoHelmet: return "����-����";
            case ItemId.NanofiberVest: return "�������������� �����";
            case ItemId.NanoLeggings: return "����-������";
            case ItemId.NanoBoots: return "�����������";
            case ItemId.ImprovedElectricJetpack: return "���������� ������������� ���������� �����";
            case ItemId.GraviChestPlate: return "����� ���������";
            case ItemId.GoldenWire: return "������� ������"; 
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
            case ItemId.Comparator: return ItemsSprite.Instance.ComparatorSprite;
            case ItemId.Rail: return ItemsSprite.Instance.RailSprite;
            case ItemId.RailGoldenPowered: return ItemsSprite.Instance.RailGoldenPoweredSprite;
            case ItemId.RailDetectorPowered: return ItemsSprite.Instance.RailDetectorPoweredSprite;
            case ItemId.CopperIngot: return ItemsSprite.Instance.CopperIngotSprite;
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
            case ItemId.CopperOre: return ItemsSprite.Instance.CopperOreSprite;
            case ItemId.ClayBlock: return ItemsSprite.Instance.ClayBlockSprite;
            case ItemId.LeadOre: return ItemsSprite.Instance.LeadOreSprite;
            case ItemId.Obsidian: return ItemsSprite.Instance.ObsidianSprite;
            case ItemId.TinOre: return ItemsSprite.Instance.TinOreSprite;
            case ItemId.TinDust: return ItemsSprite.Instance.TinDustSprite;
            case ItemId.Hammer: return ItemsSprite.Instance.HammerSprite;
            case ItemId.WireCutters: return ItemsSprite.Instance.WireCuttersSprite;
            case ItemId.BronzeIngot: return ItemsSprite.Instance.BronzeIngotSprite;
            case ItemId.BronzePlate: return ItemsSprite.Instance.BronzePlateSprite;
            case ItemId.BronzeShell: return ItemsSprite.Instance.BronzeShellSprite;
            case ItemId.CarbonFiber: return ItemsSprite.Instance.CarbonFiberSprite;
            case ItemId.CompositeIngot: return ItemsSprite.Instance.CompositeIngotSprite;
            case ItemId.Composite: return ItemsSprite.Instance.CompositeSprite;
            case ItemId.DoubleInsulatedGoldWire: return ItemsSprite.Instance.DoubleInsulatedGoldWireSprite;
            case ItemId.Faucet: return ItemsSprite.Instance.FaucetSprite;
            case ItemId.FiberglassWire: return ItemsSprite.Instance.FiberglassWireSprite;
            case ItemId.GlassPanel: return ItemsSprite.Instance.GlassPanelSprite;
            case ItemId.GoldPlate: return ItemsSprite.Instance.GoldPlateSprite;
            case ItemId.GoldenShell: return ItemsSprite.Instance.GoldenShellSprite;
            case ItemId.GoldenWireIsolated: return ItemsSprite.Instance.GoldenWireIsolatedSprite;
            case ItemId.HardenedIronPlate: return ItemsSprite.Instance.HardenedIronPlateSprite;
            case ItemId.HighVoltageDoubleInsulatedWire: return ItemsSprite.Instance.HighVoltageDoubleInsulatedWireSprite;
            case ItemId.HighVoltageWireInsulated: return ItemsSprite.Instance.HighVoltageWireInsulatedSprite;
            case ItemId.HighVoltageWire: return ItemsSprite.Instance.HighVoltageWireSprite;
            case ItemId.IronPlate: return ItemsSprite.Instance.IronPlateSprite;
            case ItemId.IronShell: return ItemsSprite.Instance.IronShellSprite;
            case ItemId.IronTurningMold: return ItemsSprite.Instance.IronTurningMoldSprite;
            case ItemId.LapisLazuliPlate: return ItemsSprite.Instance.LapisLazuliPlateSprite;
            case ItemId.LeadPlate: return ItemsSprite.Instance.LeadPlateSprite;
            case ItemId.LeadSheath: return ItemsSprite.Instance.LeadSheathSprite;
            case ItemId.ReactorShell: return ItemsSprite.Instance.ReactorShellSprite;
            case ItemId.ReinforcedIridiumPlate: return ItemsSprite.Instance.ReinforcedIridiumPlateSprite;
            case ItemId.Rubber: return ItemsSprite.Instance.RubberSprite;
            case ItemId.SolidBronzePlate: return ItemsSprite.Instance.SolidBronzePlateSprite;
            case ItemId.ThickCopperPlate: return ItemsSprite.Instance.ThickCopperPlateSprite;
            case ItemId.ThickGoldPlate: return ItemsSprite.Instance.ThickGoldPlateSprite;
            case ItemId.ThickLeadPlate: return ItemsSprite.Instance.ThickLeadPlateSprite;
            case ItemId.TinPlate: return ItemsSprite.Instance.TinPlateSprite;
            case ItemId.TinShell: return ItemsSprite.Instance.TinShellSprite;
            case ItemId.TinWireIsolated: return ItemsSprite.Instance.TinWireIsolatedSprite;
            case ItemId.TinWire:return ItemsSprite.Instance.TinWireSprite;
            case ItemId.CarbonFiberFabric: return ItemsSprite.Instance.CarbonFiberFabricSprite; 
            case ItemId.CopperPlate: return ItemsSprite.Instance.CopperPlateSprite;
            case ItemId.CopperShell: return ItemsSprite.Instance.CopperShellSprite;
            case ItemId.CopperWireIsolated: return ItemsSprite.Instance.CopperWireIsolatedSprite;
            case ItemId.CopperWire: return ItemsSprite.Instance.CopperWireSprite;
            case ItemId.AdvancedBattery: return ItemsSprite.Instance.AdvancedBatterySprite;
            case ItemId.AdvancedWiringDiagram: return ItemsSprite.Instance.AdvancedWiringDiagramSprite;
            case ItemId.AzuretronCrystal: return ItemsSprite.Instance.AzuretronCrystalSprite; 
            case ItemId.Coil: return ItemsSprite.Instance.CoilSprite;
            case ItemId.CoolingCore: return ItemsSprite.Instance.CoolingCoreSprite;
            case ItemId.CoolingRod: return ItemsSprite.Instance.CoolingRodSprite;
            case ItemId.CoolingRods: return ItemsSprite.Instance.CoolingRodsSprite;
            case ItemId.DoubleCoolingRods: return ItemsSprite.Instance.DoubleCoolingRodsSprite;
            case ItemId.ElectricLamp: return ItemsSprite.Instance.ElectricLampSprite;
            case ItemId.ElectricMotor: return ItemsSprite.Instance.ElectricMotorSprite;
            case ItemId.EnergyCrystal: return ItemsSprite.Instance.EnergyCrystalSprite;
            case ItemId.EngineBooster: return ItemsSprite.Instance.EngineBoosterSprite;
            case ItemId.FortifiedStone: return ItemsSprite.Instance.FortifiedStoneSprite;
            case ItemId.FrequencyBinder: return ItemsSprite.Instance.FrequencyBinderSprite;
            case ItemId.GravityEngine: return ItemsSprite.Instance.GravityEngineSprite;
            case ItemId.HeatIntensiveReactorPlate: return ItemsSprite.Instance.HeatIntensiveReactorPlateSprite;
            case ItemId.HeatExchanger: return ItemsSprite.Instance.HeatExchangerSprite;
            case ItemId.HeatSink: return ItemsSprite.Instance.HeatSinkSprite;
            case ItemId.ImprovedHeatDissipation: return ItemsSprite.Instance.ImprovedHeatDissipationSprite;
            case ItemId.ImprovedHeatExchanger: return ItemsSprite.Instance.ImprovedHeatExchangerSprite;
            case ItemId.MainMachineBody: return ItemsSprite.Instance.MainMachineBodySprite;
            case ItemId.MemoryCrystal: return ItemsSprite.Instance.MemoryCrystalSprite;
            case ItemId.NeutronReflector: return ItemsSprite.Instance.NeutronReflectorSprite;
            case ItemId.NotChargedBattery: return ItemsSprite.Instance.NotChargedBatterySprite;
            case ItemId.RefrigerantCapsule: return ItemsSprite.Instance.RefrigerantCapsuleSprite;
            case ItemId.SuperConductorInsulation: return ItemsSprite.Instance.SuperConductorInsulationSprite;
            case ItemId.Superconductor: return ItemsSprite.Instance.SuperconductorSprite;
            case ItemId.ThickenedNeutronReflector: return ItemsSprite.Instance.ThickenedNeutronReflectorSprite;
            case ItemId.UnfiredMemoryCrystal: return ItemsSprite.Instance.UnfiredMemoryCrystalSprite;
            case ItemId.UniversalLiquidCapsule: return ItemsSprite.Instance.UniversalLiquidCapsuleSprite;
            case ItemId.WiringDiagram: return ItemsSprite.Instance.WiringDiagramSprite;
            case ItemId.ReinforcedGlass: return ItemsSprite.Instance.ReinforcedGlassSprite;
            case ItemId.MiningLaser: return ItemsSprite.Instance.MiningLaserSprite;
            case ItemId.IronFurnace: return ItemsSprite.Instance.IronFurnaceSprite;
            case ItemId.Generator: return ItemsSprite.Instance.GeneratorSprite;
            case ItemId.ElectricFurnace: return ItemsSprite.Instance.ElectricFurnaceSprite;
            case ItemId.EnergyStorage: return ItemsSprite.Instance.EnergyStorageSprite;
            case ItemId.MediumVoltageTransformer: return ItemsSprite.Instance.MediumVoltageTransformerSprite;
            case ItemId.HighVoltageTransformer: return ItemsSprite.Instance.HighVoltageTransformerSprite;
            case ItemId.MultifunctionalEnergySaver: return ItemsSprite.Instance.MultifunctionalEnergySaverSprite;
            case ItemId.Teleport: return ItemsSprite.Instance.TeleportSprite;
            case ItemId.SolarBattery: return ItemsSprite.Instance.SolarBatterySprite;
            case ItemId.Crusher: return ItemsSprite.Instance.CrusherSprite;
            case ItemId.Compressor: return ItemsSprite.Instance.CompressorSprite;
            case ItemId.Extractor: return ItemsSprite.Instance.ExtractorSprite;
            case ItemId.InductionOven: return ItemsSprite.Instance.InductionOvenSprite;
            case ItemId.GeothermalGenerator: return ItemsSprite.Instance.GeothermalGeneratorSprite;
            case ItemId.NuclearReactor: return ItemsSprite.Instance.NuclearReactorSprite;
            case ItemId.NuclearBomb: return ItemsSprite.Instance.NuclearBombSprite;
            case ItemId.MultiFunctionalStorageUnit: return ItemsSprite.Instance.MultiFunctionalStorageUnitSprite;
            case ItemId.ExtraHighVoltageTransformer: return ItemsSprite.Instance.ExtraHighVoltageTransformerSprite;
            case ItemId.MatterProducer: return ItemsSprite.Instance.MatterProducerSprite;
            case ItemId.Replicator: return ItemsSprite.Instance.ReplicatorSprite;
            case ItemId.Scanner: return ItemsSprite.Instance.ScannerSprite;
            case ItemId.TemplateGuardian: return ItemsSprite.Instance.TemplateGuardianSprite;
            case ItemId.EnergyPack: return ItemsSprite.Instance.EnergyPackSprite;
            case ItemId.ElectricJetpack: return ItemsSprite.Instance.ElectricJetpackSprite;
            case ItemId.ImprovedLappack: return ItemsSprite.Instance.ImprovedLappackSprite;
            case ItemId.UltimateLappack: return ItemsSprite.Instance.UltimateLappackSprite;
            case ItemId.NightVisionDevice: return ItemsSprite.Instance.NightVisionDeviceSprite;
            case ItemId.NanoHelmet: return ItemsSprite.Instance.NanoHelmetSprite;
            case ItemId.NanofiberVest: return ItemsSprite.Instance.NanofiberVestSprite;
            case ItemId.NanoLeggings: return ItemsSprite.Instance.NanoLeggingsSprite;
            case ItemId.NanoBoots: return ItemsSprite.Instance.NanoBootsSprite;
            case ItemId.ImprovedElectricJetpack: return ItemsSprite.Instance.ImprovedElectricJetpackSprite;
            case ItemId.QuantumVest: return ItemsSprite.Instance.QuantumVestSprite;
            case ItemId.GraviChestPlate: return ItemsSprite.Instance.GraviChestPlateSprite;
            case ItemId.GlowingStone: return ItemsSprite.Instance.GlowingStoneSprite;
            case ItemId.LapisLazuliOre: return ItemsSprite.Instance.LapisLazuliOreSprite;
            case ItemId.TeslaCoil: return ItemsSprite.Instance.TeslaCoilSprite;
            case ItemId.IronBars: return ItemsSprite.Instance.IronBarsSprite;
            case ItemId.ReactorChamber: return ItemsSprite.Instance.ReactorChamberSprite;
            case ItemId.ImprovedMachineBody: return ItemsSprite.Instance.ImprovedMachineBodySprite;
            case ItemId.HardenedIronBar: return ItemsSprite.Instance.HardenedIronBarSprite;
            case ItemId.SilverOre: return ItemsSprite.Instance.SilverOreSprite;
            case ItemId.GlowstoneDust: return ItemsSprite.Instance.GlowstoneDustSprite;
            case ItemId.LapisLazuli: return ItemsSprite.Instance.LapisLazuliSprite;
            case ItemId.CarbonFiberPlastic: return ItemsSprite.Instance.CarbonFiberPlasticSprite;
            case ItemId.Accelerator: return ItemsSprite.Instance.AcceleratorSprite;
            case ItemId.GoldenWire: return ItemsSprite.Instance.GoldenWireSprite; 
        }
    }
}
