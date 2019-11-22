using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject menuControl;
    public GameObject MenuMouse;
    // Start is called before the first frame update
    void Start()
    {
        MenuMouse.SetActive(true);
        menuControl.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (pauseLevel.active == true)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button1))
            {
                Debug.Log("X");
                menuControl.SetActive(true);
                MenuMouse.SetActive(false);
            }
        }

    }
}
