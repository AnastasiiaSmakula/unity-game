using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public Manager Manager;
    public bool HasScored;
    public float HowFastToGetHarder;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        // CheckForScore();

        if (Manager.CurrentState == GameState.StartGame)
        {
        }
        else if (Manager.CurrentState == GameState.InGame)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime * (Manager.Difficulty * HowFastToGetHarder);
            CheckForScore();


        }
        else
        {
        }
    }

    void CheckForScore()
    {
        if (transform.position.x <= -20 && !HasScored)
        {
            Manager.IncreaseScore();
            HasScored = true;
        }
        ;

    }

}