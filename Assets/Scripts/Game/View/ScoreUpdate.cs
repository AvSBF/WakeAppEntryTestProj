using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{

    public GameObject player;
    public Text scoreText;
    public int score;

    private void Start() {
        score = 0;
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag.Equals("Fruit")){
            score++;
        }
    }
    
    private void Update() {
        scoreText.text = "Your score: " + score.ToString();
    }
    
}
