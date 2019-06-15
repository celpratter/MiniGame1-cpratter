using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    private const string AXISHORIZONTAL = "Horizontal";
    private float moveSpeed = 6.0f;
    public TextMeshProUGUI pointsScore;
    public MyScore scoreCount;
    SpriteRenderer spriteColor;
    private float leftBoundary = -6f;
    private float rightBoundary = 6f;
    private string nameFlower = "Flower(Clone)";
    private string nameSeeds = "Seeds(Clone)";
    private string nameSpiegelei = "Spiegelei(Clone)";
    void Start()
    {
        scoreCount.score = 0;
        spriteColor = GetComponent<SpriteRenderer>();
    }
    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX,
            leftBoundary, rightBoundary);

        transform.position = new Vector2(newPosX, transform.position.y);
    }
    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TriggerEvent " + collision.gameObject.name);
        if (collision.gameObject.name == nameFlower)
        {
            scoreCount.score += 20;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }
        if (collision.gameObject.name == nameSeeds)
        {
            scoreCount.score += 20;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
        }
        if (collision.gameObject.name == nameSpiegelei)
        {
            scoreCount.score -= 10;
            Debug.Log("score " + scoreCount.score);
            pointsScore.text = scoreCount.score.ToString();
            spriteColor.color = new Color(1, 0, 0, 1);
            yield return new WaitForSeconds(0.1f);
            spriteColor.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.1f);
            spriteColor.color = new Color(1, 0, 0, 1);
            yield return new WaitForSeconds(0.1f);
            spriteColor.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.1f);
            spriteColor.color = new Color(1, 0, 0, 1);
            yield return new WaitForSeconds(0.1f);
            spriteColor.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.1f);

        }
    }
    void Update()
    {
        Move();
    }
}
