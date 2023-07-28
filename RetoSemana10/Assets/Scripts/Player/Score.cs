using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour

{
   
     public TMP_Text score;
     public GameObject cherry;
     public MeshRenderer meshRenderercherry;
     public GameManager winevent;

     public static int point;
   

     private void Update()
     {
        point = Dot.pointBall;
        score.text = ( point.ToString() + " / 15 " );

        if (point ==15)
        {
            cherry.SetActive(true);
        }

         if (point >=15 && meshRenderercherry.enabled == false) 
        {
            score.text = ("Win");
             winevent.Win();
        }

    
     }

     public void RestarPunto()
{
    point--;
}
 


}
