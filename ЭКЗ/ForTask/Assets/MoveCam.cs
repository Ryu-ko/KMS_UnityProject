using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

    bool move = false;
    float speed = 0.01f;
    float offset = 0;
    Vector3 startPosition;
    Vector3 needPosition;
    Quaternion startRotation;
    Quaternion needRotaton;
    public void Move0()     //функция для положения 1
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(-9f, -2f, -8f);
        needRotaton = Quaternion.AngleAxis(30f, new Vector3(1, 0, 0));
    }
    public void Move1()         //функция для положения 2 
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(-4.25f, -1f, -6f);
        needRotaton = Quaternion.AngleAxis(30f, new Vector3(1, 0, 0));
    }
    public void Move2()     //функция для положения 3
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(-0.6f, -2.30f, -4.64f);
        needRotaton = Quaternion.AngleAxis(30, new Vector3(1, 0, 0));
    }
    void Update()
    {
        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }
}
