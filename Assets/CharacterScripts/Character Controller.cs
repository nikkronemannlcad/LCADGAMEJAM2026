using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpHeight = 2.5f;
    [SerializeField] private float gravity = -10;

    private Vector3 velocity;
    private bool jumpPressed;

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && characterController.isGrounded)
        {
            jumpPressed = true;
        }
    }

    private void FixedUpdate()
    {
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = (transform.forward * moveZ + transform.right * moveX).normalized;

        characterController.Move(moveDirection * speed * Time.fixedDeltaTime);

        if (jumpPressed)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpPressed = false;
        }

        velocity.y += gravity * Time.fixedDeltaTime;

        characterController.Move(velocity * Time.fixedDeltaTime);
    }
}
