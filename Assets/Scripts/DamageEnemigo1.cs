using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemigo1 : MonoBehaviour
{
    private float damage = 15f;

    private float tiempo = 0;
    private float currentTime = 1;
    private float maxTime = 1;
    private bool firstDamage = true;
    


    public void OnTriggerStay(Collider other)
    {
        

        
        vidaJugador vidajugado = other.transform.GetComponent<vidaJugador>();

        if (firstDamage == true)
        {
            vidajugado.TakeDamage(damage);
            firstDamage = false;
        }

        //tiempo para el daño del enemigo.
        currentTime += Time.deltaTime;
        if (vidajugado != null)
        {

            
            
            
            if (currentTime >= maxTime)
            {

                currentTime = 0;
                tiempo++;



            }

            if (tiempo == 5)
            {
                
                vidajugado.TakeDamage(damage);
                tiempo = 0;
            }


        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 

        
    }
}
