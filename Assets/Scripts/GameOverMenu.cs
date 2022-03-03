using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("Level");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
