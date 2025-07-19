using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public Manager Manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.CurrentState == GameState.InGame)
        {
            gameObject.SetActive(false);

        }

    }
}
