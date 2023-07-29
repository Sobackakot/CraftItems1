using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private AudioSource m_AudioSource;
    public AudioClip clickButton;
    public SaveController m_DataSaver;
    public InventoryUpdater inventoryUpdater;


    public void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    // UI Menu
    public void OpenIventoryButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
    }
    public void RestartChallengeButton()
    {
        inventoryUpdater.ResetInvetory();
    }
    public void RestartGameButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        m_DataSaver.RemoveSave();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitGameButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        Application.Quit();
    }
    public void TurnOnMusickButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        MusicBackground.InstanceMusick.TurnOnMusic();
    }
    public void TurnOffMusickButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        MusicBackground.InstanceMusick.TurnOffMusic();
    }
    public void NextImageBackgroundButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        ShowImage.Instance.ShowNextImage();
    }
    //UI Main
    public void RateGameCloseButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
    }
    public void PouseButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
    }

    public void ShowRecipeCurrentImageButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f); 
        ShowChallenge.InstanceChallenge.ShowCurrentRecipiImage();
    }
    public void NextImageButtonChallenge()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        if (!InventoryWindow.InstanceInventory.craftController.HasResultItem)
            ShowChallenge.InstanceChallenge.ShowNextChalleng();
    }
    public void BackImageButtonChallenge()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        if (!InventoryWindow.InstanceInventory.craftController.HasResultItem)
            ShowChallenge.InstanceChallenge.ShowBackChalleng();
    }
    public void CloseRecipeImageButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
    }
    public void NextRecipeImageButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        ShowImageRecipe.InstanceRecipe.ShowNextRecipeImage();
    }
    public void BackRecipeImageButton()
    {
        m_AudioSource.PlayOneShot(clickButton, 1f);
        ShowImageRecipe.InstanceRecipe.ShowBackRecipeImage();
    }

}
