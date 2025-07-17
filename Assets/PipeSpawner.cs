using System.Threading;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject mapa;
    public float spawnRate = 2;
    private float timer = 0;
    public float heighOffset = 10;
    public List<GameObject> Mapa = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnMapa();
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
            spawnMapa();
            timer = 0;
        }

    }

    void spawnMapa()
    {
        float lowestPoint = transform.position.y - heighOffset;
        float highestPoint = transform.position.y + heighOffset;

        GameObject newObject = Instantiate(mapa, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        newObject.SetActive(true);

        Mapa.Add(newObject);

    }

    public void resetPipe()
    {

        foreach (GameObject pipe in Mapa)
        {
            Destroy(pipe);
        }
        Mapa.Clear();
    }
}
