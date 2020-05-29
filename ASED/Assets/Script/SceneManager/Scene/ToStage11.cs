using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage11 : MonoBehaviour {

    // Stage11へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(12);
    }
}
