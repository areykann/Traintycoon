using UnityEngine;
using UnityEngine.SceneManagement;

public class WagonSceneChange : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TRIGGER ÇALIÞTI: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER ALGILANDI! SAHNE DEÐÝÞÝYOR: " + sceneName);
            SceneManager.LoadScene(sceneName);
        }
    }
}
