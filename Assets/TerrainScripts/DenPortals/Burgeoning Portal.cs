using UnityEngine;
using UnityEngine.SceneManagement;

public class BurgeoningPortal : MonoBehaviour
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
        SceneManager.LoadScene("Burgeoning");
        Debug.Log("Player has moved onto the Burgeoning Level");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player Is In Burgeoning Portal Range");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player Left Burgeoning Portal Range");
        }
    }
}
