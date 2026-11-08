using UnityEngine;
using System.Collections;

public class DenialPatrol : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private Transform PortalWaypoint;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float idleTime = 1f;
    [SerializeField] private int currentPatrolPoint = 0;
    private bool gotCaught = false;
    private Transform target;
    private GameManager gameManager;

    void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
        if (waypoints != null && waypoints.Length > 0 && waypoints[0] != null)
        {
            StartCoroutine(FollowPathRoutine());
        }    
}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gotCaught = true;
            Debug.Log("The Hare will move onto the afterlife");
            gameManager.setDenial(true);
        }
        if (other.CompareTag("Portal"))
        {

            Destroy(gameObject);
        }
    }

    IEnumerator FollowPathRoutine()
    {
        while (gotCaught == false)
        {
            target = waypoints[currentPatrolPoint];

            while (Vector3.Distance(transform.position, target.position) > 0.05f)
            {
                transform.LookAt(target);
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                yield return null;
            }
            transform.position = target.position;
            yield return new WaitForSeconds(idleTime);
            currentPatrolPoint = (currentPatrolPoint + 1) % waypoints.Length;
        }
        if (gotCaught == true)
        {
            target = PortalWaypoint;

            while (Vector3.Distance(transform.position, target.position) > 0.05f)
            {
                transform.LookAt(target);
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                yield return null;
            }
            transform.position = target.position;
            yield return new WaitForSeconds(idleTime);
            currentPatrolPoint = (currentPatrolPoint + 1) % waypoints.Length;
        }
    }
}
