using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody2d;

    // Use this for initialization
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody2d.velocity = new Vector2(speed * -1, 0f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody2d.velocity = new Vector2(speed * 1, 0f);
        }

    }
}
