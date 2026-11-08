using UnityEngine;

public class AcceptanceManager : MonoBehaviour
{
    [SerializeField] private GameObject DenialPortal;
    [SerializeField] private GameObject AngerPortal;
    [SerializeField] private GameObject BurgeoningPortal;
    [SerializeField] private GameObject DepressionPortal;
    [SerializeField] private GameObject AcceptancePortal;
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
        }
        //Level 2 Unlock
        if (gameManager.getDenial() == true && gameManager.getAnger() == false)
        {
            DenialPortal.SetActive(false);
            AngerPortal.SetActive(true);
            BurgeoningPortal.SetActive(false);
            DepressionPortal.SetActive(false);
            AcceptancePortal.SetActive(false);
        }
        //Level 3 Unlock
        if (gameManager.getAnger() == true && gameManager.getBargening() == false)
        {
            DenialPortal.SetActive(false);
            AngerPortal.SetActive(false);
            BurgeoningPortal.SetActive(true);
            DepressionPortal.SetActive(false);
            AcceptancePortal.SetActive(false);
        }
        //Level 4 Unlock
        if (gameManager.getBargening() == true && gameManager.getDepression() == false)
        {
            DenialPortal.SetActive(false);
            AngerPortal.SetActive(false);
            BurgeoningPortal.SetActive(false);
            DepressionPortal.SetActive(true);
            AcceptancePortal.SetActive(false);
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
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
