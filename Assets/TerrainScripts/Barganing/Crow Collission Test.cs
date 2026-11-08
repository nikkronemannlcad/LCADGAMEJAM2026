using TMPro;
using UnityEngine;

public class CrowCollissionTest : MonoBehaviour
{
    private GameManager gameManager;
    private bool playerInRange;
    private bool yes = true;
    public float timeRemaining = 10f;
    [SerializeField] private GameObject crowTextBox;
    [SerializeField] private GameObject crowText;
    public bool timerActive = false;
    public void Start()
    {
        crowText.SetActive(false);
        crowTextBox.SetActive(false);
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }

    public void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && gameManager.getAcquiredShiny() == true)
        {
            InteractWithShiny();
        }
        else if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            InteractWithoutShiny();
            timerActive = true;
        }
        if (timerActive && gameManager.getAcquiredShiny() == false)
        {
            crowText.SetActive(true);
            crowTextBox.SetActive(true);
            if (timeRemaining > 0)
            {

                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerActive = false;
                crowText.SetActive(false);
                crowTextBox.SetActive(false);
            }
        }
        if (timerActive && gameManager.getAcquiredShiny() == true)
        {
            crowText.SetActive(true);
            crowTextBox.SetActive(true);
            if (timeRemaining > 0)
            {

                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerActive = false;
                crowText.SetActive(false);
                crowTextBox.SetActive(false);
            }
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
