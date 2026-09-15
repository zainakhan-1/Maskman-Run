using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTransition : MonoBehaviour
{
    public CanvasGroup fadePanel;
    public float fadeTime = 1f;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        float t = 0;

        while (t < fadeTime)
        {
            t += Time.deltaTime;
            fadePanel.alpha = Mathf.Lerp(1, 0, t / fadeTime);
            yield return null;
        }

        fadePanel.alpha = 0;
    }

    public IEnumerator FadeToScene(int sceneIndex)
    {
        float t = 0;

        while (t < fadeTime)
        {
            t += Time.deltaTime;
            fadePanel.alpha = Mathf.Lerp(0, 1, t / fadeTime);
            yield return null;
        }

        SceneManager.LoadScene(sceneIndex);
    }
}