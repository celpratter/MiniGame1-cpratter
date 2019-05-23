using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public Flower flowerPrefab;
    public GameObject flowerParent;

    private void SpawnFlower()
    {
        float flowerSize = 0.2f;
        Flower flowerClone = (Flower)Instantiate(flowerPrefab, transform.position, transform.rotation);
        flowerClone.transform.SetParent(flowerParent.transform);
        flowerClone.transform.localPosition = new Vector3(Random.Range(-6f, 6f), flowerParent.transform.position.y, 0f);
        flowerClone.transform.localScale = new Vector3(flowerSize, flowerSize, 0);
        flowerClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-7, -5));
    }
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnFlower();
        }

    }
}
