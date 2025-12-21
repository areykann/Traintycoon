using UnityEngine;
using UnityEngine.UI;

public class Cooking : MonoBehaviour
{
    public float cookingTime = 3f;   // Dolma süresi
    public int rewardGold = 10;

    bool isCooking = false;
    float cookTimer = 0f;

    public Image progressImage;

    void Start()
    {
        progressImage.gameObject.SetActive(false);
        progressImage.fillAmount = 0;
    }

    void Update()
    {
        if (isCooking)
        {
            cookTimer += Time.deltaTime;
            progressImage.fillAmount = cookTimer / cookingTime;

            if (cookTimer >= cookingTime)
            {
                isCooking = false;
                progressImage.gameObject.SetActive(false);
                cookTimer = 0f;

                Debug.Log("+10 Gold Kazandýn!");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stove"))
        {
            isCooking = true;
            cookTimer = 0f;

            progressImage.gameObject.SetActive(true);
            progressImage.fillAmount = 0;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Stove"))
        {
            isCooking = false;
            cookTimer = 0f;

            progressImage.fillAmount = 0;
            progressImage.gameObject.SetActive(false);
        }
    }
}