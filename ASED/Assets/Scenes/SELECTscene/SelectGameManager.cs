using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectGameManager : MonoBehaviour
{
    protected static int stagenum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            stagenum = 1;
            SceneManager.LoadScene("GAME");
        }
    }

    public static int SelectToGame()
    {
        return stagenum;
    }
}
