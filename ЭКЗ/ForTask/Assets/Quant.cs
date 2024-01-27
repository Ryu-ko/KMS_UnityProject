using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quant : MonoBehaviour {

    float angle;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        angle = Time.time * 50;

        transform.rotation = Quaternion.AngleAxis(angle, new Vector3(1, 0, 1));//Объяснить все, angle - значение вращения, 2 параметр напривление вращения
    }
}
