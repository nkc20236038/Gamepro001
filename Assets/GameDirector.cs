using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameDirector : MonoBehaviour
{
     GameObject Time;
    public Text distanceText;
    private float distance;
    private float playTime;

    // Start is called before the first frame update
    void Start()
    {
        this.Time = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        this.Time.GetComponent<Image>().fillAmount -= 0.001f;
        playTime += Time.deltaTime;
        distance = playTime * 10;

        distanceText.text = "Distance" + distance.ToString("F2") + "m";

    }


    public void DecreaseTime()
    {
        this.Time.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
