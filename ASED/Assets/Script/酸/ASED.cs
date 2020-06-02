using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASED : MonoBehaviour {

    float speed;


    void Update()
    {
    }
}

//   public Vector2 SPEED = new Vector2(0.1f, 0.1f);
//   Rigidbody2D rb;

//   // Use this for initialization
//   void Start () {
//       rb = GetComponent<Rigidbody2D>();
//   }

//   // Update is called once per frame
//   void Update () {
//       Move();


//}

//   void Move()
//   {
//       // 現在位置をPositionに代入

//       Vector2 Position = transform.position;

//       // 左キーを押し続けていたら

//       if (Input.GetKey("left"))
//       {
//           Position.x -= SPEED.x;
//       }
//       else if (Input.GetKey("right"))
//       { 
//           Position.x += SPEED.x;
//       }
//       else if(Input.GetKey("up"))
//       {
//           Position.y += SPEED.y;
//       }
//       else if(Input.GetKey("down"))
//       {
//           Position.y -= SPEED.y;
//       }

//       // 現在の位置に加算減算を行ったPositionを代入する

//       transform.position = Position;

//   }

//   //当たり判定
//   void OnCollisionEnter2D(Collision2D collision)
//   {
//       //敵に当たったら
//       if (collision.gameObject.tag == "Pipe")
//       {
//           Destroy(collision.gameObject);
//       }
//   }