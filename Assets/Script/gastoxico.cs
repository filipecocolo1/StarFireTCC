using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gastoxico : MonoBehaviour
{
    public float tempoSpawn;
    public float contadordetempo;
    public GameObject GaxToxico;
    // Start is called before the first frame update
    void Start()
    {
        contadordetempo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;

        if (contadordetempo >= tempoSpawn)
        {

            contadordetempo = 0;
            Destroy(gameObject);


        }


    }
}