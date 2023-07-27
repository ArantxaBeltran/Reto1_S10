using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGhost3 : MonoBehaviour
{
   
  public float speedMov ;
    public Vector3[] points;
    private int startpoint = 0;
    // Start is called before the first frame update
    void Start()
    {
          points = new Vector3[]
        {
        new Vector3(-5.27f, 0f,6.78f), // Punto inicial
         new Vector3(-8.78f, 0f,6.78f),
         new Vector3(-8.78f, 0f,8.49f),
         new Vector3(-8.78f, 0f,8.49f),
         new Vector3(-1.07f, 0f,8.49f),
          new Vector3(-1.07f, 0f,6.74f),
          new Vector3(-3.11f, 0f,6.74f),
          
          new Vector3(-3.11f, 0f,4.93f),
          new Vector3(-5.14f, 0f,4.93f),
          new Vector3(-5.14f, 0f,0.64f),
          new Vector3(-5.14f, 0f,2.93f),
           new Vector3(-8.64f, 0f,2.93f),
            new Vector3(-8.64f, 0f,4.89f),
             new Vector3(-7.28f, 0f,4.89f),
              new Vector3(-7.28f, 0f,6.78f),
              new Vector3(-5.27f, 0f,6.78f),
      
       
        };
         StartCoroutine(Movement());
         StartCoroutine(RotationGhost());

         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      IEnumerator Movement()
    {
        while (startpoint < points.Length)
        {
            Vector3 nextPoint = points[startpoint];
            while (transform.position != nextPoint)
            {
                transform.position = Vector3.MoveTowards(transform.position, nextPoint,speedMov * Time.deltaTime);
                yield return null;
            }
            startpoint++;
            if ( startpoint == points.Length)
            {
                startpoint=0;
            }
            
        }



    }

      IEnumerator RotationGhost()
      {
        
          while (startpoint < points.Length)
          {
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
          yield return new WaitForSeconds(2.8f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
          yield return new WaitForSeconds(1.3f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
          yield return new WaitForSeconds(1.1f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
          yield return new WaitForSeconds(0.5f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.7f);
        gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
          yield return new WaitForSeconds(0.6f);
        gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
    }



      
     
     
        

      
    
     }

  




}
