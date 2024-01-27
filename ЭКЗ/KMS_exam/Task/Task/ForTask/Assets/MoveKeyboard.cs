using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKeyboard : MonoBehaviour {

    float get_x;
    float get_z;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        get_x = Input.GetAxis("Horizontal");
        get_z = Input.GetAxis("Vertical");

        transform.Translate(get_x, 0, get_z);

    }

}
