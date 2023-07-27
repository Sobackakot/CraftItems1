using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowChallenge : MonoBehaviour
{
    private ListObjectsImageRecipe listObjectImajeRecipe;
    public static ShowChallenge InstanceChallenge { get; private set; }
    [SerializeField] private Sprite[] spriteChallenge; 
    [SerializeField] private Image currentImageChallenge;
    [SerializeField] private TextMeshProUGUI currentTextChallenge;
    [SerializeField] private GameObject buttonsRecipe;
    [SerializeField] private ParticleSystem particlChallenge;
    [SerializeField] private ParticleSystem particlRezultSlot;

    [HideInInspector] public string nameItemSpriteChallenge;
    [HideInInspector] public bool isNextImageChallenge = false;
    private int countClickBackImageChallenge = 0;
    [HideInInspector] public int Index = 0;
    
    public void Awake()
    {
        InstanceChallenge = this;
        listObjectImajeRecipe = ListObjectsImageRecipe.InstanceListObjects;
    }
    public void Start()
    {
        Load(Index);
    }

    public void Load(int index)
    {
        Index = index;
        currentImageChallenge.sprite = spriteChallenge[Index];
        currentTextChallenge.text = spriteChallenge[Index].name;
        nameItemSpriteChallenge = spriteChallenge[Index].name;
        StartCoroutine(CoroutineDisableParticle());
    }
    //This method shows the next challenge image. It checks if there are any clicks
    //on the back button (countClickBackImageChallenge) and decreases the count if it's not zero.
    //It sets the isNextImageChallenge flag to true. If the flag is true, it deactivates the current challenge object,
    //gets the next index for the challenge, updates the current image challenge, text, and the name of the sprite challenge.
    //It also starts the coroutine to disable the particle system. Finally, it resets the isNextImageChallenge flag to false.
    public void ShowNextChalleng()
    {
        if (countClickBackImageChallenge != 0)
        {
            countClickBackImageChallenge--;
            isNextImageChallenge = true;
        }
        if (isNextImageChallenge)
        {
            listObjectImajeRecipe.objectsRecipe[Index].gameObject.SetActive(false);
            buttonsRecipe.gameObject.SetActive(false);
            GetNextIndexChallenge(); 
            currentImageChallenge.sprite = spriteChallenge[Index];
            currentTextChallenge.text = spriteChallenge[Index].name;
            nameItemSpriteChallenge = spriteChallenge[Index].name;
            StartCoroutine(CoroutineDisableParticle()); 
        }
        isNextImageChallenge = false;
    }
    //This method shows the previous challenge image.
    //It deactivates the current challenge object, gets the previous index for the challenge,
    //updates the current image challenge, text, and the name of the sprite challenge.
    //It starts the coroutine to disable the particle system.
    public void ShowBackChalleng()
    {
        listObjectImajeRecipe.objectsRecipe[Index]?.gameObject.SetActive(false);
        buttonsRecipe.gameObject.SetActive(false);
        GetBackIndexChallenge(); 
        currentImageChallenge.sprite = spriteChallenge[Index];
        currentTextChallenge.text = spriteChallenge[Index].name;
        nameItemSpriteChallenge = spriteChallenge[Index].name;
        StartCoroutine(CoroutineDisableParticle());
        
    }
    //This method shows the current recipe image. It activates the current challenge object.
    public void ShowCurrentRecipiImage()
    {
         listObjectImajeRecipe.objectsRecipe[Index]?.gameObject.SetActive(true);
        buttonsRecipe.gameObject.SetActive(true);
    }
    //This method retrieves the next index for the challenge.
    //If the current index is less than the total number of sprite challenges minus one,
    //it increments the index, plays the particle systems, and returns the new index.
    //If the current index is the last index, it returns the current index without incrementing.
    private void GetNextIndexChallenge()
    {
        if (Index < spriteChallenge.Length - 1)
        {   
            particlChallenge.Play();
            particlRezultSlot.Play();
             Index++;
        }
        else Index = spriteChallenge.Length - 1;
    }
    //This method retrieves the previous index for the challenge.
    //If the current index is greater than zero, it decrements the index,
    //increments the count of clicks on the back button, plays the particle systems, and returns the new index.
    //If the current index is zero, it returns the current index without decrementing.
    private void GetBackIndexChallenge()
    {
        if (Index > 0)
        { 
            countClickBackImageChallenge++;
            particlChallenge.Play();
            particlRezultSlot.Play();
            Index--;
        }
        else Index = 0; 
    }
    //This coroutine method disables the particle system after a certain delay.
    //It waits for a specified duration and stops the particle system.
    private IEnumerator CoroutineDisableParticle()
    { 
        yield return new WaitForSeconds(3);
        particlChallenge.Stop();
        particlRezultSlot.Stop();
    }
}

