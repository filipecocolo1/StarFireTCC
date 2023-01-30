using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject Shot;//Para Armazenar prefab do Tiro
    private int speed= 5;//Velocidade do prefab 
    public GameObject Ult;//para armazenar o tiro da ult
   private int vida = 10;//Vida 
    public Transform arma1;//Possição do tiro 1
    public Transform arma1A;//Possição do tiro 2
    public Transform arma2;//Possição do tiro 3
    public Transform arma2a;//Possição do tiro 3
    private GameObject inimigo;//para poder Tiro 
   public int cargaUlt = 0;//Contador para a ult começar com 1
public float contador = 0;//contador para funcionar a ult
    public Text vidA;//Texto para descrever quanto voce tem de vida 
    private int score = 0;//para declarar seu score  
    public Text scorE;// para aperecer texto do score na tela   
    public Animator anim;//Declarar Animacao da Ult
    private bool fire1 = false;//Para funcionar o botão do tiro 1   
    private bool fire2 = false;//Para funcionar o botão do tiro 2
    public Joystick fixedJoystick;//para funcionar a movimentação do player
    public Rigidbody2D rb;
    public GameObject buttonUlt;
    public Slider mainSlider;

    void Start()

    {
        anim = GetComponent<Animator>();
        buttonUlt.GetComponent<Button>().interactable = false;
        rb = GetComponent<Rigidbody2D>();




    }





    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))//os  dois if controla o Tiro e a UltMate 

        {
            ChamarTiro1();

        }

        if (fire1)
        {//os  dois if controla o Tiro e a UltMate 


            ChamarTiro1();

            fire1 = false;

        }

        contador += Time.deltaTime;


        if (contador > 30)
        {
           if (cargaUlt == 0)
            {

                cargaUlt++;
                anim.SetBool("PodeUsarUlt",true);


            }

            contador = 0;
          

        }
        if (cargaUlt > 0)
        {
            buttonUlt.GetComponent<Button>().interactable = true;
            if (Input.GetKeyDown(KeyCode.J))
            {
                Debug.Log("J");
                ChamarTiroUltimate();

            }

            if (fire2)
            {
                ChamarTiroUltimate();

                fire2 = false;

            }
        }
        vidA.text = "Vida:" + vida;
        Joystick();
        if (mainSlider != null)
        {
            mainSlider.value = vida;
        }
    }
    private void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;//controla a movimentação do player
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(h, v, 0);
    }

    private void OnTriggerEnter2D(Collider2D collider)//Este metodo é onde funciona a vida do Player
    {
        if (collider.gameObject.tag == "Inimigo")
        {

            vida -= 1;
            Destroy(collider.gameObject);
        }
        if (vida == 0)
        {

            Destroy(gameObject);
            Destroy(collider.gameObject);
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }

    }

    public void ChamarVida(int vidaParareceber)
    {

        vida += vidaParareceber;

    }
    public void ChamarScore(int scoreParaReceber)
    {

        score += scoreParaReceber;



    }


    public void botaoUm()
    {
        fire1 = true;
    }

    public void botaoDois()
    {


        if( cargaUlt >0 || contador > 30)
        {
            fire2 = true;


        }
        else
        {
            Debug.Log("Ainda Não Esta Prota!");
        }

    }
    public void ChamarTiro1()
    {
        Instantiate(Shot, arma1.position, Quaternion.identity);
        Instantiate(Shot, arma1A.position, Quaternion.identity);


    }
    public void ChamarTiroUltimate()
    {
        Debug.Log("Chamar");

        if (cargaUlt > 0)
        {
            Debug.Log("DentroCargaUlt");


            Instantiate(Ult, arma2.position, Quaternion.identity);
            Instantiate(Ult, arma2a.position, Quaternion.identity);
          
            contador = 0;
            cargaUlt = 0;
            anim.SetBool("PodeUsarUlt", false);
            buttonUlt.GetComponent<Button>().interactable = false;


        }





    }
    public void Joystick()
    {


        float h = fixedJoystick.Horizontal * speed * Time.deltaTime;//controla a movimentação do player
        float v = fixedJoystick.Vertical * speed * Time.deltaTime;
        transform.Translate(h, v, 0);



    }


    public void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Laser")
        {
            vida -= 1;

        }
        if (vida == 0)
        {

            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }


        if (collision.gameObject.tag == "Gas") {

            vida -= 1;
                    
        
        }
        if (vida == 0) {

            SceneManager.LoadScene("Menu", LoadSceneMode.Single);

        }


    }
}