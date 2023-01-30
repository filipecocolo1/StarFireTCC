using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
   

private float vida = 120;
    public Transform olho;
    public GameObject habilidadeBoss;
    public float tempoDaHabldoboss;//Tempo de spawn da Habilidade que o boss vai soltar
    public float contadordetempo; //Contador de Tempo para spawn Da Habilidade
    private GameObject gamecontroller;
    public GameObject SM;
    public Slider mainSlider;
    public GameObject TelaWinns;
    void Start()
    {
        contadordetempo = 0; // o tempo aqui vai começar em 0 
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
        TelaWinns.SetActive(false);
    }

    void Update()
        {
  
        contadordetempo += Time.deltaTime;                                    //ele tem a função de somar o tempo 

        if (contadordetempo > tempoDaHabldoboss)                             //esse If faço a  Habilidade do boss aparecer na tela
        {

            contadordetempo = 0;
            Instantiate(habilidadeBoss, olho.position, Quaternion.identity);
        }
        
        mainSlider.value = vida;





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
            vida -= 50;
            collider.gameObject.SetActive(false);
        

        }
        if (vida == 0)
        {

            Morrer(collider);

        }


    }
    private void Morrer(Collider2D collider)
    {
        ControllerPontuacaoJogador s = gamecontroller.GetComponent<ControllerPontuacaoJogador>();
        s.AtualizarScore(5);
        ControllerPontuacaoJogador v = GameObject.FindObjectOfType<ControllerPontuacaoJogador>();
        v.AtulizarColecionavel(1);

        Destroy(gameObject);
        Destroy(collider.gameObject);
        TelaWinns.SetActive(true);
        
        //ScenneController sc = SM.GetComponent<ScenneController>();
        //sc.PlayGamePlayerPrefs();
        
   
        

    }


}
