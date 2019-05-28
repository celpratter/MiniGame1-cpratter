using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{
    public Flower flowerPrefab;
    public GameObject flowerParent;
    public Spiegelei eiPrefab;
    public GameObject eiParent;

    private void SpawnFlower()
    {
        float flowerSize = 0.2f;
        Flower flowerClone = (Flower)Instantiate(flowerPrefab, transform.position, transform.rotation);
        flowerClone.transform.SetParent(flowerParent.transform);
        flowerClone.transform.localPosition = new Vector3(Random.Range(-6f, 6f), flowerParent.transform.position.y, 0f);
        flowerClone.transform.localScale = new Vector3(flowerSize, flowerSize, 0);
        flowerClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-7, -5));
    }
    private void SpawnEi()
    {
        float eiSize = 0.2f;
        Spiegelei eiClone = (Spiegelei)Instantiate(eiPrefab, transform.position, transform.rotation);
        eiClone.transform.SetParent(flowerParent.transform);
        eiClone.transform.localPosition = new Vector3(Random.Range(-6f, 6f), flowerParent.transform.position.y, 0f);
        eiClone.transform.localScale = new Vector3(eiSize, eiSize, 0);
        eiClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-7, -5));
    }
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            SpawnFlower();
            yield return new WaitForSeconds(1);
            SpawnEi();
        }

    }
}
