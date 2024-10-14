using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{   
    public static GameManager instance;

    [SerializeField] TextMeshProUGUI scoreTXT;
    [SerializeField] TextMeshProUGUI recordTXT;

    [SerializeField] GameObject startGameScreen;
    [SerializeField] GameObject gameOverScreen;

    int score;
    int record;

    bool isGameOver;
    public bool GameStarted;
    private void Awake()
    {
        instance = this;
        record = PlayerPrefs.GetInt("record", 0);
        UpdateScore();
        UpdateRecord();
        startGameScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }

    public void StartGame () 
    {
        GameStarted = true;
        startGameScreen.SetActive(false);
    }
    public void AddScore () 
    {
        if (isGameOver) return;

        score++;
        UpdateScore();

        if (score > record)
        {
            record = score;
            PlayerPrefs.SetInt("record", record);
            UpdateRecord();
        }
    }

    void UpdateScore() 
    {
        scoreTXT.text = score.ToString("00");    
    }

    void UpdateRecord() 
    {
        recordTXT.text = record.ToString("0000");
    }

    public void GameOver() 
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        Invoke("RestartGame", 1.2f);
    }

    public void RestartGame () 
    {
        SceneManager.LoadScene(0);
    }
}
