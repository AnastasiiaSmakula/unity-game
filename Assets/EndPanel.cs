using UnityEngine;

public class EndPanel : MonoBehaviour
{
    public Manager Manager;
    public GameObject VisualPart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame (if active)
    void Update()
    {
        if (Manager.CurrentState == GameState.InGame)
        {
            VisualPart.SetActive(false);

        }
        else if (Manager.CurrentState == GameState.EndGame)
        {
            VisualPart.SetActive(true);

        }

    }
}
