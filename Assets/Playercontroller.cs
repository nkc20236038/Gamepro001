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
        //W�L�[�������ꂽ��
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.2f, 0, 0);    //��Ɂi�@�j������
        }

        //S�L�[�������ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.2f, 0, 0);�@�@//���Ɂi�@�j������
        }
        
    }
}
       
    

