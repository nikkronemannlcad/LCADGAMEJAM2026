using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class BoarScript : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Transform player;
    [SerializeField] private float chargeDuration = 3.5f;
    [SerializeField] private float idleTime = 1.5f;
    [SerializeField] private Animator animator;


    private GameManager gameManager;
    private int playerhitcount;
    private bool isAngry = false;
    private bool chargeOngoing;

    void Start()
    {
        gameManager = Object.FindFirstObjectByType<GameManager>();
    }
    public void Update()
    {
        if (isAngry && !chargeOngoing)
        {
            StartCoroutine(ChargeRoutine());
            gameManager.setAnger(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isAngry)
        {
            if (playerhitcount == 0 && isAngry)
            {
                Debug.Log("If you get hit another time you die");
                playerhitcount++;
            }
            else if (playerhitcount == 1 && isAngry)
            {
                Debug.Log("Player Died");
                SceneManager.LoadScene("Anger");
            }
        }
    }

    IEnumerator ChargeRoutine()
    {
        chargeOngoing = true;
        yield return new WaitForSeconds(0.5f);

        Vector3 targetPosition = player.position;
        targetPosition.y = transform.position.y;
        transform.LookAt(targetPosition);
        animator.SetFloat("Speed", 0.5f);
        float timerForCharge = 0f;

        while (Vector3.Distance(transform.position, targetPosition) > 0.3f && timerForCharge < chargeDuration)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            timerForCharge += Time.deltaTime;
            yield return null;
        }
        if (Vector3.Distance(transform.position, targetPosition) <= 0.1f)
        {
            transform.position = targetPosition;
        }
        animator.SetFloat("Speed", 0f);
        yield return new WaitForSeconds(idleTime);
        chargeOngoing = false;
    }

    public void setAngry(bool value)
    {
        isAngry = value;
    }
}
