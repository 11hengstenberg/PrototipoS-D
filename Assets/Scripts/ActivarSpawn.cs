using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarSpawn : MonoBehaviour
{
    public GameObject area;
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        area.SetActive(false);
        spawn.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("dentro");
        Instantiate(spawn, this.gameObject.transform);
        Instantiate(area,this.gameObject.transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
