using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    string levelkey = "level";
    string characterkey = "character";

    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void AudioSwitch()
    {
        if (AudioListener.pause == false)
        {
            AudioListener.pause = true;
            Debug.Log("off");
        }
        else
        {
            AudioListener.pause = false;
            Debug.Log("on");
        }
    }
    public void ResetGame()
    {
        PlayerPrefs.SetInt(levelkey, 1);
    }

    public void InputData(int value)
    {
        if (value == 0)
        {
            PlayerPrefs.SetInt(characterkey, 0);
            Debug.Log("character changed to 0");
        }
        if (value == 1)
        {
            PlayerPrefs.SetInt(characterkey, 1);
            Debug.Log("character changed to 1");
        }
        if (value == 2)
        {
            PlayerPrefs.SetInt(characterkey, 2);
            Debug.Log("character changed to 2");
        }

    }
    private void Start()
    {
        
        if (PlayerPrefs.GetInt(levelkey) < 1)
        {
            PlayerPrefs.SetInt(levelkey, 1);
        }
    }
}