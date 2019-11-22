using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MisionCompleta : MonoBehaviour
{
    public GameObject particulas;

    IEnumerator Esperar()
    {

        yield return new WaitForSeconds(10);
        vidaJugador.vida = 100;
        RaycastController.bullets1 = 30;
        RaycastController.acrivarArma = false;
        RaycastController.bullets2 = 120;
        FollowPersonSave.seguir = false;
        SceneManager.LoadSceneAsync("victoria");
        
    }

    public void Start()
    {
        particulas.SetActive(false);
    }

    public void Update()
    {
        if (FollowPersonSave.seguir == true)
        {
            particulas.SetActive(true);
        }
    }

    public void OnTriggerStay(Collider other)
    {


        if (FollowPersonSave.seguir == true)
        {
           
            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                
                StartCoroutine("Esperar");


            }
        }
    }
        

        
        


 
}
