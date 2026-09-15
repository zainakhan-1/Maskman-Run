using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelExit : MonoBehaviour
{
    public FadeTransition fade;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int nextScene =
                SceneManager.GetActiveScene().buildIndex + 1;

            StartCoroutine(fade.FadeToScene(nextScene));
        }
    }
}