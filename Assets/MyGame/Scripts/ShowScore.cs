using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI scorePoints;
    public MyScore scoreCount;

    void Start()
    {
        scorePoints.text = scoreCount.score.ToString();
    }
}
