using UnityEngine;
using UnityEngine.UI;

public class Cooking : MonoBehaviour
{
    public float cookingTime = 3f;
    public int rewardGold = 10;

    bool isCooking = false;
    float cookTimer = 0f;

    public Image progressImage;
    public GoldManager goldManager;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        progressImage.gameObject.SetActive(false);
        progressImage.fillAmount = 0;
    }

    void Update()
    {
        if (!isCooking) return;

        cookTimer += Time.deltaTime;
        progressImage.fillAmount = cookTimer / cookingTime;

        if (cookTimer >= cookingTime)
        {
            isCooking = false;
            cookTimer = 0f;

            animator.SetBool("isCooking", false);

            progressImage.gameObject.SetActive(false);

            goldManager.AddGold(rewardGold);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stove"))
        {
            isCooking = true;
            cookTimer = 0f;

            animator.SetBool("isCooking", true);

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

            animator.SetBool("isCooking", false);

            progressImage.fillAmount = 0;
            progressImage.gameObject.SetActive(false);
        }
    }
}