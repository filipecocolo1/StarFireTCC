using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoParaCimaeBaixo : MonoBehaviour
{
    public float speed;
    public bool MoverParaCima;
    //public float distance;
    //public Transform groundDetection;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (MoverParaCima)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);




        }
        else
        {

            transform.Translate(0, -2 * Time.deltaTime * speed, 0);



        }


        //transform.Translate(Vector2.up * speed * Time.deltaTime);
        //RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.up, distance);
        //if (groundInfo.collider == false)
        //{

        //    if (MoverParaCima == true)
        //    {

        //        transform.eulerAngles = new Vector3(0, 4, 0);
        //        MoverParaCima = false;
        //    }
        //    else
        //    {
        //        transform.eulerAngles = new Vector3(0, 0, 0);
        //        MoverParaCima = true;
        //    }




    }
    private void OnTriggerEnter2D(Collider2D trig)
    {

        Debug.Log("Entrou");

        if (trig.gameObject.tag == "Turn")
        {
            Debug.Log("EntrouB");

            if (MoverParaCima)
            {

                MoverParaCima = false;
                Debug.Log("IndoParaBaixo");

            }
            else
            {

                MoverParaCima = true;

                Debug.Log("IndoParaCima");
            }

        }
    }
}
    




