using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour
{   string levelkey = "level";
    int wincndtn1;
    int wincndtn2;
    public bool gameHasEnded = false;
    int goal = 20;
    int level = 1;
    public TextMeshProUGUI goaltext;
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            GameOverScreen();
        }
    }
    public void LevelComplete()
    {
        int levelvalueold = (PlayerPrefs.GetInt(levelkey));
        int levelvaluenew = levelvalueold + 1;
        PlayerPrefs.SetInt(levelkey, levelvaluenew);
        Debug.Log(levelvaluenew);
        SceneManager.LoadScene("LevelComplete");
    }
    public void GameOverScreen()
    {
        SceneManager.LoadScene("GameOverMenu");
    }
    private void Start()
    {
        Advertisement.Banner.Hide();
        try
        {
            level = PlayerPrefs.GetInt(levelkey);
        }
        catch
        {

        }
        if (level > 20)
        {
            goal = goal + ((level - 20) * 2); 
        }
        string showonscreen = "SHOOT DOWN " + goal.ToString() + " JETS AND PISS OFF PUTIN TO WIN!";
        goaltext.text = showonscreen;
    }
    private void Update()
    {
        wincndtn1 = FindObjectOfType<EnemySpawn>().killcount;
        wincndtn2 = FindObjectOfType<PutinController>().score;
        if (wincndtn1 >= goal && wincndtn2 == 10)
        {
            Invoke("LevelComplete", 0.4f);
            goal = 1000;
        }
    }
    
}
