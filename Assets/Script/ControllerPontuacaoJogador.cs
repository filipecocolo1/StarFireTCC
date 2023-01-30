using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControllerPontuacaoJogador : MonoBehaviour
{
    private int score = 0;
    public Text textoScore;
   private int colecionavel = 0;
    public Text colecionavelText;


    // Start is called before the first frame update
    void Start()
    {
        textoScore.text = "Score:" + score;
        colecionavelText.text = "C:" + colecionavel;
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void AtualizarScore(int scoreParaReceber)
    {

        score += scoreParaReceber;
        textoScore.text = "Score:" + score;

    }
    public void AtulizarColecionavel(int colecionavelParaReceber)
    {
       colecionavel += colecionavelParaReceber;
        colecionavelText.text = "c:" + colecionavel;
        PlayerPrefs.SetInt("colecionavel", colecionavel);
        PlayerPrefs.Save();

    }
}
