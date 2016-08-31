using UnityEngine;
using System.Collections;

public class ArrowMotion : MonoBehaviour {
    private float count = 0f;
    public bool stop = false;
    public Vector3 movepos;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = new Vector3(0, 0, transform.localScale.z);
        float x = transform.localScale.z / 5;
        Vector3 rpos = transform.forward;
        Quaternion q = Quaternion.Euler(0, 10, 0);
        movepos = rpos * x * 7.5f;
        count++;
        if (stop == false)
        {
            if (count % 50 == 0)
            {
                this.gameObject.transform.position += movepos;
            }
        }
	}
/*
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<LeakageMotion>().leakage == false)
        {
            stop = true;
        }
    }
    */
}
