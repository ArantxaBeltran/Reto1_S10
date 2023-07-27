using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cherry : MonoBehaviour
{
   
    // Obtener una referencia al componente Mesh Renderer en el Awake (asegura que el objeto lo tenga)
    private MeshRenderer meshRenderer;
   

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
       
       
    }

    void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.CompareTag("Player"))
        {
            
            
            meshRenderer.enabled = false;
           
        }

       
   }
     

}
