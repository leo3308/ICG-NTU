using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

    public Camera firstPersonal;
    public Camera thirdPersonal;
	// Use this for initialization
	void Start () {
        firstPersonal.enabled = true;
        thirdPersonal.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("p") == true){
            if(firstPersonal.enabled == true){
                firstPersonal.enabled = false;
                thirdPersonal.enabled = true;
            }
            else{
                firstPersonal.enabled = true;
                thirdPersonal.enabled = false;
            }
        }
	}
}
