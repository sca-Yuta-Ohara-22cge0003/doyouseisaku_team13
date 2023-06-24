using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingLivesManager : MonoBehaviour
{
    private GameObject _playerObject;
    private PlayerMove _playerMove;

    //private int _remainingLivesValue = 2;
    public static int _remainingLivesValue = 2;
    private bool _remainingLivesMinus = false;

    public static RemainingLivesManager instance; //�I�u�W�F�N�g

    [SerializeField] private float _changeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject); //���̃}�l�[�W���[�͑J�ڂ��Ă������Ȃ�
        _playerObject = GameObject.Find("Player");
        _playerMove = _playerObject.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�����Ȃ���ԁA���A�v���C���[��T���Ă݂����ɑ��݂���Ƃ�
        //if(_playerObject == null && GameObject.Find("Player") != null)
        //{
        //    _playerObject = GameObject.Find("Player");
        //    _playerMove = _playerObject.GetComponent<PlayerMove>();
        //}

        if (!(_playerMove.GetPlayerDead()) && !(_remainingLivesMinus))
        {
            _remainingLivesValue--;
            _remainingLivesMinus = true;
            StartCoroutine(DeadTime());

            Debug.Log("dhfuiaeghuiervbuyeipgvu");
        }
    }

    IEnumerator DeadTime()
    {
        yield return new WaitForSeconds(_changeTime);
        _remainingLivesMinus = false;
    }

    public int GetRemainingLives()
    {
        return _remainingLivesValue;
    }

    //private void Awake() //���@����
    //{
    //    CheckInstance(); //�C���X�^���X����ʓ��ɂ������݂����ׂ�
    //}

    //void CheckInstance()
    //{
    //    if (instance == null)
    //    {
    //        //�I�u�W�F�N�g�̓o�^
    //        instance = this;
    //    }
    //    else
    //    {
    //        //���ł�instance�ɃI�u�W�F�N�g���i�[����Ă���ꍇ�͍폜
    //        Destroy(gameObject);
    //    }
    //}
}
