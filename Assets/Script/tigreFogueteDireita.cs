using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tigreFogueteDireita : MonoBehaviour
{
    private float impulsox = 4f;
    private float impulsoY = -4f;
    private int vida = 1;
    private GameObject gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
      

        
        transform.Translate(impulsox* Time.deltaTime, impulsoY* Time.deltaTime, 0, Space.World);
    }
    void OnBecameInvisible()
    {

        Destroy(gameObject);

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
