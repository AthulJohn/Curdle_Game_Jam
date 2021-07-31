using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
using TMPro;

public class BaloonControl : MonoBehaviour
{
    public float fallSpeed=1f,jumpVelocity=10f;
    public GameObject panel,score,panelText,highscore,livehighscore;
    Animator baloonAnimator,panelAnimator;
    Rigidbody2D rb;
    ScoreControl scoreText;
    TextMeshProUGUI paneltxt;
    public AudioSource aud,main;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=0f;
        panelAnimator=panel.GetComponent<Animator>();
        baloonAnimator=GetComponent<Animator>();
        paneltxt=panelText.GetComponent<TextMeshProUGUI>();
        rb=GetComponent<Rigidbody2D>();
        scoreText=score.GetComponent<ScoreControl>();
        rb.velocity=Vector2.up * 3;
    }

    public void GameOver(string content){
        bool alreadyfinished=scoreText.PauseIt();
        if(!alreadyfinished)
        {
            main.Pause();
            aud.Play();
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
