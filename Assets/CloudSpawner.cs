using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnRate = 3f;
    private float timer = 0f;
    public float heightOffset = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0f;
        }
    }

    void SpawnCloud()
    {
        float minY = transform.position.y - heightOffset;
        float maxY = transform.position.y + heightOffset;
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(minY, maxY), 0f);

        GameObject newCloud = Instantiate(cloudPrefab, spawnPosition, Quaternion.identity);
        newCloud.SetActive(true);
    }
}
