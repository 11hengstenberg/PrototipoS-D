using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickArmas : MonoBehaviour
{
    public AudioClip recoger;
    public AudioClip noRecoger;
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    AudioSource fuenteAudio;
    public GameObject resplandor;
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        resplandor.gameObject.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        resplandor.gameObject.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
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

        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            fuenteAudio.clip = recoger;
            fuenteAudio.Play();
            objeto1.SetActive(false);
            objeto2.SetActive(false);
            objeto3.SetActive(false);
            RaycastController.acrivarArma = true;

            StartCoroutine("tiempo");



        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
