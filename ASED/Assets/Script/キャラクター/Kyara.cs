using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kyara : MonoBehaviour
{
    // 速度

    public Vector2 SPEED = new Vector2(0.2f, 0.2f);
    public float flap = 5000.0f;
    bool jump = false;
    Rigidbody2D rb2d;
    // Use this for initialization

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame

    void Update()
    {
        // 移動処理
        Move();

        //ジャンプ判定
        if (Input.GetKeyDown("space") && !jump)
        {
            rb2d.AddForce(Vector2.up * flap);
            jump = true;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipe") || collision.gameObject.CompareTag("Pipe_L_2") ||
            collision.gameObject.CompareTag("Pipe_L_2(gyaku1)") || collision.gameObject.CompareTag("Pipe_L_2(gyaku2)") || collision.gameObject.CompareTag("Pipe_L_2(gyaku3)"))
        {
            jump = false;
        }

        if (collision.gameObject.tag == "Flower")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

    }

    // 移動関数

    void Move()
    {
        // 現在位置をPositionに代入
        Vector2 Position = transform.position;

        // 左キーを押し続けていたら

        if (Input.GetKey("left"))
        {

            // 代入したPositionに対して加算減算を行う

            Position.x -= SPEED.x;

        }
        else if (Input.GetKey("right"))
        { // 右キーを押し続けていたら

            // 代入したPositionに対して加算減算を行う

            Position.x += SPEED.x;

        }
        // 上キーを押し続けていたら

        if (Input.GetKey("up"))
        {

            // 代入したPositionに対して加算減算を行う

            Position.y += SPEED.y;

        }
        else if (Input.GetKey("down"))
        { // 下キーを押し続けていたら

            // 代入したPositionに対して加算減算を行う

            Position.y -= SPEED.y;

        }

        // 現在の位置に加算減算を行ったPositionを代入する

        transform.position = Position;

    }





}


