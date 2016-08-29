using UnityEngine;
using System.Collections;

public class LeakageMotion : MonoBehaviour {

    public bool leakage = false;
    public GameObject arrowobj;
    private GameObject obj;

    public float do30 = 30 * Mathf.Deg2Rad;
    public float do150 = 150 * Mathf.Deg2Rad;
    public float do210 = 210 * Mathf.Deg2Rad;
    public float do330 = 330 * Mathf.Deg2Rad;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //arrow生成用// //上 //右上 //右下 //下 //左下 //左上
        Vector3 POS1 = new Vector3(transform.position.x, transform.position.y, transform.position.z + 50);
        Vector3 POS2 = new Vector3(transform.position.x + Mathf.Cos(do30) * 50, transform.position.y, transform.position.z + Mathf.Sin(do30) * 50);
        Vector3 POS3 = new Vector3(transform.position.x + Mathf.Cos(do330) * 50, transform.position.y, transform.position.z + Mathf.Sin(do330) * 50);
        Vector3 POS4 = new Vector3(transform.position.x, transform.position.y, transform.position.z - 50);
        Vector3 POS5 = new Vector3(transform.position.x + Mathf.Cos(do210) * 50, transform.position.y, transform.position.z + Mathf.Sin(do210) * 50);
        Vector3 POS6 = new Vector3(transform.position.x + Mathf.Cos(do150) * 50, transform.position.y, transform.position.z + Mathf.Sin(do150) * 50);

        //arrow生成用// //上 //右上 //右下 //下 //左下 //左上
        Vector3 RPOS1 = new Vector3(0f, 0f, 1f);
        Vector3 RPOS2 = new Vector3(Mathf.Cos(do30), 0f, Mathf.Sin(do30));
        Vector3 RPOS3 = new Vector3(Mathf.Cos(do330), 0f, Mathf.Sin(do330));
        Vector3 RPOS4 = new Vector3(0f, 0f, -1f);
        Vector3 RPOS5 = new Vector3(Mathf.Cos(do210), 0f, Mathf.Sin(do210));
        Vector3 RPOS6 = new Vector3(Mathf.Cos(do150), 0f, Mathf.Sin(do150));

        Quaternion Qua1 = Quaternion.Euler(0,30,0);
        if (leakage == true)
        {
            //上 //右上 //右下 //下 //左下 //左上
            if (gameObject.GetComponent<Relationship6>().Obj_Up != null)
            {
                Instantiate(arrowobj,POS1,Qua1);
                obj = this.gameObject.GetComponent<Relationship6>().Obj_Up;
            }
        }

	}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(this.gameObject.GetComponent<Renderer>().materials[1]);
        if (collider.gameObject.CompareTag("arrow"))
        {
            this.gameObject.GetComponent<Renderer>().materials[1].color = Color.red;
            leakage = true;
        }
    }
    
}
