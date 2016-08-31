using UnityEngine;
using System.Collections;

public class clickback : MonoBehaviour {
    void Update()
    {
        // 左クリックを取得
        if (Input.GetMouseButtonDown(0))
        {
            // クリックしたスクリーン座標をrayに変換
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Rayの当たったオブジェクトの情報を格納する
            RaycastHit hit = new RaycastHit();
            // オブジェクトにrayが当たった時
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.CompareTag("arrow"))
                {
                    Vector3 x = hit.collider.gameObject.GetComponent<ArrowMotion>().movepos;
                    hit.collider.gameObject.transform.position -= x;
                }
            }
        }
    }
}
