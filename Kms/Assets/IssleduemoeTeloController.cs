using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IssleduemoeTeloController : MonoBehaviour
{
    public bool massState = true;
    private float massKoef = 0.96f;

    private void OnMouseDown()
    {
        if (massState)
            massKoef = 0.96f;
        else
            massKoef = 0.55f;
    }
}
