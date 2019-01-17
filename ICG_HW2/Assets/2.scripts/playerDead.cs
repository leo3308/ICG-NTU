using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDead : MonoBehaviour {

    public GameObject effect;
    public float health;
    public int weaponPower;
    int count = 0;
	// Use this for initialization
	void Start () {
        health = 100;
        weaponPower = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bomb")
        {
            health = health - 10;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        else if(collision.gameObject.tag == "bonus")
        {
            if (health < 100){
                health = health + 10;
            }
            count++;
            if (count == 3){
                weaponPower += 10;
                count = 0;
            }
        }
        else if(collision.gameObject.tag == "bullet2")
        {
            health = health - 10;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
