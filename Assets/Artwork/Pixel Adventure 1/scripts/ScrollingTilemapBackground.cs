using UnityEngine;

public class ScrollingTilemapBackground : MonoBehaviour
{
    public float scrollSpeedX = 0.5f;
    public float scrollSpeedY = 0.5f;
    public float tileSize = 1f; // match your Grid's cell size

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float offsetX = Mathf.Repeat(Time.time * scrollSpeedX, tileSize);
        float offsetY = Mathf.Repeat(Time.time * scrollSpeedY, tileSize);

        transform.position = new Vector3(startPos.x + offsetX, startPos.y + offsetY, startPos.z);
    }
}