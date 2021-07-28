using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamControl : MonoBehaviour
{
    public int moveSpeed = 4;
    public GameObject baloon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PushUp();
        }
        
    }

    void PushUp()
{
    //  Vector3 position = transform.position;
    //  Vector3 targetPosition = other.gameObject.transform.position;
    //  Vector3 direction = targetPosition - position;
    //  direction.Normalize();
    Debug.Log("Down");
    for(int i=0;i<moveSpeed;i++)
     baloon.transform.position += new Vector3(0,1,0) * Time.deltaTime;

}
}
