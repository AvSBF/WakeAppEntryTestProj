using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class HeartsSystem : MonoBehaviour
{
   public int heart;
   public int numOfHearts;
   public Image[] hearts;
   public Sprite enabledHeart;

   private void Update() {
    for (int i = 0; i<hearts.Length; i++){
        if(i<numOfHearts){
            hearts[i].enabled = true;
        }
        else
        {
            hearts[i].enabled = false;
        }
    }
   }

   private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag.Equals("Enemy")){
            numOfHearts-=1;
            Thread.Sleep(1);
        }
        if(numOfHearts==0){
            SceneManager.LoadScene("GameOverScene");
        }
   }
}
