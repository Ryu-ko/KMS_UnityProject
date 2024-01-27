using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamaraCanvas : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 5f;
    public Canvas canvas;

    void Start()
    {

        canvas.GetComponentInChildren<Button>().onClick.AddListener(ChangeCameraView);

    }

    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X");
       // transform.RotateAround(target.position, Vector3.up, mouseX * rotationSpeed);
    }

    void ChangeCameraView()
    {
        transform.LookAt(target);
    }



}
