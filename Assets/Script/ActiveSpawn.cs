using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempoSpawn;
    public float contadordetempo;
    public GameObject SpawnLigado;
    // Start is called before the first frame update
    void Start()
    {
        contadordetempo = 0;
        SpawnLigado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoSpawn)
        {

            contadordetempo = 0;
            SpawnLigado.SetActive(true);



        }


    }
}


