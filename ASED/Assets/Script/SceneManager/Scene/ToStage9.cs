using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage9 : MonoBehaviour {

    // Stage9へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(10);
    }
}
