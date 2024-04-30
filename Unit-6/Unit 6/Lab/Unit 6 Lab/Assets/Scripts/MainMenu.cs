using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    public AudioClip click;
    private AudioSource menuAudio;
    // Start is called before the first frame update
    private void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        menuAudio.PlayOneShot(click);
        SceneManager.LoadScene(sceneToLoad);//loads the start menu
        Debug.Log("Scene Loaded");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        menuAudio.PlayOneShot(click);
        Application.Quit();//closes the application
        Debug.Log("Quit Game");
    }    
}
