using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCLEAR : MonoBehaviour {

    // CLEARへ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(17);
    }
}
