using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLives : MonoBehaviour
{
    public int lives = 3;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        gm = GameObject.Find("GameMangaer").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void removeLives()
    {
        lives--;
        gm.lifeText(lives);
    }
}
