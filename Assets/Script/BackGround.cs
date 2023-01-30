using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour//Esse Script eu basicamente estou fazendo o background se movimentar então eu pego a posição inicial dele faço uma conta e até chegar na posição final e ele
//Então ele vai se repedindo
{
    private Sprite Imagem;
    private Vector3 posInicial;
    public float velocitDeRolamento = 2.0f;
    public float tamanhoSprite ;
    private float tamanhoRealSprite;
    private float escalaY;
    // Start is called before the first frame update
    void Start()
    {
        tamanhoSprite = this.GetComponent<SpriteRenderer>().size.y;
        escalaY = this.transform.localScale.y;
        tamanhoRealSprite = this.tamanhoSprite * escalaY;

        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(Time.time * velocitDeRolamento, tamanhoRealSprite);
        this.transform.position = posInicial + Vector3.down * deslocamento;
    }
}
