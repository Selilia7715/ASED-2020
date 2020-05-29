using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage3 : MonoBehaviour {

    // Stage3へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }
}
