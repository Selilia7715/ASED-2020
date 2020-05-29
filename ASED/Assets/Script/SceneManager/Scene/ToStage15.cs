using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage15 : MonoBehaviour {

    // Stage15へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(16);
    }
}
