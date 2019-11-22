using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseLevel : MonoBehaviour
{
    public static bool active;
    Canvas canvas;
    public GameObject eventsistem;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Joystick1Button12))
        {
            active = !active;
            
            if (active == true)
            {
                canvas.enabled = true;
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                RaycastController.acrivarArma = false;
                Time.timeScale = 0;
                eventsistem.SetActive(true);
            }

            if (active == false)
            {
                canvas.enabled = false;
              
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                RaycastController.acrivarArma = true;
                Time.timeScale = 1;
                eventsistem.SetActive(false);


            }
            

        }
    }
}
