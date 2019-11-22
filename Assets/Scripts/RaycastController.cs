using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastController : MonoBehaviour
{
    public float range = 100f;
    public GameObject efect;
    public GameObject impactBullet;
    public GameObject impactorotacionbala;
    public GameObject fuegoRifle;
    public GameObject puntaArma;
    public Text balasPistola;
    public Text balasCargador;
    private float damage = 30f;

    public static bool acrivarArma = false;

    public GameObject canva;
    public GameObject arma;
    public GameObject foco;

    public static int bullets1 = 30;
    public static int bullets2 = 120;
    private int datoParaActualizarRecargaDeBalas = 0;
    private Camera m_Camera;

    public AudioClip recargar;
    public AudioClip disparar;

    public bool esperaDisparo=true;
    public bool modorecargando = false;

    AudioSource fuenteAudio;

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(2);
        modorecargando = false;
        datoParaActualizarRecargaDeBalas = 30 - bullets1;
        if (datoParaActualizarRecargaDeBalas > bullets2)
        {

            bullets1 = bullets1 + bullets2;
            bullets2 = bullets2 - bullets2;
            balasPistola.text = "" + bullets1;
            balasCargador.text = "" + bullets2;

        }

        if (datoParaActualizarRecargaDeBalas <= bullets2)
        {

            bullets1 = bullets1 + datoParaActualizarRecargaDeBalas;
            bullets2 = bullets2 - datoParaActualizarRecargaDeBalas;
            balasPistola.text = "" + bullets1;
            balasCargador.text = "" + bullets2;

        }

    }
    IEnumerator tiempoDisparo()
    {
        yield return new WaitForSeconds(0.4f);
        esperaDisparo = true;

    }


    // Start is called before the first frame update
    void Start()
    {
        balasPistola.text = ""+bullets1;
        balasCargador.text = ""+bullets2;
        m_Camera = Camera.main;

        canva.gameObject.SetActive(false);
        foco.gameObject.SetActive(false);
        arma.gameObject.SetActive(false);
        fuenteAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        //para la caja de municion.
        //actualizar los datos en canvas.

        if (acrivarArma == true)
        {
            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                balasCargador.text = "" + bullets2;

                if (acrivarArma == false)
                {
                    canva.gameObject.SetActive(false);
                    foco.gameObject.SetActive(false);
                    arma.gameObject.SetActive(false);
                }

                if (acrivarArma == true)
                {
                    canva.gameObject.SetActive(true);
                    foco.gameObject.SetActive(true);
                    arma.gameObject.SetActive(true);
                }
            }

            if (acrivarArma == true)
            {
                if (bullets1 < 30 & bullets1 >= 0)
                {

                    if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Joystick1Button0))
                    {
                        modorecargando = true;
                        fuenteAudio.clip = recargar;
                        fuenteAudio.Play();

                        StartCoroutine("tiempo");


                    }
                }


                //disparando las balas

                if (bullets1 > 0 & bullets1 <= 30)
                {
                    if (modorecargando == false)
                    {
                        if (esperaDisparo == true)
                        {
                            //disparando
                            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Joystick1Button7))
                            {

                                fuenteAudio.clip = disparar;
                                fuenteAudio.Play();
                                bullets1 = bullets1 - 1;
                                balasPistola.text = "" + bullets1;
                                RaycastHit hit;
                                GameObject _puntaArma = Instantiate(fuegoRifle, puntaArma.transform);
                                Destroy(_puntaArma, 0.04f);


                                //generar los impactos donde topo el raycastHit
                                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range, -5, QueryTriggerInteraction.Ignore))
                                {



                                    //instanciar objetos de impacto de bala

                                    GameObject _efect = Instantiate(efect, hit.point, Quaternion.identity);
                                    GameObject _impactBullet = Instantiate(impactBullet, hit.point, Quaternion.identity);
                                    _impactBullet.transform.rotation = (impactorotacionbala.transform.rotation);



                                    //destruir objetos despues de un tiempo.
                                    Destroy(_efect, 0.05f);
                                    Destroy(_impactBullet, 2f);




                                    //impacto a los enemigos encontrados.
                                    if (hit.collider.GetComponent<Rigidbody>() != null)
                                    {

                                        Destroy(hit.collider);
                                        StartCoroutine("tiempoDisparo");
                                    }

                                    VidaEnemigo1 vidaEnemigo1 = hit.transform.GetComponent<VidaEnemigo1>();

                                    if (vidaEnemigo1 != null)
                                    {
                                        vidaEnemigo1.TakeDamage(damage);
                                        StartCoroutine("tiempoDisparo");
                                    }
                                    esperaDisparo = false;
                                    StartCoroutine("tiempoDisparo");

                                }
                            }
                        }
                    }
                }
            }
            //recargar el arma
        }



    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * range);
    }
}
