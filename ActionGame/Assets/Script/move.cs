using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private CharacterController characterController;
    private Vector3 velocity;
    [SerializeField]
    private float walkSpeed;


    // 以下キャラクターコントローラ用パラメタ
    // 前進速度
    public float forwardSpeed = 3.0f;
    // 後退速度
    public float backwardSpeed = 3.0f;
    // 旋回速度
    public float rotateSpeed = 2.0f;

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update () {
        //カメラに対してローカル移動


        float h = Input.GetAxis("Horizontal");              // 入力デバイスの水平軸をhで定義
        float v = Input.GetAxis("Vertical");                // 入力デバイスの垂直軸をvで定義
        float r = Input.GetAxis("CameraHorizontal");              // 入力デバイスの水平軸をhで定義


        // 以下、キャラクターの移動処理
        velocity = new Vector3(h, 0, v);        // 上下のキー入力からZ軸方向の移動量を取得
                                                // キャラクターのローカル空間での方向に変換
        velocity = transform.TransformDirection(velocity);
        //以下のvの閾値は、Mecanim側のトランジションと一緒に調整する
        if (v > 0.1 || h > 0.1)
        {
            velocity *= forwardSpeed;       // 移動速度を掛ける
        }
        else if (v < -0.1 || h < -0.1)
        {
            velocity *= backwardSpeed;  // 移動速度を掛ける
        }

        // 移動キー入力でキャラクターを移動させる
        transform.localPosition += velocity * Time.fixedDeltaTime;

        // 左右のキー入力でキャラクタをY軸で旋回させる
        transform.Rotate(0, r * rotateSpeed, 0);

    }
}
