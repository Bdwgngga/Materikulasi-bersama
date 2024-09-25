using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LoadSceneSync("Scene1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LoadSceneSync("Scene2");
        }
    }

    void LoadSceneSync(string targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }

    void LoadSceneSync(int targetSceneIndex)
    {
        SceneManager.LoadScene(targetSceneIndex);
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation loadingScene = SceneManager.LoadSceneAsync("SceneB");
        while (!loadingScene.isDone)
        {
            // kalkulasi berapa persen loadnya
            // nampilin loading screen
            yield return null;
        }
    }
}
