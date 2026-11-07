using UnityEngine;
using UnityEngine.SceneManagement;

public class DepressionPortal : MonoBehaviour
{
    private GameManager gameManager;
    private bool playerInRange;
    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }

    public void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void Interact()
    {
        SceneManager.LoadScene("Depression");
        Debug.Log("Player has moved onto the Depression Level");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player Is In Depression Portal Range");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player Left Depression Portal Range");
        }
    }
}
