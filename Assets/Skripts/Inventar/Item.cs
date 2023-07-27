
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
            case ItemId.Torch: return "Факел";
            case ItemId.IronBucket: return "Железное ведро";
            case ItemId.Arrow: return "Стрела";
            case ItemId.Feather: return "Перо";
            case ItemId.Strings: return "Нить";
            case ItemId.Cauldron: return "Котел";
            case ItemId.Lantern: return "Фонарь";
            case ItemId.WoodBlock: return "Древесина";
            case ItemId.Boards: return "Доски";
            case ItemId.DiamondOre: return "Алмазная руда";
            case ItemId.GoldOre: return "Золотая руда";
            case ItemId.CoalOre: return "Угольная руда";
            case ItemId.RedstoneOre: return "Красная руда";
            case ItemId.Cobblestone: return "Булыжник";
            case ItemId.IronOre: return "Железная руда";
            case ItemId.DiamondHelmet: return "Алмазный шлем";
            case ItemId.DiamondChestplate: return "Алмазный нагрудник";
            case ItemId.DiamondLeggings: return "Алмазные поножи";
            case ItemId.DiamondBoots: return "Алмазные ботинки";
            case ItemId.Shield: return "Щит";
            case ItemId.DiamondSword: return "Алмазный меч";
            case ItemId.DiamondPickaxe: return "Алмазная кирка";
            case ItemId.DiamondAxe: return "Алмазный топор";
            case ItemId.DiamondShovel: return "Алмазная лопата";
            case ItemId.DiamondHoe: return "Алмазная мотыга";
            case ItemId.Bow: return "Лук";
            case ItemId.FishingRod: return "Удочка";
            case ItemId.Shears: return "Ножницы";
            case ItemId.FlintSteel: return "Огниво";
            case ItemId.Crossbow: return "Арбалет";
            case ItemId.Coal: return "Уголь";
            case ItemId.Diamond: return "Алмаз";
            case ItemId.IronIngot: return "Железный слиток";
            case ItemId.GoldIngot: return "Золотой слиток";
            case ItemId.Redstone: return "Красная пыль";
            case ItemId.Flint: return "Кремень";
            case ItemId.IronNugget: return "Железный самородок";
            case ItemId.Workbench: return "Верстак";
            case ItemId.WoodenChest: return "Деревянный сундук";
            case ItemId.Stove: return "Печка";
            case ItemId.Stick: return "Палка";
            case ItemId.TripWireSource: return "Петля";
            case ItemId.SmoothStone: return "Гладкий камень";
            case ItemId.Sand: return "Песок";
            case ItemId.IronBlock: return "Железный блок";
            case ItemId.Glass: return "Стекло";
            case ItemId.HalfBlock: return "Полублок";
            case ItemId.PressurePlate: return "Нажимная плита";
            case ItemId.TNT: return "ТНТ";
            case ItemId.RedstoneTorch: return "Красный факел";
            case ItemId.Compass: return "Компас";
            case ItemId.Gunpowder: return "Порох";
            case ItemId.Hopper: return "Воронка";
            case ItemId.Trolley: return "Вагонетка";
            case ItemId.EchoShard: return "Осколок эха";
            case ItemId.Quartz: return "Кварц";
            case ItemId.Piston: return "Поршень";
            case ItemId.StickyPiston: return "Липкий поршень";
            case ItemId.SlimeBall: return "Шарик слизи";
            case ItemId.RecoveryCompass: return "Компас восстановления";
            case ItemId.TrolleyTNT: return "Вагонетка с ТНТ";
            case ItemId.TrolleyStove: return "Вагонетка с печкой";
            case ItemId.TrolleyChest: return "Вагонетка с сундком";
            case ItemId.TrolleyHopper: return "Вагонетка с воронкой";
            case ItemId.Anvil: return "Наковальня";
            case ItemId.DaylightSensor: return "Датчик дневного света";
            case ItemId.Distributor: return "Раздатчик";
            case ItemId.Ejector: return "Выбрасыватель";
            case ItemId.Observer: return "Наблюдатель";
            case ItemId.MeltingFurnace: return "Плавильная печь";
            case ItemId.Smokehouse: return "Коптильню";
            case ItemId.Repeater: return "Повторитель";
            case ItemId.Comparator: return "Компаратор";
            case ItemId.Rail: return "Рельсы";
            case ItemId.RailGoldenPowered: return "Энергорельсы золотые";
            case ItemId.RailDetectorPowered: return "Энергорельсы с детектором";
            case ItemId.CopperIngot: return "Слиток меди";
            case ItemId.TinIngot: return "Оловянный слиток";
            case ItemId.SulfurDust: return "Серная пыль";
            case ItemId.SilverIngot: return "Серебряный слиток";
            case ItemId.SilverDust: return "Серебряная пыль";
            case ItemId.Silica: return "Диоксид кремния";
            case ItemId.ObsidianDust: return "Обсидиановая пыль";
            case ItemId.LeadIngot: return "Слиток свинца";
            case ItemId.LeadDust: return "Свинцовая пыль";
            case ItemId.Latex: return "Латекс";
            case ItemId.LapisLazuliDust: return "Лазуритовая пыль";
            case ItemId.Iridium: return "Иридиум";
            case ItemId.EnergyDust: return "Энергетическая пыль";
            case ItemId.DiamondDust: return "Алмазная пыль";
            case ItemId.CoalDust: return "Угольная пыль";
            case ItemId.ClayDust: return "Глиняная пыль";
            case ItemId.ClayBlock: return "Глиняный блок";
            case ItemId.CopperOre: return "Медная руда";
            case ItemId.LeadOre: return "Свинцовая руда";
            case ItemId.Obsidian: return "Обсидиан";
            case ItemId.TinOre: return "Оловянная руда";
            case ItemId.Hammer: return "Молоток";
            case ItemId.WireCutters: return "Кусачки";
            case ItemId.BronzeIngot: return "Бронзовый слиток";
            case ItemId.BronzePlate: return "Бронзовая пластина";
            case ItemId.BronzeShell: return "Бронзовая оболочка";
            case ItemId.CompositeIngot: return "Композитный слиток";
            case ItemId.Composite: return "Композит";
            case ItemId.DoubleInsulatedGoldWire: return "Золотой провод с двойной изоляцией";
            case ItemId.Faucet: return "Кран";
            case ItemId.FiberglassWire: return "Стекловолоконная проволока";
            case ItemId.GlassPanel: return "Стеклянная панель";
            case ItemId.GoldPlate: return "Золотая пластина";
            case ItemId.GoldenShell: return "Золотая оболочка";
            case ItemId.GoldenWireIsolated: return "Золотой провод изолирован";
            case ItemId.HardenedIronPlate: return "Стальная пластина";
            case ItemId.HighVoltageDoubleInsulatedWire: return "Высоковольтный провод с двойной изоляцией";
            case ItemId.HighVoltageWireInsulated: return "Высоковольтный провод с изоляцией";
            case ItemId.HighVoltageWire: return "Высоковольтный провод";
            case ItemId.IronPlate: return "Железная пластина";
            case ItemId.IronShell: return "Железная оболочка";
            case ItemId.IronTurningMold: return "Железная токарная форма";
            case ItemId.LapisLazuliPlate: return "Лазуритовая пластина";
            case ItemId.LeadPlate: return "Свинцовая пластина";
            case ItemId.LeadSheath: return "Свинцовая оболочка";
            case ItemId.ReactorShell: return "Оболочка реактора";
            case ItemId.ReinforcedIridiumPlate: return "Усиленная иридиевая пластина";
            case ItemId.Rubber: return "Резина";
            case ItemId.SolidBronzePlate: return "Твердая бронзовая пластина";
            case ItemId.ThickCopperPlate: return "Толстая медная пластина";
            case ItemId.ThickGoldPlate: return "Толстая золотая пластина";
            case ItemId.ThickLeadPlate: return "Толстая свинцовая пластина";
            case ItemId.TinPlate: return "Оловяная пластина";
            case ItemId.TinShell: return "Оловяная оболочка";
            case ItemId.TinWireIsolated: return "Оловянная проволока изолирована";
            case ItemId.TinWire: return "Оловяная проволока";
            case ItemId.TinDust: return "Оловянная пыль";
            case ItemId.CarbonFiberFabric: return "Ткань из углеродного волокна";
            case ItemId.CarbonFiber: return "Углеродное волокно";
            case ItemId.CopperPlate: return "Медная пластина";
            case ItemId.CopperShell: return "Медная оболочка";
            case ItemId.CopperWireIsolated: return "Изолированный медный провод";
            case ItemId.CopperWire: return "Медный провод";
            case ItemId.AdvancedBattery: return "Улучшенный аккумулятор";
            case ItemId.AdvancedWiringDiagram: return "Улучшенная электросхема";
            case ItemId.AzuretronCrystal: return "Кристалл азуретрона";
            case ItemId.Coil: return "Катушка";
            case ItemId.CoolingCore: return "Охлаждающее ядро";
            case ItemId.CoolingRod: return "Охлаждающий стержень";
            case ItemId.CoolingRods: return "Охлаждающие стержни";
            case ItemId.DoubleCoolingRods: return "Двойные охлаждающие стержни";
            case ItemId.ElectricLamp: return "Электрическая лампа";
            case ItemId.ElectricMotor: return "Электродвигатель";
            case ItemId.EnergyCrystal: return "Кристалл энергии";
            case ItemId.EngineBooster: return "Усилитель двигателя";
            case ItemId.FortifiedStone: return "Укрепленный камень";
            case ItemId.FrequencyBinder: return "Радиомаяк";
            case ItemId.GravityEngine: return "Гравитационный двигатель";
            case ItemId.HeatIntensiveReactorPlate: return "Теплоемкая реакторная плита";
            case ItemId.HeatExchanger: return "Теплообменник";
            case ItemId.HeatSink: return "Радиатор";
            case ItemId.ImprovedHeatDissipation: return "Улучшенный теплоотвод";
            case ItemId.ImprovedHeatExchanger: return "Улучшенный теплообменник";
            case ItemId.MainMachineBody: return "Основной корпус механизма";
            case ItemId.MemoryCrystal: return "Кристалл памяти";
            case ItemId.NeutronReflector: return "Нейтронный отражатель";
            case ItemId.NotChargedBattery: return "Батарея незаряженая";
            case ItemId.RefrigerantCapsule: return "Капсула хладагента";
            case ItemId.ReinforcedGlass: return "Армированное стекло";
            case ItemId.SuperConductorInsulation: return "Изоляция сверхпроводника"; 
            case ItemId.Superconductor: return "Сверхпроводник"; 
            case ItemId.ThickenedNeutronReflector: return "Утолщенный отражатель нейтронов";
            case ItemId.UnfiredMemoryCrystal: return "Шаблон кристалла памяти";
            case ItemId.UniversalLiquidCapsule: return "Универсальная жидкая капсула";
            case ItemId.WiringDiagram: return "Электросхема";
            case ItemId.MiningLaser: return "Шахтерский лазер";
            case ItemId.IronFurnace: return "Железная печь";
            case ItemId.Generator: return "Генератор";
            case ItemId.ElectricFurnace: return "Электрическая печь";
            case ItemId.EnergyStorage: return "Хранилище энергии";
            case ItemId.MediumVoltageTransformer: return "Трансформатор среднего напряжения";
            case ItemId.HighVoltageTransformer: return "Высоковольтный трансформатор";
            case ItemId.MultifunctionalEnergySaver: return "Многофункциональное энергосбережение";
            case ItemId.Teleport: return "Телепорт";
            case ItemId.NightVisionDevice: return "Прибор ночного видения";
            case ItemId.EnergyPack: return "Энергопак";
            case ItemId.ElectricJetpack: return "Электрический реактивный ранец";
            case ItemId.ImprovedLappack: return "Улучшенный лаппак";
            case ItemId.UltimateLappack: return "Ултимейт лаппак";
            case ItemId.QuantumVest: return "Квантовый жилет";
            case ItemId.GlowingStone: return "Светящийся камень";
            case ItemId.LapisLazuliOre: return "Лазуритовая руда";
            case ItemId.TeslaCoil: return "Катушка Тесла";
            case ItemId.IronBars: return "Железная решетка";
            case ItemId.ReactorChamber: return "Реакторная камера";
            case ItemId.ImprovedMachineBody: return "Улучшенный корпус механизма";
            case ItemId.HardenedIronBar: return "Закаленая сталь";
            case ItemId.SilverOre: return "Серебряная руда";
            case ItemId.GlowstoneDust: return "Светящаяся пыль";
            case ItemId.LapisLazuli: return "Лазурит";
            case ItemId.CarbonFiberPlastic: return "Пластик из углеродного волокна";
            case ItemId.Accelerator: return "Ускоритель";
            case ItemId.SolarBattery: return "Солнечная батарея";
            case ItemId.Crusher: return "Дробитель";
            case ItemId.Compressor: return "Компрессор";
            case ItemId.Extractor: return "Экстрактор";
            case ItemId.InductionOven: return "Индукционная печь";
            case ItemId.GeothermalGenerator: return "Геотермальный генератор";
            case ItemId.NuclearReactor: return "Ядерный реактор";
            case ItemId.NuclearBomb: return "Ядерная бомба";
            case ItemId.MultiFunctionalStorageUnit: return "Многофункциональное хранилище";
            case ItemId.ExtraHighVoltageTransformer: return "Трансформатор сверхвысокого напряжения";
            case ItemId.MatterProducer: return "Производитель материи";
            case ItemId.Replicator: return "Репликатор";
            case ItemId.Scanner: return "Сканер";
            case ItemId.TemplateGuardian: return "Хранилище шаблонов";
            case ItemId.NanoHelmet: return "Нано-шлем";
            case ItemId.NanofiberVest: return "Нановолоконный жилет";
            case ItemId.NanoLeggings: return "Нано-поножи";
            case ItemId.NanoBoots: return "Наноботинки";
            case ItemId.ImprovedElectricJetpack: return "Улучшенный электрический реактивный ранец";
            case ItemId.GraviChestPlate: return "Грави нагрудник";
            case ItemId.GoldenWire: return "Золотой провод";
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
