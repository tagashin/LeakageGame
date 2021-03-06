﻿using UnityEngine;
using System.Collections;

public class GenerateRelationship3D6 : MonoBehaviour {
    public GameObject obj;
    public GameObject pobj;
    public float do30 = 30 * Mathf.Deg2Rad;
    public float do150 = 150 * Mathf.Deg2Rad;
    public float do210 = 210 * Mathf.Deg2Rad;
    public float do330 = 330 * Mathf.Deg2Rad;



    // Use this for initialization
    void Start () {
        StartCoroutine(main());
    }
    // Update is called once per frame
    void Update(){

    }

    IEnumerator main()
    {
        if ((transform.position.x < 300) && (transform.position.x > -300) && (transform.position.z < 150) && (transform.position.z > -150))
        {
            pobj = this.gameObject;

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

            yield return new WaitForSeconds(waittimecount());
            if (Physics.Raycast(ray1, 60f) == false)
            {
                GameObject cobj1 = (GameObject)Instantiate(obj, POS1, Quaternion.identity);
                cobj1.transform.SetParent(pobj.transform);
                Debug.DrawRay(ray1.origin, ray1.direction * 60, Color.red, 1, false);
            }
            else
            {
                Debug.DrawRay(ray1.origin, ray1.direction * 60, Color.white, 1, false);
            }

            yield return new WaitForSeconds(waittimecount());
            if (Physics.Raycast(ray2, 60f) == false)
            {
                GameObject cobj2 = (GameObject)Instantiate(obj, POS2, Quaternion.identity);
                cobj2.transform.SetParent(pobj.transform);
                Debug.DrawRay(ray2.origin, ray2.direction * 60, Color.red, 1, false);
            }
            else
            {
                Debug.DrawRay(ray2.origin, ray2.direction * 60, Color.white, 1, false);
            }

            yield return new WaitForSeconds(waittimecount());
            if (Physics.Raycast(ray3, 60f) == false)
            {
                GameObject cobj3 = (GameObject)Instantiate(obj, POS3, Quaternion.identity);
                cobj3.transform.SetParent(pobj.transform);
                Debug.DrawRay(ray3.origin, ray3.direction * 60, Color.red, 1, false);
            }
            else
            {
                Debug.DrawRay(ray3.origin, ray3.direction * 60, Color.white, 1, false);
            }

            yield return new WaitForSeconds(waittimecount());
            if (Physics.Raycast(ray4, 60f) == false)
            {
                GameObject cobj4 = (GameObject)Instantiate(obj, POS4, Quaternion.identity);
                cobj4.transform.SetParent(pobj.transform);
                Debug.DrawRay(ray4.origin, ray4.direction * 60, Color.red, 1, false);
            }
            else
            {
                Debug.DrawRay(ray4.origin, ray4.direction * 60, Color.white, 1, false);
            }

            yield return new WaitForSeconds(waittimecount());
            if (Physics.Raycast(ray5, 60f) == false)
            {
                GameObject cobj5 = (GameObject)Instantiate(obj, POS5, Quaternion.identity);
                cobj5.transform.SetParent(pobj.transform);
                Debug.DrawRay(ray5.origin, ray5.direction * 60, Color.red, 1, false);
            }
            else
            {
                Debug.DrawRay(ray5.origin, ray5.direction * 60, Color.white, 1, false);
            }

            yield return new WaitForSeconds(waittimecount());
            if (Physics.Raycast(ray6, 60f) == false)
            {
                GameObject cobj6 = (GameObject)Instantiate(obj, POS6, Quaternion.identity);
                cobj6.transform.SetParent(pobj.transform);
                Debug.DrawRay(ray6.origin, ray6.direction * 60, Color.red, 1, false);
            }
            else
            {
                Debug.DrawRay(ray6.origin, ray6.direction * 60, Color.white, 1, false);
            }
        }
    }

    float waittimecount()
    {
        /*
        //ray用のベクトル// //上 //右上 //右下 //下 //左下 //左上
        Vector3 RPOS1 = new Vector3(0f, 0f, 1f);
        Vector3 RPOS2 = new Vector3(Mathf.Cos(do30), 0f, Mathf.Sin(do30));
        Vector3 RPOS3 = new Vector3(Mathf.Cos(do330), 0f, Mathf.Sin(do330));
        Vector3 RPOS4 = new Vector3(0f, 0f, -1f);
        Vector3 RPOS5 = new Vector3(Mathf.Cos(do210), 0f, Mathf.Sin(do210));
        Vector3 RPOS6 = new Vector3(Mathf.Cos(do150), 0f, Mathf.Sin(do150));

        //ray // //上 //右上 //右下 //下 //左下 //左上
        Ray ray1 = new Ray(transform.position, RPOS1);
        Ray ray2 = new Ray(transform.position, RPOS2);
        Ray ray3 = new Ray(transform.position, RPOS3);
        Ray ray4 = new Ray(transform.position, RPOS4);
        Ray ray5 = new Ray(transform.position, RPOS5);
        Ray ray6 = new Ray(transform.position, RPOS6);

        float count = 0.0f;
        if (Physics.Raycast(ray1, 400f)) { count += 1.2f; }
        if (Physics.Raycast(ray2, 400f)) { count += 1.2f; }
        if (Physics.Raycast(ray3, 400f)) { count += 1.2f; }
        if (Physics.Raycast(ray4, 400f)) { count += 1.2f; }
        if (Physics.Raycast(ray5, 400f)) { count += 1.2f; }
        if (Physics.Raycast(ray6, 400f)) { count += 1.2f; }
        return count;
        /*
        float count = Random.Range(5.0f,9.5f);
        return count;
        */
        return 2f;
    }
}
