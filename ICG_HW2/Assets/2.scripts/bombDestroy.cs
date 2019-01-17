using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombDestroy : MonoBehaviour {
    public GameObject effect;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter (Collision collision) {//碰撞發生時呼叫
        //碰撞後產生爆炸
        
        if(collision.gameObject.tag == "Player"){//當撞到的collider具有enemy tag時
            Instantiate (effect, transform.position, transform.rotation);
            Destroy(gameObject);//刪除砲彈
        }
    }
}
