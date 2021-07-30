using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    public float highscore=0f;
    public GameObject Exhaust,Fire,Ground,Bird;

    TextMeshProUGUI scoremesh;
    float startTime=0f,speed=3f,tensmultiple=10;
    int currentScore=0;
    ExhaustControl ex,fr;
    GroundControl gr;
    BirdController brd;
    Animator animator;
    bool paused=false;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        scoremesh=GetComponent<TextMeshProUGUI>();
        startTime=Time.time;
        StartCoroutine(TimeIncrementor());
        ex=Exhaust.GetComponent<ExhaustControl>();
        fr=Fire.GetComponent<ExhaustControl>();
        gr=Ground.GetComponent<GroundControl>();
        brd=Bird.GetComponent<BirdController>();
    }

    private void FixedUpdate() {
         if(currentScore>InfoClass.highscore)
       {
           InfoClass.highscore=currentScore;
       }
        if(Time.time-startTime>tensmultiple&&!paused)
        {
            Time.timeScale=1.0f+(tensmultiple/300);
        tensmultiple+=10;
        }
    }

    public void AddExtra(){
        currentScore+=10;
    }

   public bool PauseIt(){
       bool temp=paused;
       paused=true;
       if(!temp&&currentScore>InfoClass.highscore)
       {
        //    highscore=currentScore;
           InfoClass.highscore=currentScore;
       }
       return temp;
   }

   public float GetHighScore(){
       return InfoClass.highscore;
   }

    IEnumerator TimeIncrementor()
    {
        while(true)
        {
            if(!paused)
            {
           animator.SetTrigger("TimeTrigger"); 
           yield return new WaitForSeconds(0.4f);   
           currentScore++;
        scoremesh.text=(currentScore).ToString();
            }
           yield return new WaitForSeconds(0.6f); 
        }
            }
}
