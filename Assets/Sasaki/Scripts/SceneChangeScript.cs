using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    void Update()   
    {
        //ƒGƒ“ƒ^[‚ğ‰Ÿ‚µ‚½‚ç
        if (Input.GetKey(KeyCode.Return))
        {
            //"StageSelectScene"‚É‘JˆÚ‚·‚é
            SceneManager.LoadScene("PlayerMoveScene");
        }
    }
}
