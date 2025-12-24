using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    public Transform targetPoint; // Mutfak vagonunda spawn noktasý

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = targetPoint.position;
        }
    }
}
