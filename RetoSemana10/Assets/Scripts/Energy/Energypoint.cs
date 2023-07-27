using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energypoint : MonoBehaviour
{
       void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.CompareTag("Player"))
        {
            
            Dot.pointBall +=1;
            gameObject.SetActive(false);
        }

       
   }
}
