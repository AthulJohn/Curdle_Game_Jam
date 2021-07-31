using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutPanelController : MonoBehaviour
{
    public GameObject prev,next;
    
    public void Previous(){
        prev.SetActive(true);
        gameObject.SetActive(false);
    }
    public void Next(){
        next.SetActive(true);
        gameObject.SetActive(false);
    }
    

    public void Quit(){
        Application.Quit();
    }
}
