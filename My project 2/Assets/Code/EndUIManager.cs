using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndUIManager : MonoBehaviour
{
    public Text EndscoreText;
    public Text EndtimeText;
    public Text Title;

    AudioSource myAudio;
    public AudioClip clear;
    public AudioClip gameover;

    void Awake()
    {
        myAudio = GetComponent<AudioSource>();
    }
    void Start()
    {
        int currentScore = Player.score;
        if(currentScore >= 1000)
        {
            Title.text = "게임 클리어!";
            myAudio.clip = clear;
            myAudio.Play();
        }
        else
        {
            Title.text = "게임 오버...";
            myAudio.clip = gameover;
            myAudio.Play();
        }
        // 시:분:초로 변환
        TimeSpan timeSpan = TimeSpan.FromSeconds(Score.playTime);

        // 시간을 표시
        string formattedTime = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        if (EndtimeText != null)
        {
            EndtimeText.text = "플레이 시간 " + formattedTime;
        }

        if (EndscoreText != null)
        {
            EndscoreText.text = "게임 스코어 " + currentScore + "점";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
