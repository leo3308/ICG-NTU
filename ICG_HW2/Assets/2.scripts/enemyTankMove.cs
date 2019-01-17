using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTankMove : MonoBehaviour {
    
    public float mSpeed = 1;
    public float rSpeed = 1;
    float v,h;
	// Use this for initialization
	void Start () {
		InvokeRepeating("move",0f,4f);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void move(){
        v = Random.Range(-1.0f, 1.0f);
        h = Random.Range(-1.0f, 1.0f);
        transform.Translate(0, 0, -mSpeed * v);
        transform.Translate(0, rSpeed * h, 0);
    }
}
