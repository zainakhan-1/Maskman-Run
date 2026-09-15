using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;

    private Rigidbody2D rb;
    private Animator anim;
    private AudioSource audioSource;

    public AudioClip footstepClip;

    private int jumpCount = 0;
    public int maxJumps = 2;
    private bool isGrounded = true;

    private Transform currentPlatform;
    private Vector3 lastPlatformPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        GameObject startPoint = GameObject.FindGameObjectWithTag("Start");
        if (startPoint != null)
        {
            transform.position = startPoint.transform.position;
        }
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(x * speed, rb.linearVelocity.y);

        // Move with platform without parenting
        if (currentPlatform != null)
        {
            Vector3 delta = currentPlatform.position - lastPlatformPosition;
            transform.position += new Vector3(delta.x, 0, 0);
            lastPlatformPosition = currentPlatform.position;
        }

        // Running Animation
        anim.SetBool("running", x != 0);

        // Jump / Falling Animation
        anim.SetBool("jumping", !isGrounded && rb.linearVelocity.y > 0.01f);
        anim.SetBool("falling", !isGrounded && rb.linearVelocity.y < -0.01f);

        // Face Direction
        if (x > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        // Double Jump
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpCount++;
            isGrounded = false;
            currentPlatform = null;
        }
    }

    // Called from an Animation Event on the running animation
    public void PlayFootstepSound()
    {
        if (audioSource != null && footstepClip != null)
        {
            audioSource.PlayOneShot(footstepClip);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("FallingPlatform") ||
            collision.gameObject.CompareTag("Platform"))
        {
            jumpCount = 0;
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Platform"))
        {
            currentPlatform = collision.gameObject.transform;
            lastPlatformPosition = currentPlatform.position;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            currentPlatform = null;
        }
    }
}