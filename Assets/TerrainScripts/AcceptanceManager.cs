using UnityEngine;

public class AcceptanceManager : MonoBehaviour
{
    [SerializeField] private GameObject DenialPortal;
    [SerializeField] private GameObject AngerPortal;
    [SerializeField] private GameObject BurgeoningPortal;
    [SerializeField] private GameObject DepressionPortal;
    [SerializeField] private GameObject AcceptancePortal;

    [SerializeField] private GameObject DenialPortalHitbox;
    [SerializeField] private GameObject AngerPortalHitbox;
    [SerializeField] private GameObject BurgeoningPortalHitbox;
    [SerializeField] private GameObject DepressionPortalHitbox;
    [SerializeField] private GameObject AcceptancePortalHitbox;


    [SerializeField] private GameObject DenialPortalVFX;
    [SerializeField] private GameObject AngerPortalVFX;
    [SerializeField] private GameObject BurgeoningPortalVFX;
    [SerializeField] private GameObject DepressionPortalVFX;
    [SerializeField] private GameObject AcceptancePortalVFX1;
    [SerializeField] private GameObject AcceptancePortalVFX2;
    [SerializeField] private GameObject owlFamily;
    private GameManager gameManager;
    public void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();

        //Level 1 Unlock
        if (gameManager.getDenial() == false)
        {
            DenialPortal.SetActive(true);
            AngerPortal.SetActive(false);
            BurgeoningPortal.SetActive(false);
            DepressionPortal.SetActive(false);
            AcceptancePortal.SetActive(false);

            DenialPortalHitbox.SetActive(true);
            AngerPortalHitbox.SetActive(false);
            BurgeoningPortalHitbox.SetActive(false);
            DepressionPortalHitbox.SetActive(false);
            AcceptancePortalHitbox.SetActive(false);

            DenialPortalVFX.SetActive(true);
            AngerPortalVFX.SetActive(false);
            BurgeoningPortalVFX.SetActive(false);
            DepressionPortalVFX.SetActive(false);
            AcceptancePortalVFX1.SetActive(false);
            AcceptancePortalVFX2.SetActive(false);

            owlFamily.SetActive(false);
        }
        //Level 2 Unlock
        if (gameManager.getDenial() == true && gameManager.getAnger() == false)
        {
            DenialPortal.SetActive(false);
            AngerPortal.SetActive(true);
            BurgeoningPortal.SetActive(false);
            DepressionPortal.SetActive(false);
            AcceptancePortal.SetActive(false);

            DenialPortalHitbox.SetActive(false);
            AngerPortalHitbox.SetActive(true);
            BurgeoningPortalHitbox.SetActive(false);
            DepressionPortalHitbox.SetActive(false);
            AcceptancePortalHitbox.SetActive(false);

            DenialPortalVFX.SetActive(false);
            AngerPortalVFX.SetActive(true);
            BurgeoningPortalVFX.SetActive(false);
            DepressionPortalVFX.SetActive(false);
            AcceptancePortalVFX1.SetActive(false);
            AcceptancePortalVFX2.SetActive(false);
            owlFamily.SetActive(false);
        }
        //Level 3 Unlock
        if (gameManager.getAnger() == true && gameManager.getBargening() == false)
        {
            DenialPortal.SetActive(false);
            AngerPortal.SetActive(false);
            BurgeoningPortal.SetActive(true);
            DepressionPortal.SetActive(false);
            AcceptancePortal.SetActive(false);

            DenialPortalHitbox.SetActive(false);
            AngerPortalHitbox.SetActive(false);
            BurgeoningPortalHitbox.SetActive(true);
            DepressionPortalHitbox.SetActive(false);
            AcceptancePortalHitbox.SetActive(false);

            DenialPortalVFX.SetActive(false);
            AngerPortalVFX.SetActive(false);
            BurgeoningPortalVFX.SetActive(true);
            DepressionPortalVFX.SetActive(false);
            AcceptancePortalVFX1.SetActive(false);
            AcceptancePortalVFX2.SetActive(false);
            owlFamily.SetActive(false);
        }
        //Level 4 Unlock
        if (gameManager.getBargening() == true && gameManager.getDepression() == false)
        {
            DenialPortal.SetActive(false);
            AngerPortal.SetActive(false);
            BurgeoningPortal.SetActive(false);
            DepressionPortal.SetActive(true);
            AcceptancePortal.SetActive(false);

            DenialPortalHitbox.SetActive(true);
            AngerPortalHitbox.SetActive(true);
            BurgeoningPortalHitbox.SetActive(false);
            DepressionPortalHitbox.SetActive(true);
            AcceptancePortalHitbox.SetActive(false);

            DenialPortalVFX.SetActive(false);
            AngerPortalVFX.SetActive(false);
            BurgeoningPortalVFX.SetActive(false);
            DepressionPortalVFX.SetActive(true);
            AcceptancePortalVFX1.SetActive(false);
            AcceptancePortalVFX2.SetActive(false);
            owlFamily.SetActive(false);
        }
        //End of Game
        if (gameManager.getBargening() == true && gameManager.getDepression() == true && gameManager.getAnger() == true && gameManager.getDenial() == true)
        {
            DenialPortal.SetActive(false);
            AngerPortal.SetActive(false);
            BurgeoningPortal.SetActive(false);
            DepressionPortal.SetActive(false);
            gameManager.setAcceptance(true);
            AcceptancePortal.SetActive(true);

            DenialPortalHitbox.SetActive(false);
            AngerPortalHitbox.SetActive(false);
            BurgeoningPortalHitbox.SetActive(false);
            DepressionPortalHitbox.SetActive(false);
            AcceptancePortalHitbox.SetActive(true);

            DenialPortalVFX.SetActive(false);
            AngerPortalVFX.SetActive(false);
            BurgeoningPortalVFX.SetActive(false);
            DepressionPortalVFX.SetActive(false);
            AcceptancePortalVFX1.SetActive(true);
            AcceptancePortalVFX2.SetActive(true);

            owlFamily.SetActive(true);

        }
    }
}
