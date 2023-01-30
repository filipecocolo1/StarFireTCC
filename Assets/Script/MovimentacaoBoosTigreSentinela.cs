using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoBoosTigreSentinela : MonoBehaviour
{
    public float speed;
    public bool MoverParEsquerda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (MoverParEsquerda)
        {
            transform.Translate(2 * Time.deltaTime * speed,0, 0);



           
        }
        else
        {

            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);



        }

    }


    private void OnTriggerEnter2D(Collider2D trig)
    {



        if (trig.gameObject.tag == "Cima")
        {
            

            if (MoverParEsquerda)
            {

                MoverParEsquerda = false;
             
            }
            else
            {

                MoverParEsquerda = true;

               
            }

        }
    }



}
