using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class BaloonControl : MonoBehaviour
{
    public float fallSpeed=1f,jumpVelocity=10f;
    public GameObject panel,score,panelText,highscore,livehighscore;
    Animator baloonAnimator,panelAnimator;
    Rigidbody2D rb;
    ScoreControl scoreText;
    TextMeshProUGUI paneltxt,highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        panelAnimator=panel.GetComponent<Animator>();
        baloonAnimator=GetComponent<Animator>();
        paneltxt=panelText.GetComponent<TextMeshProUGUI>();
        highScoreText=highscore.GetComponent<TextMeshProUGUI>();
        rb=GetComponent<Rigidbody2D>();
        scoreText=score.GetComponent<ScoreControl>();
        rb.velocity=Vector2.up * 3;
        Time.timeScale=0f;
    }

    public void GameOver(string content){
        bool alreadyfinished=scoreText.PauseIt();
        if(!alreadyfinished)
        {
        baloonAnimator.SetTrigger("Blast");
        panelAnimator.SetTrigger("PanelPopUp");
        // highScoreText.text=InfoClass.highscore.ToString();
        paneltxt.text=content;
        }
        
    }

    public void GameStart(){
Time.timeScale=1f;
score.SetActive(true);
livehighscore.SetActive(true);
    }

   
}
