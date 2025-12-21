using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public static FoodManager Instance;
    public int foodPrice = 10; // Her yemek satýþý kaç para

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    // Yemek servis etme fonksiyonu
    public void ServeFood()
    {
        MoneyManager.Instance.AddMoney(foodPrice);
        Debug.Log("Yemek satýldý! +" + foodPrice);
    }
}
