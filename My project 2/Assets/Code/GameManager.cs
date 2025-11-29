using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isLive;
    public static int health = 3;

    void Start()
    {
        isLive = true;
    }
    public static void GameStart()
    {

    }
    public static void GameOver()
    {
        SceneManager.LoadScene("End");
    }
    public static void DataClear()
    {
        isLive = false;
        Player.score = 0;
        health = 3;
    }
    public static void GetItem()
    {
        Player.score += 100;
    }

    public static void Damage()
    {
        health--;

        if (health == 0) {
            GameOver();
        }
    }

    public static void Clear()
    {
        Player.score += 1000;
        SceneManager.LoadScene("End");
    }

}
