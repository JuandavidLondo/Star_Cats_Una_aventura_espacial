using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public Image Mil;
    public Image Cien;
    public Image Diez;
    public Image Uno;
    private float puntos;
    private int puntosenteros;
    public GameObject Municionypuntuacion;
    public playercontroler player;
    // Start is called before the first frame update
    //Relacionado con STAR-12
    void Start()
    {
        Mil = GameObject.Find("Mil").GetComponent<Image>();
        Cien = GameObject.Find("Cien").GetComponent<Image>();
        Diez = GameObject.Find("Diez").GetComponent<Image>();
        Uno  = GameObject.Find("Uno").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.life != 0)
        {
            puntos += 1 * Time.deltaTime;
            puntosenteros = (int)puntos;
            if (puntosenteros % 10 == 0)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/0");
            }
            else if (puntosenteros % 10 == 1)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/1");
            }
            else if (puntosenteros % 10 == 2)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/2");
            }
            else if (puntosenteros % 10 == 3)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/3");
            }
            else if (puntosenteros % 10 == 4)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/4");
            }
            else if (puntosenteros % 10 == 5)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/5");
            }
            else if (puntosenteros % 10 == 6)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/6");
            }
            else if (puntosenteros % 10 == 7)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/7");
            }
            else if (puntosenteros % 10 == 8)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/8");
            }
            else if (puntosenteros % 10 == 9)
            {
                Uno.sprite = Resources.Load<Sprite>("numeros/9");
            }
            if (puntosenteros % 100 == 0)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/0");
            }
            else if (puntosenteros % 100 == 10)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/1");
            }
            else if (puntosenteros % 100 == 20)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/2");
            }
            else if (puntosenteros % 100 == 30)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/3");
            }
            else if (puntosenteros % 100 == 40)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/4");
            }
            else if (puntosenteros % 100 == 50)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/5");
            }
            else if (puntosenteros % 100 == 60)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/6");
            }
            else if (puntosenteros % 100 == 70)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/7");
            }
            else if (puntosenteros % 100 == 80)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/8");
            }
            else if (puntosenteros % 100 == 90)
            {
                Diez.sprite = Resources.Load<Sprite>("numeros/9");
            }
            if (puntosenteros % 1000 == 0)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/0");
            }
            else if (puntosenteros % 1000 == 100)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/1");
            }
            else if (puntosenteros % 1000 == 200)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/2");
            }
            else if (puntosenteros % 1000 == 300)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/3");
            }
            else if (puntosenteros % 1000 == 400)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/4");
            }
            else if (puntosenteros % 1000 == 500)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/5");
            }
            else if (puntosenteros % 1000 == 600)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/6");
            }
            else if (puntosenteros % 1000 == 700)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/7");
            }
            else if (puntosenteros % 1000 == 800)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/8");
            }
            else if (puntosenteros % 1000 == 900)
            {
                Cien.sprite = Resources.Load<Sprite>("numeros/9");
            }
            if (puntosenteros % 10000 == 0)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/0");
            }
            else if (puntosenteros % 10000 == 1000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/1");
            }
            else if (puntosenteros % 10000 == 2000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/2");
            }
            else if (puntosenteros % 10000 == 3000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/3");
            }
            else if (puntosenteros % 10000 == 4000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/4");
            }
            else if (puntosenteros % 10000 == 5000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/5");
            }
            else if (puntosenteros % 10000 == 6000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/6");
            }
            else if (puntosenteros % 10000 ==7000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/7");
            }
            else if (puntosenteros % 10000 == 8000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/8");
            }
            else if (puntosenteros % 10000 == 9000)
            {
                Mil.sprite = Resources.Load<Sprite>("numeros/9");
            }
        }
        if(player.life == 0 || Input.GetKeyDown(KeyCode.Escape))
        {
            Municionypuntuacion.SetActive(false);
        }
    }
}
