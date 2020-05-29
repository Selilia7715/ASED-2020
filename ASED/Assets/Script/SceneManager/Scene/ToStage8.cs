using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage8 : MonoBehaviour {

    // Stage8へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(9);
    }
}
