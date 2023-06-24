using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeStraight : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Direction();
    }

    // Update is called once per frame
    void Update()
    {
        //ƒLƒƒƒ‰ˆÚ“®
        Vector2 pos = new Vector2(-speed * Time.deltaTime, 0);
        transform.Translate(pos);
    }

    void Direction()
    {
        //ƒLƒƒƒ‰‚ÌŒü‚«
        Vector2 lscale = gameObject.transform.localScale;
        lscale.x *= -1;
        gameObject.transform.localScale = lscale;
    }
}
