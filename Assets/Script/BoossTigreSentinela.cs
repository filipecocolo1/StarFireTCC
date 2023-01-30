using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BoossTigreSentinela : MonoBehaviour
{
    public GameObject missel;
    public Transform arma1;
    public Transform arma2;
    public Transform arma3;
    public Transform arma4;
    public float tempoBalaSpawn;//Tempo de spawn do Inimigo 
    public float contadordetempo; //Contador de Tempo para spawn 
  private float vida = 120;
    private GameObject gamecontroller;
    public GameObject SM;
    public Slider mainSlider;
    public GameObject TelaWinns;
    void Start()
    {
        contadordetempo = 0;
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
        
    }

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoBalaSpawn)
        {

            contadordetempo = 0;
            Instantiate(missel, arma1.position, this.transform.rotation);
            Instantiate(missel, arma2.position, this.transform.rotation);
            Instantiate(missel, arma3.position, this.transform.rotation);
            Instantiate(missel, arma4.position, this.transform.rotation);


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
    void OnBecameInvisible()
    {

        Destroy(gameObject);

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