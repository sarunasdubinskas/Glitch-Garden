using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenLoader : MonoBehaviour
{
    SceneLoader sceneLoader;
    [SerializeField] float waitTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        StartCoroutine(LoadStartSceneAfterWaiting());
    }

    private IEnumerator LoadStartSceneAfterWaiting()
    {
        yield return new WaitForSeconds(waitTime);
        sceneLoader.LoadMainMenu();
    }
}
