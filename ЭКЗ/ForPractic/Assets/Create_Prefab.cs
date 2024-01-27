using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Prefab : MonoBehaviour {

    public GameObject prefub1;

    public Vector3 startpos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, 45f));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefub1, startpos + Vector3.up * 10f, Quaternion.identity);
        }
    }
}
