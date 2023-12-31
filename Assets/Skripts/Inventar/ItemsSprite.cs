
using UnityEngine;

public class ItemsSprite : MonoBehaviour
{
    public static ItemsSprite Instance {  get; private set; }
    public void Awake()
    {
        Instance = this; 
    } 
    public Sprite TorchSprite;
    public Sprite IronBucketSprite;
    public Sprite ArrowSprite;
    public Sprite FeatherSprite;
    public Sprite StringsSprite;
    public Sprite CauldronSprite;
    public Sprite LanternSprite; 
    public Sprite WoodBlockSprite;
    public Sprite BoardsSprite;
    public Sprite DiamondOreSprite;
    public Sprite GoldOreSprite;
    public Sprite CoalOreSprite;
    public Sprite RedstoneOreSprite;
    public Sprite CobblestoneSprite;
    public Sprite IronOreSprite;
    public Sprite DiamondHelmetSprite;
    public Sprite DiamondChestplateSprite;
    public Sprite DiamondLeggingsSprite;
    public Sprite DiamondBootsSprite;
    public Sprite ShieldSprite;
    public Sprite DiamondSwordSprite;
    public Sprite DiamondPickaxeSprite;
    public Sprite DiamondAxeSprite;
    public Sprite DiamondShovelSprite;
    public Sprite DiamondHoeSprite;
    public Sprite BowSprite;
    public Sprite FishingRodSprite;
    public Sprite ShearsSprite;
    public Sprite FlintSteelSprite;
    public Sprite CrossbowSprite;
    public Sprite CoalSprite;
    public Sprite DiamondSprite;
    public Sprite IronIngotSprite;
    public Sprite GoldIngotSprite;
    public Sprite RedstoneSprite;
    public Sprite FlintSprite;
    public Sprite IronNuggetSprite;
    public Sprite HardenedIronBarSprite;
    public Sprite WorkbenchSprite;
    public Sprite WoodenChestSprite;
    public Sprite StoveSprite;
    public Sprite StickSprite;
    public Sprite TripWireSourceSprite;
    public Sprite SmoothStoneSprite;
    public Sprite SandSprite;
    public Sprite IronBlockSprite;
    public Sprite GlassSprite;
    public Sprite PressurePlateSprite;
    public Sprite HalfBlockSprite;
    public Sprite TNTSprite;
    public Sprite RedstoneTorchSprite;
    public Sprite CompassSprite;
    public Sprite GunpowderSprite;
    public Sprite HopperSprite;
    public Sprite TrolleySprite;
    public Sprite EchoShardSprite;
    public Sprite QuartzSprite;
    public Sprite PistonSprite;
    public Sprite StickyPistonSprite;
    public Sprite SlimeBallSprite;
    public Sprite RecoveryCompassSprite;
    public Sprite TrolleyTNTSprite;
    public Sprite TrolleyStoveSprite;
    public Sprite TrolleyChestSprite;
    public Sprite TrolleyHopperSprite;
    public Sprite AnvilSprite;
    public Sprite DaylightSensorSprite;
    public Sprite DistributorSprite;
    public Sprite EjectorSprite;
    public Sprite ObserverSprite;
    public Sprite MeltingFurnaceSprite;
    public Sprite SmokehouseSprite;
    public Sprite RepeaterSprite;
    public Sprite ComparatorSprite;
    public Sprite RailSprite;
    public Sprite RailGoldenPoweredSprite;
    public Sprite RailDetectorPoweredSprite; 
    public Sprite CopperIngotSprite;
    public Sprite TinIngotSprite;
    public Sprite SulfurDustSprite;
    public Sprite SilverOreSprite;
    public Sprite SilverIngotSprite;
    public Sprite BronzeIngotSprite;
    public Sprite SilverDustSprite;
    public Sprite SilicaSprite;
    public Sprite ObsidianDustSprite;
    public Sprite LeadIngotSprite;
    public Sprite LeadDustSprite;
    public Sprite LatexSprite;
    public Sprite LapisLazuliOreSprite;
    public Sprite LapisLazuliSprite;
    public Sprite LapisLazuliDustSprite;
    public Sprite IridiumSprite;
    public Sprite EnergyDustSprite;
    public Sprite DiamondDustSprite;
    public Sprite CoalDustSprite;
    public Sprite ClayDustSprite;
    public Sprite ClayBlockSprite;
    public Sprite CopperOreSprite; 
    public Sprite LeadOreSprite;
    public Sprite ObsidianSprite;
    public Sprite TinOreSprite;
    public Sprite GlowingStoneSprite; 
    public Sprite GlowstoneDustSprite;
    public Sprite HammerSprite;
    public Sprite WireCuttersSprite;
    public Sprite BronzePlateSprite;
    public Sprite BronzeShellSprite; 
    public Sprite CompositeIngotSprite;
    public Sprite CompositeSprite;
    public Sprite DoubleInsulatedGoldWireSprite;
    public Sprite FaucetSprite;
    public Sprite FiberglassWireSprite;
    public Sprite GlassPanelSprite;
    public Sprite GoldPlateSprite;
    public Sprite GoldenShellSprite;
    public Sprite GoldenWireIsolatedSprite;
    public Sprite GoldenWireSprite;
    public Sprite HardenedIronPlateSprite;
    public Sprite HighVoltageDoubleInsulatedWireSprite;
    public Sprite HighVoltageWireInsulatedSprite;
    public Sprite HighVoltageWireSprite;
    public Sprite IronPlateSprite;
    public Sprite IronShellSprite;
    public Sprite IronTurningMoldSprite;
    public Sprite IronBarsSprite;
    public Sprite LapisLazuliPlateSprite;
    public Sprite LeadPlateSprite;
    public Sprite LeadSheathSprite;
    public Sprite ReactorShellSprite;
    public Sprite ReinforcedIridiumPlateSprite;
    public Sprite RubberSprite;
    public Sprite SolidBronzePlateSprite;
    public Sprite ThickCopperPlateSprite;
    public Sprite ThickGoldPlateSprite;
    public Sprite ThickLeadPlateSprite;
    public Sprite TinPlateSprite;
    public Sprite TinShellSprite;
    public Sprite TinWireIsolatedSprite;
    public Sprite TinDustSprite;
    public Sprite TinWireSprite;
    public Sprite CarbonFiberPlasticSprite;
    public Sprite CarbonFiberFabricSprite;
    public Sprite CarbonFiberSprite;
    public Sprite CopperPlateSprite;
    public Sprite CopperShellSprite;
    public Sprite CopperWireIsolatedSprite;
    public Sprite CopperWireSprite;
    public Sprite AdvancedBatterySprite;
    public Sprite AdvancedWiringDiagramSprite;
    public Sprite AzuretronCrystalSprite;
    public Sprite CoilSprite;
    public Sprite CoolingCoreSprite;
    public Sprite CoolingRodSprite;
    public Sprite CoolingRodsSprite;
    public Sprite DoubleCoolingRodsSprite;
    public Sprite AcceleratorSprite;
    public Sprite ElectricLampSprite;
    public Sprite ElectricMotorSprite;
    public Sprite EnergyCrystalSprite;
    public Sprite EngineBoosterSprite;
    public Sprite FortifiedStoneSprite;
    public Sprite FrequencyBinderSprite;
    public Sprite GravityEngineSprite;
    public Sprite HeatIntensiveReactorPlateSprite;
    public Sprite HeatExchangerSprite;
    public Sprite HeatSinkSprite;
    public Sprite ImprovedHeatDissipationSprite;
    public Sprite ImprovedHeatExchangerSprite;
    public Sprite MainMachineBodySprite;
    public Sprite ImprovedMachineBodySprite;
    public Sprite MemoryCrystalSprite;
    public Sprite NeutronReflectorSprite;
    public Sprite NotChargedBatterySprite;
    public Sprite RefrigerantCapsuleSprite;
    public Sprite SuperConductorInsulationSprite;
    public Sprite TeslaCoilSprite;
    public Sprite SuperconductorSprite;
    public Sprite ThickenedNeutronReflectorSprite;
    public Sprite UnfiredMemoryCrystalSprite;
    public Sprite UniversalLiquidCapsuleSprite;
    public Sprite WiringDiagramSprite;
    public Sprite ReinforcedGlassSprite;
    public Sprite MiningLaserSprite;
    public Sprite IronFurnaceSprite; 
    public Sprite GeneratorSprite;
    public Sprite ElectricFurnaceSprite; 
    public Sprite EnergyStorageSprite;
    public Sprite MediumVoltageTransformerSprite;
    public Sprite HighVoltageTransformerSprite;
    public Sprite MultifunctionalEnergySaverSprite;
    public Sprite TeleportSprite;
    public Sprite ReactorChamberSprite;
    public Sprite SolarBatterySprite;
    public Sprite CrusherSprite;
    public Sprite CompressorSprite;
    public Sprite ExtractorSprite;
    public Sprite InductionOvenSprite;
    public Sprite GeothermalGeneratorSprite;
    public Sprite NuclearReactorSprite;
    public Sprite NuclearBombSprite;
    public Sprite MultiFunctionalStorageUnitSprite;
    public Sprite ExtraHighVoltageTransformerSprite;
    public Sprite MatterProducerSprite;
    public Sprite ReplicatorSprite;
    public Sprite ScannerSprite;
    public Sprite TemplateGuardianSprite;
    public Sprite EnergyPackSprite;
    public Sprite ElectricJetpackSprite;
    public Sprite ImprovedLappackSprite;
    public Sprite UltimateLappackSprite;
    public Sprite NightVisionDeviceSprite;
    public Sprite NanoHelmetSprite;
    public Sprite NanofiberVestSprite;
    public Sprite NanoLeggingsSprite;
    public Sprite NanoBootsSprite;
    public Sprite ImprovedElectricJetpackSprite;
    public Sprite QuantumVestSprite;
    public Sprite GraviChestPlateSprite; 
}
