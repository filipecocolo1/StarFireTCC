using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBossTank : MonoBehaviour
{
    public GameObject boss;

    public float conometroseg;
    public int tempoTotalDoSpawn =100;
    private int conometro;
    private bool active = false;
   

    void Start()
    {

    }

    
    void Update()
    {

        conometroseg += Time.deltaTime;

        if (conometroseg > tempoTotalDoSpawn && active == false)
        {
            Instantiate(boss, this.transform.position, this.transform.rotation);

            active = true;
        }
        int min = (int)((tempoTotalDoSpawn + conometro) / 60);
        int Seg = (int)(60 + conometroseg);
    }
}

