using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public float jumpStregnth;
    public Rigidbody2D rigidbody;
    public Manager Manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        // if (Input.GetKeyDown(KeyCode.UpArrow))
        // {
        //     Debug.Log("Up was pressed");
        // }
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("hi");
        Manager.GameOver();

    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            rigidbody.linearVelocityY = jumpStregnth;
        }

    }


}
