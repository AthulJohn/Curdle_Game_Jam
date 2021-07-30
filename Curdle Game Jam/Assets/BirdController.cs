using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float moveSpeed=4f;
    GameObject baloon,score;
    BaloonControl balooncontrol;
     private Vector2 screenBounds; 
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb=GetComponent<Rigidbody2D>();
        screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        
        rb.velocity=new Vector2(-moveSpeed,0);
        baloon =GameObject.Find("Baloon");
        balooncontrol=baloon.GetComponent<BaloonControl>();


    }

     void Update()
    {
        if(transform.position.x< -3f*screenBounds.x)
        {
            
            Destroy(gameObject);}
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name=="Baloon")
        {
            balooncontrol.GameOver("Whoa, Look out the birds!");

        }
    }

    
}
