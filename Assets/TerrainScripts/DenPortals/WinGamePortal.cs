using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
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
        SceneManager.LoadScene("Credits");
        Debug.Log("Player has moved onto the Credits Level");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player Is In Credit Portal Range");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player Left Credit Portal Range");
        }
    }
}
