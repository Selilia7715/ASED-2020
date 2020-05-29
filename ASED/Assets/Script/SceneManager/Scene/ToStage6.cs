using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStage6 : MonoBehaviour {

    // Stage6へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }
}
