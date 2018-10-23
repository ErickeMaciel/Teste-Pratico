using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {


    public float anglesRot = -30.0f;
    public float rotTemp;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // Funcao de rotacao do objeto
    public void RotateObject()
    {
        rotTemp -= anglesRot;

        transform.eulerAngles = new Vector3(0, rotTemp, 0);
    }
}
