using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TiroTigreSentinela : MonoBehaviour
{
    public float velocidade;
    public Transform player;
    public float vida = 1;
    private GameObject gamecontroller;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>().transform;

        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            this.transform.rotation = LookAt2D(this.gameObject, player.gameObject);

            velocidade = Vector2.Distance(transform.position, player.position);
            transform.position = Vector2.MoveTowards(transform.position, player.position, velocidade * Time.deltaTime);

        }
    }

    public Quaternion LookAt2D(GameObject source, GameObject target)//aqui server para funcionar a rotação do inimigo conforme onde o inimigo esta no mapa
    {
        if (source == null || target == null)
        {
            return Quaternion.identity;
        }
        Vector2 translationVector = target.transform.position - source.transform.position; 
        float angle = Mathf.Atan2(translationVector.y, translationVector.x) * Mathf.Rad2Deg;
        return Quaternion.AngleAxis(angle, Vector3.forward);
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
        s.AtualizarScore(0);

        Destroy(gameObject);
        Destroy(collider.gameObject);
    }




}




