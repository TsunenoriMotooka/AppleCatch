using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject timerText;
    public GameObject pointText;

    float time = 60.0f;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");        
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + " point";
    }

    public void GetApple()   
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
    }
}
