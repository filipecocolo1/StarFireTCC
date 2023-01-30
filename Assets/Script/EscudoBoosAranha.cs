using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoBoosAranha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)//Este metodo é onde funciona a vida dele 
    {
        if (collider.gameObject.tag == "Ult")
        {
            Destroy(collider.gameObject);
            // Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Tiro")
        {
            Destroy(collider.gameObject);
            // Destroy(collider.gameObject);
        }



    }
 
}
