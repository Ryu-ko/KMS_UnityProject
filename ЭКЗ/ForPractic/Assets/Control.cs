using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    float get_x;
    float get_z;

    float mouse_x;
    float mouse_y;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        get_x = Input.GetAxis("Horizontal");
        get_z = Input.GetAxis("Vertical");

        transform.Translate(get_x, 0, get_z);

        mouse_y = Input.GetAxis("Mouse X");
        mouse_x = Input.GetAxis("Mouse Y");

        transform.Rotate(mouse_x, mouse_y, 0);

    }
}
