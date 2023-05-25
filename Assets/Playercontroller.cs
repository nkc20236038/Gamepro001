using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class　Playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
             
    }

    // Update is called once per frame
    void Update()
    {
        //Wキーが押された時
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(-3, 0, 0);    //上に（　）動かす
        }

        //Sキーが押されたとき
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(3, 0, 0);　　//下に（　）動かす
        }
    }
}
