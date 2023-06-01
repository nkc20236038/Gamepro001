using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Km : MonoBehaviour
{
    int len = 0;
    GameObject kyoriText;
    // Start is called before the first frame update
    void Start()
    {
        kyoriText = GameObject.Find("Km");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(len);
        len += 1;
        float length = len;
        kyoriText.GetComponent<TextMeshProUGUI>().text =
           len.ToString("D6") + "km";

    }
}
