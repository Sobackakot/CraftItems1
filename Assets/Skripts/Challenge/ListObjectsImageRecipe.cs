using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListObjectsImageRecipe : MonoBehaviour
{   
    public static ListObjectsImageRecipe InstanceListObjects { get; private set; }
    public GameObject [] objectsRecipe;
    [SerializeField] private GameObject recipeGameObject;
    public void Awake()
    {
        InstanceListObjects = this;
    }
    public void Start()
    {
        recipeGameObject.gameObject.SetActive(false);
        objectsRecipe[0].gameObject.SetActive(true);
    } 
}
