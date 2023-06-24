using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndRollText : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.0f;
    private bool _scrollEnd = false;
    [SerializeField] private float _scrollStopPosY = 2500;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void FixedUpdate()
    {
        if (_scrollStopPosY <= this.transform.position.y)
        {
            _scrollEnd = true;
            this.transform.position = new Vector3(transform.position.x, _scrollStopPosY, transform.position.z);
        }

        if (!_scrollEnd)
        {
            transform.Translate(0, _moveSpeed, 0);
        }
    }
}
