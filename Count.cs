using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour {
    public int count = 0;
    private float point = 0;
    public Vector3 FPOS = new Vector3(0, 0, 0);
    public Vector3 NPOS = new Vector3(0, 0, 0);
    private Vector3 OPOS = new Vector3(0, 0, 0);

	void Start () {}
	void Update ()
    {
        if(Vector3.Distance(FPOS,OPOS) < Vector3.Distance(NPOS,OPOS))
        {
            FPOS = NPOS;
        }
        if (Time.time > 30.0f)
        {
            if(count > 100)
            {
                point = 100;
            }
            else
            {
                point = count;
            }
            PlayerPrefs.SetFloat("point",point);
            //SceneManager.LoadScene();
        }

	}
}
