using UnityEngine;
using System.Collections;

public class AnswerYes : MonoBehaviour {
    public GameObject q;
	public void ButtonPush()
    {
        q.GetComponent<ReadAndQuestion>().yes = true;
    }
}
