using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonControl : MonoBehaviour
{
    public float fallSpeed=1f,jumpVelocity=10f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.velocity=Vector2.up * 3;
    }

   
}
