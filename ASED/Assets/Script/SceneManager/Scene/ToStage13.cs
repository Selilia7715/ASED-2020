using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage13 : MonoBehaviour {

    // Stage13へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(14);
    }
}
