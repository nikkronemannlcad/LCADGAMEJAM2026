using UnityEngine;

public class ShinyTest : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private GameObject coinPickupSound;

    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.setAcquiredShiny(true);
            coinPickupSound.SetActive(true);
            Destroy(gameObject);
            Debug.Log("Acquired Shiny Object for Crow");

        }
    }
}