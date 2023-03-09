using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip PointerEnterSound;
    public Button button;
    public Sprite newSprite;
    public Sprite originalSprite;
   

    public void PointerEnter()
    {
        audioSource.PlayOneShot(PointerEnterSound);
        button.image.sprite = newSprite;
    }

    public void PointerExit()
    {
        button.image.sprite = originalSprite;
    }

}