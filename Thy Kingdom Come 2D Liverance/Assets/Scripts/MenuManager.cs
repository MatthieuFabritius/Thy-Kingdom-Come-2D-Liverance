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

    public AudioSource audioSource;
    public AudioClip buttonClick;
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

    public void CloseAllPanels()
    {
        ContinuePanel.SetActive(false);
        NewGamePanel.SetActive(false);
        LoadGamePanel.SetActive(false);
        SettingsPanel.SetActive(false);
        HelpsPanel.SetActive(false);
        DLCsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        // autre panels
    }
}