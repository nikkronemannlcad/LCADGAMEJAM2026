using UnityEngine;

public class AngerLevelManager : MonoBehaviour
{

    [SerializeField] private GameObject returnPortal;
    [SerializeField] private GameObject returnPortalHitBox;

    [SerializeField] private GameObject boarPortal1;
    [SerializeField] private GameObject boarPortal2;

    [SerializeField] private GameObject boarPortal3;
    [SerializeField] private GameObject boarPortal4;

    [SerializeField] private GameObject boarPortal5;
    [SerializeField] private GameObject boarPortal6;

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
            boarPortal1.SetActive(false);
            boarPortal2.SetActive(false);

            boarPortal3.SetActive(false);
            boarPortal4.SetActive(false);

            boarPortal5.SetActive(false);
            boarPortal6.SetActive(false);

            boarTextBox.SetActive(false);
            boarText.SetActive(false);

            returnPortal.SetActive(true);
            returnPortalHitBox.SetActive(true);
        }
    }
}
