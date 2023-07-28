using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverscreen;
    public  GameObject playercube;
    public  GameObject  animPlayer;
     private MeshRenderer cubeplayer;
     public GameObject winscreen;
   

      private void Awake()
    {
        cubeplayer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
   public void Gameover ()
   {
     
     StartCoroutine(Animecube());

   }
    IEnumerator Animecube()
      {
           
         
         yield return new WaitForSeconds(0.1f);
         cubeplayer.enabled = false;

         animPlayer.SetActive(true);
       
         yield return new WaitForSeconds(1f);
         Time.timeScale = 0f;
         gameoverscreen.SetActive (true);
        
    }

      public void Win()
    {
        
      
      winscreen.SetActive(true);
        
   }



      
     
     
        

      
    
     



  


}
