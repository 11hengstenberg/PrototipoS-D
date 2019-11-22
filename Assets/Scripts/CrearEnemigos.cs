using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigos : MonoBehaviour
{
    public GameObject enemigo;
    public BoxCollider box;
    public BoxCollider box0;
    public BoxCollider box1;
    public BoxCollider box2; 
    public BoxCollider box3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(enemigo, this.transform);
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
