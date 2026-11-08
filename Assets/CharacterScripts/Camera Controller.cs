using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerTarget;
    public Vector3 positionOffset = new Vector3(0f, 2f, 0f);

    public float mouseSensitivity = 100f;
    public float minVerticalAngle = -45f;
    public float maxVerticalAngle = 45f;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, minVerticalAngle, maxVerticalAngle);

        if (playerTarget != null)
        {
            playerTarget.Rotate(Vector3.up * mouseX);
        }
    }

    void LateUpdate()
    {
        if (playerTarget == null) return;
        transform.position = playerTarget.position + (playerTarget.rotation * positionOffset);

        Quaternion horizontalRotation = Quaternion.Euler(0f, playerTarget.eulerAngles.y, 0f);
        Quaternion verticalRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.rotation = horizontalRotation * verticalRotation;
    }
}
