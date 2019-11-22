using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdf : MonoBehaviour
{
    public GameObject tiempoenemigos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Instantiate(tiempoenemigos, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
