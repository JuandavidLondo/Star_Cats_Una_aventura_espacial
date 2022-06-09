using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameoverpanel;


    // Update is called once per frame
    //Relacionado con STAR-13
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameoverpanel.SetActive(true);
            
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
