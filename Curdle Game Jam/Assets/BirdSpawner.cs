using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
         screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        StartCoroutine(Waver());
    }

    public void SpawnEnemy(){
        GameObject a=Instantiate(bird) as GameObject;
        // float yaxis= Random.Range(-1.5f,4f);
        if(Random.value>0.5)
        a.transform.position=new Vector2(screenBounds.x*2,-1f);
        else
        a.transform.position=new Vector2(screenBounds.x*2,2.0f);

    }

    IEnumerator Waver()
    {
        while(true)
        {
            float toWait= Random.Range(4.0f,10f);
            yield return new WaitForSeconds(toWait+1.0f);
            SpawnEnemy();
        }
    }
}
