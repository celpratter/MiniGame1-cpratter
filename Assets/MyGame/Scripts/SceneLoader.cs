using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string sceneMain = "Main";
    private string sceneEnd = "End";
    private string sceneIntro = "Intro";
    public void LoadSceneMain()
    {
        SceneManager.LoadScene(sceneMain);
    }

    public void LoadSceneEnd()
    {
        SceneManager.LoadScene(sceneEnd);
    }

    public void LoadSceneIntro()
    {
        SceneManager.LoadScene(sceneIntro);
    }
}
