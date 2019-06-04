using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int timeLeft = 60;
    public TextMeshProUGUI countdown;

    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }
    void Update()
    {
        countdown.text = ("00:" + timeLeft);
        if (timeLeft == 0)
        {
            SceneManager.LoadScene("End");
        }
    }

    IEnumerator LoseTime()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
