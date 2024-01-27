using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qarter16 : MonoBehaviour
{
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = Time.time * 50;
        transform.rotation= Quaternion.AngleAxis(angle,new Vector3(1,0,0));

    }
}
