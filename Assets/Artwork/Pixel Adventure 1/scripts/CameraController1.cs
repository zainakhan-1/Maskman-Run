using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    [Header("Follow Settings")]
    public float smoothSpeed = 5f;

    [Header("Camera Size")]
    public float desiredWidth = 20f;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();

        // Set camera size based on desired width
        cam.orthographicSize = desiredWidth / (2f * cam.aspect);
    }

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 targetPosition = new Vector3(
            player.position.x,
            player.position.y,
            -10f
        );

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}