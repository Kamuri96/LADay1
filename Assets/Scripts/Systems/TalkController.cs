using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkController : MonoBehaviour
{
    /// <summary>
    /// 誰が話しているかの話者を指定するEnum
    /// </summary>
    public enum Talker
    {
        Player,
        Buddy,
        Enemy
    }


    /// <summary>
    /// Talkデータを持つ構造体
    /// </summary>
    public struct TalkStruct
    {
        public int id;
        public Talker talker;
        public string contents;

        public TalkStruct(int id,Talker talker,string contents)
        {
            this.id = id;
            this.talker = talker;
            this.contents = contents;
        }
    }


    /// <summary>
    /// TalkStruct型のListを定義する
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        List<TalkStruct> talkStructList = new List<TalkStruct>();
        talkStructList.Add(new TalkStruct(1, Talker.Player, "おはよう"));
        talkStructList.Add(new TalkStruct(2, Talker.Buddy, "今日もいい天気だね"));
        talkStructList.Add(new TalkStruct(3, Talker.Player, "待って、あそこに何かいる"));
        talkStructList.Add(new TalkStruct(4, Talker.Enemy, "がおー"));
        talkStructList.Add(new TalkStruct(5, Talker.Buddy, "うわ！ゴブリンが出てきた！"));

        foreach(TalkStruct ts in talkStructList)
        {
            Debug.Log("Talker:" + ts.talker + ",Contents:" + ts.contents);
        }
    }
}
