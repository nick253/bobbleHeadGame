using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour {

    public Camera FpsCam;
    public Camera TpsCam;
    bool tpsCam = true;

	// Use this for initialization
	void Start () {
        FpsCam.enabled = !tpsCam;
        TpsCam.enabled = tpsCam;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C)) {
            tpsCam = !tpsCam;
            FpsCam.enabled = tpsCam;
            TpsCam.enabled = !tpsCam;
        }
	}
}
