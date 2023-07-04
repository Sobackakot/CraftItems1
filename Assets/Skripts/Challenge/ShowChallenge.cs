using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowChallenge : MonoBehaviour
{
    public static ShowChallenge InstanceChallenge { get; private set; }
    [SerializeField] private Sprite[] spriteChallenge; 
    [SerializeField] private Image currentImageChallenge;
    [SerializeField] private TextMeshProUGUI qurrentText;
    [SerializeField] private ParticleSystem particlChallenge;
    [SerializeField] private ParticleSystem particlRezultSlot;
    [HideInInspector] public string nameItemSpriteChallenge;
    [HideInInspector] public bool isNextImageChallenge = false;
    private int countClickBackImageChallenge = 0;
    private int Index = 0; 
    
    public void Awake()
    {
        InstanceChallenge = this;
    }
    public void Start()
    {
        currentImageChallenge.sprite = spriteChallenge[Index];
        qurrentText.text = spriteChallenge[Index].name;
        nameItemSpriteChallenge = spriteChallenge[Index].name; 
        StartCoroutine(CoroutineDisableParticle());
    }
    public void ShowNextChalleng()
    {   
        StopCoroutine(CoroutineDisableParticle());
        if (countClickBackImageChallenge != 0)
        {
            countClickBackImageChallenge--;
            isNextImageChallenge = true;
        } 
        if (isNextImageChallenge)
        {
            if (ListObjectsImageRecipe.InstanceListObjects != null)
                ListObjectsImageRecipe.InstanceListObjects.objectsRecipe[Index].gameObject.SetActive(false);
            if (Index < spriteChallenge.Length - 1)
            {
                Index++;
                particlChallenge.Play();
                particlRezultSlot.Play();
            }
            else
            {
                Index = spriteChallenge.Length - 1;
            }
            if (ListObjectsImageRecipe.InstanceListObjects != null)
                ListObjectsImageRecipe.InstanceListObjects.objectsRecipe[Index].gameObject.SetActive(true);
            currentImageChallenge.sprite = spriteChallenge[Index];
            qurrentText.text = spriteChallenge[Index].name;
            nameItemSpriteChallenge = spriteChallenge[Index].name;
            StartCoroutine(CoroutineDisableParticle());
        }
        isNextImageChallenge = false;
    }
    public void ShowBackChalleng()
    {   
        StopCoroutine(CoroutineDisableParticle()); 
        if (ListObjectsImageRecipe.InstanceListObjects != null)
            ListObjectsImageRecipe.InstanceListObjects.objectsRecipe[Index].gameObject.SetActive(false);
        if (Index > 0)
        {
            Index--;
            countClickBackImageChallenge++;
            particlChallenge.Play();
            particlRezultSlot.Play();
        }
        else
        {
            Index = 0;
        }
        if (ListObjectsImageRecipe.InstanceListObjects != null)
            ListObjectsImageRecipe.InstanceListObjects.objectsRecipe[Index].gameObject.SetActive(true);
        currentImageChallenge.sprite = spriteChallenge[Index];
        qurrentText.text = spriteChallenge[Index].name;
        nameItemSpriteChallenge = spriteChallenge[Index].name;
        StartCoroutine(CoroutineDisableParticle());
    }
    public void ShowCurrentRecipiImage()
    { 
        if (ListObjectsImageRecipe.InstanceListObjects != null)
            ListObjectsImageRecipe.InstanceListObjects.objectsRecipe[Index].gameObject.SetActive(true);
    }
    private IEnumerator CoroutineDisableParticle()
    { 
        yield return new WaitForSeconds(3);
        particlChallenge.Stop();
        particlRezultSlot.Stop();
    }
}

