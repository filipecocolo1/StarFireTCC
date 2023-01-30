using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColecionavelSpawn : MonoBehaviour
{
    public float conometroseg;
  public int tempoTotalDoSpawn = 5;
    private int conometro;
    private bool active = false;
    public GameObject ColecionavelPrefabb;
    void Start()
    {

    }


    void Update()
    {

        conometroseg += Time.deltaTime;

        if (conometroseg > tempoTotalDoSpawn && active == false)
        {
            Instantiate(ColecionavelPrefabb, this.transform.position, this.transform.rotation);

            active = true;
        }
        int min = (int)((tempoTotalDoSpawn + conometro) / 60);
        int Seg = (int)(60 + conometroseg);
    }
}
