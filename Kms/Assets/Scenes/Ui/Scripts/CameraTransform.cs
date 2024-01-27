using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransform : MonoBehaviour
{
    [SerializeField]
    Transform target;
    float scrollSpeed = 5f;    // скорость вращения и передвижения камеры
    int rotationSensivity = 7;
    int maxDistance = 10;
    int minDistance = 1;
 
    void Start()
    {
        transform.LookAt(target);
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void FixedUpdate()
    {
        // Движение камеры влево-право, вниз-вверх ADSW.
        if (!Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Horizontal"); 
            float y = Input.GetAxis("Vertical"); 
            if (x != 0 || y != 0)
            {
                Vector3 newPos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / rotationSensivity;
                if (ControlDistance(Vector3.Distance(newPos, target.position))) 
                {
                    transform.position = newPos;
                }
            }
        }
        // Приближение камеры колёсиком мыши.
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newPos = transform.position + transform.TransformDirection(Vector3.forward 
            * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            if (ControlDistance(Vector3.Distance(newPos, target.position))) transform.position = newPos;
        }

        // Вращение вокруг установки.
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * scrollSpeed);
        }

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

    // Функция ограничения пределов движения камеры.
    bool ControlDistance (float distance)
    {
        if (distance > minDistance && distance < maxDistance) 
        {
            return true;
        }
        return false;
    }

    Vector3 startPosition;
    Vector3 needPosition;
    bool move = false;
    float speed = 0.07f;
    float offset = 0;
    Quaternion startRotation;
    Quaternion needRotaton;

    public void SetDefault()
        {
            if (!move)
            {
                move = true;
                startPosition = transform.position;
                startRotation = transform.rotation;
                needPosition = new Vector3(0.144f, 2.4f, 3.87f);
                needRotaton = Quaternion.Euler(0, 180, 0);
            }
        }  
    
    public void ZoomRamkaElDatchikMagnitPodvichnBalka()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-0.28f, 2.29f, -0.66f);
            needRotaton = Quaternion.Euler(0f, 180f, 0f);
        }
    }

    public void ZoomKronshtein()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-0.4f, 2.41f, 0.24f);
            needRotaton = Quaternion.Euler(0f, 180f, 0f);
        }
    }

    public void ZoomCifrshetchik()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-0.65f, 2.16f, -0.46f);
            needRotaton = Quaternion.Euler(32.157f, 180f, 0f);
        }
    }

    public void Zoomsecundomer()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-0.65f, 2.16f, -0.75f);
            needRotaton = Quaternion.Euler(51.035f, 180f, 0f);
        }
    }

    public void ZoomIssledTelo()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(1.03f, 1.79f, -0.08f);
            needRotaton = Quaternion.Euler(31.239f, 203.781f, 0f);
        }
    }


    
}
