using UnityEngine;

public class SawMovement : MonoBehaviour
{
    public Transform waypoint1;
    public Transform waypoint2;
    public float speed = 3f;

    private Transform target;

    void Start()
    {
        transform.position = waypoint1.position;
        target = waypoint2;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (Vector2.Distance(transform.position, target.position) < 0.05f)
        {
            target = target == waypoint1 ? waypoint2 : waypoint1;
        }
    }
}