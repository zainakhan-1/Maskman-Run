using UnityEngine;

public class DestroyAfterAnimation : MonoBehaviour
{
    public float lifetime = 0.5f; // adjust to match animation length

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}