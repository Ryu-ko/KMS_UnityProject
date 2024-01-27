using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterExit : MonoBehaviour
{
    // Увеличиваем объект в два раза при входе в триггер
    void OnTriggerEnter(Collider other)
    {
        other.transform.localScale = other.transform.localScale * 2;
    }

    // Возвращаем объекту исходный размер при выходе из триггера
    void OnTriggerExit(Collider other)
    {
        other.transform.localScale = other.transform.localScale / 2;
    }
}
