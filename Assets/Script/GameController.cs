using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject canvasPause;// Aqui é a tela De pauase que vai aparecer quando apertar o Pause
    public GameObject CanvasStadius;
    public GameObject CanvasStadius2;
    public GameObject BotaoInvisivel;//Objeto Vazio no Inspector para quando der pause ele desativar com SeCT Active
    public Button fase2;
    public Button fase3;
    public GameObject[] Vida;


    void Start() {
        Debug.Log("Colecionavel: " + PlayerPrefs.GetInt("colecionavel"));
        if (fase2 != null)
        {
            fase2.interactable = PlayerPrefs.GetInt("colecionavel") >= 3;


        }
        if(fase3 != null)
        {
            fase3.interactable = PlayerPrefs.GetInt("colecionavel") >= 4;


        }
        
    }


    void Update()
    {






    }

    public void botaoCanvasPause()
    {//Metado para poder aperta o Botão De  Pause
        Time.timeScale = 0;
        if (canvasPause.activeSelf) // Esse If server para quando apertar o Botão Pausar
        {
            canvasPause.SetActive(false);
            Time.timeScale = 1;
            BotaoInvisivel.SetActive(true);


        }
        else
        {
            canvasPause.SetActive(true);
            BotaoInvisivel.SetActive(false);
        }




    }
    public void botaoCanvasStadius()
    {//Metado Para escolher a fase

        if (CanvasStadius.activeSelf)
        {
            CanvasStadius.SetActive(false);


        }
        else
        {
            CanvasStadius.SetActive(true);


        }
    }
    public void botaoCanvasStadius2()
    {//Metado Para escolher a fase

        if (CanvasStadius2.activeSelf)
        {
            CanvasStadius2.SetActive(false);


        }
        else
        {
            CanvasStadius2.SetActive(true);

        }
    }

    public void Fase2() {

        if (fase2 != null)
        {
            fase2.interactable = PlayerPrefs.GetInt("colecionavel") >= 3;
    

        }

    }
    public void Fase3()
    {

        if (fase3 != null)
        {
            fase3.interactable = PlayerPrefs.GetInt("colecionavel") >= 4;


        }

    }

    

}




