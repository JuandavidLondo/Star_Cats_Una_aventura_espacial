using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    private playercontroler jugador;


    // Start is called before the first frame update
    //Relacionado con STAR-17
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
            if (jugador.life == 0)
            {
                Destroy(player.gameObject);
            }
        }
        
    }

}
