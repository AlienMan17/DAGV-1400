using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //defines variables
    public int score;
    public TextMeshProUGUI scoreText;
    public AudioClip enemyExplosion;
    private AudioSource enemyAudio;

    private void Start()
    {
        enemyAudio = GetComponent<AudioSource>();//gets the audio source component
    }
    public void IncreaseScore(int amount, bool isEnemy)
    {
        if (isEnemy)
        {
            enemyAudio.PlayOneShot(enemyExplosion);//playes enemy explosion sound
        }
        score += amount;//increases score
        UpdateScore();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;//decreases score
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;//sets the score text to the score value
    }
}
