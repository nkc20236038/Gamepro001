using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercontroller : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.2f, 0, 0);    //上に（　）動かす
        }

        //Sキーが押されたとき
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.2f, 0, 0);　　//下に（　）動かす
        }
        
    }
}
       
    

