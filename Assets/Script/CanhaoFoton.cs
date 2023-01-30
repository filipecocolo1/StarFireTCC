using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanhaoFoton : MonoBehaviour
{
    public float vida = 5;


    private GameObject gamecontroller;
    public GameObject laser;
    public float tempoBalaSpawn;//Tempo de spawn do Inimigo 
    public float contadordetempo; //Contador de Tempo para spawn
    

    // Start is called before the first frame update
    void Start()
    {
        contadordetempo = 0;
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");

        laser.SetActive(false);

    } 

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoBalaSpawn)
        {

            contadordetempo = 0;
            laser.SetActive(true);
           


        }
       
        
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
    }

    
}
