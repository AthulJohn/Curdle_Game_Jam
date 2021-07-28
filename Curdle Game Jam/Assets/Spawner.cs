using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject exhaust;
    public float spawntime;
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

    IEnumerator Waver()
    {
        while(true)
        {
            float toWait= Random.Range(1.0f,3.5f);
            yield return new WaitForSeconds(toWait+1.0f);
            SpawnEnemy();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
