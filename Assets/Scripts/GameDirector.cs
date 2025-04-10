using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject timerText;
    public GameObject pointText;
    public GameObject itemGenerator;

    float time = 30.0f;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;

        if (this.time < 0)
        {
            this.time = 0;
            this.itemGenerator.GetComponent<ItemGenerator>().SetParameter(10000f, 0, 0);
        }
        else if (this.time >= 0 && this.time < 4)
        {
            this.itemGenerator.GetComponent<ItemGenerator>().SetParameter(0.9f, -0.06f, 0);
        }
        else if (this.time >= 4 && this.time < 12)
        {
            this.itemGenerator.GetComponent<ItemGenerator>().SetParameter(0.4f, -0.05f, 6);
        }
        else if (this.time >= 12 && this.time < 23)
        {
            this.itemGenerator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 4);
        }
        else if (this.time >= 23 && this.time < 30)
        {
            this.itemGenerator.GetComponent<ItemGenerator>().SetParameter(1.0f, -0.03f, 2);
        }


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
