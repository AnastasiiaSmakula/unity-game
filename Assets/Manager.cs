using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public BirdScript Bird;
    public PipeSpawner Pipe;
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        Pipe.resetPipe();
        Bird.transform.position = new Vector3(0, 0, 0);
        Bird.rigidbody.linearVelocityY = 0;
        ResetScore();
    }

    public void IncreaseScore()
    {
        score++;

    }

    public void ResetScore()
    {
        score = 0;

    }
}


// 1. Vytvorit script na Text (TMP) v UI aby mohol nastavit text
// 2. Vypocitat skore podla pipespawner
// 3. Likonvat Score script aj tu
// 3. Tu, v Update(), posunut skore s pipeswanera do SCore script :)
