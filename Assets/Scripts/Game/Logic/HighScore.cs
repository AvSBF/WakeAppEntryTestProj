using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public ScoreUpdate su;
    [SerializeField] GameObject pScore;
    private int highscore;
    public bool newHighSore = false;

    private void Awake() {
        su = pScore.GetComponent<ScoreUpdate>();
    }

    private void Start() {
        highscore = PlayerPrefs.GetInt("HighScore", 0);
    }    
    
    private void Update() {
        if(su.score > highscore){
            PlayerPrefs.SetString("isHS", "Y");
            PlayerPrefs.SetInt("HighScore", su.score);
        }
    }

}
