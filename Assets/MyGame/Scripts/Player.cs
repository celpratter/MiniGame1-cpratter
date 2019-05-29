﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    private const string AXISHORIZONTAL = "Horizontal";
    private float moveSpeed = 6.0f;
    public TextMeshProUGUI pointsScore;
    public MyScore scoreCount;
    void Start()
    {
        scoreCount.score = 0;
    }
    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX,
            -6f, 6f);

        transform.position = new Vector2(newPosX, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TriggerEvent " + collision.gameObject.name);
        if (collision.gameObject.name == "Flower(Clone)")
        {
            scoreCount.score += 20;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }
        if (collision.gameObject.name == "Spiegelei(Clone)")
        {
            scoreCount.score -= 10;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }
    }
    void Update()
    {
        Move();
    }
}
