using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Scene格納
public enum Scene_Name
{
    TITLE, // 0
    SELECT,
    Stage1,
    Stage2,
    Stage3,
    Stage4,
    Stage5,
    Stage6,
    Stage7,
    Stage8,
    Stage9,
    Stage10,
    Stage11,
    Stage12,
    Stage13,
    Stage14,
    Stage15,
    CLERA,
    GAMEOVER,

};

/* static とは静的メンバー(変数や、メソッド等を、インスタンス単位で生成するのではなく、
 アプリケーションにただ１つだけ生成したいときに使用します。)*/

// シングルトン
public class SceneManager : MonoBehaviour
{
    // 唯一のインスタンス
    protected static SceneManager instance;

    public string[] sceneName; // 文字列



    public static SceneManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (SceneManager)FindObjectOfType(typeof(SceneManager));

                if (Instance == null)
                {
                    Debug.LogError("SceneManager instance Error");
                }
            }

            return instance;
        }
    }


    void Awake() // Start関数より早く呼び出される　オブジェクトが配置された後に呼び出される
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("SceneManager");
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // シーン遷移
    public void NextScene(int index)
    {
        if (0 > index || sceneName.Length <= index)  // 配列変数名.Length  Length(配列の長さを取得する)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName[index]);
        }
    }
}

