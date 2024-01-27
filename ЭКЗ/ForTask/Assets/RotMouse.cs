using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotMouse : MonoBehaviour {

    float mouse_x;
    float mouse_y;


    // Update is called once per frame
    void Update()
    {

        mouse_y = Input.GetAxis("Mouse X");
        mouse_x = Input.GetAxis("Mouse Y");

        transform.Rotate(mouse_x, mouse_y, 0);

    }
}
