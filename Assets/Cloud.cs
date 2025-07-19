using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Manager Manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.CurrentState == GameState.StartGame)
        {
        }
        else if (Manager.CurrentState == GameState.InGame)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if (transform.position.x < -30f)
            {
                Destroy(gameObject);
            }


        }
        else
        {
        }

    }
}
