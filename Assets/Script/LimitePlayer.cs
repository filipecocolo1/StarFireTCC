using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
      transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.28f, 2.28f), Mathf.Clamp
        (transform.position.y, -4.28f, 4.28f), transform.position.z);
    }
}
