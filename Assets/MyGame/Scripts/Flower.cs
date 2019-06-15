using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public Animator anim;
    private string player = "Player";
    private string animationTrigger = "trigger";
    private string colliderGround = "Collider";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == player)
        {
            anim.SetTrigger(animationTrigger);
            Destroy(gameObject);
        }
        if (collision.gameObject.name == colliderGround)
        {
            Destroy(gameObject);
        }
    }
}