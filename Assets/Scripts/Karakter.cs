using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody2D rb;
    Vector2 movement;

    SpriteRenderer sr;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Sadece sað - sol
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = 0;

        // Yüz döndürme
        if (movement.x > 0)
            sr.flipX = false;
        else if (movement.x < 0)
            sr.flipX = true;

        // KOÞU – IDLE animasyon kontrol
        animator.SetBool("isRunning", movement.x != 0);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}