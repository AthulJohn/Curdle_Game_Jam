using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    public float moveSpeed=3f;
    public GameObject exhaust;
    public float spawntime;
     private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
        Rigidbody2D rb=GetComponent<Rigidbody2D>();
        rb.velocity=new Vector2(-moveSpeed,0);
    }

     void Update()
    {
        if(transform.position.x< -3f*screenBounds.x)
        {
            SpawnEnemy();
            Destroy(gameObject);}
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name=="Baloon")
        {
            other.gameObject.GetComponent<BaloonControl>().GameOver("Oops! Crashed to the ground!");
        }
    }

    public void SpawnEnemy(){
        GameObject a=Instantiate(exhaust) as GameObject;
        a.name="groundClone";
        a.transform.position=new Vector2(screenBounds.x*3f,gameObject.transform.position.y);
    }
}
