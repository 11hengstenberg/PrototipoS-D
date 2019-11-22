using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour

{ 

    public void PlayScene()
    {
        vidaJugador.vida = 100;
        RaycastController.bullets1 = 30;
        RaycastController.acrivarArma = false;
        RaycastController.bullets2 = 120;
        SceneManager.LoadScene("PantallaCarga");
        Time.timeScale = 1;
    }

    public void CreditsScene()
    {
        vidaJugador.vida = 100;
        RaycastController.bullets1 = 30;
        RaycastController.acrivarArma = false;
        RaycastController.bullets2 = 120;
        SceneManager.LoadScene("PantallaCarga2");
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void Quit()
    {
        Application.Quit();

    }

    public void MenuScene()
    {
        RaycastController.bullets1 = 30;
        vidaJugador.vida = 100;
        RaycastController.acrivarArma = false;
        RaycastController.bullets2 = 120;
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
