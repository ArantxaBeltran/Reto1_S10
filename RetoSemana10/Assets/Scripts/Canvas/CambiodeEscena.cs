using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambiodeEscena : MonoBehaviour
{
    public string sceneName;
    public string sceneNameInicio;
    public GameObject escscreen;
    

   public void  Play()
   {
            
        SceneManager.LoadScene(sceneName);
         Time.timeScale = 1f;
         Dot.pointBall =0;
   }

    public void  Salir()
   {       
    
        Application.Quit();
   }

      public void Restart ()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         Time.timeScale = 1f;
         Dot.pointBall =0;

   }
   public void Inicio()
   {
      SceneManager.LoadScene(sceneNameInicio);
   }

     public void Instruction()
    {
        
      
      escscreen.SetActive(true);
        
   }
     public void Instructionexit()
    {
        
      
      escscreen.SetActive(false);
        
   }
    

       

    
}
