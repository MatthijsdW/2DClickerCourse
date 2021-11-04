using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;

    public Sprite[] backgrounds;
    private int currentBackground;
    private int enemiesUntilBackgroundChange;
    public Image backgroundImage;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        enemiesUntilBackgroundChange = 5;
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = $"Gold: {gold}";
    }

    public void BackgroundCheck()
    {
        enemiesUntilBackgroundChange--;

        if (enemiesUntilBackgroundChange <= 0)
        {
            currentBackground = currentBackground + 1 == backgrounds.Length ? 0 : currentBackground + 1;
            backgroundImage.sprite = backgrounds[currentBackground];

            enemiesUntilBackgroundChange = 5;
        }
    }
}
