using UnityEngine;
using UnityEngine.SceneManagement;

public class SawHazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Reload the current scene (or load a specific "start" scene)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            // OR load a specific scene by name:
            // SceneManager.LoadScene("StartScene");
        }
    }
}