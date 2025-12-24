using UnityEngine;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int gold = 0;
    public TextMeshProUGUI goldText;

    void Start()
    {
        UpdateGoldUI();
    }

    public void AddGold(int amount)
    {
        gold += amount;
        UpdateGoldUI();
    }

    void UpdateGoldUI()
    {
        goldText.text = "Gold : " + gold;
    }
}
