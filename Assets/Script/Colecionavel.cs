using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Colecionavel : MonoBehaviour
{


    private float velocidade =-3.0f;
    Rigidbody2D rb;
    private int colecionavel = 0;

 public GameObject gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, velocidade);
    }


    private void OnTriggerEnter2D(Collider2D collider)//Este metodo é onde funciona a vida dele 
    {
        if (collider.gameObject.tag == "Player")
        {
            colecionavel += 1;
            Destroy(this.gameObject);

            GanhouUmColecionavel(collider);
        }




    }

    private void GanhouUmColecionavel(Collider2D collider)
    {
        ControllerPontuacaoJogador s = GameObject.FindObjectOfType<ControllerPontuacaoJogador>();
        s.AtulizarColecionavel(1);

      
    }

}