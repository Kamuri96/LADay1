using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : Character
{
    //キャラクタータイプの指定
    CharactorType cType = CharactorType.Villager;
    // 生成するダイアログに当たるゲームオブジェクト
    [SerializeField]
    GameObject dialogObject;
    // ダイアログを生成するHierarchy上で親関係となるゲームオブジェクト
    [SerializeField]
    Transform canvas;
    //向き制御用
    [SerializeField]
    GameObject target;

    private void Start()
    {

    }

    private void Update()
    {
        LookYAxis(target.transform.position); //Y軸を常にPlayerの方向へ
    }

    // ダメージを受けた際の実装例
    /*void ダメージを受けた！()
    {
        SetDialog("表示するテキスト","誰が話しているか");
    }*/

    /// <summary>
    /// ダイヤログへ文字を表示させる処理
    /// </summary>
    /// <param name="content">表示させる内容</param>
    /// <param name="talker">話者</param>

    private void SetDialog(string content, string talker)
    {
        // ダイアログを生成させる
        var dialog = Instantiate(dialogObject, canvas);
        // Dialogクラスを呼び出し、表示処理を実行する
        dialog.GetComponent<Dialog>().DisplayDialog(content, talker);
        Destroy(dialog, 3);
    }

    internal override void Attack()
    {
        //実行されない
    }

    internal override void Damage()
    {
        DisplayDialog();
    }

    internal override void Dead()
    {
        //実行されない
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerBullet"||other.gameObject.tag == "EnemyBullet")
        {
            Damage();
        }
    }

    void DisplayDialog()
    {
        SetDialog("Hi!", "Villager");
    }
}
