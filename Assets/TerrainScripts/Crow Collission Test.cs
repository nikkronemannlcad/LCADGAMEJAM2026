using UnityEngine;

public class CrowCollissionTest : MonoBehaviour
{
    private GameManager gameManager;
    private bool playerInRange;
    private bool yes = true;
    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }

    public void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && gameManager.getAcquiredShiny() == true)
        {
            InteractWithShiny();
        } else if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            InteractWithoutShiny();
        }
    }

    private void InteractWithShiny()
    {
        gameManager.setBargening(yes);
        gameManager.setAcquiredShiny(false);
        Debug.Log("Player has given the crow the shiny object");
        Destroy(gameObject);

    }
    private void InteractWithoutShiny()
    {
        Debug.Log("Player must obtain the Crow's shiny object first");
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
