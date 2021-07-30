using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
   private Vector2 screenBounds;
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
         screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        StartCoroutine(Waver());
    }

    public void SpawnEnemy(){
        GameObject a=Instantiate(fire) as GameObject;
        a.transform.position=new Vector2(screenBounds.x*2,-2.9f);
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
