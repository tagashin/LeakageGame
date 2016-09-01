using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {
    private float fpoint = 0;
    public int point = 0;
    public TextAsset TextA;
    public string[] getstrings;
    public string[] cutstrings;
	void Start () {
        fpoint = PlayerPrefs.GetFloat("point");
        point = (int)fpoint;
        getstrings = TextA.text.Split('\n');
        if (point == 0) cutstrings = getstrings[0].Split('\t');
        else if (point > 0 && point <= 10) cutstrings = getstrings[1].Split('\t');
        else if (point > 10 && point <= 20) cutstrings = getstrings[2].Split('\t');
        else if (point > 20 && point <= 30) cutstrings = getstrings[3].Split('\t');
        else if (point > 30 && point <= 40) cutstrings = getstrings[4].Split('\t');
        else if (point > 40 && point <= 50) cutstrings = getstrings[5].Split('\t');
        else if (point > 50 && point <= 60) cutstrings = getstrings[6].Split('\t');
        else if (point > 60 && point <= 70) cutstrings = getstrings[7].Split('\t');
        else if (point > 70 && point <= 80) cutstrings = getstrings[8].Split('\t');
        else if (point > 80 && point <= 90) cutstrings = getstrings[9].Split('\t');
        else if (point > 90 && point <= 100) cutstrings = getstrings[10].Split('\t');
        StartCoroutine(Show());
    }
	

	void Update() { }
    IEnumerator Show()
    {
        yield return new WaitForSeconds(0.0f);
        GameObject resulttext = GameObject.Find("result");
        GameObject OVtext = GameObject.Find("OV");
        GameObject extext = GameObject.Find("ex");
        resulttext.GetComponent<Text>().text = "漏えい度" + point;
        OVtext.GetComponent<Text>().text = cutstrings[1];
        extext.GetComponent<Text>().text = cutstrings[2];
    }
}
