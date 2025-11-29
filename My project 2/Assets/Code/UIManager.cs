using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;

    public GameObject[] health;

    public static float playTime; //게임시간
    void Start()
    {
        playTime = 0f;
        UpdateHealth();
    }

   
    void Update()
    {
        UpdatePlayTime();
        UpdateScore();
        UpdateHealth();
    }
    private void UpdatePlayTime()
    {
        playTime += Time.deltaTime;

        // 시:분:초로 변환
        TimeSpan timeSpan = TimeSpan.FromSeconds(playTime);

        // 시간을 표시
        string formattedTime = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);

        // Text 컴포넌트에 적용
        if (timeText != null)
        {
            timeText.text = "Time: " + formattedTime;
        }
    }
    private void UpdateScore()
    {
        int currentScore = Player.score;

        // Text 컴포넌트에 적용
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore;
        }
    }

    private void UpdateHealth()
    {
        int currentHealth = GameManager.health;
        for (int i = 0; i < health.Length; i++)
        {
            if (i < currentHealth)
            {
                health[i].SetActive(true);
            }
            else
            {
                health[i].SetActive(false);
            }
        }
    }
}
