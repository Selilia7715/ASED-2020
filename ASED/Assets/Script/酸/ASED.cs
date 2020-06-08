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

    // 進行方向
    public MOVE_DISTANCE dis;

    // 一つ前の進行方向
    private MOVE_DISTANCE beforeDis;

    // 一つ前の座標
    private Vector3 beforePos;

    // 下降中
    private bool descendingFlg = false;

    private int descendingCnt = 0;

    void Start()
    {
        // リジボの取得
        rb = GetComponent<Rigidbody2D>();
        // 進行方向の取得
        beforeDis = dis;
        // 座標の取得
        beforePos = transform.position;
    }
    void Update()
    {
        // 動作処理
        Move();
    }

    //当たり判定
    void OnCollisionStay2D(Collision2D collision)
    {
        // 進行方向の再算出
        if( MOVE_DISTANCE.NONE == dis && 
            "Pipe" == collision.gameObject.tag )
        {
            Pipe.Pipe_Status status = collision.gameObject.GetComponent<Pipe>().status;
            if ( MOVE_DISTANCE.RIGHT == beforeDis && 
                true == status.right)
            {
                dis = MOVE_DISTANCE.RIGHT;
                beforeDis = dis;
            }
            else if( MOVE_DISTANCE.LEFT == beforeDis &&
                true == status.left)
            {
                dis = MOVE_DISTANCE.LEFT;
                beforeDis = dis;
            }
            else if ( MOVE_DISTANCE.TOP == beforeDis || 
                MOVE_DISTANCE.DOWN == beforeDis )
            {
                if (true == status.right &&
                    false == status.left)
                {
                    dis = MOVE_DISTANCE.RIGHT;
                }
                else if (false == status.right &&
                    true == status.left)
                {
                    dis = MOVE_DISTANCE.LEFT;
                }
                else if( true == status.right &&
                    true == status.left)
                {
                    // 2つに分かれる処理
                }
            }
        }
    }

    //当たり判定
    void OnCollisionEnter2D(Collision2D collision)
    {
        //pipeに当たったら
        if ( "Pipe" == collision.gameObject.tag )
        {
            // 進行方向の決定
            if (DistanceDecision(collision.gameObject) )
            {
                // 1.5秒後に破壊
                //Destroy(collision.gameObject, 1.5f);
            } 
        }

        // Flowerに当たったら
        if ( "Flower" == collision.gameObject.tag )
        {
            // GAMEOVERに移動
            UnityEngine.SceneManagement.SceneManager.LoadScene(18);
        }

    }

    // 進行方向の決定
    bool  DistanceDecision(GameObject obj)
    {
        Pipe.Pipe_Status status = obj.GetComponent<Pipe>().status;

        // 進行方向通りに進めればtrue、そうでなければfalse
        bool moveOnFlg = true;

        // 進行方向通りに進めない場合
        switch (dis)
        {
            case MOVE_DISTANCE.TOP:
                if ( true != status.down )
                {
                    beforeDis = dis;
                    dis = MOVE_DISTANCE.DOWN;
                    moveOnFlg = false;
                }
                break;
   
            case MOVE_DISTANCE.DOWN:
                if ( true != status.top )
                {
                    beforeDis = dis;
                    dis = MOVE_DISTANCE.TOP;
                    moveOnFlg = false;
                }
                break;

            case MOVE_DISTANCE.RIGHT:
                if ( true != status.right )
                {
                    beforeDis = dis;
                    dis = MOVE_DISTANCE.LEFT;
                    moveOnFlg = false;
                }
                break;

            case MOVE_DISTANCE.LEFT:
                if ( true != status.left )
                {
                    beforeDis = dis;
                    dis = MOVE_DISTANCE.RIGHT;
                    moveOnFlg = false;
                }
                break;

            default:
                break;
        }

        return moveOnFlg;
             
    }

    // 動作処理
    void Move()
     {
        // 下方向
        if (beforePos.y > transform.position.y + 0.1f ||
            beforePos.y < transform.position.y - 0.1f)
        {
            dis = MOVE_DISTANCE.DOWN;
            descendingFlg = true;
        }
        else if (MOVE_DISTANCE.DOWN == dis && 
            true == descendingFlg &&
            beforePos.y == transform.position.y)
        {
            dis = MOVE_DISTANCE.NONE;
            descendingFlg = false;
        }

        // どの方向に移動するか
        switch (dis)
        {
            case MOVE_DISTANCE.TOP:
                rb.velocity = new Vector2(rb.velocity.x, speed);
                break;

            case MOVE_DISTANCE.DOWN:
                //rb.velocity = new Vector2(rb.velocity.x, -speed);
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
        
        if( 0 == descendingCnt % 30)
        {
            beforePos.y = transform.position.y;
        }

        descendingCnt++;

    }
}


