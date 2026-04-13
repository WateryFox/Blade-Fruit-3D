using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        scoreText.text = "Score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        score += 100;
        scoreText.text = score + " ";
    }
}
