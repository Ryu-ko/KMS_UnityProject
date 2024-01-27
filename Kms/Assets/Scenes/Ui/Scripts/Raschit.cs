using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Diagnostics;
using System;

public class Raschit : MonoBehaviour
{

    public int a = 1;
    public int b = 1;

    public Text textN11;
    public Text textN12;
    public Text textN13;

    public Text textt11;
    public Text textt12;
    public Text textt13;

    public Text textT11;
    public Text textT12;
    public Text textT13;

    public Text textTsr1;
    public Text textTdel1;

    public Text textN11telo;
    public Text textN12telo;
    public Text textN13telo;

    public Text textt11telo;
    public Text textt12telo;
    public Text textt13telo;

    public Text textT11telo;
    public Text textT12telo;
    public Text textT13telo;

    public Text textTsr1telo;
    public Text textTdel1telo;

    public Text Inerz;
    public Text OtnosPogreshn;
    public Text AbsolPOgreshn;


    float textN11f;
    float textN12f;
    float textN13f;

    float textt11f;
    float textt12f;
    float textt13f;

    float textT11f;
    float textT12f;
    float textT13f;

    float textTsr1f;

    float textTdel1f;

    float textN11telof;
    float textN12telof;
    float textN13telof;

    float textt11telof;
    float textt12telof;
    float textt13telof;

    float textT11telof;
    float textT12telof;
    float textT13telof;

    float textTsr1telof;
    float textTdel1telof;

    float Inerzf;
    float OtnosPogreshnf;
    float AbsolPOgreshnf;


    public void zapisat()
    {
        if (BtnStartTimeAnim.BtnStartWorkPractic)
        {
            if (BtnStartTimeAnim.kolvo > 0 && BtnStartTimeAnim.timer > 0)
            {
                if (IssledTeloAnim.OnState == false)
                {
                    if (a == 1)
                    {
                        textN11f = BtnStartTimeAnim.kolvoforRaschet;
                        textt11f = BtnStartTimeAnim.timer;
                        textN11.text = BtnStartTimeAnim.kolvoforRaschet.ToString();
                        textt11.text = BtnStartTimeAnim.timer.ToString();
                        a++;
                    }
                    else if (a == 2)
                    {
                        textN12f = BtnStartTimeAnim.kolvoforRaschet;
                        textt12f = BtnStartTimeAnim.timer;
                        textN12.text = BtnStartTimeAnim.kolvoforRaschet.ToString();
                        textt12.text = BtnStartTimeAnim.timer.ToString();
                        a++;
                    }
                    else if (a == 3)
                    {
                        textN13f = BtnStartTimeAnim.kolvoforRaschet;
                        textt13f = BtnStartTimeAnim.timer;
                        textN13.text = BtnStartTimeAnim.kolvoforRaschet.ToString();
                        textt13.text = BtnStartTimeAnim.timer.ToString();
                        a++;
                    }
                }

                else
                {

                    if (b == 1)
                    {
                        textN11telof = BtnStartTimeAnim.kolvoforRaschet;
                        textt11telof = BtnStartTimeAnim.timer;
                        textN11telo.text = BtnStartTimeAnim.kolvoforRaschet.ToString();
                        textt11telo.text = BtnStartTimeAnim.timer.ToString();
                        b++;
                    }
                    else if (b == 2)
                    {
                        textN12telof = BtnStartTimeAnim.kolvoforRaschet;
                        textt12telof = BtnStartTimeAnim.timer;
                        textN12telo.text = BtnStartTimeAnim.kolvoforRaschet.ToString();
                        textt12telo.text = BtnStartTimeAnim.timer.ToString();
                        b++;
                    }
                    else if (b == 3)
                    {
                        textN13telof = BtnStartTimeAnim.kolvoforRaschet;
                        textt13telof = BtnStartTimeAnim.timer;
                        textN13telo.text = BtnStartTimeAnim.kolvoforRaschet.ToString();
                        textt13telo.text = BtnStartTimeAnim.timer.ToString();
                        b++;
                    }
                }
            }

        }

    }

    public void ochistit()
    {
        textN11.text = "";
        textN12.text = "";
        textN13.text = "";

        textt11.text = "";
        textt12.text = "";
        textt13.text = "";

        textT11.text = "";
        textT12.text = "";
        textT13.text = "";

        textTsr1.text = "";

        textTdel1.text = "";


        textN11telo.text = "";
        textN12telo.text = "";
        textN13telo.text = "";

        textt11telo.text = "";
        textt12telo.text = "";
        textt13telo.text = "";

        textT11telo.text = "";
        textT12telo.text = "";
        textT13telo.text = "";

        textTsr1telo.text = "";

        textTdel1telo.text = "";


        textN11f = 0;
        textN12f = 0;
        textN13f = 0;

        textt11f = 0;
        textt12f = 0;
        textt13f = 0;

        textT11f = 0;
        textT12f = 0;
        textT13f = 0;

        textTsr1f = 0;

        textTdel1f = 0;


        textN11telof = 0;
        textN12telof = 0;
        textN13telof = 0;

        textt11telof = 0;
        textt12telof = 0;
        textt13telof = 0;

        textT11telof = 0;
        textT12telof = 0;
        textT13telof = 0;

        textTsr1telof = 0;

        textTdel1telof = 0;

        Inerz.text = "";
        OtnosPogreshn.text = "";
        AbsolPOgreshn.text = "";

        Inerzf = 0;
        OtnosPogreshnf = 0;
        AbsolPOgreshnf = 0;

        a = 1;
        b = 1;
    }

    public void rasschitat()
    {
        if (a == 4 && b == 4 )
        {
            textT11f = (float)Math.Round(textt11f / textN11f, 2);
            textT12f = (float)Math.Round(textt12f / textN12f, 2);
            textT13f = (float)Math.Round(textt13f / textN13f, 2);

            textT11.text = textT11f.ToString();
            textT12.text = textT12f.ToString();
            textT13.text = textT13f.ToString();

            textT11telof = (float)Math.Round(textt11telof / textN11telof, 2);
            textT12telof = (float)Math.Round(textt12telof / textN12telof, 2);
            textT13telof = (float)Math.Round(textt13telof / textN13telof, 2);

            textT11telo.text = textT11telof.ToString();
            textT12telo.text = textT12telof.ToString();
            textT13telo.text = textT13telof.ToString();


            textTsr1f = (float)Math.Round((textT11f + textT12f + textT13f) / 3, 2);

            textTsr1.text = textTsr1f.ToString();


            textTsr1telof = (float)Math.Round((textT11telof + textT12telof + textT13telof) / 3, 2);

            textTsr1telo.text = textTsr1telof.ToString();


            textTdel1f = 0.05f;
            textTdel1.text = textTdel1f.ToString();


            textTdel1telof = 0.05f;
            textTdel1telo.text = textTdel1telof.ToString();


            float Inerzf = (float)(6.87e-4 * ((Math.Pow(textTsr1f, 2) / Math.Pow(textTsr1telof, 2)) - 1));
            float OtnosPogreshnf = (float)Math.Sqrt(Math.Pow(0.05e-4 / 6.87e-4, 2) + Math.Pow((4 * Math.Pow(textTsr1f, 4)) / (Math.Pow(textTsr1f, 2) - Math.Pow(textTsr1telof, 2)), 2) * (Math.Pow(textTdel1f / textTsr1f, 2) + Math.Pow(textTdel1telof / textTsr1telof, 2)) );
            float AbsolPOgreshnf = Inerzf * OtnosPogreshnf;
           
            Inerz.text = Math.Round(Inerzf, 4).ToString();
            OtnosPogreshn.text = Math.Round(OtnosPogreshnf, 4).ToString();
            AbsolPOgreshn.text = Math.Round(AbsolPOgreshnf, 4).ToString();



        }
    }

}
