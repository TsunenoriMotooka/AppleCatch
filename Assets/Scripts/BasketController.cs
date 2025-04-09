using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {        
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("ray:" + ray);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                Debug.Log("x:"+x + " z:" + z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }
}
