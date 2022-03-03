using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelCounter : MonoBehaviour
{
    string levelkey = "level";
    string levelnum;
    public TextMeshProUGUI levelNumber;
    
    void Start()
    {
        levelnum = "1";
        try
        {
            levelnum = PlayerPrefs.GetInt(levelkey).ToString();
        }
        catch
        {

        }
        levelNumber.text = "LEVEL " + levelnum;
    }
}

   
