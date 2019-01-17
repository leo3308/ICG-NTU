using UnityEngine;
using System.Collections;

public class playerhealthBar : MonoBehaviour {
    public float maxHealth;
    public GameObject tank;
    public playerDead hp;
    // Use this for initialization
    void Start () {
        tank = GameObject.Find("tank");
        hp = tank.GetComponent<playerDead>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = new Vector3(-98 + 96 * hp.health / maxHealth, 2f, 0f);
    }
}
