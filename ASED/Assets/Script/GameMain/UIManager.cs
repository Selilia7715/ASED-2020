using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    //----------public変数--------------//

    //----------------------------------//

    //---------private変数--------------//

    //----------------------------------//


    //------------フラグ系-----------------//
    private bool gameStartUpFlg;                 //ゲーム画面が起動しているかどうかの判定


    public bool poseFlg;                         //pose画面が起動しているかどうかの判定
    //-------------------------------------//


	// Use this for initialization
	void Start () {
        Initialize();
	}
	
	// Update is called once per frame
	void Update () {
        //gameStartUpFlgの切り替え
        CheckGameStartUp();
	}


    //初期化関数
    public void Initialize()
    {
        gameStartUpFlg = false;
        poseFlg = false;
    }

    //ゲームを起動させてもいいのかを判定する関数
    private void CheckGameStartUp()
    {
        //各フラグがfalseになっているかのチェック
        if (poseFlg == false)
        {
            gameStartUpFlg = true;
        }
        else
        {
            gameStartUpFlg = false;
        }
    }


    //poseFlg変換関数
    public void ChangePoseFlg(bool flg)
    {
        poseFlg = flg;
    }


}
