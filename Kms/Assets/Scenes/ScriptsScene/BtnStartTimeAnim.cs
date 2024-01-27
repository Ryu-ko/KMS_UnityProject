using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Serializable]
public class BtnStartTimeAnim : MonoBehaviour
{
    public GameObject Ramka;
    public GameObject electrodatchik;
    public TMP_Text textKolvo;
    public TMP_Text textTimer;

    public static bool BtnStartWorkPractic=false;
    public static float timer = 0;
    public static int kolvo;
    public static int kolvoforRaschet;

    public float MagnitGrad = 40;
    public float newAngle;
    public float TelomassKoef;
    public static bool work;
    public float offset = 0;

    private Quaternion initialRotation; // Добавляем переменную для сохранения начального вращения
    private Vector3 initialPosition; // Добавляем переменную для сохранения начальной позиции

    private Color originaColor;
    private Material originalMaterial;

    public void BtnSTartPractic() {
        BtnStartWorkPractic = true;
        GetComponent<Renderer>().material.color = originaColor;
        GetComponent<Renderer>().material = originalMaterial;

    }

    void Start()
    {
        originaColor = GetComponent<Renderer>().material.color;
        originalMaterial = GetComponent<Renderer>().material;
        initialPosition = Ramka.transform.position;
        initialRotation = Ramka.transform.rotation;
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void StartWork()
    {

        timer = 0;
        kolvo = 0;

        work = true;
    }

        public void ResetPosition()
    {
        // Возвращаем объект в начальное положение
        Ramka.transform.position = initialPosition;
        Ramka.transform.rotation = initialRotation;
    }

    private void OnMouseDown()
    {

        if (BtnStartWorkPractic)
        {
            if (IssledTeloAnim.OnState == true && PorjadokText.RabotaBezCube == false)
            {
                TelomassKoef = 0.96f;
                StartWork();
            }

            else if(IssledTeloAnim.OnState == false && PorjadokText.RabotaBezCube == true)
            {
                TelomassKoef = 0.55f; 
                StartWork();
            } 
           
        }
        else {
            MessageListener.print("Нажмите кнопку начать работу");
        }
    }

    void Update()
    {
       
        ResetPosition(); 

        if (work)
        {
            timer = (float)Math.Round((timer + Time.deltaTime), 2);
            offset += Time.deltaTime;
            textKolvo.text = (kolvo/2).ToString();
            kolvoforRaschet = (kolvo / 2);

            if (timer > 0)
            {
                textTimer.text = string.Format("{0:00.00}", timer).Replace(',', ':');
            }
            else
            {
                textTimer.text = "00:00";
            }
            RotateRamka(); 
            
        }
    }


    void RotateRamka()
    {
        if (IssledTeloAnim.OnState == true)
        {
            offset += Time.deltaTime;
            
            newAngle = (float)(Math.Cos(1 * Math.PI * offset * TelomassKoef) * MagnitGrad * 0.8f);
            Ramka.transform.rotation = Quaternion.Lerp(Ramka.transform.rotation, Quaternion.Euler(-90, 0,newAngle), 100);
            Debug.Log("Cube is on Ramka!"+ TelomassKoef);

        }
        else
        {
            offset += Time.deltaTime;

            newAngle = (float)(Math.Cos(1 * Math.PI * offset * TelomassKoef) * MagnitGrad * 0.8f);
            Ramka.transform.rotation = Quaternion.Lerp(Ramka.transform.rotation, Quaternion.Euler(-90, 0,newAngle), 100);
            Debug.Log("Cube is NOT in Ramka!" + TelomassKoef);
        }


    }


  

}











/*
 * 
    private void OnMouseDown()
    {
        // bool currentClickedState = anim.GetBool("IsBtnStartClick");
        //anim.SetBool("IsBtnStartClick", !currentClickedState);
        //animRamka.SetBool("RamkBool", true);

*/