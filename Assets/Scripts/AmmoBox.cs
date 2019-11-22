using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{

    //variables
    public AudioClip recoger;
    public AudioClip noRecoger;

    AudioSource fuenteAudio;

    public GameObject modelo;
    public GameObject resplandor;
    public int bulletsBox = 50;


    // Start is called before the first frame update
    public void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        resplandor.gameObject.SetActive(false);
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
        
    }


    public void OnTriggerStay(Collider other)
    {
        

        transform.Rotate(new Vector3(0f, 40f, 0f) * Time.deltaTime);

        if (RaycastController.acrivarArma == true)
        {
            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {

                fuenteAudio.clip = recoger;
                fuenteAudio.Play();
                modelo.SetActive(false);
                resplandor.SetActive(false);
                RaycastController.bullets2 = RaycastController.bullets2 + bulletsBox;
                StartCoroutine("tiempo");
                //para recargar


            }
        }
        if (RaycastController.acrivarArma == false)
        {
            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                fuenteAudio.clip = noRecoger;
                fuenteAudio.Play();
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        resplandor.gameObject.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        resplandor.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

    }


}
