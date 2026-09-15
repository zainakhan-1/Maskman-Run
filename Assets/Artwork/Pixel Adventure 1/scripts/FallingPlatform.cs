using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallDelay = 1f;
    public float destroyY = -10f;

    private Rigidbody2D rb;
    private Animator anim;
    private bool hasFallen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasFallen && collision.gameObject.CompareTag("Player"))
        {
            hasFallen = true;
            Invoke("Fall", fallDelay);
        }
    }

    void Fall()
    {
        // Stop fan animation
        if (anim != null)
        {
            anim.enabled = false;
        }

        // Make platform fall
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void Update()
    {
        if (transform.position.y < destroyY)
        {
            Destroy(gameObject);
        }
    }
}