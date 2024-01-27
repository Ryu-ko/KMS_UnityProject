using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    private MeshRenderer meshRenderer;

    void Start()
    {
        // Получаем компонент MeshRenderer
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // Проверяем, был ли сделан щелчок левой кнопкой мыши
        if (Input.GetMouseButtonDown(0))
        {
            // Создаем луч от позиции камеры в направлении, куда указывает мышь
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Проверяем, столкнулся ли луч с этим объектом
            if (Physics.Raycast(ray, out hit) && hit.transform == transform)
            {
                // Если да, то меняем цвет материала на случайный
                meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }
}
