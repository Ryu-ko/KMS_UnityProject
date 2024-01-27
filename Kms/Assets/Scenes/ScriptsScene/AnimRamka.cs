using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimRamka : MonoBehaviour
{
    Animator animRamka;
    public GameObject Ramka;

    void Start()
    {
        animRamka = GetComponent<Animator>();
        animRamka.SetBool("RamkBool", false);

    }

    public void OnMouseDown()
    {

        bool currentClickedState = animRamka.GetBool("RamkBool");
        animRamka.SetBool("RamkBool", currentClickedState);

    }
}
