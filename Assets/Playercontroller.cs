using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class�@Playercontroller : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(-3, 0, 0);    //��Ɂi�@�j������
        }

        //S�L�[�������ꂽ�Ƃ�
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(3, 0, 0);�@�@//���Ɂi�@�j������
        }
    }
}
