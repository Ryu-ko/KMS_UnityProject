using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger19 : MonoBehaviour
{
    float x_move;
    float z_move;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter( Collider other )
    {
        other.transform.localScale = other.transform.localScale * 2;
    }
    void OnTriggerExit( Collider other )
    {
        other.transform.localScale = other.transform.localScale/2;
    }

    // Update is called once per frame
    void Update()
    {
        x_move = Input.GetAxis("Horizontal");
        z_move = Input.GetAxis("Vertical");

        Vector3 move= new Vector3(x_move,0, z_move)/6f;
        transform.Translate(move);
    }
}  

