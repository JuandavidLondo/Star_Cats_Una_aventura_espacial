using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuinicio : MonoBehaviour
{
    //Relacionado con STAR-5
    public void jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
