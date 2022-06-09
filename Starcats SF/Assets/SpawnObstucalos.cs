using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnObstucalos : MonoBehaviour
{
    public GameObject obstucalo;
    public GameObject PiedraB;
    public GameObject PiedraC;
    public GameObject Dobstaculo;
    public GameObject Bolsa;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetweenSpawn;
    private float spawnTime;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Time.time> spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timebetweenSpawn;
        }
    }
    void Spawn()
    {
        int ramdomnum = Random.Range(0, 101);
        float ramdomX = Random.Range(minX, maxX);
        float ramdomY = Random.Range(minY, maxY);
        if (ramdomnum <= 5)
        {
            Instantiate(Bolsa, transform.position + new Vector3(ramdomX, ramdomY, 0), transform.rotation);
        }
        else if (ramdomnum <= 69)
        {
            int ramdomnumero = Random.Range(0, 10);
            if (ramdomnumero < 5)
            {
                Instantiate(obstucalo, transform.position + new Vector3(ramdomX, ramdomY, 0), transform.rotation);
            }
            else if (ramdomnumero <= 7)
            {
                Instantiate(PiedraB, transform.position + new Vector3(ramdomX, ramdomY, 0), transform.rotation);
            }
            else if(ramdomnumero > 7)
            {
                Instantiate(PiedraC, transform.position + new Vector3(ramdomX, ramdomY, 0), transform.rotation);
            }
            
        }
        else if (ramdomnum >= 70)
        {
            Instantiate(Dobstaculo, transform.position + new Vector3(ramdomX, ramdomY, 0), transform.rotation);
        }
        
    }

}
