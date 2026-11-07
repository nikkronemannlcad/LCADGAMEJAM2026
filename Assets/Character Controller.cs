using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;
    [SerializeField] private float speed = 5;

    private float jumpVelocity;
    private Vector3 movement;
    private bool jumpPressed;
    private int testCounter = 0;

    private void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(movement.x, 0, movement.y).normalized;

        characterController.Move(move * Time.deltaTime);

        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }
    }
}
