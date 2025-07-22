using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighestScore : MonoBehaviour
{
    private int highScore = 0;
    public Manager Manager;
    public TextMeshProUGUI highestScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.score > highScore)
        {
            highScore = Manager.score;
            highestScore.text = "Highest Score: " + highScore;

        }
    }
}
