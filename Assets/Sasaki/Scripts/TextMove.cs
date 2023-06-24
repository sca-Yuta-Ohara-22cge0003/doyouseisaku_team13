using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMove : MonoBehaviour
{
    [SerializeField]
    private float time = 2.0f;
    [SerializeField]
    private float speed = 10;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Swith", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(0, y * speed * Time.deltaTime);
        transform.Translate(pos);
    }

    void Swith()
    {
        y = -1f;
        //time�b���Swith2�����s����
        Invoke("Swith2", time);
    }
    void Swith2()
    {
        y = 1f;
        //time�b���Swith�����s����
        Invoke("Swith", time);
    }
}
