using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// キャラクターの種類を示すEnum「CharactorType」
/// </summary>

/// <summary>
/// キャラクターの状態を示すEnum「CharactorState」
/// </summary>

public abstract class Character : MonoBehaviour
{
    // 整数型の変数hpとmpを作成
    public int hp;
    public int mp;
    public int Maxhp;

    // EnumのCharactorTypeを定義
    public enum CharactorType
    {
        Monster,
        Player,
        Buddy,
        Pet,
        Villager
    }

    // EnumのCharactorStateを定義
    public enum CharactorState
    {
        Alive,
        Dead,
        Stay
    }

    // 抽象メソッドを作成（abstract, virtualどちらでも構わない）
    // 死亡処理を行うメソッド
    internal abstract void Dead();

    // 攻撃処理を行うメソッド
    internal abstract void Attack();

    // ダメージ処理を行うメソッド
    internal abstract void Damage();


    /// <summary>
    /// ターゲットに対してY軸方向で振り向く
    /// </summary>
    /// <param name="target">ターゲットの三次元座標</param>
    public void LookYAxis(Vector3 target)
    {
        // ターゲットへの方向ベクトル
        Vector3 direction = target - transform.position;
        direction.y = 0;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, 0.1f);
    }
}
