using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public GameManager gameoverevent;
    public GameObject energy1;
    public GameObject energy2;
    public GameObject energy3;
    public GameObject energy4;
    public Score scoreScript;
    public Image pila1;
    public Image pila2;
    public Image pila3;
    public Image pila4;


    void Start()
    {
        StartCoroutine(ActiveEnergy());
    }

     void Update()
    {
        if (energy1.activeSelf ||energy2.activeSelf||energy3.activeSelf||energy4.activeSelf )
        {
            pila1.enabled = false;

        }

        else 
        {
             pila1.enabled = true;

        }
       
          if (energy1.activeSelf && energy2.activeSelf)
        {
            
            pila2.enabled = false;

        }
        else

        {
            pila2.enabled = true;

        }
        
           if (energy1.activeSelf && energy2.activeSelf && energy3.activeSelf)
        {
            
            pila3.enabled = false;

        }
         else

        {
            pila3.enabled = true;

        }
         
          if (energy1.activeSelf && energy2.activeSelf && energy3.activeSelf && energy4.activeSelf)
        {
            
            gameoverevent.Gameover();
            pila4.enabled = false;

        }
           else

        {
            pila4.enabled = true;

        }
         
    }

     IEnumerator ActiveEnergy()
      {
        while (Dot.pointBall < 15)
        {
            yield return new WaitForSeconds(5f);
            energy1.SetActive(true);
            Dot.pointBall -=1;
            yield return new WaitForSeconds(30f);
            energy2.SetActive(true);
            Dot.pointBall -=1;
            yield return new WaitForSeconds(60f);
            energy3.SetActive(true);
            Dot.pointBall -=1;
            yield return new WaitForSeconds(90f);
            energy4.SetActive(true); 
            Dot.pointBall -=1;        

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && energy1.activeSelf)
        {
            energy1.SetActive(false); 
             
        }
        if (collision.CompareTag("Player") && energy2.activeSelf)
        {
            energy2.SetActive(false); 
           
        }
         if (collision.CompareTag("Player") && energy3.activeSelf)
        {
            energy3.SetActive(false);
           
        }
         if (collision.CompareTag("Player") && energy4.activeSelf)
        {
            energy4.SetActive(false); 
            
        }

    }

 }    
