using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASED : MonoBehaviour {

    // 酸の動く向き
    public enum MOVE_DISTANCE
    {
        NONE = 0,
        TOP,
        DOWN,
        RIGHT,
        LEFT,
    }

    // 速度
    public float speed;
    // 動く方向
    public MOVE_DISTANCE dis;

    void Update()
    {
    }
}


//   //当たり判定
//   void OnCollisionEnter2D(Collision2D collision)
//   {
//       //敵に当たったら
//       if (collision.gameObject.tag == "Pipe")
//       {
//           Destroy(collision.gameObject);
//       }
//   }