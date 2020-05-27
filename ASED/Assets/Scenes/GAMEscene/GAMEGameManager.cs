using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GAMEGameManager : MonoBehaviour
{
    //protected static SceneInfo[] gamelist = new SceneInfo[15];
    //[System.Serializable]
    [System.NonSerialized]
    public bool clearFg;
    [System.NonSerialized]
    public bool failedFg;
    [System.NonSerialized]
    public bool selectFg;  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("CLEAR");
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene("SELECT");
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_WEBPLAYER
	            	Application.OpenURL("http://www.yahoo.co.jp/");
            #else
	            	Application.Quit();
            #endif
        }
    }
}
