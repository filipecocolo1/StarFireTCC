using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AranhaGas : MonoBehaviour
{
   
    private int vida = 5;
    private GameObject gamecontroller;
    public GameObject Gas;
    public Transform gas;
    Rigidbody2D rb;
    private float velocidade = -2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");


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
            Destroy(collider.gameObject);
        }
        if (vida == 0)
        {
            Morrer(collider);
        }

        if (collider.gameObject.tag == "Ult")
        {

            Morrer(collider);

        }
    }
    private void Morrer(Collider2D collider)
    {
        ControllerPontuacaoJogador s = gamecontroller.GetComponent<ControllerPontuacaoJogador>();
        s.AtualizarScore(5);

        Destroy(gameObject);
        Destroy(collider.gameObject);
        Instantiate(Gas, gas.position, this.transform.rotation);

    }
    void OnBecameInvisible()
    {

        Destroy(gameObject);

    }

}
