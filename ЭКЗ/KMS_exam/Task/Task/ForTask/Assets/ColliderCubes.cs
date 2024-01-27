using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCubes : MonoBehaviour {

    float dX;
    float dZ;

    // Update is called once per frame
    void Update()
    {
        dZ = Input.GetAxis("Vertical");
        dX = Input.GetAxis("Horizontal");

        transform.Translate(dX, 0, dZ);

        GameObject Cube1 = GameObject.Find("Cube1");
        GameObject Cube2 = GameObject.Find("Cube2");
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube1")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (col.gameObject.name == "Cube2")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
