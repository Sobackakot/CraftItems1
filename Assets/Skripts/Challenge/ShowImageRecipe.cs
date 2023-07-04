using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImageRecipe : MonoBehaviour
{   
    public static ShowImageRecipe InstanceRecipe { get; private set; }
    [SerializeField] private Sprite[] spritesRecipe;
    [SerializeField] private Image qurrentSpriteRecipe;
    private int IndexSprite = 0;
    public void Awake()
    {
            InstanceRecipe = this;
    }
    public void Start()
    {
        qurrentSpriteRecipe.sprite = spritesRecipe[0];
    }
    public void ShowNextRecipeImage()
    {   
        if (IndexSprite >= spritesRecipe.Length - 1)
            return;
        else
            IndexSprite++;
        qurrentSpriteRecipe.sprite = spritesRecipe[IndexSprite];
    }
    public void ShowBackRecipeImage()
    {
        if (IndexSprite <= 0)
            return;
        else
            IndexSprite--;
        qurrentSpriteRecipe.sprite = spritesRecipe[IndexSprite];
    }
}
