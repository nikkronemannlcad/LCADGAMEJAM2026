using UnityEngine;

public class BoarTalkingScript : MonoBehaviour
{
    private bool playerIsInRange = false;
    public float timeRemaining = 10f;
    public BoarScript boarScript;
    [SerializeField] private GameObject boarTextBox;
    [SerializeField] private GameObject boarText;
    public bool timerActive = false;
    public void Update()
    {
        if (playerIsInRange && Input.GetKeyDown(KeyCode.E))
        {
            boarText.SetActive(true);
            boarTextBox.SetActive(true);
            timerActive = true;
            while (timerActive)
            {
                if (timeRemaining > 0)
                {

                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    timeRemaining = 0;
                    timerActive = false;
                    Debug.Log(timeRemaining);
                    boarText.SetActive(false);
                    boarTextBox.SetActive(false);
                    boarScript.setAngry(true);
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playerIsInRange = false;
    }
}
