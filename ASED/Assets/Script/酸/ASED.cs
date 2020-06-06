using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    Rigidbody2D rb;

    // 速度
    public float speed;

    public MOVE_DISTANCE dis;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
    }

    //当たり判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        //pipeに当たったら
        if (collision.gameObject.tag == "Pipe")
        {
            // 1.5秒後に破壊
            Destroy(collision.gameObject,1.5f);
        }

        //Pipe_L_2に当たったら
        if (collision.gameObject.tag == "Pipe_L_2")
        {
            dis = MOVE_DISTANCE.RIGHT;
            // 1.5秒後に破壊
            Destroy(collision.gameObject,1.5f);
        }

        //Pipe_L_2(gyaku1)に当たったら
        if (collision.gameObject.tag == "Pipe_L_2(gyaku1)")
        {
            dis = MOVE_DISTANCE.RIGHT;
            // 1.5秒後に破壊
            Destroy(collision.gameObject,1.5f);
        }

        //Pipe_L_2(gyaku2)に当たったら
        if (collision.gameObject.tag == "Pipe_L_2(gyaku2)")
        {
            dis = MOVE_DISTANCE.DOWN;
            // 1.5秒後に破壊
            Destroy(collision.gameObject,1.5f);
        }

        //Pipe_L_2(gyaku3)に当たったら
        if (collision.gameObject.tag == "Pipe_L_2(gyaku3)")
        {
            dis = MOVE_DISTANCE.TOP;
            // 1.5秒後に破壊
            Destroy(collision.gameObject,1.5f);
        }

        // Flowerに当たったら
        if (collision.gameObject.tag == "Flower")
        {
            // GAMEOVERに移動
            UnityEngine.SceneManagement.SceneManager.LoadScene(18);
        }

    }

    void Move()
     {
        // どの方向に移動するか
        switch (dis)
        {
            case MOVE_DISTANCE.TOP:
                rb.velocity = new Vector2(rb.velocity.x, speed);
                break;

            case MOVE_DISTANCE.DOWN:
                rb.velocity = new Vector2(rb.velocity.x, -speed);
                break;

            case MOVE_DISTANCE.RIGHT:
                rb.velocity = new Vector2(speed, rb.velocity.y);
                break;

            case MOVE_DISTANCE.LEFT:
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                break;

            default:
                break;
        }

    }
}


