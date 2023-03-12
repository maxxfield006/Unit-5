using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI playerLivesText;
    public TextMeshProUGUI retryButton;

    int score;

    playerLives playerLives;

    void Start()
    {
        score = 0;

        gameOverText.enabled = false;
        retryButton.enabled = false;

        playerLives = GameObject.Find("lives").GetComponent<playerLives>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLives.lives < 1)
        {
            gameOverText.enabled = true;
            retryButton.enabled = true; 
        }
    }
    

    public void updateScore(int scoreToUpdate)
    {
        score += scoreToUpdate;
        scoreText.text = "Score: " + score;
    }
    public void lifeText(int lives)
    {
        playerLives.lives -= lives;
        playerLivesText.text = "Lives: " + playerLives.lives;
    }
    
}
