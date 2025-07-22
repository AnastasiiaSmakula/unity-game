using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public enum GameState
{
    StartGame,
    InGame,
    EndGame
}

public class Manager : MonoBehaviour
{
    public BirdScript Bird;
    public PipeSpawner Pipe;
    public CloudSpawner Clouds;
    public int score = 0;
    public GameState CurrentState;

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
        CurrentState = GameState.EndGame;
        Pipe.resetPipe();
        Bird.transform.position = new Vector3(0, 0, 0);
        Bird.rigidbody.linearVelocityY = 0;
        Clouds.resetClouds();
    }

    public void IncreaseScore()
    {
        score++;

    }

    public void ResetScore()
    {

        score = 0;

    }

    public void StartGame()
    {
        CurrentState = GameState.InGame;
        ResetScore();
    }
}