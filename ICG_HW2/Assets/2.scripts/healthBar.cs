using UnityEngine;
using System.Collections;

public class healthBar : MonoBehaviour {
    public float maxHealth;
    public enemydead hp;
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        enemy = GameObject.Find("enemy");
        hp = enemy.GetComponent<enemydead>();
    }

	// Update is called once per frame
	void Update () {
        transform.localPosition = new Vector3(-98 + 96 * hp.health / maxHealth, 2f, 0f);
	}
}
