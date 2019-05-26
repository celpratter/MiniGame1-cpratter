﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    private const string AXISHORIZONTAL = "Horizontal";
    private float moveSpeed = 6.0f;
    // private int score = 0;
    // public TextMeshProUGUI pointsScore;
    private void Move()
    {
        transform.position.z == 0;
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX,
            -300f, 300f);

        transform.position = new Vector2(newPosX, transform.position.y);
    }
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     Debug.Log("TriggerEvent " + collision.gameObject.name);
    //     if (collision.gameObject.name == "Flower")
    //     {
    //         score += 5;
    //         Debug.Log("score " + score);
    //         pointsScore.text = score.ToString();
    //     }
    // }
    void Update()
    {
        Move();
    }
}