using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    [Tooltip("x‚Ì”ÍˆÍ")]
    [SerializeField]
    [Range(0, 20)]
    private float range_x = 5;
    [Tooltip("‰•œ‚·‚éŠÔ")]
    [SerializeField]
    [Range(0, 3)]
    private float time = 1;
    private Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(pos.x + Mathf.Sin((Time.time) / time) * range_x, pos.y);
    }
}
