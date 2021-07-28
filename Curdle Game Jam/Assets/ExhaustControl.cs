using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExhaustControl : MonoBehaviour
{

    char ch;
    GameObject textObject;
    TextMeshPro textMesh;
    void Start()
    {
        // Random rnd = new Random();
        char ch =(char)Random.Range(65,90); 
        textObject=transform.GetChild(0).gameObject;
        Debug.Log(textObject.name);
        textMesh=textObject.GetComponent<TextMeshPro>();
        textMesh.text=ch.ToString();
        Debug.Log(textMesh.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
