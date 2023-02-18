using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 弾の移動速度を指定する
    [SerializeField]
    float moveSpeed = 10f;

    void Start()
    {
        // 弾の削除処理
        Destroy(this.gameObject, 4f);
    }

    void Update()
    {
        // 三次元の移動方向量を計算する
        Vector3 moveValue = Vector3.forward * Time.deltaTime * moveSpeed;
        // 弾を移動させる
        transform.Translate(moveValue);
    }
}
