using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Threading;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BtnSBros : MonoBehaviour
{

    public GameObject Ramka;


    void Start()
    {
    }

    public void OnMouseDown()
    {

        Debug.Log("BtnSBros OnMouseDown");
        BtnStartTimeAnim.work = false;

    }


}









//Animator anim;

//void Start()
//{
//    anim = GetComponent<Animator>();
//    animRamka = Ramka.GetComponent<Animator>();

//    animRamka.runtimeAnimatorController = animRamkaController;

//}

//public void OnMouseDown()
//{
//            //  bool currentClickedState = anim.GetBool("IsBtnSbros");
//  anim.SetBool("IsBtnSbros", !currentClickedState);
//}



