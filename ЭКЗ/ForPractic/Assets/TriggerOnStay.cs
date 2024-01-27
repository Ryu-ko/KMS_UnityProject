using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnStay : MonoBehaviour {

    void OnTriggerStay(Collider other)
    {
        other.transform.localScale = other.transform.localScale * 1.005f;
    }
}
