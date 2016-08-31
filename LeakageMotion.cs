using UnityEngine;
using System.Collections;

public class LeakageMotion : MonoBehaviour {

    public bool leakage = false;
    public bool oneshot = false;
    public GameObject arrowobj;
    private GameObject obj;

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
                //上 //右上 //右下 //下 //左下 //左上
                if (gameObject.GetComponent<Relationship6>().Obj_Up != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS1, Qua1);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_Up;
                    scalesize = checkspeed(obj);
                    scalesize = 5 * 2;
                    arrow.transform.localScale = new Vector3(5,5,scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_UpperRight != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS2, Qua2);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_UpperRight;
                    scalesize = checkspeed(obj);
                    scalesize = 5 * 2;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_LowerRight != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS3, Qua3);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_LowerRight;
                    scalesize = checkspeed(obj);
                    scalesize = 5 * 2;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_Under != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS4, Qua4);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_Under;
                    scalesize = checkspeed(obj);
                    scalesize = 5 * 2;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_LowerLeft != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS5, Qua5);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_LowerLeft;
                    scalesize = checkspeed(obj);
                    scalesize = 5 * 2;
                    arrow.transform.localScale = new Vector3(5, 5, scalesize);
                }
                if (gameObject.GetComponent<Relationship6>().Obj_UpperLeft != null)
                {
                    GameObject arrow = (GameObject)Instantiate(arrowobj, POS6, Qua6);
                    obj = this.gameObject.GetComponent<Relationship6>().Obj_UpperLeft;
                    scalesize = checkspeed(obj);
                    scalesize = 5 * 2;
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
            }
        }
    }

    float checkspeed(GameObject obj)
    {
        float speed = 0f;
        if (this.gameObject.CompareTag("i"))
        {
            if (obj.CompareTag("friend")) speed = PlayerPrefs.GetFloat("i-friend");
            if (obj.CompareTag("teacher")) speed = PlayerPrefs.GetFloat("i-teacher");
            if (obj.CompareTag("parent")) speed = PlayerPrefs.GetFloat("i-parent");
            if (obj.CompareTag("senior")) speed = PlayerPrefs.GetFloat("i-senior");
            if (obj.CompareTag("linefriend")) speed = PlayerPrefs.GetFloat("i-linefriend");
            if (obj.CompareTag("follower")) speed = PlayerPrefs.GetFloat("i-follower");
        }
        else if(this.gameObject.CompareTag("friend"))
        {
            if (obj.CompareTag("friend")) speed = PlayerPrefs.GetFloat("friend-friend");
            if (obj.CompareTag("teacher")) speed = PlayerPrefs.GetFloat("friend-teacher");
            if (obj.CompareTag("senior")) speed = PlayerPrefs.GetFloat("friend-senior");
            if (obj.CompareTag("other")) speed = PlayerPrefs.GetFloat("friend-other");
        }
        else if(this.gameObject.CompareTag("teacher"))
        {
            if (obj.CompareTag("friend")) speed = PlayerPrefs.GetFloat("teacher-friend");
            if (obj.CompareTag("senior")) speed = PlayerPrefs.GetFloat("teacher-senior");
            if (obj.CompareTag("headmaster")) speed = PlayerPrefs.GetFloat("teacher-headmaster");
        }
        else if(this.gameObject.CompareTag("parent"))
        {
            if (obj.CompareTag("relative")) speed = PlayerPrefs.GetFloat("parent-relative");
        }
        else if(this.gameObject.CompareTag("senior"))
        {
            if (obj.CompareTag("friend")) speed = PlayerPrefs.GetFloat("senior-friend");
            if (obj.CompareTag("cult")) speed = PlayerPrefs.GetFloat("senior-cult");
            if (obj.CompareTag("senior")) speed = PlayerPrefs.GetFloat("senior-senior");
            if (obj.CompareTag("other")) speed = PlayerPrefs.GetFloat("senior-other");
        }
        else if(this.gameObject.CompareTag("linefriend") || this.gameObject.CompareTag("other") || this.gameObject.CompareTag("relative"))
        {
            if (obj.CompareTag("other")) speed = PlayerPrefs.GetFloat("-other");
        }
        else if(this.gameObject.CompareTag("cult") || this.gameObject.CompareTag("believer"))
        {
            if (obj.CompareTag("believer")) speed = PlayerPrefs.GetFloat("-believer");
        }
        else if(this.gameObject.CompareTag("follower"))
        {
            if (obj.CompareTag("twitteruser")) speed = PlayerPrefs.GetFloat("follower-twitteruser");
        }
        else if(this.gameObject.CompareTag("twitteruser"))
        {
            if (obj.CompareTag("twitteruser")) speed = PlayerPrefs.GetFloat("twitteruser-twitteruser");
        }
        return speed;
    }
}
