using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage4 : MonoBehaviour {

    // Stage4へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }
}
