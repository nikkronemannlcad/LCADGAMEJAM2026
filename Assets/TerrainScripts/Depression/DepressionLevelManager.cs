using UnityEngine;

public class DepressionLevelManager : MonoBehaviour
{

    [SerializeField] private GameObject returnPortal;
    [SerializeField] private GameObject returnPortalHitBox;

    [SerializeField] private GameObject bearTextBox;
    [SerializeField] private GameObject bearText;

    private GameManager gameManager;

    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
        returnPortal.SetActive(true);
        returnPortalHitBox.SetActive(true);
        bearTextBox.SetActive(true);
        bearText.SetActive(true);
    }

    public void Update()
    {
        if (gameManager.getDepression() == true)
        {
            bearTextBox.SetActive(false);
            bearText.SetActive(false);

            returnPortal.SetActive(true);
            returnPortalHitBox.SetActive(true);
        }
    }
}
