using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform centralObject; // Центральный объект установки
    public float rotateSpeed = 50.0f; // Скорость вращения камеры
    public float moveSpeed = 5.0f; // Скорость передвижения камеры
    public int xLimit = 20; // Предел по X
    public int zLimit = 20; // Предел по Z
    public float zoomSpeed = 10.0f; // Скорость приближения/удаления

    public float minZoomDistance = 4f; // Минимальное расстояние до центр. объекта
    public float maxZoomDistance = 20.0f;

    private void Update()
    {
        RotateCamera();
        MoveCamera();
        ZoomCamera();
    }

    private void RotateCamera()
    {
        // Вращение вокруг объекта при нажатии правой клавиши мыши
        if (Input.GetMouseButton(1)) // пкм
        {
            float h = rotateSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
            float v = rotateSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;

            transform.RotateAround(centralObject.position, Vector3.up, h); // вращение отнносильно центр. объекта
            transform.RotateAround(centralObject.position, transform.right, -v);  // -v - угол
        }
    }

    private void MoveCamera()
    {
        
        float horizontal = -Input.GetAxis("Horizontal");
        float vertical = -Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        Vector3 newPosition = transform.position + movement;

        // Ограничения по X и Z
        newPosition.x = Mathf.Clamp(newPosition.x, centralObject.position.x - xLimit, centralObject.position.x + xLimit);
        newPosition.z = Mathf.Clamp(newPosition.z, centralObject.position.z - zLimit, centralObject.position.z + zLimit);

        transform.position = newPosition;
    }

    private void ZoomCamera()
    {
        
        float zoomChange = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        Vector3 direction = centralObject.position - transform.position;
        float distance = direction.magnitude;

        if ((zoomChange > 0 && distance <= minZoomDistance) ||
            (zoomChange < 0 && distance >= maxZoomDistance))
        {
            return;
        }

        transform.Translate(0, 0, zoomChange);
        // Проверяем новое расстояние после приближения/удаления

        distance = (centralObject.position - transform.position).magnitude; 
        
        // Если новое расстояние выходит за границы
        if (distance < minZoomDistance)
        {
            transform.position = centralObject.position - direction.normalized * minZoomDistance;
        }
        else if (distance > maxZoomDistance)
        {
            transform.position = centralObject.position - direction.normalized * maxZoomDistance;
        }
    }

}