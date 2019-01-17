using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydead : MonoBehaviour {
    public GameObject effect;
    public float health;
    public playerDead weapon;
    public GameObject tank;
	// Use this for initialization
	void Start () {
        health = 100;
        tank = GameObject.Find("tank");
        weapon = tank.GetComponent<playerDead>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "eevee")
        {
            health = health - weapon.weaponPower;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        else if(collision.gameObject.tag == "snorlax")
        {
            health = health - weapon.weaponPower;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
