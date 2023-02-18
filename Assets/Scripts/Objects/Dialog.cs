using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    // 内容にあたるテキストを表示させる
    [SerializeField]
    Text contentsText;
    // 話者にあたるテキストを表示させる
    [SerializeField]
    Text talkerText;

    /// <summary>
    /// ダイヤログへ文字を表示させる処理
    /// </summary>
    /// <param name="content">表示させる内容</param>
    /// <param name="talker">話者</param>
    public void DisplayDialog(string content = "", string talker = "")
    {
        talkerText.text = talker;
        contentsText.text = content;
    }
}
