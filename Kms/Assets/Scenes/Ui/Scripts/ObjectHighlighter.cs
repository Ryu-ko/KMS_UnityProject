using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectHighlighter : MonoBehaviour
{
    public Camera mainCamera;
    private Color originaColor;
    private Material originalMaterial;


    void Start()
    {
        originaColor = GetComponent<Renderer>().material.color;
        originalMaterial = GetComponent<Renderer>().material;

    }

    public void OnPointerEnter()
    {
       
       GetComponent<Renderer>().material.color = Color.red; 
    }

    public void OnPointerExit()
    {
     
       GetComponent<Renderer>().material.color = originaColor; 
       GetComponent<Renderer>().material = originalMaterial; 
    }

}
