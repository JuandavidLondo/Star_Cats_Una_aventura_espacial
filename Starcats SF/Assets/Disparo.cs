using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public int municion = 5;
    public GameObject Balaa;
    public float fireRate = 0.5f;
    float NextRate = 0.0f;
    // Start is called before the first frame update
    //Relacionado con STAR-20
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (municion > 9)
        {
            municion = 9;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > NextRate)
        {
            if (municion > 0)
            {
                NextRate = Time.time + fireRate;
                fire();
                municion--;
            }
            
        }
    }
    void fire()
    {
        Instantiate(Balaa, transform.position, Quaternion.identity);
    }
    
}
