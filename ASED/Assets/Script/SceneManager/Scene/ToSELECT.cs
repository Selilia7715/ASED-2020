using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSELECT : MonoBehaviour {

    // SELECTへ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }



    void Update()
    {
        // ENTERキーでSELECTへ移動
        if (Input.GetKeyDown(KeyCode.Return))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }

}
