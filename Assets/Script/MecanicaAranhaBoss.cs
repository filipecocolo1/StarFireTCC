using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaAranhaBoss : MonoBehaviour
{
    private float velocidade = -3.0f;
    Rigidbody2D rb;
    private float vida = 2;
    private GameObject gamecontroller;


    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, velocidade);
    }
    private void OnTriggerEnter2D(Collider2D collider)//Este metodo é onde funciona a vida dele 
    {
        if (collider.gameObject.tag == "Tiro")
        {
            vida -= 1;
            collider.gameObject.SetActive(false);
            // Destroy(collider.gameObject);
        }


        if (collider.gameObject.tag == "Ult")
        {
            vida -= 1;
            collider.gameObject.SetActive(false);


        }
        if (vida == 0)
        {

            Morrer(collider);

        }
    }
    void OnBecameInvisible()
    {

        Destroy(gameObject);

    }

    private void Morrer(Collider2D collider)
    {
        ControllerPontuacaoJogador s = gamecontroller.GetComponent<ControllerPontuacaoJogador>();
        s.AtualizarScore(2);

        Destroy(gameObject);
        Destroy(collider.gameObject);
    }






}



