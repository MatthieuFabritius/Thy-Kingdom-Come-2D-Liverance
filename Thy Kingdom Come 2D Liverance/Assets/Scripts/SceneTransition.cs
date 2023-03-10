using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public Image blackScreen;
    public float fadeDuration = 1.0f;

    private bool isFading = false;

    void Start()
    {
        // fade in from black when the scene starts
        StartCoroutine(FadeIn());
    }

    void Update()
    {
        // check if the "Jump" button (spacebar) is pressed and not already fading
        if (Input.GetKeyDown(KeyCode.Space) && !isFading)
        {
            // start the transition to the next scene
            StartCoroutine(TransitionToNextScene());
        }
    }

    IEnumerator FadeIn()
    {
        // set the initial alpha of the black screen to fully opaque (1.0f)
        blackScreen.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);

        // set the isFading flag to true to prevent multiple fades at once
        isFading = true;

        // fade the black screen to fully transparent (0.0f) over the specified duration
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(1.0f, 0.0f, elapsedTime / fadeDuration);
            blackScreen.color = new Color(0.0f, 0.0f, 0.0f, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // set the isFading flag to false to allow future fades
        isFading = false;
    }

    IEnumerator FadeOut()
    {
        // set the initial alpha of the black screen to fully transparent (0.0f)
        blackScreen.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);

        // set the isFading flag to true to prevent multiple fades at once
        isFading = true;

        // fade the black screen to fully opaque (1.0f) over the specified duration
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Lerp(0.0f, 1.0f, elapsedTime / fadeDuration);
            blackScreen.color = new Color(0.0f, 0.0f, 0.0f, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // set the isFading flag to false to allow future fades
        isFading = false;
    }

    IEnumerator TransitionToNextScene()
    {
        // fade out to black before loading the next scene
        yield return StartCoroutine(FadeOut());

        // load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        // fade in from black after loading the next scene
        yield return StartCoroutine(FadeIn());
    }
}