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
    public float gapSize = 5f;
    public float minGapSize = 2f;
    public float gapDecreaseRate = 0.1f;
    public Manager Manager;
    public List<GameObject> Mapa = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnMapa();
    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.CurrentState == GameState.InGame)
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

    }

    void spawnMapa()
    {
        float lowestPoint = transform.position.y - heighOffset;
        float highestPoint = transform.position.y + heighOffset;

        float centerY = Random.Range(lowestPoint + gapSize / 2, highestPoint - gapSize / 2);

        Vector3 position = new Vector3(
            transform.position.x, //x
            centerY, //y
            0); //z
        //GameObject newPipe = Instantiate(mapa, new Vector3(1,1,1));
        GameObject newObject = Instantiate(mapa, position, transform.rotation);
        newObject.SetActive(true);

        Mapa.Add(newObject);

        gapSize = Mathf.Max(minGapSize, gapSize - gapDecreaseRate * Time.deltaTime);

        Transform topPipeTransform = newObject.transform.GetChild(0);
        Transform bottomPipeTransform = newObject.transform.GetChild(1);

        topPipeTransform.localPosition = topPipeTransform.localPosition + new Vector3(0, gapSize, 0);
        bottomPipeTransform.localPosition = bottomPipeTransform.localPosition - new Vector3(0, gapSize, 0);



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
