using UnityEngine;
using System.Collections;

public class tankMove : MonoBehaviour {

	public float mSpeed = 1;
	public float rSpeed = 1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");//獲取水平軸向按鍵
		float v = Input.GetAxis ("Vertical");//獲取垂直軸向按鍵
		transform.Translate(0,0,-mSpeed * v);//根據垂直軸向按鍵來前進或後退
        transform.Rotate(0,rSpeed * h,0);//根據水平軸向按鍵來旋轉

    }
}
