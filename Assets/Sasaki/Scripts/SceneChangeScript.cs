using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    void Update()   
    {
        //エンターを押したら
        if (Input.GetKey(KeyCode.Return))
        {
            //"StageSelectScene"に遷移する
            SceneManager.LoadScene("PlayerMoveScene");
        }
    }
}
