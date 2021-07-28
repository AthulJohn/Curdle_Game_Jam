using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SteamControl : MonoBehaviour
{

    public float jumpVelocity=10f;
    public GameObject baloon,exhaust,steam;
    Rigidbody2D baloonRigidbody;
    TextMeshPro textMesh;
    Animator animator;
    bool entered=false;
    // Start is called before the first frame update
    void Start()
    {
        baloon =GameObject.Find("Baloon");
        animator=steam.GetComponent<Animator>();
        baloonRigidbody=baloon.GetComponent<Rigidbody2D>();
        textMesh=exhaust.GetComponent<TextMeshPro>();
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (char c in Input.inputString)
        {   
            //c: character pressed in small case. c-32: character converted to Uppercase.
            if ( ( (char)(c-32) ).ToString() == textMesh.text) 
            {
    Jump();
            }
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        entered=true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        entered=false;
    }



    void Jump(){
        animator.SetTrigger("SteamTrigger");
        if(entered) {     baloonRigidbody.velocity=Vector2.up * jumpVelocity;}
    }

}
