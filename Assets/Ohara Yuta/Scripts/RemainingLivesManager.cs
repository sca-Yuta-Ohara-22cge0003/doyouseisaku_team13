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

    public static RemainingLivesManager instance; //オブジェクト

    [SerializeField] private float _changeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject); //このマネージャーは遷移しても消えない
        _playerObject = GameObject.Find("Player");
        _playerMove = _playerObject.GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーがいない状態、かつ、プレイヤーを探してみた時に存在するとき
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

    //private void Awake() //動機処理
    //{
    //    CheckInstance(); //インスタンスが画面内にいくつ存在か調べる
    //}

    //void CheckInstance()
    //{
    //    if (instance == null)
    //    {
    //        //オブジェクトの登録
    //        instance = this;
    //    }
    //    else
    //    {
    //        //すでにinstanceにオブジェクトが格納されている場合は削除
    //        Destroy(gameObject);
    //    }
    //}
}
