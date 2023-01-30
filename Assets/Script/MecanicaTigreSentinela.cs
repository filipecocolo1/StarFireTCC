using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaTigreSentinela: MonoBehaviour
{
    public GameObject missel;
    public Transform arma1;
    
    public float tempoBalaSpawn;//Tempo de spawn do Inimigo 
    public float contadordetempo; //Contador de Tempo para spawn 
   public float vida = 6;
    private GameObject gamecontroller;
  private float velocidade= -1.0f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        contadordetempo = 0;
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoBalaSpawn)
        {

            contadordetempo = 0;
            Instantiate(missel, arma1.position, this.transform.rotation);
           

        }
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
        s.AtualizarScore(5);

        Destroy(gameObject);
        Destroy(collider.gameObject);
    }

}
