using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class SteamControl : MonoBehaviour
{

    public float jumpVelocity=10f;
    public GameObject exhaustText,steam;
    SpriteRenderer lay;
    public AudioSource aud;
    GameObject baloon;
    Rigidbody2D baloonRigidbody;
    TextMeshPro textMesh;
    Animator steamAnimator,baloonAnimator;
    bool entered=false;
    // Start is called before the first frame update
    void Start()
    {
        baloon =GameObject.Find("Baloon");
        lay =GameObject.Find("SteamLayer").GetComponent<SpriteRenderer>();
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

            if ( ( char.ToUpper(c) ).ToString() == textMesh.text) 
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
        Color col=lay.color;
        col.a=Mathf.Clamp(col.a+0.03f,0f,1f);
        lay.color=col;
        if(entered) {     
            aud.Play();
            baloonAnimator.SetTrigger("BaloonTrigger");
            baloonRigidbody.velocity=Vector2.up * jumpVelocity;
        }
    }

}
