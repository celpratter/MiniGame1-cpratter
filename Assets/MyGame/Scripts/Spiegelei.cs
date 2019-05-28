using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiegelei : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Collider")
        {
            Destroy(gameObject);
        }
    }
}