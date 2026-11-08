using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;
    [SerializeField] private Animator animator;
    [SerializeField] private float speed = 10f;

    private Vector3 velocity;

    private void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = (transform.forward * moveZ + transform.right * moveX).normalized;

        if (moveDirection == Vector3.zero)
        {
            animator.SetFloat("Speed", 0f);
        } else if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("Speed", 0.5f);
        }

            characterController.Move(moveDirection * speed * Time.fixedDeltaTime);
        characterController.Move(velocity * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bear"))
        {
            animator.SetBool("isPushing", true);
            Debug.Log("Bear pushing test");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isPushing", false);
        Debug.Log("Player left Bear push Test Area");
    }
}
