using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject collectEffect; // assign the "Collected" animation prefab here
    public AudioClip collectSound;   // assign your collect sound here

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (collectEffect != null)
            {
                Instantiate(collectEffect, transform.position, Quaternion.identity);
            }

            if (collectSound != null)
            {
                AudioSource.PlayClipAtPoint(collectSound, transform.position);
            }

            FruitCounter.Instance.AddFruit(1);

            Destroy(gameObject);
        }
    }
}