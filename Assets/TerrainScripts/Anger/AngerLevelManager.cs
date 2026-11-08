using UnityEngine;

public class AngerLevelManager : MonoBehaviour
{

    [SerializeField] private GameObject returnPortal;
    [SerializeField] private GameObject returnPortalHitBox;

    [SerializeField] private GameObject boarTextBox;
    [SerializeField] private GameObject boarText;

    private GameManager gameManager;

    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
        returnPortal.SetActive(false);
        returnPortalHitBox.SetActive(false);
        boarTextBox.SetActive(false);
        boarText.SetActive(false);
    }

    public void Update()
    {
        if (gameManager.getAnger() == true)
        {
            boarTextBox.SetActive(false);
            boarText.SetActive(false);

            returnPortal.SetActive(true);
            returnPortalHitBox.SetActive(true);
        }
    }
}
