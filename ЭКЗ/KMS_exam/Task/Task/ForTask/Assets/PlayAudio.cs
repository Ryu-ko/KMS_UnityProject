using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    public AudioSource audio;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Capsule")
        {
            audio.Play();
        }
    }

}
