using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip apleSE;
    public AudioClip bombSE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {        
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Catch " + (other.gameObject.tag == "Apple" ? "Apple" : "Bomb"));
        if (other.gameObject.tag == "Apple")
        {
            this.audioSource.PlayOneShot(this.apleSE);
        } 
        else if (other.gameObject.tag == "Bomb")
        {
            this.audioSource.PlayOneShot(this.bombSE);
        }
        Destroy(other.gameObject);
    }
}
