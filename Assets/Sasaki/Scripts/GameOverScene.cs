using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //エンターを押したら
        if (Input.GetKey(KeyCode.Return))
        {
            //"StageSelectScene"に遷移する
            SceneManager.LoadScene("TitleScene");
        }

    }
}
