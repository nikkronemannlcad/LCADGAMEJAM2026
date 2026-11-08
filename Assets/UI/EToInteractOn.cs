using UnityEngine;

public class EToInteractOn : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private GameObject UICoin;
    private bool hasCoin;
    [SerializeField] private GameObject uiEtoInt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
        if (UICoin != null)
        {
            UICoin.SetActive(false);
        }
        if (uiEtoInt != null)
        {
            uiEtoInt.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.getAcquiredShiny() == true)
        {
            if (UICoin != null)
            {
                UICoin.SetActive(true);
            }
        } else
        {
            if (UICoin != null)
            {
                UICoin.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TextBox"))
        {
            if (uiEtoInt != null)
            {
                uiEtoInt.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (uiEtoInt != null)
        {
            uiEtoInt.SetActive(false);
        }
    }
}
