using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AudioPlyerControler : MonoBehaviour
{
    public float waitVideoTimer = 145.2f;
    public string sceneName;
    private void Start()
    {
        StartCoroutine(waitVideo());
    }
    public IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(waitVideoTimer);
        SceneManager.LoadScene(sceneName);
    }
}