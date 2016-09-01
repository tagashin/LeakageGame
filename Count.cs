using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour {
    public int count = 0;
    private int i = 50;
    private float point = 0;
    public GameObject A;
    public Vector3 FPOS = new Vector3(0, 0, 0);
    public Vector3 NPOS = new Vector3(0, 0, 0);
    private Vector3 OPOS = new Vector3(0, 0, 0);

	void Start ()
    {
        StartCoroutine(counttime());
        A = GameObject.Find("Camera");
    }
	void Update ()
    {
        if(Vector3.Distance(FPOS,OPOS) < Vector3.Distance(NPOS,OPOS))
        {
            FPOS = NPOS;
        }
        if(A.transform.position.y < Vector3.Distance(FPOS,OPOS)+50)
        {
            i++;
            A.transform.position = new Vector3(0,i,0);
        }


	}
    IEnumerator counttime()
    {
        yield return new WaitForSeconds(30.0f);
        if (count > 100)
        {
            point = 100;
        }
        else
        {
            point = count;
        }
        PlayerPrefs.SetFloat("point", point);
        SceneManager.LoadScene("result");
    }
}
