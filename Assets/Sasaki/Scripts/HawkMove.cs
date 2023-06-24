using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawkMove : MonoBehaviour
{
    private float time;
    [SerializeField]
    private float speed = 2; //スピード

    [SerializeField]
    private float y = 4; //y軸

    [Tooltip("xの幅")]
    [SerializeField]
    private float width= 4; //幅
    
    [Tooltip("高さ")]
    [SerializeField]
    private float height= 1; //高さ

    Vector2 pos;

    bool rote = true;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime * speed;

        //八の字移動
        transform.position = new Vector2(pos.x + Mathf.Sin(time) * width, pos.y + Mathf.Sin(time * 2) * height);

        //xの判定
        if (this.transform.position.x <= 0.0001f - width + pos.x)
        {
            rote = false;
        }
        else if (this.transform.position.x >= pos.x + width - 0.0001f)
        {
            rote = true;
        }
        //キャラの向き
        Vector2 lscale = gameObject.transform.localScale;
        if ((lscale.x < 0 && rote) || (lscale.x > 0 && !rote))
        {
            lscale.x *= -1;
            gameObject.transform.localScale = lscale;
        }
    }
}
