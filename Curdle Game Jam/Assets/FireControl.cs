using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class FireControl : MonoBehaviour
{
    
    public GameObject exhaustText,fire;
    GameObject baloon;
    Rigidbody2D baloonRigidbody;
    TextMeshPro textMesh;
    Animator fireAnimator;
    BaloonControl baloonControl;
    bool baloonentered=false,birdentered=false;
    GameObject currentBird;
    public AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        baloon =GameObject.Find("Baloon");
        fireAnimator=fire.GetComponent<Animator>();
        baloonControl=baloon.GetComponent<BaloonControl>();
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
        if(other.gameObject.name=="Baloon")baloonentered=true;
        else 
        {
            birdentered=true;
            currentBird=other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.name=="Baloon")baloonentered=false;
        else birdentered=false;
    }



    void Jump(){
        fireAnimator.SetTrigger("FireTrigger");
        aud.Play();
        if(baloonentered) {     
           baloonControl.GameOver("Hey, Whats the burning smell?");
        }
        if(birdentered)
        Destroy(currentBird);
    }

}
