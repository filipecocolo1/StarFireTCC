using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAranha : MonoBehaviour
{
    public float vida = 50;
    private GameObject gamecontroller;
    public GameObject SM;
    public Slider mainSlider;
    public GameObject escudo;
    public float contadordetempo;
    public float tempoEscudoSpawn;
    public GameObject TelaWinns;
    // Start is called before the first frame update
    void Start()
    {

        contadordetempo = 0;

        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
        TelaWinns.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoEscudoSpawn)
        {

            contadordetempo = 0;
            escudo.SetActive(!escudo.activeSelf);



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

