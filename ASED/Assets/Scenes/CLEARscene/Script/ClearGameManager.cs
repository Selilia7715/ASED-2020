using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            //次のステージ
            TitleGameManager.stagenum++;
            UnityEngine.SceneManagement.SceneManager.LoadScene("GAME");
        }
    }
}
