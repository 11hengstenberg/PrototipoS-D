using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cursorvisible : MonoBehaviour
{
    public bool cursorLocked = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    
    
}
