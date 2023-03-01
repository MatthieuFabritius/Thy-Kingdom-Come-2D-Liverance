using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VideoPlayerController : MonoBehaviour
{
    public float waitVideoTimer = 145.2f;
    private void Start()
    {
        StartCoroutine(waitVideo());
    }
    public IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(waitVideoTimer);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))

        { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }
    }
}