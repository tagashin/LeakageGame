using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Answer : MonoBehaviour {
    public GameObject q;
    public GameObject pairobj;
    public void ButtonPush()
    {
        if (this.gameObject.name=="Yes")
        {
            if(q.GetComponent<ReadAndQuestion>().number==1)
            {
                pairobj.GetComponent<Button>().interactable = true;
            }
            q.GetComponent<ReadAndQuestion>().yes = true;
        }
        if(this.gameObject.name=="No")
        {
            q.GetComponent<ReadAndQuestion>().no = true;
        }
    }
}
