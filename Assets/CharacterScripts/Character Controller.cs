using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;
    [SerializeField] private float speed = 10f;

    private float currentTime = 0f;
    private bool isGoingOn = false;
    private float moveX;
    private float moveZ;

    void Start()
    {
        currentTime = 3f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (rb == null) rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
    }

    private void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveZ = Input.GetAxisRaw("Vertical");

        Vector3 inputDirection = new Vector3(moveX, 0f, moveZ);
        if (inputDirection == Vector3.zero)
        {
            animator.SetFloat("Speed", 0f);
            animator.SetBool("isPushing", false);
        }
        else
        {
            animator.SetFloat("Speed", 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Application.Quit();
            Debug.Log("Player Quit Game");
        }
        if (isGoingOn)
        {
            currentTime -= Time.deltaTime;
        }
        if (currentTime <= 0)
        {
            animator.SetBool("isPushing", false);
            isGoingOn = false;
            currentTime = 0;
        }
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = (transform.forward * moveZ + transform.right * moveX).normalized;
        Vector3 targetVelocity = moveDirection * speed;

        rb.linearVelocity = new Vector3(targetVelocity.x, rb.linearVelocity.y, targetVelocity.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bear"))
        {
            isGoingOn = true;
            animator.SetBool("isPushing", true);
            Debug.Log("Bear pushing test");
        }
    }
}