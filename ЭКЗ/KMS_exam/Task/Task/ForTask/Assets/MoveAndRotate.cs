using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour {

    float speed = 0.5f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * 10, 0, 0);
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}
//Можно для различных объектов задавать различные параметры. 
//И / или разделить этот скрипт на несколько файлов.
