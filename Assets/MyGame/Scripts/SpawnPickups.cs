using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{

    public GameObject flower;
    // public GameObject seeds;
    // public GameObject cheese;
    // public GameObject egg;

    public float spawnTime = 2f;
    private float timer = 0;
    private int randomNumber;
    public float fallSpeed;

    // Use this for initialization
    public void SpawnRandom()
    {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width),
         Random.Range(900, Screen.height), Camera.main.farClipPlane / 2));

        Instantiate(flower, screenPosition, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            SpawnRandom();
            timer = 0;
        }
    }
}
