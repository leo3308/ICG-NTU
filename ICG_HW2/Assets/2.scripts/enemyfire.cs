using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfire : MonoBehaviour {

    public Rigidbody projcetile;
    float speed = 30;
	// Use this for initialization
	void Start () {
        InvokeRepeating("fire",1f,5f); //(function name, when, frequnecy)
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void fire(){
        Rigidbody shoot =
        (Rigidbody)Instantiate(projcetile, transform.position, transform.rotation);
        //給砲彈方向力，將他從y軸推出去
        shoot.velocity = transform.TransformDirection(new Vector3( 0, speed, 0));
        //讓坦克的碰撞框忽略砲彈的碰撞框
        Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), shoot.GetComponent<Collider>());
    }
}
