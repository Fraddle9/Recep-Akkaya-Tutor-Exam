using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public float detectionRange;
    private Transform playerTransform;
    private Rigidbody rb;

    private void Start()
    {
        moveSpeed = 2f;
        detectionRange = 10f;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // To prevent rigidbody from rotating due to physics
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

            if (distanceToPlayer <= detectionRange)
            {
                // Look at the player
                Vector3 directionToPlayer = (playerTransform.position - transform.position).normalized;
                Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);

                // Move forward using Rigidbody velocity
                Vector3 forwardDirection = transform.forward;
                rb.velocity = forwardDirection * moveSpeed;
            }
            else
            {
                // Stop the enemy's movement when player is out of detection range
                rb.velocity = new Vector3(0f,rb.velocity.y,0f);
            }
        }
    }
}
