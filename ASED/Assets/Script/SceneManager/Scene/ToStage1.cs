using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 遷移する前のシーンのMonoBehaviourのクラス

public class  ToStage1: MonoBehaviour
{
    // Stage1へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
