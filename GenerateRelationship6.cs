using UnityEngine;
using System.Collections;

public class GenerateRelationship6 : MonoBehaviour {
    public GameObject obj;
    public GameObject pobj;
    public float do30 = 30 * Mathf.Rad2Deg;
    public float do120 = 120 * Mathf.Rad2Deg;
    public float do210 = 210 * Mathf.Rad2Deg;
    public float do300 = 300 * Mathf.Rad2Deg; 
	// Use this for initialization
	void Start () {
        if ((transform.position.x < 300) && (transform.position.x > -300) && (transform.position.y < 150) && (transform.position.y > -150))
        {
            pobj = this.gameObject;
            //上
            Vector3 POS1 = new Vector3(this.transform.position.x, this.transform.position.y + 100, this.transform.position.z);
            //下
            Vector3 POS2 = new Vector3(this.transform.position.x, this.transform.position.y - 100, this.transform.position.z);
            //右上
            Vector3 POS3 = new Vector3(this.transform.position.x + Mathf.sin, this.transform.position.y, this.transform.position.z);
            //右下
            Vector3 POS4 = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            //左上
            Vector3 POS5 = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            //左下
            Vector3 POS6 = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            
            GameObject cobj1 = (GameObject)Instantiate(obj, POS1, Quaternion.identity);
            GameObject cobj2 = (GameObject)Instantiate(obj, POS2, Quaternion.identity);
            GameObject cobj3 = (GameObject)Instantiate(obj, POS3, Quaternion.identity);
            GameObject cobj4 = (GameObject)Instantiate(obj, POS4, Quaternion.identity);
            cobj1.transform.SetParent(pobj.transform);
            cobj2.transform.SetParent(pobj.transform);
            cobj3.transform.SetParent(pobj.transform);
            cobj4.transform.SetParent(pobj.transform);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
