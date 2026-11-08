using UnityEngine;

public class ShinyTest : MonoBehaviour
{
    private GameManager gameManager;

    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.setAcquiredShiny(true);
            Destroy(gameObject);
            Debug.Log("Acquired Shiny Object for Crow");
        }
    }
}