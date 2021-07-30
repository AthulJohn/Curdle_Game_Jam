using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMBaloonControl : MonoBehaviour
{
    GameObject score;
    Animator animator;
    ScoreControl scontrol;
    // Start is called before the first frame update
    void Start()
    {
        score=GameObject.Find("UI").transform.GetChild(2).gameObject;
        animator=GetComponent<Animator>();
        scontrol=score.GetComponent<ScoreControl>();
        GetComponent<Rigidbody2D>().velocity=new Vector2(-3f,0.5f);
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name=="Baloon")
        {
            animator.SetTrigger("TakeMiniBaloon");
            scontrol.AddExtra();
        }
    }
}
