using UnityEngine;
using System.Collections;

public class ray_test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(new Vector2(0,0),new Vector2(0,1),Mathf.Infinity))
        {
            Debug.Log("hit");
        }
	}
}
