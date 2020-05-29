using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage5 : MonoBehaviour {

    // Stage5へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
}
