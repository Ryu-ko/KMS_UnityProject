using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD17 : MonoBehaviour
{
    float x_trans;
    float z_trans;

    float x_rotate;
    float y_rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_trans = Input.GetAxis("Horizontal");
        z_trans = Input.GetAxis("Vertical");
        transform.Translate(x_trans, 0, z_trans);

        x_rotate = Input.GetAxis("Mouse X");
        y_rotate = Input.GetAxis("Mouse Y");

        transform.Rotate(x_rotate, y_rotate, 0);


    }
}
