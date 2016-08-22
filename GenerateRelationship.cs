using UnityEngine;
using System.Collections;

public class GenerateRelationship : MonoBehaviour {
    public GameObject obj;
    public GameObject pobj;
    void Start(){
        if ((transform.position.x<300)&&(transform.position.x>-300)&&(transform.position.y<150)&&(transform.position.y>-150))
        {
            pobj = this.gameObject;
            Vector3 POS1 = new Vector3(this.transform.position.x + 100, this.transform.position.y, this.transform.position.z);
            Vector3 POS2 = new Vector3(this.transform.position.x, this.transform.position.y + 100, this.transform.position.z);
            Vector3 POS3 = new Vector3(this.transform.position.x - 100, this.transform.position.y, this.transform.position.z);
            Vector3 POS4 = new Vector3(this.transform.position.x, this.transform.position.y - 100, this.transform.position.z);
            GameObject cobj1 = (GameObject)Instantiate(obj, POS1, Quaternion.identity);
            GameObject cobj2 = (GameObject)Instantiate(obj, POS2, Quaternion.identity);
            GameObject cobj3 = (GameObject)Instantiate(obj, POS3, Quaternion.identity);
            GameObject cobj4 = (GameObject)Instantiate(obj, POS4, Quaternion.identity);
            cobj1.transform.SetParent(pobj.transform);
            cobj2.transform.SetParent(pobj.transform);
            cobj3.transform.SetParent(pobj.transform);
            cobj4.transform.SetParent(pobj.transform);
        }
        
        //Vector3 pos = new Vector3(this.transform.position.x + 100,this.transform.position.y,this.transform.position.z);
        //GameObject prefab = (GameObject)Resources.Load("Prebabs/gobj/friend");
        //GameObject obj = (GameObject)Instantiate(prefab,pos,Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
