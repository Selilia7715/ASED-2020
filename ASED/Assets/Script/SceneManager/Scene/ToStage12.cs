using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage12 : MonoBehaviour {

    // Stage12へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(13);
    }
}
