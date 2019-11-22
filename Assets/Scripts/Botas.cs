using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class Botas : MonoBehaviour
{
    public float Speed = 2;
    public bool tiempoBotas = false;
    private float tiempo = 0;
    private float currentTime = 1;
    private float maxTime = 1;
    public GameObject modelo;
    public AudioClip recoger;
    public AudioClip noRecoger;

    AudioSource fuenteAudio;

    public float repetitivo = 0;

    IEnumerator tiempo1()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);



    }
    public void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }
    public void OnTriggerStay(Collider other)
    {
        
        transform.Rotate(new Vector3(0f, 40f, 0f) * Time.deltaTime);
        

        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            fuenteAudio.clip = recoger;
            fuenteAudio.Play();
            tiempoBotas = true;
            FirstPersonController.velocidad = 2.3f;

            
            
            if (tiempoBotas == true)
            {

                modelo.SetActive(false);


                
            }


        }
       
    }
    
    public void Update()
    {

       

        if (tiempoBotas == true)
        {

            currentTime += Time.deltaTime;

            if (currentTime >= maxTime)
            {

                currentTime = 0;
                tiempo++;

            }

            if (tiempo == 18)
            {
                
                FirstPersonController.velocidad = 1;
                tiempoBotas = false;
                Destroy(this.gameObject);
                
                tiempo = 0;
                repetitivo = 1;
            }
        }








    }
}

