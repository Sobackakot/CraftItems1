

using System.Collections;
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

    private bool isCraftingInProgress = false; 
    private Item.ItemId [] CraftOrder { get; set; }
    private int EndHorizontalIdex { get; set; }
    private int EndVerticalIdex { get; set; }
    private int StartHorizontalIndex { get; set; }
    private int StartVerticalIndex { get; set; }
    private int HorizontalIsNull { get; set; }
    private int VerticalIsNull { get; set; }

    public bool HasResultItem => craftResultSlot.ItemInSlot != null; 

    private string[] resourcesItemName1 = new string[11] //List of SECONDARY CRAFTS
    {
        "Доски", "Палка", "Уголь", 
        "Алмаз", "Золотой слиток", "Красная пыль" ,
        "Железный слиток","Кремень","Нить","Факел","Железный самородок"
    }; 
    private string[] resourcesItemName2 = new string[24] //List of SECONDARY CRAFTS
    {
       "Доски", "Палка", "Уголь",
        "Алмаз", "Золотой слиток", "Красная пыль" ,
        "Железный слиток","Нить","Факел","Железный самородок","Железный блок",
        "Полублок","Нажимная плита","Стекло","Красный факел","Компас","Деревянный сундук","ТНТ","Печка","Петля","Вагонетка","Лук","Поршень", "Воронка"
    };
    private string[] resourcesItemName3 = new string[128]
    { 
        "Доски","Уголь",
        "Алмаз", "Золотой слиток", "Красная пыль",
        "Железный слиток","Стекло","Красный факел","ТНТ","Печка", 
        "Доски", "Бронзовый слиток", "Бронзовая пластина", "Бронзовая оболочка",
        "Углеродное волокно", "Ткань из углеродного волокна", "Пластик из углеродного волокна",
        "Глиняная пыль", "Уголь", "Угольная пыль", "Катушка", "Композит",
        "Композитный слиток",  "Охлаждающее ядро", "Охлаждающий стержень",
        "Охлаждающие стержни", "Слиток меди", "Медная пластина", "Медная оболочка",
        "Медный провод", "Изолированный медный провод", "Алмаз", 
        "Алмазная пыль", "Раздатчик", "Двойные охлаждающие стержни",
        "Золотой провод с двойной изоляцией", "Выбрасыватель", "Электрическая печь", "Электрический реактивный ранец",
        "Электрическая лампа", "Электродвигатель", "Усилитель двигателя",
        "Кристалл энергии", "Энергетическая пыль", "Энергопак","Хранилище энергии", 
        "Кран" , "Стекловолоконная проволока", 
        "Радиомаяк", "Генератор", "Стекло", "Стеклянная панель",
        "Светящийся камень", "Светящаяся пыль", "Золотой слиток", "Золотая пластина", "Золотая оболочка",  
        "Золотой провод изолирован", "Гравитационный двигатель",
        "Закаленая сталь", "Стальная пластина", "Теплообменник", "Радиатор",
        "Высоковольтный провод с двойной изоляцией", "Высоковольтный трансформатор",
        "Высоковольтный провод", "Высоковольтный провод с изоляцией", "Улучшенный теплоотвод",
        "Улучшенный теплообменник", "Улучшенный корпус механизма",  "Железная печь",
        "Железная пластина", "Железная оболочка", "Железная токарная форма", "Лазурит", "Лазуритовая пыль",  
         "Слиток свинца", "Свинцовая пластина", "Свинцовая оболочка",
        "Свинцовая пыль", "Основной корпус механизма" ,
        "Кристалл памяти","Шаблон кристалла памяти" , "Трансформатор среднего напряжения", "Шахтерский лазер",
        "Многофункциональное энергосбережение", "Нейтронный отражатель",
        "Прибор ночного видения", "Батарея незаряженая" , "Обсидиановая пыль", "Квантовый жилет", 
        "Капсула хладагента", "Армированное стекло", "Усиленная иридиевая пластина" ,
        "Толстая свинцовая пластина", "Укрепленный камень", "Резина",  "Диоксид кремния",
        "Серебряная пыль", "Серебряный слиток", 
        "Изоляция сверхпроводника", "Сверхпроводник", "Серная пыль", "Телепорт", "Катушка Тесла",
        "Утолщенный отражатель нейтронов", "Оловянная пыль", "Оловянный слиток",
        "Оловяная проволока", "Оловянная проволока изолирована",
        "Улучшенный лаппак", "Железная решетка",
        "Универсальная жидкая капсула", "Электросхема",
         "Нановолоконный жилет","Ускоритель", "Ултимейт лаппак",
        "Геотермальный генератор", "Оболочка реактора", "Реакторная камера",
        "Улучшенная электросхема", "Кристалл азуретрона", "Улучшенный аккумулятор",
        "Золотой провод", "Лазуритовая пластина", "Теплоемкая реакторная плита", "Оловяная пластина","Оловяная оболочка"
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

