using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public bool _alive;

    private Rigidbody2D _rb;

    [SerializeField] private float _speed = 5;
    [SerializeField] private float _jumpForce = 20;

    private float _velocityX = 0;

    private bool _jumpFlag = false;

    private BoxCollider2D _boxCol;

    [SerializeField] private float _changeTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _alive = true;
        _rb = GetComponent<Rigidbody2D>();
        _boxCol = GetComponent<BoxCollider2D>();
        _boxCol.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        _velocityX = 0;

        if (_alive)
        {
            if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
            {
                _velocityX = _speed;
            }
            else if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
            {
                _velocityX = -_speed;
            }

            if (Input.GetKeyDown("up") || Input.GetKeyDown(KeyCode.Space))
            {
                if (_jumpFlag)
                {
                    _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
                }
            }

            Fall();
        }
    }

    private void Fall()
    {
        if (_alive)
        {
            if (transform.position.y <= -10)
            {
                _alive = false;
                StartCoroutine(DeadTime());
                Debug.Log("uifgriauherueu");
            }
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_velocityX, _rb.velocity.y);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //�n�ʂ��u���b�N�̏�ɗ�������W�����v���͂̎󂯕t�����s��
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Block") || collision.gameObject.CompareTag("Switch"))
        {
            _jumpFlag = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //�n�ʂ��u���b�N�𗣂ꂽ��W�����v���͂̎󂯕t�������Ȃ�
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Block") || collision.gameObject.CompareTag("Switch"))
        {
            _jumpFlag = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_alive)
        {
            //Obstacle : ��Q���@�v���C���[����Q��(�)�ɓ��������Ƃ��Ɏ��S������s��
            //Enemy : �G�@�v���C���[���G(�ցA��)�ɓ��������Ƃ��Ɏ��S������s��
            if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Enemy"))
            {
                _alive = false;
                _boxCol.enabled = false;
                _rb.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
                StartCoroutine(DeadTime());
            }
        }
    }

    IEnumerator DeadTime()
    {
        yield return new WaitForSeconds(_changeTime); //1�b�҂�
        _alive = true;
        SceneManager.LoadScene("Test");
    }

    public bool GetPlayerDead()
    {
        return _alive;
    }
}
