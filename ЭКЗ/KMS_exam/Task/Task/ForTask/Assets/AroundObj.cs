using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundObj : MonoBehaviour {

    [SerializeField]
    Transform targetPos;
    [SerializeField]
    int sensitivity = 3;
    [SerializeField]
    float scrollSpeed = 10f;
    [SerializeField]
    int maxDistance = 20;
    [SerializeField]
    int minDistance = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float y = Input.GetAxis("Mouse X") * sensitivity;
            if (y != 0)
            {
                transform.RotateAround(targetPos.position, Vector3.up, y);

            }
        }

        // ДВИЖЕНИЕ КАМЕРЫ В СТОРОНЫ КЛАВИШАМИ С ОГРАНИЧЕНИЯМИ ПО РАЗМЕРАМ ПОМЕЩЕНИЯ
        float x = Input.GetAxis("Horizontal") / sensitivity; // клавиши A, D
        if (x != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(new Vector3(x, 0, 0));
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
            {
                transform.position = newpos;
            }
        }

        // ПРИБЛИЖЕНИЕ И УДАЛЕНИЕ КАМЕРЫ К УСТАНОВКЕ НА СЦЕНЕ ПРОКРУТКОЙ КОЛЕСА МЫШИ
        float z = Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
        if (z != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * z);
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
            {
                transform.position = newpos;
            }
        }
    }

    bool ControlDistance(float distance)
    {
        if (distance > minDistance && distance < maxDistance) return true;
        return false;
    }
}
