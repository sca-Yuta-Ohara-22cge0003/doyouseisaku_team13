using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawkMove : MonoBehaviour
{
    private float time;
    [SerializeField]
    private float speed = 2; //�X�s�[�h

    [SerializeField]
    private float y = 4; //y��

    [Tooltip("x�̕�")]
    [SerializeField]
    private float width= 4; //��
    
    [Tooltip("����")]
    [SerializeField]
    private float height= 1; //����

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

        //���̎��ړ�
        transform.position = new Vector2(pos.x + Mathf.Sin(time) * width, pos.y + Mathf.Sin(time * 2) * height);

        //x�̔���
        if (this.transform.position.x <= 0.0001f - width + pos.x)
        {
            rote = false;
        }
        else if (this.transform.position.x >= pos.x + width - 0.0001f)
        {
            rote = true;
        }
        //�L�����̌���
        Vector2 lscale = gameObject.transform.localScale;
        if ((lscale.x < 0 && rote) || (lscale.x > 0 && !rote))
        {
            lscale.x *= -1;
            gameObject.transform.localScale = lscale;
        }
    }
}
