using UnityEngine;
using System.Collections;

public class LeakageMotion : MonoBehaviour {

    public bool leakage = false;
    public bool oneshot = false;
    public GameObject arrowobj;
    private GameObject obj;

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

    public float do30 = 30 * Mathf.Deg2Rad;
    public float do150 = 150 * Mathf.Deg2Rad;
    public float do210 = 210 * Mathf.Deg2Rad;
    public float do330 = 330 * Mathf.Deg2Rad;
    private int i;

    // Use this for initialization
    void Start () {
        i = 1;
	}
	
	// Update is called once per frame
	void Update () {
        //arrow生成用// //上 //右上 //右下 //下 //左下 //左上
        Vector3 POS1 = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10.1f);
        Vector3 POS2 = new Vector3(transform.position.x + Mathf.Cos(do30) * 10.1f, transform.position.y, transform.position.z + Mathf.Sin(do30) * 10.1f);
        Vector3 POS3 = new Vector3(transform.position.x + Mathf.Cos(do330) * 10.1f, transform.position.y, transform.position.z + Mathf.Sin(do330) * 10.1f);
        Vector3 POS4 = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10.1f);
        Vector3 POS5 = new Vector3(transform.position.x + Mathf.Cos(do210) * 10.1f, transform.position.y, transform.position.z + Mathf.Sin(do210) * 10.1f);
        Vector3 POS6 = new Vector3(transform.position.x + Mathf.Cos(do150) * 10.1f, transform.position.y, transform.position.z + Mathf.Sin(do150) * 10.1f);

        //arrow生成用// //上 //右上 //右下 //下 //左下 //左上
        Vector3 RPOS1 = new Vector3(0f, 0f, 1f);
        Vector3 RPOS2 = new Vector3(Mathf.Cos(do30), 0f, Mathf.Sin(do30));
        Vector3 RPOS3 = new Vector3(Mathf.Cos(do330), 0f, Mathf.Sin(do330));
        Vector3 RPOS4 = new Vector3(0f, 0f, -1f);
        Vector3 RPOS5 = new Vector3(Mathf.Cos(do210), 0f, Mathf.Sin(do210));
        Vector3 RPOS6 = new Vector3(Mathf.Cos(do150), 0f, Mathf.Sin(do150));

        Quaternion Qua1 = Quaternion.Euler(0,0,0);
        Quaternion Qua2 = Quaternion.Euler(0,60,0);
        Quaternion Qua3 = Quaternion.Euler(0,120,0);
        Quaternion Qua4 = Quaternion.Euler(0,180,0);
        Quaternion Qua5 = Quaternion.Euler(0,240,0);
        Quaternion Qua6 = Quaternion.Euler(0,300,0);

        if (oneshot == false)
        {
            if (leakage == true)
            {
                float scalesize;
                float i = 5;
                //上 //右上 //右下 //下 //左下 //左上
                if (gameObject.GetComponent<Relationship6>().Obj_Up != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS1, Qua1);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_Up;
                    scalesize = checkspeed(obj);
                    //scalesize = i;
                    arrow.transform.localScale = new Vector3(5,5,scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_UpperRight != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS2, Qua2);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_UpperRight;
                    scalesize = checkspeed(obj);
                    //scalesize = i;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_LowerRight != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS3, Qua3);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_LowerRight;
                    scalesize = checkspeed(obj);
                    //scalesize = i;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_Under != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS4, Qua4);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_Under;
                    scalesize = checkspeed(obj);
                    //scalesize = i;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_LowerLeft != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS5, Qua5);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_LowerLeft;
                    scalesize = checkspeed(obj);
                    //scalesize = i;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_UpperLeft != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS6, Qua6);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_UpperLeft;
                    scalesize = checkspeed(obj);
                    //scalesize = i;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                oneshot = true;
            }
        }

	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("arrow"))
        {
            if (leakage == false)
            {
                this.gameObject.GetComponent<Renderer>().materials[1].color = Color.red;
                leakage = true;
                collider.gameObject.GetComponent<ArrowMotion>().stop = true;
                GameObject Cobj = GameObject.Find("CountObject");
                Cobj.GetComponent<Count>().count++;
                Cobj.GetComponent<Count>().NPOS = this.gameObject.transform.position;
            }
        }
    }

    float checkspeed(GameObject obj)
    {
        float speed = 0f;
        if (this.gameObject.CompareTag("i"))
        {
            if (obj.CompareTag("friend")) speed = GetScale(Pattern.IFriend);
            if (obj.CompareTag("teacher")) speed = GetScale(Pattern.ITeacher);
            if (obj.CompareTag("parent")) speed = GetScale(Pattern.IParent);
            if (obj.CompareTag("senior")) speed = GetScale(Pattern.ISenior);
            if (obj.CompareTag("linefriend")) speed = GetScale(Pattern.ILinefriend);
            if (obj.CompareTag("follower")) speed = GetScale(Pattern.IFollower);
        }
        else if(this.gameObject.CompareTag("friend"))
        {
            if (obj.CompareTag("friend")) speed = GetScale(Pattern.FriendFriend);
            if (obj.CompareTag("teacher")) speed = GetScale(Pattern.FriendTeacher);
            if (obj.CompareTag("senior")) speed = GetScale(Pattern.FriendSenior);
            if (obj.CompareTag("other")) speed = GetScale(Pattern.FriendSenior);
        }
        else if(this.gameObject.CompareTag("teacher"))
        {
            if (obj.CompareTag("friend")) speed = GetScale(Pattern.TeacherFriend);
            if (obj.CompareTag("senior")) speed = GetScale(Pattern.TeacherSenior);
            if (obj.CompareTag("headmaster")) speed = GetScale(Pattern.TeacherHeadmaster);
        }
        else if(this.gameObject.CompareTag("parent"))
        {
            if (obj.CompareTag("relative")) speed = GetScale(Pattern.ParentRelative);
        }
        else if(this.gameObject.CompareTag("senior"))
        {
            if (obj.CompareTag("friend")) speed = GetScale(Pattern.SeniorFriend);
            if (obj.CompareTag("cult")) speed = GetScale(Pattern.SeniorCult);
            if (obj.CompareTag("senior")) speed = GetScale(Pattern.SeniorSenior);
            if (obj.CompareTag("other")) speed = GetScale(Pattern.SeniorOther);
        }
        else if(this.gameObject.CompareTag("linefriend") || this.gameObject.CompareTag("other") || this.gameObject.CompareTag("relative"))
        {
            if (obj.CompareTag("other")) speed = GetScale(Pattern.Other);
        }
        else if(this.gameObject.CompareTag("cult") || this.gameObject.CompareTag("believer"))
        {
            if (obj.CompareTag("believer")) speed = GetScale(Pattern.Believer);
        }
        else if(this.gameObject.CompareTag("follower"))
        {
            if (obj.CompareTag("twitteruser")) speed = GetScale(Pattern.FollowerTwitteruser);
        }
        else if(this.gameObject.CompareTag("twitteruser"))
        {
            if (obj.CompareTag("twitteruser")) speed = GetScale(Pattern.TwitteruserTwitteruser);
        }
        return speed;
    }
    float GetScale(Pattern P)
    {
        string key = P.ToString();
        return PlayerPrefs.GetFloat(key);
    }
}
