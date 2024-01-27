using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePref : MonoBehaviour
{

    public GameObject prefub1;

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
            // Генерируем случайные координаты для объекта
            float x = Random.Range(-10.0f, 10.0f);
            float y = Random.Range(-10.0f, 10.0f);
            float z = Random.Range(-10.0f, 10.0f);
            Vector3 randomPosition = new Vector3(x, y, z);

            // Создаем объект в случайной позиции
            Instantiate(prefub1, randomPosition, Quaternion.identity);
        }
    }
}
