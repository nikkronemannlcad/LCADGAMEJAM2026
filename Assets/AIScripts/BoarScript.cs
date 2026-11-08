using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class BoarScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float locationDelay = 0.5f;
    [SerializeField] private Transform player;
    private Transform playerTransform;
    private GameManager gameManager;
    private int playerhitcount;
    private Queue<Vector3> playerHistory = new Queue<Vector3>();

    void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
        if (player != null)
        {
            playerTransform = player;
        }
        StartCoroutine(RecordPlayerPath());
        StartCoroutine(FollowPlayerPath());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerhitcount == 0)
            {
                Debug.Log("Player got hit one more and player dies");
                playerhitcount++;
            }
            else if (playerhitcount == 1)
            {
                Debug.Log("Player Died to the Boar");
                SceneManager.LoadScene("Anger");
            }
        }
        if (other.CompareTag("Portal"))
        {
            Debug.Log("Player beat the boar and won the level, return to den");
            gameManager.setAnger(true);
            Destroy(gameObject);
        }
    }
    IEnumerator RecordPlayerPath()
    {
        while (true)
        {
            if (playerTransform != null)
            {
                playerHistory.Enqueue(playerTransform.position);
            }
            yield return null;
        }
    }
    IEnumerator FollowPlayerPath() { 
        yield return new WaitForSeconds(locationDelay);

        while (true)
        {
            if (playerHistory.Count > 0)
            {
                Vector3 targetPosition = playerHistory.Dequeue();
                while (Vector3.Distance(transform.position, targetPosition) > 0.05f)
                {
                    targetPosition.y = 1;
                    transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                    yield return null;
                }
                transform.position = targetPosition;
            }
            else
            {
                yield return null;
            }
        }
    }
}
