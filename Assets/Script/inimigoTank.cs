using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoTank : MonoBehaviour
{
   
    public float vida = 10;
    public Transform olho;
    public GameObject habilidadetank;
    private GameObject gamecontroller;

    public float tempoDaHabldoboss;//Tempo de spawn da Habilidade que o boss vai soltar
    public float contadordetempo; //Contador de Tempo para spawn Da Habilidade


    void Start()
    {
        contadordetempo = 0; // o tempo aqui vai começar em 0 
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
    }

    void Update()
    {

        contadordetempo += Time.deltaTime;                                    //ele tem a função de somar o tempo 

        if (contadordetempo > tempoDaHabldoboss)                             //esse If faço a  Habilidade do boss aparecer na tela
        {

            contadordetempo = 0;
            Instantiate(habilidadetank, olho.position, Quaternion.identity);
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
