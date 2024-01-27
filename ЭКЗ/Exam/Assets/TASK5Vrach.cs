using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TASK5Vrach : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public float moveSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;

        // Перемещение
        transform.Translate(horizontal, 0, vertical);

        // Поворот вокруг оси Y
        Quaternion rotation = Quaternion.Euler(0, vertical, 0);
        transform.rotation *= rotation;
    }
}
