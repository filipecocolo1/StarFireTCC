using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactiveSpawn : MonoBehaviour
{
    public float tempoSpawn;
    public float contadordetempo; 
    public GameObject SpawnDesligado;
    // Start is called before the first frame update
    void Start()
    {
        contadordetempo = 0;
        SpawnDesligado.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoSpawn)
        {

            contadordetempo = 0;
            SpawnDesligado.SetActive(false);



        }


    }
}
