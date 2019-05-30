using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeds : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            anim.SetTrigger("trigger");
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Collider")
        {
            Destroy(gameObject);
        }
    }
}
