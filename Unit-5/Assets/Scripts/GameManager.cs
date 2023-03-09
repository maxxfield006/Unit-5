using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    int score;

    TossObjects tOScript;

    void Start()
    {
        score = 0;

        gameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tOScript.gameOver)
        {
            gameOverText.enabled = true;
        }
    }
    

    public void updateScore(int scoreToUpdate)
    {
        score += scoreToUpdate;
        scoreText.text = "Score: " + score;
    }
    
}
