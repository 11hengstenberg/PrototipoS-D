using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaMenu : MonoBehaviour
{
    public void PlayScene()
    {
        vidaJugador.vida = 100;
        RaycastController.bullets1 = 30;
        RaycastController.acrivarArma = false;
        RaycastController.bullets2 = 120;
        SceneManager.LoadScene("PantallaCarga");
        Time.timeScale = 1;
        pauseLevel.active = false;
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
        pauseLevel.active = false;

    }

    public void Quit()
    {
        Application.Quit();

    }

    public void MenuScene()
    {
        vidaJugador.vida = 100;
        RaycastController.bullets1 = 30;
        RaycastController.acrivarArma = false;
        RaycastController.bullets2 = 120;
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pauseLevel.active = false;
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
