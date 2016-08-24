using UnityEngine;
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
        if ((transform.position.x < 300) && (transform.position.x > -300) && (transform.position.y < 150) && (transform.position.y > -150))
        {
            //オブジェクト配置用のPOS//
            //上
            Vector3 POS1 = new Vector3(transform.position.x,transform.position.y,transform.position.z);
            //右上
            //右下
            //下
            //左下
            //左上
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
