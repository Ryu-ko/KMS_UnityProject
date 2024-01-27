using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IssledTeloAnim : MonoBehaviour 
{
    Animator anim;
    public static GameObject cubeObj;

    public static bool OnState = false;

    void Start()
    {
            anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (BtnStartTimeAnim.BtnStartWorkPractic)
        {
            if (PorjadokText.ZadanieCubemove)
            {

                bool currentClickedState = anim.GetBool("IsBlocAnim");
                anim.SetBool("IsBlocAnim", !currentClickedState);
                if (anim.GetBool("IsBlocAnim"))
                {
                    OnState = true;
                    Debug.Log("OnState: " + OnState);

                }
                else
                {
                    OnState = false;
                    Debug.Log("OnState: " + OnState);
                }
            }

            else {
                OnState = false;
            }

        }



    }



}
