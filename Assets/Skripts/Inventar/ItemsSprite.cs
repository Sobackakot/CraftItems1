using System.Collections;
using System.Collections.Generic;
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
    public Sprite WorkbenchSprite;
    public Sprite WoodenChestSprite;
    public Sprite StoveSprite;
    public Sprite StickSprite;
    public Sprite TripWireSourceSprite; 
}
