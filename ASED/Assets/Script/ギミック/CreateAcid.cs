using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAcid : MonoBehaviour {

    // 酸の動く向き
    public enum MOVE_DISTANCE
    {
        NONE = 0,
        TOP,
        DOWN,
        RIGHT,
        LEFT,
    }
    // 酸のゲームオブジェクト
    public GameObject acid;
    // 酸の動く向き
    public MOVE_DISTANCE dis;

    // Use this for initialization
    void Start () {
        // 酸の生成
        Create();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // 酸の生成
    void Create()
    {
        // 酸の生成
        GameObject obj = Instantiate(acid);
        // 酸の生成座標の決定
        obj.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.0f);
        // 酸の大きさの決定
        obj.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, 0.0f);
        // 酸の動く向きを決定
        switch(dis)
        {
            case MOVE_DISTANCE.TOP:
                obj.GetComponent<ASED>().dis = ASED.MOVE_DISTANCE.TOP;
                break;
            case MOVE_DISTANCE.DOWN:
                obj.GetComponent<ASED>().dis = ASED.MOVE_DISTANCE.DOWN;
                break;
            case MOVE_DISTANCE.RIGHT:
                obj.GetComponent<ASED>().dis = ASED.MOVE_DISTANCE.RIGHT;
                break;
            case MOVE_DISTANCE.LEFT:
                obj.GetComponent<ASED>().dis = ASED.MOVE_DISTANCE.LEFT;
                break;
            default:
                break;
        }

    }
}
