using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 遷移する前のシーンのMonoBehaviourのクラス

public class ToStage2 : MonoBehaviour
{
    // Stage2へ移動
    public void ButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
