using UnityEngine;
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
            
            GameObject cobj1 = (GameObject)Instantiate(obj, POS1, Quaternion.identity);
            GameObject cobj2 = (GameObject)Instantiate(obj, POS2, Quaternion.identity);
            GameObject cobj3 = (GameObject)Instantiate(obj, POS3, Quaternion.identity);
            GameObject cobj4 = (GameObject)Instantiate(obj, POS4, Quaternion.identity);
            GameObject cobj5 = (GameObject)Instantiate(obj, POS5, Quaternion.identity);
            GameObject cobj6 = (GameObject)Instantiate(obj, POS6, Quaternion.identity);
            cobj1.transform.SetParent(pobj.transform);
            cobj2.transform.SetParent(pobj.transform);
            cobj3.transform.SetParent(pobj.transform);
            cobj4.transform.SetParent(pobj.transform);
            cobj5.transform.SetParent(pobj.transform);
            cobj6.transform.SetParent(pobj.transform);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
