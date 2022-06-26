using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHighScore : MonoBehaviour
{
    public Text HighScoreText; 

    private void Update() {
        if(PlayerPrefs.GetString("isHS", "N")=="Y"){
            HighScoreText.text = "NEW HIGH SCORE! " + PlayerPrefs.GetInt("HighScore").ToString();
            PlayerPrefs.SetString("isHS", "N");
        }
        else
        {
            HighScoreText.text = "You high score is: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }
}
