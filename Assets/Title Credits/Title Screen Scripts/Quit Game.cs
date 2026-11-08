using UnityEngine;

public class QuitGame : MonoBehaviour
{
  public void ExitGame()
    {
        Debug.Log("Player Exited Game");
        Application.Quit();
        
    }
}
