using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPersonSave : MonoBehaviour
{
    Transform player;
    public GameObject particulas;

    UnityEngine.AI.NavMeshAgent nav;
    public static bool seguir = false;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("jugador").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    public void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            seguir = true;
            particulas.SetActive(false);

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (seguir == true)
        {

            nav.SetDestination(player.position);
        }
        

    }
}
