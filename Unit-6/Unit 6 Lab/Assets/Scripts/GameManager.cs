using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //define variable
    public bool isGameOver;
    //defines game objects
    private GameObject gameOverText;
    private GameObject mainMenuButton;

    private void Awake()
    {
        isGameOver = false;//when script is loaded set game over to not true
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");//gets the right object
        mainMenuButton = GameObject.Find("Return");//get the button
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
            mainMenuButton.gameObject.SetActive(false);//hides main menu button
        }
    }

    void EndGame()
    {
        gameOverText.gameObject.SetActive(true);//shows game over text
        mainMenuButton.gameObject.SetActive(true);//shows main menu button
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);//loads the start menu scene
    }
}
