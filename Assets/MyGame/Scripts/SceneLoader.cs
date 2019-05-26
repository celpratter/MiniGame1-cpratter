using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadSceneMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadSceneEnd()
    {
        SceneManager.LoadScene("End");
    }

    public void LoadSceneIntro()
    {
        SceneManager.LoadScene("Intro");
    }
}
