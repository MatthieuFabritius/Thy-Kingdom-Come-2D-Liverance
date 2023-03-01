using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip PointerEnterSound;
    public GameObject arrow;

    public void PointerEnter()
    {
        audioSource.PlayOneShot(PointerEnterSound);
        arrow.SetActive(true);
    }

    public void PointerExit()
    {
        arrow.SetActive(false);
    }

}