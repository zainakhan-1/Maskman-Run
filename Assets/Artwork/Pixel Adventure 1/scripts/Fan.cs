using UnityEngine;

public class Fan : MonoBehaviour
{
    public float liftForce = 12f;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, liftForce);
            }
        }
    }
}