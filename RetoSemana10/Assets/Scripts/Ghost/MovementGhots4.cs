using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGhots4 : MonoBehaviour
{
     
  public float speedMov ;
    public Vector3[] points;
    private int startpoint = 0;
    // Start is called before the first frame update
    void Start()
    {
          points = new Vector3[]
        {
        new Vector3(-1.08f, 0f,4.92f), // Punto inicial
        new Vector3(-1.08f, 0f,2.92f),
         new Vector3(-3.04f, 0f,2.92f),
         new Vector3(-3.04f, 0f,1.14f),
         new Vector3(3.07f, 0f,1.14f),
         new Vector3(-3.04f, 0f,1.14f),
         new Vector3(-3.04f, 0f,-0.64f),
          new Vector3(-3.04f, 0f,-0.64f),
         new Vector3(-9.66f, 0f,-0.64f),
           new Vector3(-3.04f, 0f,-0.64f),
            new Vector3(-3.04f, 0f,-2.56f),
         
         new Vector3(0f, 0f,-2.56f),
         new Vector3(0f, 0f,-3.85f),
          new Vector3(0f, 0f,-2.56f),
          new Vector3(3.04f, 0f,-2.56f),
         new Vector3(3.04f, 0f,-0.64f),
         new Vector3(9.66f, 0f,-0.64f),
          new Vector3(3.04f, 0f,-0.64f),
          
         new Vector3(3.04f, 0f,1.14f),
                new Vector3(-3.04f, 0f,1.14f),
                  new Vector3(3.04f, 0f,1.14f),
                   new Vector3(3.04f, 0f,2.92f),
                    new Vector3(1.08f, 0f,2.92f),
                    new Vector3(1.08f, 0f,4.92f),

           



      


    
      
       
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
          yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
         yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
           yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
           yield return new WaitForSeconds(1.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
          yield return new WaitForSeconds(1.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
           yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
          yield return new WaitForSeconds(1.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
           yield return new WaitForSeconds(1.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
          yield return new WaitForSeconds(0.6f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
          yield return new WaitForSeconds(0.6f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
           yield return new WaitForSeconds(0.6f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
             yield return new WaitForSeconds(0.4f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
          yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
           yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
           yield return new WaitForSeconds(1.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f,- 90f, 0f);
           yield return new WaitForSeconds(1.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
           yield return new WaitForSeconds(1.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
          yield return new WaitForSeconds(1.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
               yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
          yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            yield return new WaitForSeconds(0.47f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
       }

        
      } 



      
     
     
        

}
