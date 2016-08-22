using UnityEngine;
using System.Collections;

public class LineConnection : MonoBehaviour {
    LineRenderer line;
    public GameObject ppobj;
    public GameObject pobj;
	// Use this for initialization
	void Start () {
        line = GetComponent<LineRenderer>();
        pobj = transform.parent.gameObject;
        ppobj = transform.parent.parent.gameObject;
    }
	
    void awake()
    {

    }
	// Update is called once per frame
	void Update ()
    {
        Vector3 pospobj = pobj.transform.position - new Vector3(0, 0, -100);
        Vector3 posppobj = ppobj.transform.position - new Vector3(0, 0, -100);
        line.SetPosition(0, pospobj);
        line.SetPosition(1, posppobj);
	}
}
