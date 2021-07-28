using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExhaustControl : MonoBehaviour
{

    char ch;
    
    public float moveSpeed=5f;
    public GameObject baloon;
    GameObject textObject;
    TextMeshPro textMesh;

    private Vector2 screenBounds;

    void Start()
    {
        
        Rigidbody2D rb=GetComponent<Rigidbody2D>();
        rb.velocity=new Vector2(-moveSpeed,0);
        screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        ch =(char)Random.Range(65,90); 
        textObject=transform.GetChild(0).gameObject;
        textMesh=textObject.GetComponent<TextMeshPro>();
        textMesh.text=ch.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< -2*screenBounds.x)
        {
            Destroy(gameObject);}
        
    }

}
