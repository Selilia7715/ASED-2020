using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {

    // オブジェクト情報
    [System.Serializable]
    public class StageData
    {
        public GameObject obj;
    }

    // ステージ名称
    public string stageNanme;

    // オブジェクト大きさ
    public Vector2 objSize;

    // ステージに配置するオブジェクト群
    public StageData[] stageData;

    // CSVデータ格納変数
    public List<string[]> csvDatas = new List<string[]>();
    // Use this for initialization
    void Start()
    {
        // ファイルパスの作成
        string failPath = "Stage/";
        failPath = failPath + stageNanme;

        // CSV読み込み
        LoadCsv(failPath);
        // ステージ作成
        CreateStage();

        // テスト
        SoundManager.Instance.PlayBGM((int)BGM_NAME.TITLE);
    }

    // Update is called once per frame
    void Update()
    {
    }

    // CSV読み込み関数
    void LoadCsv(string csvName)
    {
        //テキストの読み込み
        TextAsset csv = Resources.Load(csvName) as TextAsset;
        StringReader reader = new StringReader(csv.text);
        while (reader.Peek() > -1)
        {
            // ','ごとに区切って配列へ格納
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(','));
        }
    }

    // ステージ生成関数
    void CreateStage()
    {
        // 初期座標の決定
        Vector2 objPos;
        objPos.x = -((csvDatas[0].Length * objSize.x));
        objPos.y = ((csvDatas.Count * objSize.y) / 2.0f);
        // SpriteとPositionの補正値
        Vector2 offsetPos;
        offsetPos.x = stageData[(int)1].obj.GetComponent<SpriteRenderer>().bounds.size.x - (objSize.x * 2.0f);
        offsetPos.y = stageData[(int)1].obj.GetComponent<SpriteRenderer>().bounds.size.y - (objSize.y * 2.0f);

        // Y座標
        for (int y = 0; y < csvDatas.Count; y++)
        { 
            // X座標
            for(int x = 0;x < csvDatas[y].Length;x++)
            {
                // 0の時は何も生成しない(生成オブジェクトなし)
                if( 0 != int.Parse(csvDatas[y][x]))
                {
                    // ステージオブジェクトの生成
                    GameObject obj = Instantiate(stageData[int.Parse(csvDatas[y][x])].obj);
                    // オブジェクト座標を決定する
                    obj.transform.position = new Vector3(objPos.x, objPos.y, 0.0f);
                    // オブジェクトの大きさを決定する
                    obj.transform.localScale = new Vector3(objSize.x, objSize.y, 0.0f);
                }
                // X座標を加算する
                objPos.x += ((objSize.x * 2.0f) + offsetPos.x);
            }
            // X座標を初期座標にする
            objPos.x = -((csvDatas[0].Length * objSize.x));

            // Y座標を減算する
            objPos.y -= ((objSize.y * 2.0f) + offsetPos.y);
        }
    }

}
