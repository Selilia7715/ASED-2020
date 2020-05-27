using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyara : MonoBehaviour
{

    //public Vector3 SPEED = new Vector3(0.01f, 0.01f,0.0f);
    public float jump = 350;
    bool isflg = false;

    private Rigidbody2D rb;

    public float SpeedX = 3;
    // xbox
    public float moveHorizontal;
    public float moveVertical;

    //private gamemanager manager;
    //private GameObject managerobj;

    // Use this for initialization
    void Start()
    {
        //float x = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody2D>();

        //マネージャー取得
        //managerobj = GameObject.Find("GameManager");
        //manager = managerobj.GetComponent<gamemanager>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, -Vector2.down);
        hit.distance = 0.5f;
        Vector3 raystart = transform.position;
        raystart.y += 0.5f;
        //　Cubeのレイを飛ばしターゲットと接触しているか判定
        if (//Physics.BoxCast(raystart, Vector3.one * 0.5f, Vector3.down, out hit, 0.5f, LayerMask.GetMask("Default"))
                hit.collider != null)
        {
            isflg = false;
        }

        if (!isflg) // 地面フラグ
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jump);
                isflg = true;
            }
        }

        Move(); // 横移動
    }

    // 横移動
    void Move()
    {
        Vector3 Position = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.position -= new Vector3(SpeedX, 0.0f, 0.0f);
            rb.velocity = new Vector2(SpeedX, 0.0f);
            Debug.Log("a");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //transform.position += new Vector3(SpeedX, 0.0f, 0.0f);
            rb.velocity = new Vector2(-SpeedX, 0.0f);
        }

    }

}
