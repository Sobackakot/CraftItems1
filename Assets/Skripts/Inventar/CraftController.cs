using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    public bool HasResultItem => craftResultSlot.ItemInSlot != null;
    private bool isCraftingInProgress = false;
    private string[] resourcesItemName = new string[18]
    {
        "Wood Block", "Boards","Stick","Coal Ore","Coal","Diamond Ore","Diamond",
        "Gold Ore","Gold Ingot","Redstone Ore","Redstone","Iron Ingot","Flint","Feather","String","Trip Wire Source","Torch","Iron Nugget"
    };
    public void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>(); 
        particlCraftSlot.Stop();
    } 
    public void Init()
    {   
        craftSlot = new CraftSlot[3,3];
        CreateSlotsPrefabs();
    }
    
    private void CreateSlotsPrefabs()
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
    public void CheckCraft()
    {
        ItemInSlot newItem = null;

        int currentRecipeHorizontal = 0;
        int currentRecipeVertical = 0;
        int currentRecipeHorizontalStartIndex = -1;
        int currentRecipeVerticalStartIndex = -1;
        int horizontalIsNull = 0;
        int verticalIsNull = 0;
        for (int i = 0; i < craftSlot.GetLength(0); i++)
        {
            for (int j = 0; j < craftSlot.GetLength(1); j++)
            {
                if (craftSlot[i, j].HasItem)
                {
                    if (currentRecipeHorizontalStartIndex == -1)
                        currentRecipeHorizontalStartIndex = i;
                    currentRecipeHorizontal++;

                    if (horizontalIsNull <3)
                        horizontalIsNull =0;
                    break;
                }
                else if(currentRecipeHorizontalStartIndex != -1)
                {
                    if (i == 1 && !craftSlot[i, j].HasItem && horizontalIsNull != 3)
                    {
                        horizontalIsNull++;
                        if (horizontalIsNull == 3)
                        {   
                            currentRecipeHorizontal++;
                        }
                    }
                    else if (i ==2 && !craftSlot[i, j].HasItem)
                    {
                        if (horizontalIsNull == 3)
                            horizontalIsNull --;
                        else if(horizontalIsNull == 2)
                            horizontalIsNull--;
                        else if (horizontalIsNull == 1)
                        {
                            horizontalIsNull--;
                            currentRecipeHorizontal--;
                        } 
                    }
                } 
            }
        }
        for (int i = 0; i < craftSlot.GetLength(1); i++)
        {
            for (int j = 0; j < craftSlot.GetLength(0); j++)
            {
                if (craftSlot[j,i].HasItem)
                {
                    if (currentRecipeVerticalStartIndex == -1)
                        currentRecipeVerticalStartIndex = i; 
                    currentRecipeVertical++;

                    if (verticalIsNull <3)
                        verticalIsNull=0;
                    break;
                }
               
                else if(currentRecipeVerticalStartIndex != -1)
                {
                    if (i== 1 && !craftSlot[j,i].HasItem && verticalIsNull != 3)
                    {
                        verticalIsNull++;
                        if (verticalIsNull == 3)
                        {
                            currentRecipeVertical++;
                        }
                    }
                    else if (i ==2 && !craftSlot[j, i].HasItem )
                    {
                        if (verticalIsNull == 3)
                            verticalIsNull--;
                        else if (verticalIsNull == 2)
                            verticalIsNull --;
                        else if (verticalIsNull == 1)
                        {
                            verticalIsNull--;
                            currentRecipeVertical--;
                        } 
                    }
                } 
            }
        }
        var craftOrder = new Item.ItemId[currentRecipeHorizontal * currentRecipeVertical];
        for (int orderId = 0, i = currentRecipeHorizontalStartIndex; i < currentRecipeHorizontalStartIndex + currentRecipeHorizontal; i++) 
        {
            for (int j = currentRecipeVerticalStartIndex; j < currentRecipeVerticalStartIndex + currentRecipeVertical; j++) 
            {
                if (craftSlot[i, j].HasItem)
                {
                    craftOrder[orderId++] = craftSlot[i, j].ItemInSlot.Item.itemId;
                }
                else if (currentRecipeVertical ==3 || currentRecipeHorizontal==3)
                {
                    craftOrder[orderId++] = Item.ItemId.None;
                }
            }
        }
        foreach (var item in ItemsManager.InstanceItemManager.Items)
        {
            if (item.HasRecipe && craftOrder.SequenceEqual(item.Recipe.RecipeItemOrder))
            {
                
                newItem = new ItemInSlot(item , item.Recipe.Amount); 
                break;
            }
        } 
        if (newItem != null)
        { 
            if (ShowChallenge.InstanceChallenge.nameItemSpriteChallenge != null)
            { 
                for (int i = 0; i < resourcesItemName.Length; i++)
                {
                    string nameItem = resourcesItemName[i];
                    if (nameItem == newItem.Item.GetNameItemId())
                    {
                        craftResultSlot.SetItem(newItem);
                        m_AudioSource.PlayOneShot(craftSlotAoudio, 1f);
                        particlCraftSlot.Play();
                        StartCoroutine(CoroutineDisableParticle());
                        return;
                    }
                }
                if (ShowChallenge.InstanceChallenge.nameItemSpriteChallenge == newItem.Item.GetNameItemId())
                {
                    string copi = newItem.Item.GetNameItemId();
                    craftResultSlot.SetItem(newItem);
                    m_AudioSource.PlayOneShot(craftSlotAoudio, 1f);
                    particlCraftSlot.Play();
                    ShowChallenge.InstanceChallenge.isNextImageChallenge = true;
                    isCraftingInProgress = true;
                    StartCoroutine(CoroutineDisableParticle());
                    IsQuestCraft = true;
                    return;
                }
            }
        }
        else
        {
            craftResultSlot.ResetItem(); 
            m_AudioSource.Stop();
            particlCraftSlot.Stop();
        }      
    }
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
    private IEnumerator CoroutineDisableParticle()
    {
        yield return new WaitForSeconds(3);
        particlCraftSlot.Stop();
    }
    private IEnumerator CoroutineCraftingProgress()
    { 
        yield return new WaitForSeconds(1);
        isCraftingInProgress = false;
    }
}

