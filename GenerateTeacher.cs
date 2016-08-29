using UnityEngine;
using System.Collections;

public class GenerateTeacher : MonoBehaviour {
    int randomcount;

    public GameObject obj;

    public GameObject friendobj;
    public GameObject seniorobj;
    public GameObject headmasterobj;

    public GameObject LineObj;
    public GameObject LineParentObj;

    public float do30 = 30 * Mathf.Deg2Rad;
    public float do150 = 150 * Mathf.Deg2Rad;
    public float do210 = 210 * Mathf.Deg2Rad;
    public float do330 = 330 * Mathf.Deg2Rad;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;

    public GameObject Lobj1;
    public GameObject Lobj2;
    public GameObject Lobj3;
    public GameObject Lobj4;
    public GameObject Lobj5;
    public GameObject Lobj6;
    // Use this for initialization
    void Start()
    {
        LineParentObj = GameObject.Find("LineParent");
        //StartCoroutine(main());
            //オブジェクト配置用のPOS// //上 //右上 //右下 //下 //左下 //左上
            Vector3 POS1 = new Vector3(transform.position.x, transform.position.y, transform.position.z + 50);
            Vector3 POS2 = new Vector3(transform.position.x + Mathf.Cos(do30) * 50, transform.position.y, transform.position.z + Mathf.Sin(do30) * 50);
            Vector3 POS3 = new Vector3(transform.position.x + Mathf.Cos(do330) * 50, transform.position.y, transform.position.z + Mathf.Sin(do330) * 50);
            Vector3 POS4 = new Vector3(transform.position.x, transform.position.y, transform.position.z - 50);
            Vector3 POS5 = new Vector3(transform.position.x + Mathf.Cos(do210) * 50, transform.position.y, transform.position.z + Mathf.Sin(do210) * 50);
            Vector3 POS6 = new Vector3(transform.position.x + Mathf.Cos(do150) * 50, transform.position.y, transform.position.z + Mathf.Sin(do150) * 50);

            //ray用のベクトル// //上 //右上 //右下 //下 //左下 //左上
            Vector3 RPOS1 = new Vector3(0f, 0f, 1f);
            Vector3 RPOS2 = new Vector3(Mathf.Cos(do30), 0f, Mathf.Sin(do30));
            Vector3 RPOS3 = new Vector3(Mathf.Cos(do330), 0f, Mathf.Sin(do330));
            Vector3 RPOS4 = new Vector3(0f, 0f, -1f);
            Vector3 RPOS5 = new Vector3(Mathf.Cos(do210), 0f, Mathf.Sin(do210));
            Vector3 RPOS6 = new Vector3(Mathf.Cos(do150), 0f, Mathf.Sin(do150));

            //ray// //上 //右上 //右下 //下 //左下 //左上
            Ray ray1 = new Ray(transform.position, RPOS1);
            Ray ray2 = new Ray(transform.position, RPOS2);
            Ray ray3 = new Ray(transform.position, RPOS3);
            Ray ray4 = new Ray(transform.position, RPOS4);
            Ray ray5 = new Ray(transform.position, RPOS5);
            Ray ray6 = new Ray(transform.position, RPOS6);
            //上のオブジェクト用
            //yield return new WaitForSeconds(waittimecount());
            Lobj1 = (GameObject)Instantiate(LineObj, LineParentObj.transform.position, Quaternion.identity);
            Lobj1.transform.SetParent(LineParentObj.transform);
            if (Physics.Raycast(ray1, 60f) == false)
            {
                randomcounter();
                if (randomcount >= 7)
                {
                    randomobj();
                    obj1 = (GameObject)Instantiate(obj, POS1, Quaternion.identity);
                    Debug.DrawRay(ray1.origin, ray1.direction * 60, Color.red, 1, false);
                    //接続作成
                    Relationship6 myrela = GetComponent<Relationship6>();
                    myrela.Obj_Up = obj1;
                    Relationship6 yourrela = obj1.GetComponent<Relationship6>();
                    yourrela.Obj_Under = this.gameObject;
                    //線を引く
                    LineConnection myLine = Lobj1.GetComponent<LineConnection>();
                    myLine.POS1 = this.gameObject.transform.position;
                    myLine.POS2 = obj1.transform.position;
                }
            }
            else
            {
                Debug.DrawRay(ray1.origin, ray1.direction * 60, Color.white, 1, false);
            }
            //右上のオブジェクト用
            //yield return new WaitForSeconds(waittimecount());
            Lobj2 = (GameObject)Instantiate(LineObj, LineParentObj.transform.position, Quaternion.identity);
            Lobj2.transform.SetParent(LineParentObj.transform);
            //yield return new WaitForSeconds(waittimecount());
            if (Physics.Raycast(ray2, 60f) == false)
            {
                randomcounter();
                if (randomcount >= 7)
                {
                    randomobj();
                    obj2 = (GameObject)Instantiate(obj, POS2, Quaternion.identity);
                    Debug.DrawRay(ray2.origin, ray2.direction * 60, Color.red, 1, false);
                    //接続作成
                    Relationship6 myrela = GetComponent<Relationship6>();
                    myrela.Obj_UpperRight = obj2;
                    Relationship6 yourrela = obj2.GetComponent<Relationship6>();
                    yourrela.Obj_LowerLeft = this.gameObject;
                    //線を引く
                    LineConnection myLine = Lobj2.GetComponent<LineConnection>();
                    myLine.POS1 = this.gameObject.transform.position;
                    myLine.POS2 = obj2.transform.position;
                }
            }
            else
            {
                Debug.DrawRay(ray2.origin, ray2.direction * 60, Color.white, 1, false);
            }
            //右下のオブジェクト用
            //yield return new WaitForSeconds(waittimecount());
            Lobj3 = (GameObject)Instantiate(LineObj, LineParentObj.transform.position, Quaternion.identity);
            Lobj3.transform.SetParent(LineParentObj.transform);
            if (Physics.Raycast(ray3, 60f) == false)
            {
                randomcounter();
                if (randomcount >= 7)
                {
                    randomobj();
                    obj3 = (GameObject)Instantiate(obj, POS3, Quaternion.identity);
                    Debug.DrawRay(ray3.origin, ray3.direction * 60, Color.red, 1, false);
                    //接続作成
                    Relationship6 myrela = GetComponent<Relationship6>();
                    myrela.Obj_LowerRight = obj3;
                    Relationship6 yourrela = obj3.GetComponent<Relationship6>();
                    yourrela.Obj_UpperLeft = this.gameObject;
                    //線を引く
                    LineConnection myLine = Lobj3.GetComponent<LineConnection>();
                    myLine.POS1 = this.gameObject.transform.position;
                    myLine.POS2 = obj3.transform.position;
                }
            }
            else
            {
                Debug.DrawRay(ray3.origin, ray3.direction * 60, Color.white, 1, false);
            }
            //下のオブジェクト用
            //yield return new WaitForSeconds(waittimecount());
            Lobj4 = (GameObject)Instantiate(LineObj, LineParentObj.transform.position, Quaternion.identity);
            Lobj4.transform.SetParent(LineParentObj.transform);
            if (Physics.Raycast(ray4, 60f) == false)
            {
                randomcounter();
                if (randomcount >= 7)
                {
                    randomobj();
                    obj4 = (GameObject)Instantiate(obj, POS4, Quaternion.identity);
                    Debug.DrawRay(ray4.origin, ray4.direction * 60, Color.red, 1, false);
                    //接続作成
                    Relationship6 myrela = GetComponent<Relationship6>();
                    myrela.Obj_Under = obj4;
                    Relationship6 yourrela = obj4.GetComponent<Relationship6>();
                    yourrela.Obj_Up = this.gameObject;
                    //線を引く
                    LineConnection myLine = Lobj4.GetComponent<LineConnection>();
                    myLine.POS1 = this.gameObject.transform.position;
                    myLine.POS2 = obj4.transform.position;
                }
            }
            else
            {
                Debug.DrawRay(ray4.origin, ray4.direction * 60, Color.white, 1, false);
            }
            //左下のオブジェクト用
            //yield return new WaitForSeconds(waittimecount());
            Lobj5 = (GameObject)Instantiate(LineObj, LineParentObj.transform.position, Quaternion.identity);
            Lobj5.transform.SetParent(LineParentObj.transform);
            if (Physics.Raycast(ray5, 60f) == false)
            {
                randomcounter();
                if (randomcount >= 7)
                {
                    randomobj();
                    obj5 = (GameObject)Instantiate(obj, POS5, Quaternion.identity);
                    Debug.DrawRay(ray5.origin, ray5.direction * 60, Color.red, 1, false);
                    //接続作成
                    Relationship6 myrela = GetComponent<Relationship6>();
                    myrela.Obj_LowerLeft = obj5;
                    Relationship6 yourrela = obj5.GetComponent<Relationship6>();
                    yourrela.Obj_UpperRight = this.gameObject;
                    //線を引く
                    LineConnection myLine = Lobj5.GetComponent<LineConnection>();
                    myLine.POS1 = this.gameObject.transform.position;
                    myLine.POS2 = obj5.transform.position;
                }
            }
            else
            {
                Debug.DrawRay(ray5.origin, ray5.direction * 60, Color.white, 1, false);
            }
            //左上のオブジェクト用
            //yield return new WaitForSeconds(waittimecount());
            Lobj6 = (GameObject)Instantiate(LineObj, LineParentObj.transform.position, Quaternion.identity);
            Lobj6.transform.SetParent(LineParentObj.transform);
            if (Physics.Raycast(ray6, 60f) == false)
            {
                randomcounter();
                if (randomcount >= 7)
                {
                    randomobj();
                    obj6 = (GameObject)Instantiate(obj, POS6, Quaternion.identity);
                    Debug.DrawRay(ray6.origin, ray6.direction * 60, Color.red, 1, false);
                    //接続作成
                    Relationship6 myrela = GetComponent<Relationship6>();
                    myrela.Obj_UpperLeft = obj6;
                    Relationship6 yourrela = obj6.GetComponent<Relationship6>();
                    yourrela.Obj_LowerRight = this.gameObject;
                    //線を引く
                    LineConnection myLine = Lobj6.GetComponent<LineConnection>();
                    myLine.POS1 = this.gameObject.transform.position;
                    myLine.POS2 = obj6.transform.position;
                }
            }
            else
            {
                Debug.DrawRay(ray6.origin, ray6.direction * 60, Color.white, 1, false);
            }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    float waittimecount()
    {
        return 0.5f;
    }
    void randomobj()
    {
        int i = Random.Range(0, 3);
        switch (i)
        {
            case 0:
                obj = friendobj;
                break;
            case 1:
                obj = seniorobj;
                break;
            case 2:
                obj = headmasterobj;
                break;
        }

    }
    void randomcounter()
    {
        randomcount = Random.Range(7, 8);
    }
}

