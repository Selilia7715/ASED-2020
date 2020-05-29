using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage10 : MonoBehaviour {

    // Stage10へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
    }
}
