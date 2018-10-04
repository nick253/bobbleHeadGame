using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //head.AddForce(Vector3.up * 500f);
            this.transform.Translate(Vector3.up * 7, Space.World);
            //this.transform.Translate(Vector3.forward * (Time.deltaTime / 10) * 200);
        }
    }
}
