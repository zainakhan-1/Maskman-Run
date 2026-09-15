using UnityEngine;
using TMPro;

public class FruitCounter : MonoBehaviour
{
    public static FruitCounter Instance;

    [SerializeField] private TextMeshProUGUI fruitCountText;
    private int fruitCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddFruit(int amount = 1)
    {
        fruitCount += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        fruitCountText.text = fruitCount.ToString();
    }
}