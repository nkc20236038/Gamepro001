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
        //フレームごとに等速で移動
        transform.Translate(-0.2f, 0, 0);

        //画面外に出たらオブジェクトを破壊
        if (transform.position.x < -10.2f)
        {
            Destroy(gameObject);
        }
        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 1.0f;




        if (d < r1 + r2)
        {
            //監督に衝突伝達
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();

            //衝突した場合敵は消える
            Destroy(gameObject);
        }

   
    }
}
