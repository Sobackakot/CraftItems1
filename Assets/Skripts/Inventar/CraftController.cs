
using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Linq;
using System.Numerics;
using UnityEditor;
using UnityEngine; 

public class CraftController : MonoBehaviour
{
    private AudioSource m_AudioSource; 
    [SerializeField] private AudioClip craftSlotAoudio;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform craftGrid;
    [SerializeField] private ParticleSystem particlCraftSlot; 
    [HideInInspector] public bool IsQuestCraft;
    public CraftSlot[,] craftSlot { get; private set; }
    public CraftResultSlot craftResultSlot;

    private bool isCraftingInProgress = false; 
    private Item.ItemId [] CraftOrder { get; set; }
    private int EndHorizontalIdex { get; set; }
    private int EndVerticalIdex { get; set; }
    private int StartHorizontalIndex { get; set; }
    private int StartVerticalIndex { get; set; }
    private int HorizontalIsNull { get; set; }
    private int VerticalIsNull { get; set; }

    public bool HasResultItem => craftResultSlot.ItemInSlot != null; 

    private string[] resourcesItemName1 = new string[17] //List of SECONDARY CRAFTS
    {
        "Wood Block", "Boards","Stick","Coal Ore","Coal","Diamond Ore","Diamond",
        "Gold Ore","Gold Ingot","Redstone Ore","Redstone","Iron Ingot","Flint","Feather","String","Torch","Iron Nugget"
    };
    private string[] resourcesItemName2 = new string[31] //List of SECONDARY CRAFTS
    {
        "Wood Block", "Boards","Stick","Coal Ore","Coal","Diamond Ore","Diamond",
        "Gold Ore","Gold Ingot","Redstone Ore","Redstone","Iron Ingot","Flint","Feather","String","Trip Wire Source","Torch","Iron Nugget",
        "Iron Block", "Half Block","Pressure Plate","Glass","Redstone Torch","Compass","Wooden Chest", "TNT", "Stove","Hopper", "Trolley","Bow","Piston"
    };
    private string[] resourcesItemName3 = new string[225]
    {
        "Wood Block", "Boards","Stick","Coal Ore","Coal","Diamond Ore","Diamond",
        "Gold Ore","Gold Ingot","Redstone Ore","Redstone","Iron Ingot","Flint","Feather","String","Trip Wire Source","Torch","Iron Nugget",
        "Iron Block", "Half Block","Pressure Plate","Glass","Redstone Torch","Compass","Wooden Chest", "TNT", "Stove","Hopper", "Trolley","Bow","Piston",
        "Arrow", "Boards", "Bow", "Bronze Ingot", "Bronze Plate", "Bronze Shell", "Carbon Fiber", "Carbon Fiber Fabric", "Carbon Fiber Plastic", "Cauldron", 
        "Clay Block", "Clay Dust", "Coal", "Coal Dust", "Coal Ore", "Coil", "Composite", "Composite Ingot", "Comparator", "Compass", "Cooling Core", "Cooling Rod",
        "Cooling Rods", "Copper Ingot", "Copper Ore", "Copper Plate", "Copper Shell", "Copper Wire", "Copper Wire Isolated", "Crossbow", "Daylight Sensor", "Diamond", 
        "Diamond Axe", "Diamond Boots", "Diamond Chestplate", "Diamond Helmet", "Diamond Hoe", "Diamond Leggings", "Diamond Ore", "Diamond Pickaxe", "Diamond Shovel", 
        "Diamond Sword", "Diamond Dust", "Distributor", "Double Cooling Rods", "Double Insulated Gold Wire", "Ejector", "Electric Furnace", "Electric Jetpack", "Electric Lamp", 
        "Electric Motor", "Elevator", "Ender Pearl", "Engine Booster", "Energy Crystal", "Energy Dust", "Energy Pack", "Energy Storage", "Faucet", "Feather", "Fiberglass Wire", 
        "Fishing Rod", "Flint", "Flint and Steel", "Fortified Stone", "Frequency Binder", "Generator", "Glass", "Glass Panel", "Glowing Stone", "Glowstone Dust", "Gold Ingot", 
        "Gold Plate", "Golden Shell", "Golden Wire Isolated", "Gravity Engine", "Gunpowder", "Hammer", "Hardened Iron Bar", "Hardened Iron Plate", "Heat Exchanger", "Heat Sink", 
        "High Voltage Double Insulated Wire", "High Voltage Transformer", "High Voltage Wire", "High Voltage Wire Insulated", "Hopper", "Improved Heat Dissipation", "Improved Heat Exchanger", 
        "Improved Lappack", "Improved Machine Body", "Iridium", "Iron Bars", "Iron Block", "Iron Bucket", "Iron Furnace", "Iron Ingot", "Iron Ore", "Iron Plate", "Iron Shell", "Iron Turning Mold", 
        "Lantern", "Lapis Lazuli", "Lapis Lazuli Dust", "Lapis Lazuli Ore", "Latex", "Lead Ingot", "Lead Ore", "Lead Plate", "Lead Sheath", "Lead Dust", "Machine", "Main Machine Body", "Melting Furnace", 
        "Memory Crystal", "Medium Voltage Transformer", "Mining Laser", "Multifunctional Energy Saver", "Neutron Reflector", "Night-Vision Device", "Not Charged Battery", "Observer", "Obsidian", "Obsidian Dust", 
        "Piston", "Press-ure Plate", "Quantum Vest", "Rail", "Rail Detector Powered", "Rail Golden Powered", "Recovery Compass", "Refrigerant Capsule", "Reinforced Glass", "Reinforced Iridium Plate", 
        "Reinforced Machine Body", "Reinforced Reactor Plate", "Reinforced Stone", "Rubber", "Sand", "Shears", "Shield", "Silica", "Silver Dust", "Silver Ingot", "Silver Ore", "Silicon", 
        "Silicon Boule", "Silicon Dioxide", "Silicon Ingot", "Slime Ball", "Smokehouse", "Smooth Stone", "Sticky Piston", "Stick", "Stove", "Super Conductor Insulation", "Superconductor", "Sulfur Dust", 
        "Super Conductor", "Teleport", "Tesla Coil", "Thick Copper Plate", "Thick Gold Plate", "Thick Lead Plate", "Thickened Neutron Reflector", "Tin Dust", "Tin Ingot", "Tin Ore", "Tin Plate", "Tin Shell", 
        "Tin Wire", "Tin Wire Isolated", "TNT", "Trolley", "Trolley Chest", "Trolley Hopper", "Trolley Stove", "Trolley TNT", "Trip Wire Source", "Ultimate Lappack", "Unfired Memory Crystal",
        "Universal Liquid Capsule", "Wiring Diagram", "Wood Block", "Wooden Chest", "Workbench","Nanofiber Vest","Geothermal Generator","Reactor Shell","Reactor Chamber",
        "Advanced Wiring Diagram","Azuretron Crystal","Advanced Battery","Golden Wire"
    };
    public void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>(); 
        particlCraftSlot.Stop();
    }
    //This method initializes the craftSlot array and creates the crafting grid.
    //It instantiates slot prefabs and assigns them to the craftSlot array.
    public void Init() 
    {   
        craftSlot = new CraftSlot[3,3];
        CreateSlotsPrefabs();
    }
    // This method creates the crafting grid by instantiating slot prefabs and placing them in the craft grid.
    // It iterates over the craftSlot array and assigns each slot with the CraftSlot component.
    private void CreateSlotsPrefabs() // Init  
    {
        for( int i = 0; i <craftSlot.GetLength(0);  i++ )
        {
            for(int j= 0; j < craftSlot.GetLength(1); j++)
            {
                var slot = Instantiate(slotPrefab, craftGrid, false);
                craftSlot[i, j] = slot.AddComponent<CraftSlot>();
            }
        }
    }
    // !!! EXTERNOL METHODS !!!
    //This method checks the crafting recipe based on the items present in the crafting slots.
    //It determines the resulting item by comparing the CraftOrder array
    //(representing the order of items in the slots) with the defined item recipes.
    public void CheckCraft() 
    {
        ItemInSlot NewItemcInResultSlot = null;
        EndHorizontalIdex = 0;
        EndVerticalIdex = 0;
        StartHorizontalIndex = -1;
        StartVerticalIndex = -1;
        HorizontalIsNull = 0;
        VerticalIsNull = 0;
        for (int i = 0; i < craftSlot.GetLength(0); i++)
        {
            for (int j = 0; j < craftSlot.GetLength(1); j++)
            { 
                if (craftSlot[i, j].HasItem)
                {
                    SetHorizontalIndexItem(i);
                    break;
                } 
                else if (StartHorizontalIndex != -1)
                {
                    IncrementHorizontalNull(i,j);
                    DecrementHorizontalNull(i,j);
                } 
            }
        }
        for (int i = 0; i < craftSlot.GetLength(1); i++)
        {
            for (int j = 0; j < craftSlot.GetLength(0); j++)
            { 
                if (craftSlot[j, i].HasItem)
                {
                    SetVerticalIndexItem(i);
                    break;
                } 
                else if (StartVerticalIndex != -1)
                {
                    IncrementVerticalNull(j,i);
                    DecrementVerticalNull(j,i);
                } 
            }
        }
        CreatingNewCraftingArray();
        NewItemcInResultSlot = CheckCraftRecipe(NewItemcInResultSlot);
        SetNewItemInResultSlot(NewItemcInResultSlot); 
    }
    //This method crafts the item. It decreases the item amounts in the crafting slots
    //by 1 and initiates the crafting progress coroutine.
    //If crafting is already in progress, it doesn't perform any action.
    public void CraftItem()
    {
        for(int i = 0; i< craftSlot.GetLength(0); i++)
        {
            for(int j= 0; j <craftSlot.GetLength(1); j++)
            {
                if (craftSlot[i, j].ItemInSlot != null)
                {
                    craftSlot[i, j].DecreaseItemAmount(1);
                }
            }
        }
        StartCoroutine(CoroutineCraftingProgress());
        if(!isCraftingInProgress)
        CheckCraft();
    }


    // !!! INTERNOL METHODS !!!
    //This method creates a new array (CraftOrder) that represents the order of items in the crafting slots.
    //It iterates over the slots and populates the CraftOrder array accordingly.
    private void CreatingNewCraftingArray() // CheckCraft 
    {
        CraftOrder = new Item.ItemId[EndHorizontalIdex * EndVerticalIdex];
        for (int orderId = 0, i = StartHorizontalIndex; i < StartHorizontalIndex + EndHorizontalIdex; i++)
        {
            for (int j = StartVerticalIndex; j < StartVerticalIndex + EndVerticalIdex; j++)
            {
                if (craftSlot[i, j].HasItem)
                {
                    CraftOrder[orderId++] = craftSlot[i, j].ItemInSlot.Item.itemId;
                }
                else if (EndVerticalIdex == 3 || EndHorizontalIdex == 3)
                {
                    CraftOrder[orderId++] = Item.ItemId.None;
                }
            }
        } 
    }
    //This method checks the crafting recipe by comparing the CraftOrder array with the defined item recipes.
    //It iterates over the items in the game and checks if the recipe matches the CraftOrder. If a match is found, it returns the resulting item.
    private ItemInSlot CheckCraftRecipe(ItemInSlot NewItemcInResultSlot) // CheckCraft 
    {
        foreach (var item in ItemsManager.InstanceItemManager.Items)
        {
            if (item.HasRecipe && CraftOrder.SequenceEqual(item.Recipe.RecipeItemOrder))
            {
                NewItemcInResultSlot = new ItemInSlot(item, item.Recipe.Amount);
                break;
            }
        }
        return NewItemcInResultSlot;
    }
    //This method sets the resulting item in the craft result slot based on the crafted item.
    //If a resulting item is found, it sets the item in the craft result slot, plays the craft slot audio,
    //and starts the particle system. If no resulting item is found, it resets the craft result slot and stops the audio and particle effects.
    private void SetNewItemInResultSlot(ItemInSlot NewItemcInResultSlot) //CheckCraft 
    {
        if (NewItemcInResultSlot != null)
        {
            SetSecondaryItemInResultSlot(NewItemcInResultSlot);
            SetResultChallengeItemInResultSlot(NewItemcInResultSlot);
        }
        else
        {
            craftResultSlot.ResetItem();
            m_AudioSource.Stop();
            particlCraftSlot.Stop();
        }
    }
    //This method sets the resulting item in the craft result slot if it's a secondary resource item.
    //It compares the resulting item with the list of secondary resource item names and sets it in the craft result slot if there's a match.
    //It also plays the craft slot audio and starts the particle system.
    private void SetSecondaryItemInResultSlot(ItemInSlot NewItemcInResultSlot) //SetNewItemInResultSlot  
    {
        bool condition1 = ShowChallenge.InstanceChallenge.Index < 20;
        bool condition2 = ShowChallenge.InstanceChallenge.Index < 40;
        string [] selectedArray = condition1 ? resourcesItemName1 : (condition2 ? resourcesItemName2 : resourcesItemName3); 
        for (int i = 0; i < selectedArray.Length; i++)
        {
            string nameItem = selectedArray[i];
            if (nameItem == NewItemcInResultSlot.Item.GetNameItemId())
            { 
                craftResultSlot.SetItem(NewItemcInResultSlot);
                m_AudioSource.PlayOneShot(craftSlotAoudio, 1f);
                particlCraftSlot.Play();
                StartCoroutine(CoroutineDisableParticle());
                return;
            }
        }
    }
    //This method sets the resulting item in the craft result slot if it matches the challenge item and updates the challenge progress.
    //It compares the resulting item with the challenge item's name and sets it in the craft result slot if there's a match.
    //It plays the craft slot audio and starts the particle system. It also sets the isNextImageChallenge flag in the challenge instance,
    //indicating that the challenge progress should be updated.
    private void SetResultChallengeItemInResultSlot(ItemInSlot NewItemcInResultSlot) // SetNewItemInResultSlot
    {
        if (ShowChallenge.InstanceChallenge?.nameItemSpriteChallenge == NewItemcInResultSlot.Item.GetNameItemId())
        { 
            craftResultSlot.SetItem(NewItemcInResultSlot);
            m_AudioSource.PlayOneShot(craftSlotAoudio, 1f);
            particlCraftSlot.Play();
            StartCoroutine(CoroutineDisableParticle());
            ShowChallenge.InstanceChallenge.isNextImageChallenge = true;
            isCraftingInProgress = true;
            IsQuestCraft = true;
            return;
        }
    }
    //This method sets the starting and ending horizontal indices for the crafting slots.
    //It is called when an item is found in the crafting slots and updates the StartHorizontalIndex and EndHorizontalIdex accordingly.
    private void SetHorizontalIndexItem(int i) //CheckCraft -
    {
        if (StartHorizontalIndex == -1)
            StartHorizontalIndex = i;
        EndHorizontalIdex++; 
        if (HorizontalIsNull < 3)
            HorizontalIsNull = 0; 
    }
    //This method sets the starting and ending vertical indices for the crafting slots.
    //It is called when an item is found in the crafting slots and updates the StartVerticalIndex and EndVerticalIdex accordingly.
    private void SetVerticalIndexItem(int i) //CheckCraft -
    {
        if (StartVerticalIndex == -1)
            StartVerticalIndex = i;
        EndVerticalIdex++; 
        if (VerticalIsNull < 3)
            VerticalIsNull = 0; 
    }
    //This method increments the horizontal null count and adjusts the ending horizontal index based on empty slots.
    //It is called when there are empty slots in the crafting grid and updates the HorizontalIsNull and EndHorizontalIdex accordingly.
    private void IncrementHorizontalNull(int i, int j) //CheckCraft -
    {
        if (i == 1 && !craftSlot[i, j].HasItem && HorizontalIsNull != 3)
        {
            HorizontalIsNull++; 
            if (HorizontalIsNull == 3)
            {
                EndHorizontalIdex++;
            }
            return;
        }
    }
    //This method decrements the horizontal null count and adjusts the ending horizontal index based on empty slots.
    //It is called when there are empty slots in the crafting grid and updates the HorizontalIsNull and EndHorizontalIdex accordingly.
    private void DecrementHorizontalNull(int i, int j) //CheckCraft -
    { 
        if (i == 2 && !craftSlot[i, j].HasItem)
        { 
            if (HorizontalIsNull == 3)
            {
                HorizontalIsNull--; 
            } 
            else if (HorizontalIsNull == 2)
            {
                HorizontalIsNull--; 
            }
            else if (HorizontalIsNull == 1)
            {
                HorizontalIsNull--;
                EndHorizontalIdex--; 
            }
            return;
        }
    }
    //This method increments the vertical null count and adjusts the ending vertical index based on empty slots.
    //It is called when there are empty slots in the crafting grid and updates the VerticalIsNull and EndVerticalIdex accordingly.
    private void IncrementVerticalNull(int j, int i) //CheckCraft -
    {
        if (i == 1 && !craftSlot[j, i].HasItem && VerticalIsNull != 3)
        {
            VerticalIsNull++; 
            if (VerticalIsNull == 3)
            {
                EndVerticalIdex++;
            }
            return;
        }
    }
    //This method decrements the vertical null count and adjusts the ending vertical index based on empty slots.
    //It is called when there are empty slots in the crafting grid and updates the VerticalIsNull and EndVerticalIdex accordingly.
    private void DecrementVerticalNull(int j, int i) //CheckCraft 
    { 
        if (i == 2 && !craftSlot[j, i].HasItem)
        { 
            if (VerticalIsNull == 3)
            {
                VerticalIsNull--; 
            } 
            else if (VerticalIsNull == 2)
            {
                VerticalIsNull--; 
            }
                
            else if (VerticalIsNull == 1)
            {
                VerticalIsNull--;
                EndVerticalIdex--; 
            }
            return;
        }
    }
    //This coroutine method disables the particle system after a certain delay.
    //It is called after the particle system is played and waits for a specified duration before stopping the particle system.
    private IEnumerator CoroutineDisableParticle() //SetSecondaryItemInResultSlot 
    {
        yield return new WaitForSeconds(3);
        particlCraftSlot.Stop();
    }
    //This coroutine method manages the crafting progress.
    //It sets the isCraftingInProgress flag to true and waits for a specified duration before setting it back to false.
    //It is used to prevent repeated crafting actions during the crafting progress.
    private IEnumerator CoroutineCraftingProgress() //CraftItem -
    { 
        yield return new WaitForSeconds(1);
        isCraftingInProgress = false;
    }

}

