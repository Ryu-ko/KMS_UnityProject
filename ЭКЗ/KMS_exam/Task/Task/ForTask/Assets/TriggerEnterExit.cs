using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterExit : MonoBehaviour {

    // Увеличиваем объект в два раза при входе в триггер
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.red;
    }

    // Возвращаем объекту исходный размер при выходе из триггера
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.white;
    }
}
