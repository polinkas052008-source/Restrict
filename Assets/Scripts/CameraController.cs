using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 2f;
    [SerializeField] private float _clampAngle = 80f;

    private float _rotX;

    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * _sensitivity;
        _rotX -= mouseY;
        _rotX = Mathf.Clamp(_rotX, -_clampAngle, _clampAngle);

        transform.localRotation = Quaternion.Euler(_rotX, 0f, 0f);
    }
}