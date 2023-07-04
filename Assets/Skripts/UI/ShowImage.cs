using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    public static ShowImage Instance;
    [SerializeField]private List<Sprite> spriteObjects; //Background
    private int Index = 0;
    [SerializeField] private Image currentImage;
    private void Start()
    { 
        Instance = this;
        currentImage.sprite = spriteObjects[Index];
    }

    public void ShowNextImage()
    {
        Index++;
        if (Index >= spriteObjects.Count)
            Index = 0;
        currentImage.sprite = spriteObjects[Index];
    }
}
