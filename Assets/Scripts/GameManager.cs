using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool firstPush = false;
    //スタートボタンを押したら呼ばれる
    public void PressStart()
    {
        Debug.Log("Press Start!");

        if(!firstPush)
        {
            Debug.Log("Go Next Scene!");
            FadeManager.FadeOut(1);
            //次のシーンへ行く
            // SceneManager.LoadScene("MainScese");
            //
            firstPush = true;
        }

    }
}
