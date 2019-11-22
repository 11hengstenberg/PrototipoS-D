using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine("Esperar");
    }
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(10);
        FollowPersonSave.seguir = false;
        SceneManager.LoadSceneAsync("Credits");

    }
}
