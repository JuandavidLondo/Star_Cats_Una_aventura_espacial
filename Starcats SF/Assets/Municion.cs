using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Municion : MonoBehaviour
{
    public Image Numero;
    public Disparo balas;
    // Start is called before the first frame update
    //Relacionado con STAR-18
    void Start()
    {
        Numero = GameObject.Find("Numero").GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (balas.municion == 9)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/9");
        }
        else if (balas.municion == 8)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/8");
        }
        else if (balas.municion == 7)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/7");
        }
        else if (balas.municion == 6)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/6");
        }
        else if (balas.municion == 5)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/5");
        }
        else if (balas.municion == 4)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/4");
        }
        else if (balas.municion == 3)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/3");
        }
        else if (balas.municion == 2)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/2");
        }
        else if (balas.municion == 1)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/1");
        }
        else if (balas.municion == 0)
        {
            Numero.sprite = Resources.Load<Sprite>("numeros/0");
        }
    }
}
