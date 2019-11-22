using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CargaPanta2 : MonoBehaviour
{
    public Transform BarraEspera;
    public Transform TextProgreso;
    public Transform TextCargando;
    [SerializeField] private float currentAmount;
    [SerializeField] private float Speed = 300;

    // Update is called once per frame
    void Update()
    {

        if (currentAmount < 100)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync("Credits");
           
            currentAmount += Speed * Time.deltaTime*20;
            TextProgreso.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
            TextCargando.gameObject.SetActive(true);
        }
        else
        {
            TextCargando.gameObject.SetActive(false);
            TextProgreso.GetComponent<Text>().text = "Listo!";
            //SceneManager.LoadScene("Credits");

        }
        BarraEspera.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
