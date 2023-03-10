using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject ContinuePanel;
    public GameObject NewGamePanel;
    public GameObject LoadGamePanel;
    public GameObject SettingsPanel;
    public GameObject HelpsPanel;
    public GameObject DLCsPanel;
    public GameObject CreditsPanel;

    public GameObject ContinueButton;
    public GameObject NewGameButton;
    public GameObject LoadGameButton;
    public GameObject SettingsButton;
    public GameObject HelpsButton;
    public GameObject DLCsButton;
    public GameObject CreditsButton;

    public AudioSource audioSource;
    public AudioClip buttonClick;
    public void OpenContinuePanel()
    {
        audioSource.PlayOneShot(buttonClick);
        CloseAllPanels();
        ContinuePanel.SetActive(true);
    }

    public void CloseContinuePanel()
    {
        ContinuePanel.SetActive(false);
    }

    public void OpenNewGamePanel()
    {
        audioSource.PlayOneShot(buttonClick);
        CloseAllPanels();
        NewGamePanel.SetActive(true);
    }
    
    public void CloseNewGamePanel()
    {
        NewGamePanel.SetActive(false);
    }

    public void OpenLoadGamePanel()
    {
        audioSource.PlayOneShot(buttonClick);
        CloseAllPanels();
        LoadGamePanel.SetActive(true);
    }

    public void CloseLoadGamePanel()
    {
        LoadGamePanel.SetActive(false);
    }

    public void OpenSettingsPanel()
    {
        audioSource.PlayOneShot(buttonClick);
        CloseAllPanels();
        SettingsPanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        SettingsPanel.SetActive(false);
    }

    public void OpenHelpsPanel()
    {
        audioSource.PlayOneShot(buttonClick);
        CloseAllPanels();
        HelpsPanel.SetActive(true);
    }

    public void CloseHelpsPanel()
    {
        HelpsPanel.SetActive(false);
    }
    public void OpenDLCsPanel()
    {
        audioSource.PlayOneShot(buttonClick);
        CloseAllPanels();
        DLCsPanel.SetActive(true);
    }

    public void CloseDLCsPanel()
    {
        DLCsPanel.SetActive(false);
    }
    public void OpenCreditsPanel()
    {
        audioSource.PlayOneShot(buttonClick);
        CloseAllPanels();
        CreditsPanel.SetActive(true);
    }
    public void CloseCreditsPanel()
    {
        CreditsPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void OpenPlayButton()
    {
        CloseAllPanels();
        audioSource.PlayOneShot(buttonClick);
        ContinueButton.SetActive(true);
        NewGameButton.SetActive(true);
        LoadGameButton.SetActive(true);
    }

    public void OpenOptionsButton()
    {
        CloseAllPanels();
        audioSource.PlayOneShot(buttonClick);
        HelpsButton.SetActive(true);
        SettingsButton.SetActive(true);
        DLCsButton.SetActive(true);
        CreditsButton.SetActive(true);
    }
public void CloseAllPanels()
    {
        ContinuePanel.SetActive(false);
        NewGamePanel.SetActive(false);
        LoadGamePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        HelpsPanel.SetActive(false);
        DLCsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        ContinueButton.SetActive(false);
        NewGameButton.SetActive(false);
        LoadGameButton.SetActive(false);
        SettingsButton.SetActive(false);
        HelpsButton.SetActive(false);
        DLCsButton.SetActive(false);
        CreditsButton.SetActive(false);
        // autre panels
    }
}