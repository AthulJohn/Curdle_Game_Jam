using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject exhaust,fire;
    public float spawntime;
    int var=0;
    // Start is called before the first frame update
    void Start()
    {
         screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        StartCoroutine(Waver());
    }

    public void SpawnEnemy(){
        GameObject a=Instantiate(exhaust) as GameObject;
        a.transform.position=new Vector2(screenBounds.x*2,-2.9f);
    }

    public void SpawnFire(){
        GameObject a=Instantiate(fire) as GameObject;
        a.transform.position=new Vector2(screenBounds.x*2,-2.9f);
    }

    IEnumerator Waver()
    {
        while(true)
        {
            float toWait= Random.value;
            yield return new WaitForSeconds(toWait+0.5f);
           var+=Random.Range(1,3);
           var=var%4;
           if(var==0)
            SpawnFire();
            else
            SpawnEnemy();
        }
    }
}
