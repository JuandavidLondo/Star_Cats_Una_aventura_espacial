using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dobstaculo : MonoBehaviour
{
    private GameObject player;
    private playercontroler jugador;
    // Start is called before the first frame update
    //Relacionado con STAR-17,STAR-20
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
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
        else if (collision.tag == "Bala")
        {
            Destroy(this.gameObject);
        }
    }
}
