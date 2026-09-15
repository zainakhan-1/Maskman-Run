using UnityEngine;

public class BGMusicManager : MonoBehaviour
{
    private static BGMusicManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject); // prevent duplicate music players in new scenes
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // survive scene loads
    }
}