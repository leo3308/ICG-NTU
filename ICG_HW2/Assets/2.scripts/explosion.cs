using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class explosion : MonoBehaviour {
	public GameObject effect;//特效
	void Start () {
        Destroy(gameObject, 3);
    }	
	void Update () {
    }

	void OnCollisionEnter (Collision collision) {//碰撞發生時呼叫
		//碰撞後產生爆炸
			
		if(collision.gameObject.tag == "enemy"){//當撞到的collider具有enemy tag時
			Instantiate (effect, transform.position, transform.rotation);
			Destroy(gameObject);//刪除砲彈
		}
        else if(collision.gameObject.tag == "Player"){//當撞到的collider具有enemy tag時
            Instantiate (effect, transform.position, transform.rotation);
            Destroy(gameObject);//刪除砲彈
        }
	}
}
