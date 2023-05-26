using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject Time;

    // Start is called before the first frame update
    void Start()
    {
        this.Time = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        this.Time.GetComponent<Image>().fillAmount -= 0.001f;

    }


    public void DecreaseTime()
    {
        this.Time.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
