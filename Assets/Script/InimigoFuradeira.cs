using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoFuradeira : MonoBehaviour
{
    public Transform m_player;
    public float Velocidade;
    private float distancia;
    public int vida = 3;
    private GameObject gamecontroller;
    public Animator anim;

    public Quaternion LookAt2D(Transform source, Transform target)
    {
        float angle;
        angle = Mathf.Atan2(target.position.y, target.position.x) * Mathf.Rad2Deg;
        return Quaternion.Euler(3.0f, 0.0f, angle);
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gamecontroller = GameObject.FindGameObjectWithTag("GameController");
        m_player = FindObjectOfType<Player>().transform;   // aqui fala para para o inimigo seguir  o player 


    }

    // Update is called once per frame
    void Update()
    {
        if (m_player != null)
        {
            this.transform.rotation = LookAt2D(this.gameObject, m_player.gameObject);
            distancia = Vector2.Distance(transform.position, m_player.position);

            transform.position = Vector2.MoveTowards(transform.position, m_player.position, Velocidade * Time.deltaTime);//Aqui eu fiz uma IA para o inimigo seguir o player
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
        s.AtualizarScore(5);

        Destroy(gameObject);
        Destroy(collider.gameObject);
    }

}