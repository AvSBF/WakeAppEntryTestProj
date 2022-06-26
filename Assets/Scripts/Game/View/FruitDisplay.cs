using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Random;

public class FruitDisplay : MonoBehaviour
{
    private Camera cam;
    private Vector3 nextPos;

    private void Start() {
        cam = Camera.main;
       getNewLocation();
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag.Equals("Player")){
            Debug.Log("collided");
            getNewLocation();
        }
    }
    
    private void getNewLocation(){
        float buffer = 50f;
        Vector3 worldMin = Camera.main.ScreenToWorldPoint(new Vector2(buffer, buffer));
Vector3 worldMax = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
Vector2 spawnPosition = new Vector2(
   Random.Range(worldMin.x, worldMax.x),
   Random.Range(worldMin.y, worldMax.y));
        transform.position = spawnPosition;
    }
}
