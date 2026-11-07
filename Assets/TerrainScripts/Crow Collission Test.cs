using UnityEngine;

public class CrowCollissionTest : MonoBehaviour
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
        gameManager.setAcquiredShiny(false);
        Debug.Log("Player has given the crow the shiny object");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player In Crow Talking Range");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player Left Crow Talking Range");
        }
    }
}
