using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPedregulhoController : MonoBehaviour
{

    public GameObject InimigoPedregulho;
   public int tempoTotalDoSpawn = 60;    
    public  int quantidade =4;
    public Vector3 spawn;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", tempoTotalDoSpawn);
    


    }
    void Spawn()
    {
        
            float newPositionX;
            for (int i = 0; i < quantidade; i++)
            {
                newPositionX = Random.Range(-2.37f, 2.37f);

                spawn = new Vector3(newPositionX, 5, 0);

                GameObject obj = Instantiate(InimigoPedregulho, spawn, Quaternion.identity);
            }
       
    }
}

