using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenneController : MonoBehaviour
{
    public GameObject img;
    public GameObject igmComoJogar;

    // public void NewGame()


    //SceneManager.LoadScene("Fase1", LoadSceneMode.Single);
    //PlayerPrefs.DeleteAll();


//Player Prefs
    public void NewGamePlayerPrefs()
    {
        PlayerPrefs.DeleteKey("colecionavel");
        SceneManager.LoadScene("Fase1", LoadSceneMode.Single);
    }
    public void PlayGamePlayerPrefs()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Stadius", LoadSceneMode.Single);
    }
    //Stadius
    public void SelecaoDeFase() {
        SceneManager.LoadScene("Stadius", LoadSceneMode.Single);


    }
    //Fases
    public void Fase()
    {
        SceneManager.LoadScene("Fase1", LoadSceneMode.Single);



    }
     public void Fase2()
    {
        SceneManager.LoadScene("Fase2", LoadSceneMode.Single);



    }

    public void Fase3()
    {
        SceneManager.LoadScene("Fase3", LoadSceneMode.Single);



    }



    //Menu
    public void Menu() {


        SceneManager.LoadScene("Menu", LoadSceneMode.Single);


    }
    public void TimeScalleeMenu()
    {

        Time.timeScale = 1;

        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    

    }



    //Controlles
    public void Controles()
    {


        SceneManager.LoadScene("Controles", LoadSceneMode.Single);

    }


    //Creditos
    public void ScenneCreditos()
    {


        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);


    }


    // Start is called before the first frame update

    void Start() {
        if (img!=null) {
            img.SetActive(false);
        }
        if (igmComoJogar != null)
        {
            igmComoJogar.SetActive(false);
        }


    }

    // Update is called once per frame

    public void CilicouNewGame()
    {
        if (img != null)
        {
            img.SetActive(true);

        }
    }

    public void ComoJogar() {

        if (igmComoJogar != null)
        {
            igmComoJogar.SetActive(true);
        }


    }
    public void Cancelar()
    {
        if (img != null)
        {
            img.SetActive(false);
        }


        if (igmComoJogar != null)
        {
            igmComoJogar.SetActive(false);
        }


    }

}
