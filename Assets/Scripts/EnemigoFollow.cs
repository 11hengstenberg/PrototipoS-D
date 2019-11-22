using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemigoFollow : MonoBehaviour
{
    Transform player;
    
    
    UnityEngine.AI.NavMeshAgent nav;


    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(50);
        Destroy(this.gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("tiempo");
        player = GameObject.FindGameObjectWithTag("jugador").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
            

    }

    // Update is called once per frame
    void Update()
    {
        
        nav.SetDestination(player.position);
        
    }



}
