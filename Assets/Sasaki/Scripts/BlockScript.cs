using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField]
    private float time;
    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
            {
            StartCoroutine("CoolTime");
        }
    }
    IEnumerator CoolTime()
    {
        //2秒経ったら
        yield return new WaitForSeconds(time);
        //これを作動する
        this.gameObject.SetActive(false);
    }
}
