using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowImageRecipe : MonoBehaviour
{   
    public static ShowImageRecipe InstanceRecipe { get; private set; }
    [SerializeField] private Sprite[] spritesRecipe;
    [SerializeField] private Image qurrentSpriteRecipe;
    [SerializeField] private TextMeshProUGUI textNameRecipe;
    private int IndexSprite = 0;
    public void Awake()
    {
            InstanceRecipe = this;
    }
    public void Start()
    {
        qurrentSpriteRecipe.sprite = spritesRecipe[0];
        textNameRecipe.text = spritesRecipe[0].name;
    }
    public void ShowNextRecipeImage()
    {   
        if (IndexSprite >= spritesRecipe.Length - 1)
            return;
        else
        { 
            IndexSprite++;
        }
            
        qurrentSpriteRecipe.sprite = spritesRecipe[IndexSprite];
        textNameRecipe.text = spritesRecipe[IndexSprite].name; 
    }
    public void ShowBackRecipeImage()
    {
        if (IndexSprite <= 0)
            return;
        else
        { 
            IndexSprite--;
        }
           
        qurrentSpriteRecipe.sprite = spritesRecipe[IndexSprite];
        textNameRecipe.text = spritesRecipe[IndexSprite].name;
    }
}
