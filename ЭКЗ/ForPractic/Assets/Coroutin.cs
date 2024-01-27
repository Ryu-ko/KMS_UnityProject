using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutin : MonoBehaviour {

    public GameObject prefab1;
    public Vector3 startPos;

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
            GameObject cube = Instantiate(prefab1, startPos + Vector3.up * 10f, Quaternion.identity);
            StartCoroutine(DestroyCube(cube));
        }
    }

    IEnumerator DestroyCube(GameObject cube)
    {
        yield return new WaitForSeconds(5);
        Destroy(cube);
    }
}

