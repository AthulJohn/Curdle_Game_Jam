using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMBaloonSpawner : MonoBehaviour
{
   private Vector2 screenBounds;
    public GameObject baloon;
    // Start is called before the first frame update
    void Start()
    {
         screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        StartCoroutine(Waver());
    }

    public void SpawnEnemy(){
        GameObject a=Instantiate(baloon) as GameObject;
        // float yaxis= Random.Range(-1.5f,4f);
        if(Random.value>0.5)
        a.transform.position=new Vector2(screenBounds.x*1.3f,-2f);
        else
        a.transform.position=new Vector2(screenBounds.x*1.3f,-1f);
    }

    IEnumerator Waver()
    {
        while(true)
        {
            float toWait= Random.Range(7.0f,20f);
            yield return new WaitForSeconds(toWait+1.0f);
            SpawnEnemy();
        }
    }
}
