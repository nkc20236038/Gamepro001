using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //�t���[�����Ƃɓ����ňړ�
        transform.Translate(-0.2f, 0, 0);

        //��ʊO�ɏo����I�u�W�F�N�g��j��
        if (transform.position.x < -10.2f)
        {
            Destroy(gameObject);
        }
        //�����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 1.0f;




        if (d < r1 + r2)
        {
            //�ēɏՓ˓`�B
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();

            //�Փ˂����ꍇ�G�͏�����
            Destroy(gameObject);
        }

   
    }
}
