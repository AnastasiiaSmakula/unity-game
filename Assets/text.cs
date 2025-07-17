using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Manager manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + manager.score;

    }
}