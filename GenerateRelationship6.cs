﻿using UnityEngine;
using System.Collections;

public class GenerateRelationship6 : MonoBehaviour {
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
	void Update () {
	
	}

    IEnumerator main()
    {
        
        //float r = Random.Range(0f, 1f);
        //Debug.Log(r);
        //yield return new WaitForSeconds(r);
        if ((transform.position.x < 300) && (transform.position.x > -300) && (transform.position.y < 150) && (transform.position.y > -150))
        {
            pobj = this.gameObject;
            //上
            Vector2 POS1 = new Vector2(this.transform.position.x, this.transform.position.y + 100);
            //下
            Vector2 POS2 = new Vector2(this.transform.position.x, this.transform.position.y - 100);
            //右上
            Vector2 POS3 = new Vector2(this.transform.position.x + Mathf.Cos(do30) * 100, this.transform.position.y + Mathf.Sin(do30) * 100);
            //右下
            Vector2 POS4 = new Vector2(this.transform.position.x + Mathf.Cos(do330) * 100, this.transform.position.y + Mathf.Sin(do330) * 100);
            //左上
            Vector2 POS5 = new Vector2(this.transform.position.x + Mathf.Cos(do150) * 100, this.transform.position.y + Mathf.Sin(do150) * 100);
            //左下
            Vector2 POS6 = new Vector2(this.transform.position.x + Mathf.Cos(do210) * 100, this.transform.position.y + Mathf.Sin(do210) * 100);

            //ray用のpos//
            //上
            Vector3 RPOS1 = new Vector3(0,1,0);
            //下
            Vector3 RPOS2 = new Vector3(0,-1,0);
            Ray ray1 = new Ray(transform.position, POS2);
            yield return new WaitForSeconds(1f);
            if (Physics.Raycast(ray1, 400.0f) == false)
            {
                Debug.Log("no hit!!");
                GameObject cobj2 = (GameObject)Instantiate(obj, POS2, Quaternion.identity);
                cobj2.transform.SetParent(pobj.transform);
            }
            else
            {
                Debug.Log("hit!!");
            }
            Debug.DrawRay(ray1.origin, ray1.direction*400, Color.red, 5, false);

            Ray ray2 = new Ray(transform.position, POS1);
            yield return new WaitForSeconds(1f);
            if (Physics.Raycast(ray2, 400.0f) == false)
            {
                Debug.Log("no hit!!");
                GameObject cobj1 = (GameObject)Instantiate(obj, POS1, Quaternion.identity);
                cobj1.transform.SetParent(pobj.transform);
            }
            Debug.DrawRay(ray2.origin, ray2.direction * 400, Color.black, 5, false);

            yield return new WaitForSeconds(1f);
            if (Physics.Raycast(transform.position, POS3, 400.0f) == false)
            {
                Debug.Log("no hit!!");
                GameObject cobj3 = (GameObject)Instantiate(obj, POS3, Quaternion.identity);
                cobj3.transform.SetParent(pobj.transform);
            }

            yield return new WaitForSeconds(1f);
            if (Physics.Raycast(transform.position, POS4, 400.0f) == false)
            {
                Debug.Log("no hit!!");
                GameObject cobj4 = (GameObject)Instantiate(obj, POS4, Quaternion.identity);
                cobj4.transform.SetParent(pobj.transform);
            }

            

            yield return new WaitForSeconds(1f);
            if (Physics.Raycast(transform.position, POS6, 400.0f) == false)
            {
                Debug.Log("no hit!!");
                GameObject cobj6 = (GameObject)Instantiate(obj, POS6, Quaternion.identity);
                cobj6.transform.SetParent(pobj.transform);
            }

            yield return new WaitForSeconds(1f);
            if (Physics.Raycast(transform.position, POS5, 400.0f) == false)
            {
                Debug.Log("no hit!!");
                GameObject cobj5 = (GameObject)Instantiate(obj, POS5, Quaternion.identity);
                cobj5.transform.SetParent(pobj.transform);
            }
        }
    }
}
