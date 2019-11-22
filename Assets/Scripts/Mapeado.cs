using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapeado : MonoBehaviour
{
    public Transform buttonA;

    Vector3 scaled = Vector3.one * 0.45f;
    Vector3 unscaled = Vector3.one * 0.4f;
    // Start is called before the first frame updatein
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            Debug.Log("X");
        }
        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            Debug.Log("Cuadrado");
        }
        if (Input.GetKey(KeyCode.Joystick1Button2))
        {
            Debug.Log("o");
        }
        if (Input.GetKey(KeyCode.Joystick1Button3))
        {
            Debug.Log("triangulo");
        }
        if (Input.GetKey(KeyCode.Joystick1Button4))
        {
            Debug.Log("l1");
        }
        if (Input.GetKey(KeyCode.Joystick1Button5))
        {
            Debug.Log("r1");
        }
        if (Input.GetKey(KeyCode.Joystick1Button6))
        {
            Debug.Log("l2");
        }

        if (Input.GetKey(KeyCode.Joystick1Button7))
        {
            Debug.Log("r2");
        }

        if (Input.GetKey(KeyCode.Joystick1Button8))
        {
            Debug.Log("share");
        }
        if (Input.GetKey(KeyCode.Joystick1Button9))
        {
            Debug.Log("options");
        }
        if (Input.GetKey(KeyCode.Joystick1Button10))
        {
            Debug.Log("l3");
        }
        if (Input.GetKey(KeyCode.Joystick1Button11))
        {
            Debug.Log("R3");
        }
        if (Input.GetKey(KeyCode.Joystick1Button12))
        {
            Debug.Log("pause");
        }
        if (Input.GetKey(KeyCode.Joystick2Button14))
        {
            Debug.Log("boton");
        }

        float analogico = Input.GetAxis("palanca");
        Debug.Log(analogico);
        //buttonA.localScale = Input.GetKey(KeyCode.Joystick1Button16) ? scaled : unscaled;
    }
}

