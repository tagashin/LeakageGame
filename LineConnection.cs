using UnityEngine;
using System.Collections;

public class LineConnection : MonoBehaviour {
    LineRenderer line;
    public Vector3 POS1 = new Vector3(0, 0, 0);
    public Vector3 POS2 = new Vector3(0, 0, 0);
	// Use this for initialization
	void Start () {
        line = GetComponent<LineRenderer>();
    }
	
    void awake()
    {

    }
	// Update is called once per frame
	void Update ()
    { 
        line.SetPosition(0, POS1);
        line.SetPosition(1, POS2);
	}
}
