using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TitleGameManager : MonoBehaviour
{
    //セーブ情報時間があれば
    public class SceneInfo
    {
        public bool clearFg;        //クリアしてるかどうか
        public int stagenum;        //何番目のステージか
        public int cleartime;       //クリア時間
        public bool itemFg;         //アイテムとったかどうか
    };

    //ここの変数をいじるときは特に注意
    //ステージ数
    [System.NonSerialized]
    public static int elenum = 15;
    //シーン間に必要な情報クラス 
    [System.NonSerialized]
    public static SceneInfo[] titlelist = new SceneInfo[elenum];
    //現在選択されているステージ
    [System.NonSerialized]
    public static int stagenum;

    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        //ステージ情報初期化
        for (int i = 0; i < elenum; i++)
        {
            titlelist[i].clearFg = false;
            titlelist[i].itemFg = false;
            titlelist[i].stagenum = i + 1;
            titlelist[i].cleartime = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SELECT");
        }
    }

    //public static SceneInfo[] titletogamesceneinfo()
    //{
    //    return titlelist;
    //}
    //public static int titletogameelenum()
    //{
    //    return elenum;
    //}
}
