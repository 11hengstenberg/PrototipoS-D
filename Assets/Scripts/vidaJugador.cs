using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class vidaJugador : MonoBehaviour
{
    public Text vidaPersona;
    public static float vida = 100f;
    public float vidacalcudador;
    public GameObject danio;

    public void Start()
    {
        danio.SetActive(false);
        vidaPersona.text = "" + vida;
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(0.2f);
        danio.SetActive(false);

    }

    public void TakeDamage(float amount)
    
    {
        danio.SetActive(true);
        StartCoroutine("tiempo");
        vida -= amount;
        if (vida <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        vida = 100;
        RaycastController.bullets1 = 30;
        RaycastController.acrivarArma = false;
        RaycastController.bullets2 = 120;
        SceneManager.LoadScene("GameOver");
        
    }

    public void Update()
    {
        vidaPersona.text = "" + vida;
    }

    public void TakeVida(float vida2)
    {
        if (vida <= 55)
        {
            vida += vida2;
            vidaPersona.text = "" + vida;
        }
        if(vida > 55)
        {
            vidacalcudador =  100-vida;
            vida = vida + vidacalcudador;
            vidaPersona.text = "" + vida;
        }


    }
}
