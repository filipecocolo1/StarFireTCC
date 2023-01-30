using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour
{
    public GameObject inimigo;  //Aqui onde vai armazenar o prefab

    public float tempoInmigoSpawn;//Tempo de spawn do Inimigo 
    public float contadordetempo; //Contador de Tempo para spawn 
    
       
    




    // Start is called before the first frame update
    void Start()
    {
        contadordetempo = 0;

    }

    // Update is called once per frame
    void Update()
    {
        contadordetempo += Time.deltaTime;
        if (contadordetempo >= tempoInmigoSpawn) {

            contadordetempo = 0;
            Instantiate(inimigo, this.transform.position, this.transform.rotation);
            
        }
    }
}
