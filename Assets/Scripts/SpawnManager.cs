using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            player.transform.position = spawnPoint.position;
        }
    }
}
