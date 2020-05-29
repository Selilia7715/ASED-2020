using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage14 : MonoBehaviour {

    // Stage14へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(15);
    }
}
