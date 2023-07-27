using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGhots2 : MonoBehaviour
{
  public float speedMov ;
    public Vector3[] points;
    
    private int startpoint = 0;
    // Start is called before the first frame update
    void Start()
    {
          points = new Vector3[]
        {
        new Vector3(-8.64f, 0f,-6.1f), // Punto inicial
        new Vector3(-8.64f, 0f, -4.25f), 
        new Vector3(-5.43f, 0f, -4.25f), 
        new Vector3(-5.43f, 0f, -6.14f),
        new Vector3(-3.08f, 0f, -6.14f),
        new Vector3(-3.08f, 0f, -4.35f),
        new Vector3(-1.75f, 0f, -4.35f),
           new Vector3(-3.08f, 0f, -4.35f),

        new Vector3(-3.08f, 0f, -6.14f),
        new Vector3(-8.64f, 0f,-6.14f),
        new Vector3(-0.93f, 0f,-6.14f ),
        new Vector3(-0.93f, 0f,-8.36f) ,
        new Vector3(-5.3f, 0f,-8.3f) ,  
        new Vector3(-5.14f, 0f,-6.3f),
        new Vector3(-5.3f, 0f,-8.3f) ,
        new Vector3(-8.67f, 0f,-8.3f),
        new Vector3(-8.64f, 0f,-6.1f),
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
        gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        yield return new WaitForSeconds(1f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
         yield return new WaitForSeconds(0.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
         yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
               yield return new WaitForSeconds(0.6f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                   yield return new WaitForSeconds(0.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
          yield return new WaitForSeconds(0.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            yield return new WaitForSeconds(1.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
           yield return new WaitForSeconds(2.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
          yield return new WaitForSeconds(0.8f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
           yield return new WaitForSeconds(1.5f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            yield return new WaitForSeconds(0.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            yield return new WaitForSeconds(0.6f);
         gameObject.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
           yield return new WaitForSeconds(1f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
          yield return new WaitForSeconds(0.7f);
         gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        

      }
    
     }

  




}
