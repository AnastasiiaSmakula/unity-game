using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public Manager Manager;
    public bool HasScored;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = new Vector3(transform.position.x - 0.01f, 1.6f, 0);
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        CheckForScore();
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
