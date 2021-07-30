using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public GameObject mask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            // mask.transform.position=Input.mousePosition;
            Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition) + " "+ gameObject.transform.position);
            Vector2 point=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)mask.transform.parent, Input.mousePosition, GameObject.Find("Main Camera").camera, out point);
            // Debug.Log(point);
            mask.transform.position = point;
        }

    }
}
