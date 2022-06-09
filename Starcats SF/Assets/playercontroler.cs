using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector2 input;
    public float speed;
    public int life;
    private GameObject player,obstaculo;
    public Disparo Balas;
    // Start is called before the first frame update
    //Relacionado con STAR-6,STAR-15,STAR-16, STAR-9
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        life = 3;
        player = GameObject.FindGameObjectWithTag("Player");
        obstaculo = GameObject.FindGameObjectWithTag("Obstucalo");
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        if (life == 0)
        {
            Destroy(player.gameObject);
        }
        
        
    }
    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstucalo")
        {
            life--;
        }
        if (collision.tag == "Bolsa")
        {
            Balas.municion += 3;
        }
    }
}
