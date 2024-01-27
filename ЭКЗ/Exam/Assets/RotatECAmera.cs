using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotatECAmera : MonoBehaviour
{

[SerializeField]
    public Transform Sphere;
    [SerializeField]
    float speed =5f;

    // Update is called once per frame
    void Update()
    {

            float mouseX = Input.GetAxis("Mouse X");
            if (mouseX != 0)
            {
                transform.RotateAround(Sphere.position, Vector3.up, mouseX * speed);
            }
        
    }
}
