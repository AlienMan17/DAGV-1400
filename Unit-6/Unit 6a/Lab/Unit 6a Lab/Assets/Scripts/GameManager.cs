using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //define variable
    public bool isGameOver;
    //defines game objects
    private GameObject gameOverText;

    private void Awake()
    {
        isGameOver = false;//when script is loaded set game over to not true
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");//gets the right object
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame();
        }
        else
        {
            gameOverText.gameObject.SetActive(false);//hides game over text
        }
    }

    void EndGame()
    {
        gameOverText.gameObject.SetActive(true);//shows game over text
    }
}
