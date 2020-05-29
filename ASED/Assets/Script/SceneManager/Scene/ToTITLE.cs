using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTITLE : MonoBehaviour {

    // TITLEへ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
