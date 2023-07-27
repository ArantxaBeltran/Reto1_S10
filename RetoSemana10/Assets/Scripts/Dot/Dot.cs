using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
        
     public GameObject pelota;
     public  static int pointBall;
     public LayerMask mapaLayerMask; // Capa que incluye los colliders de las paredes del mapa

     

   void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.CompareTag("Player"))
        {
            
           pointBall++;
            RespawneaPelota();
        }

       
   }


    

    private void RespawneaPelota()
    {
        Vector3 nuevaPosicion;
        do
        {
            // Genera una nueva posición aleatoria dentro del área del mapa (ajusta los valores según el tamaño del mapa)
            nuevaPosicion = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        }
        while (!EsPosicionValida(nuevaPosicion));
      // Mueve la pelota a la nueva posición
        pelota.transform.position = nuevaPosicion;

        if (pointBall == 15)
        {
            pelota.SetActive(false);
           

        }


    }

    private bool EsPosicionValida(Vector3 posicion)
    {
        // Lanza un Raycast desde la nueva posición 
        Ray rayo = new Ray(posicion + Vector3.up * 10f, Vector3.down);
        float distanciaRaycast = 200f; // Longitud máxima del Raycast
        Debug.DrawRay(rayo.origin, rayo.direction * distanciaRaycast, Color.red);



        // Si el Raycast golpea algún colisionador de la capa "mapaLayerMask", significa que la posición no es válida
        if (Physics.Raycast(rayo, out RaycastHit hitInfo, distanciaRaycast, mapaLayerMask))
        {
            return false; // La posición no es válida (hay un collider en la posición)
        }

        // Si el Raycast no golpea ningún colisionador, la posición es válida
            return true;
        }


}
