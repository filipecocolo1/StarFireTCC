using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoSeatActive : MonoBehaviour

{
    public GameObject Escudo;
    public float tempoBalaSpawn;//Tempo de spawn do Inimigo 
    public float contadordetempo; //Contador de Tempo para spawn
                                 
    void Start()
    {
        contadordetempo = 0;

        Escudo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoBalaSpawn)
        {

            contadordetempo = 0;
            Escudo.SetActive(true);



        }
        else {
            Escudo.SetActive(false);

        }
    }
}
