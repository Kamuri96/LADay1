using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character
{
    //キャラクタータイプの指定
    CharactorType cType = CharactorType.Monster;
    // HPを表示させるスライダー
    [SerializeField]
    Slider hpSlider;
    // 攻撃した際に発射されるGameObject
    [SerializeField]
    GameObject fireBallBullet;
    // 死亡した際に表示するテキスト
    [SerializeField]
    GameObject deadText;
    //向き制御用
    [SerializeField]
    GameObject target;
    //攻撃処理用
    float cycle;
    float currentTime = 0f;
    //ダメージ処理用
    int damage;

    void Start()
    {
        hpSlider.value = 1;
        Maxhp = hp;
    }

    void Update()
    {
        cycle = 3f;
        currentTime += Time.deltaTime;
        if(currentTime > cycle)
        {
            Attack();
            currentTime = 0f;
        }

        LookYAxis(target.transform.position); //Y軸を常にPlayerの方向へ
    }

    internal override void Attack()
    {
        Instantiate(fireBallBullet,this.transform.position,this.transform.rotation);
    }

    internal override void Damage()
    {
        damage = 10;
        hp -= damage;
        hpSlider.value = (float)hp / (float)Maxhp;
        if (hp <= 0)
        {
            Dead();
        }
    }

    internal override void Dead()
    {
        deadText.gameObject.SetActive(true);
        hpSlider.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerBullet")
        {
            Damage();
        }
    }
}