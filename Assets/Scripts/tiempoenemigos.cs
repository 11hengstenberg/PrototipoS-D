using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempoenemigos : MonoBehaviour
{
    public GameObject enemigo;
    public bool si= true;
    public float contador = 0;

    IEnumerator tiempoDisparo()
    {
        yield return new WaitForSeconds(20);
        contador = contador + 1;
        Instantiate(enemigo, this.transform);
        si = true;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (si == true && contador>5)
        {

            StartCoroutine("tiempoDisparo");
            si = false;

        }





    }
}
