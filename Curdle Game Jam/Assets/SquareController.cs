using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public GameObject mask;
    bool pressed=false;
    float firstPresstime,currentSwipetime;
    SpriteRenderer lay;
    // Start is called before the first frame update
    void Start()
    {
        lay=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
     {
         //save began touch 2d point
         pressed=true;
        firstPresstime = Time.time;
     }
     if(Input.GetMouseButtonUp(0))
     {
         pressed=false;
        //  Check();
           
    }

    }
    private void FixedUpdate() {
        if(pressed)
        NegateSome();
    }

    void Check(){
 
        
        currentSwipetime = Time.time-firstPresstime;
        Debug.Log(currentSwipetime);
        Color col=lay.color;
        col.a=Mathf.Clamp(col.a-(currentSwipetime/100f),0f,1f);
        lay.color=col;
    }
    void NegateSome(){
 
        
        float temptime = Time.time-firstPresstime;
        Color col=lay.color;
        col.a=Mathf.Clamp(col.a-(0.01f),0f,1f);
        lay.color=col;
        firstPresstime=Time.time;
    }
}
