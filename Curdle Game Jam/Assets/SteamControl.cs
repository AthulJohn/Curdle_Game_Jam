using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SteamControl : MonoBehaviour
{

    public float jumpVelocity=10f;
    public GameObject exhaustText,steam;
    GameObject baloon;
    Rigidbody2D baloonRigidbody;
    TextMeshPro textMesh;
    Animator steamAnimator,baloonAnimator;
    bool entered=false;
    // Start is called before the first frame update
    void Start()
    {
        baloon =GameObject.Find("Baloon");
        steamAnimator=steam.GetComponent<Animator>();
        baloonAnimator=baloon.GetComponent<Animator>();
        baloonRigidbody=baloon.GetComponent<Rigidbody2D>();
        textMesh=exhaustText.GetComponent<TextMeshPro>();
        
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
        steamAnimator.SetTrigger("SteamTrigger");
        if(entered) {     
            baloonAnimator.SetTrigger("BaloonTrigger");
            baloonRigidbody.velocity=Vector2.up * jumpVelocity;
        }
    }

}
