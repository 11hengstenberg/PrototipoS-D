using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicKit : MonoBehaviour
{
    private float regenerateVida = 45;
    public AudioClip recoger;
    public AudioClip noRecoger;
    public GameObject modelo;

    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);

    }
    public void OnTriggerStay(Collider other)
    {
        transform.Rotate(new Vector3(0f, 40f, 0f) * Time.deltaTime);
        vidaJugador vidajugado = other.transform.GetComponent<vidaJugador>();
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
        {

            if (vidaJugador.vida >= 100)
            {
                fuenteAudio.clip = noRecoger;
                fuenteAudio.Play();
            }
            //para recargar

            if (vidaJugador.vida < 100)
            {
                fuenteAudio.clip = recoger;
                fuenteAudio.Play();
                vidajugado.TakeVida(regenerateVida);
                modelo.SetActive(false);
                StartCoroutine("tiempo");
                
            }


            



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
