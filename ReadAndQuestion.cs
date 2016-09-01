using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReadAndQuestion : MonoBehaviour {

    private int last = 16;
    private string question = "";
    public string[] getstrings;
    public string[] cutstrings = null;
    private bool next = false;
    public bool yes = false;
    public bool no = false;
    public int number = 1;
    public TextAsset textA;
    private string TexT;

    float IFriend = 1;
    float ITeacher = 1;
    float IParent = 1;
    float ISenior = 1;
    float ILinefriend = 1;
    float IFollower = 1;
    float FriendFriend = 1;
    float FriendTeacher = 1;
    float FriendSenior = 1;
    float FriendOther = 1;
    float TeacherFriend = 1;
    float TeacherSenior = 1;
    float TeacherHeadmaster = 1;
    float ParentRelative = 1;
    float SeniorFriend = 1;
    float SeniorCult = 1;
    float SeniorSenior = 1;
    float SeniorOther = 1;
    float Other = 1;
    float Believer = 1;
    float FollowerTwitteruser = 1;
    float TwitteruserTwitteruser = 1;
    public enum Pattern
    {
        IFriend,
        ITeacher,
        IParent,
        ISenior,
        ILinefriend,
        IFollower,
        FriendFriend,
        FriendTeacher,
        FriendSenior,
        FriendOther,
        TeacherFriend,
        TeacherSenior,
        TeacherHeadmaster,
        ParentRelative,
        SeniorFriend,
        SeniorCult,
        SeniorSenior,
        SeniorOther,
        Other,
        Believer,
        FollowerTwitteruser,
        TwitteruserTwitteruser
    }
    void Start ()
    {
        TexT = textA.text;
        getstrings = TexT.Split('\n');
        next = true;
	}
	void Update ()
    {
        if (number <= last)
        {
            if (next == true)//次へ進む許可が出ていたら
            {
                cutstrings = null;//中身を空にし
                cutstrings = getstrings[number].Split('\t');//新しい行をタブで分解したものを入れる
                next = false;//そして止める
            }
            if (yes == true)//はいが押されたとき
            {
                if (int.Parse(cutstrings[2]) == 0)
                {
                    Add();
                }
                yes = false;
                no = false;
                number++;
                next = true;
            }
            else if (no == true)//いいえが押されたとき
            {
                if (int.Parse(cutstrings[2]) == 1)
                {
                    Add();
                }
                yes = false;
                no = false;
                next = true;
                number++;
            }
            question = cutstrings[1];
            GetComponent<Text>().text = question;
        }
        if(number == last+1)
        {
            save();
            SceneManager.LoadScene("rouei");
        }
    }
    void Add()
    {
        IFriend *= float.Parse(cutstrings[3]);
        ITeacher *= float.Parse(cutstrings[4]);
        IParent *= float.Parse(cutstrings[5]);
        ISenior *= float.Parse(cutstrings[6]);
        ILinefriend *= float.Parse(cutstrings[7]);
        IFollower *= float.Parse(cutstrings[8]);
        FriendFriend *= float.Parse(cutstrings[9]);
        FriendTeacher *= float.Parse(cutstrings[10]);
        FriendSenior *= float.Parse(cutstrings[11]);
        FriendOther *= float.Parse(cutstrings[12]);
        TeacherFriend *= float.Parse(cutstrings[13]);
        TeacherSenior *= float.Parse(cutstrings[14]);
        TeacherHeadmaster *= float.Parse(cutstrings[15]);
        ParentRelative *= float.Parse(cutstrings[16]);
        SeniorFriend *= float.Parse(cutstrings[17]);
        SeniorCult *= float.Parse(cutstrings[18]);
        SeniorSenior *= float.Parse(cutstrings[19]);
        SeniorOther *= float.Parse(cutstrings[20]);
        Other *= float.Parse(cutstrings[21]);
        Believer *= float.Parse(cutstrings[22]);
        FollowerTwitteruser *= float.Parse(cutstrings[23]);
        TwitteruserTwitteruser *= float.Parse(cutstrings[24]);
    }
    void save()
    {
        changsave(Pattern.IFriend,IFriend);
        changsave(Pattern.ITeacher,ITeacher);
        changsave(Pattern.IParent,IParent);
        changsave(Pattern.ISenior,ISenior);
        changsave(Pattern.ILinefriend,ILinefriend);
        changsave(Pattern.IFollower,IFollower);
        changsave(Pattern.FriendFriend,FriendFriend);
        changsave(Pattern.FriendSenior,FriendSenior);
        changsave(Pattern.FriendTeacher,FriendTeacher);
        changsave(Pattern.FriendOther,FriendOther);
        changsave(Pattern.TeacherFriend,TeacherFriend);
        changsave(Pattern.TeacherSenior,TeacherSenior);
        changsave(Pattern.TeacherHeadmaster,TeacherHeadmaster);
        changsave(Pattern.ParentRelative,ParentRelative);
        changsave(Pattern.SeniorFriend,SeniorFriend);
        changsave(Pattern.SeniorCult,SeniorCult);
        changsave(Pattern.SeniorSenior,SeniorSenior);
        changsave(Pattern.SeniorOther,SeniorOther);
        changsave(Pattern.Other,Other);
        changsave(Pattern.Believer,Believer);
        changsave(Pattern.FollowerTwitteruser,FollowerTwitteruser);
        changsave(Pattern.TwitteruserTwitteruser,TwitteruserTwitteruser);
    }
    void changsave(Pattern P,float p)
    {
        string key = P.ToString();
        PlayerPrefs.SetFloat(key,p);
    }
}
