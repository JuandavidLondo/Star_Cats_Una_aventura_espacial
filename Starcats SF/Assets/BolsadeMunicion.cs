using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolsadeMunicion : MonoBehaviour
{
    private GameObject player;
    public Disparo balas;
    // Start is called before the first frame update
    //Relacionado con STAR-19
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
        }

    }
}
