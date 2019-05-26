using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI pointsScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Flower")
        {
            score += 20;
            pointsScore.text = score.ToString();
            Debug.Log("Trigger");
        }

    }



}
