using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pref18 : MonoBehaviour
{
   public GameObject pref;

    Vector3 spawnpos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
       
            Instantiate(pref, spawnpos+Vector3.up*10f,Quaternion.identity);

        }

    }
}
