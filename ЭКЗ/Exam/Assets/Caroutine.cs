using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caroutine : MonoBehaviour
{
    public GameObject Pref;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
          GameObject cube= Instantiate(Pref);
            StartCoroutine(DeletPref(cube) );


        }
    }

    IEnumerator DeletPref(GameObject cube ) {
        yield return new WaitForSeconds(5);
        Destroy(cube);
    }
}
