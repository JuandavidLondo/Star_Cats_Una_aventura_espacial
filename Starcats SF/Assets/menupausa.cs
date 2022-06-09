using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupausa : MonoBehaviour
{
    [SerializeField] private GameObject botonpausa;

    [SerializeField] private GameObject menuPausa;
    public GameObject municionypuntuacion;
    private bool juegopausado = false;
    //Relacionado con STAR-23,STAR-22,STAR-26,STAR-27,STAR-28,STAR-29
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegopausado)
            {
                continuar();
            }
            else
            {
                pausa();
            }
        }
    }

    public void pausa()
    {
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void continuar()
    {
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menuPausa.SetActive(false);
        municionypuntuacion.SetActive(true);
    }

    public void reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void cerrar()
    {
        Debug.Log("cerrando juego");
        Application.Quit();
    }
}
