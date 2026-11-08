using UnityEngine;

public class BearPortalScript : MonoBehaviour
{
    private GameManager gameManager;
    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Portal"))
        {
            gameManager.setDepression(true);
            Debug.Log("Bear has Ascended to the After-life");
            Destroy(gameObject);
        }
    }
}
