using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    void Update()   
    {
        //�G���^�[����������
        if (Input.GetKey(KeyCode.Return))
        {
            //"StageSelectScene"�ɑJ�ڂ���
            SceneManager.LoadScene("PlayerMoveScene");
        }
    }
}
