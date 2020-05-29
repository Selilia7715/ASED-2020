using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respone : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;   //60fps
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //リスポーン
    void Respone()
    {
        Transform myTransform = player.transform;         //オブジェクトの位置取得
        Vector3 pos = myTransform.position;

        //飛ばしたい座標
        pos.x = -5.0f;
        pos.y = 0.0f;

        myTransform.position = pos;

        player.SetActive(true);         //自機を見えるようにする
    }

    //当たり判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        //敵に当たったら
        if (collision.gameObject.tag == "Player")
        {
            //Responeを3秒後に呼び出す
            Invoke("Respone", 3f/*何秒後にリスポーンさせるか*/);
            player.SetActive(false);            //自機を見えないようにする
        }
    }
}
