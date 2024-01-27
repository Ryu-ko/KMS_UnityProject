using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Проверяем, был ли щелчок левой кнопкой мыши
        if (Input.GetMouseButtonDown(0))
        {
            // Создаем луч из камеры в точку щелчка мыши
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Выполняем Raycast и проверяем, попал ли луч в какой-либо объект
            if (Physics.Raycast(ray, out hit))
            {
                // Если луч попал в объект, увеличиваем его размер в два раза
                hit.transform.localScale *= 2;
            }

        }
    }
}
