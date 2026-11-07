using UnityEngine;

public class BearPortalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Portal"))
        {
            Destroy(gameObject);
            Debug.Log("Bear has Ascended to the After-life");
        }
    }
}
