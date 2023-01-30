using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        rb.velocity = new Vector2(0, speed);

    }


    void OnBecameInvisible()
    {

        Destroy(gameObject);

    }


}