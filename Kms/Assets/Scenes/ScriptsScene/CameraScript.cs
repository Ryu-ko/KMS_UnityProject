using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform centralObject; // ����������� ������ ���������
    public float rotateSpeed = 50.0f; // �������� �������� ������
    public float moveSpeed = 5.0f; // �������� ������������ ������
    public int xLimit = 20; // ������ �� X
    public int zLimit = 20; // ������ �� Z
    public float zoomSpeed = 10.0f; // �������� �����������/��������

    public float minZoomDistance = 4f; // ����������� ���������� �� �����. �������
    public float maxZoomDistance = 20.0f;

    private void Update()
    {
        RotateCamera();
        MoveCamera();
        ZoomCamera();
    }

    private void RotateCamera()
    {
        // �������� ������ ������� ��� ������� ������ ������� ����
        if (Input.GetMouseButton(1)) // ���
        {
            float h = rotateSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
            float v = rotateSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;

            transform.RotateAround(centralObject.position, Vector3.up, h); // �������� ����������� �����. �������
            transform.RotateAround(centralObject.position, transform.right, -v);  // -v - ����
        }
    }

    private void MoveCamera()
    {
        
        float horizontal = -Input.GetAxis("Horizontal");
        float vertical = -Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        Vector3 newPosition = transform.position + movement;

        // ����������� �� X � Z
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
        // ��������� ����� ���������� ����� �����������/��������

        distance = (centralObject.position - transform.position).magnitude; 
        
        // ���� ����� ���������� ������� �� �������
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