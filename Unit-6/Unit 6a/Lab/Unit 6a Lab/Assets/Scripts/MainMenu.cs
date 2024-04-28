using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);//loads the start menu
        Debug.Log("Scene Loaded");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();//closes the application
        Debug.Log("Quit Game");
    }    
}
