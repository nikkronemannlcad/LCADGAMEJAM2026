using UnityEngine;

public class DepressionLevelManager : MonoBehaviour
{

    [SerializeField] private GameObject returnPortal;
    [SerializeField] private GameObject returnPortalHitBox;

    [SerializeField] private GameObject bearPortal1;
    [SerializeField] private GameObject bearPortal2;
    [SerializeField] private GameObject bearTextBox;
    [SerializeField] private GameObject bearText;

    private GameManager gameManager;

    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
        returnPortal.SetActive(false);
        returnPortalHitBox.SetActive(false);
        bearTextBox.SetActive(false);
        bearText.SetActive(false);
    }

    public void Update()
    {
        if (gameManager.getDepression() == true)
        {
            bearPortal1.SetActive(false);
            bearPortal2.SetActive(false);
            bearTextBox.SetActive(false);
            bearText.SetActive(false);

            returnPortal.SetActive(true);
            returnPortalHitBox.SetActive(true);
        }
    }
}
