using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage7 : MonoBehaviour {

    // Stage7へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(8);
    }
}
