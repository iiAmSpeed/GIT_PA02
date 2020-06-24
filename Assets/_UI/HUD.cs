﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public static HUD HUDManager;
    [SerializeField] private Text Txt_Score = null;
    [SerializeField] private Image Image_Lives = null;
    [SerializeField] private Text Txt_Message = null;
 
    void Start()
    {
        HUDManager = this;
    }

    public void UpdateScore()
    {
        GameManager.Score += 1;
        Txt_Score.text = "SCORE : " + GameManager.Score;
        

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    //updates the number of hearts for lives
    public void UpdateLives()
    {
        
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.Lives * 50, 30);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("GameOver");
        GameManager.CurrentState = GameManager.GameState.GameOver;
        Txt_Message.color = Color.red;
        Txt_Message.text = "GAME OVER! \n PRESS ENTER TO RESTART GAME.";
        UpdateScore();
    }

    public void DismissMessage()
    {
        Txt_Message.text = "";
    }
}
