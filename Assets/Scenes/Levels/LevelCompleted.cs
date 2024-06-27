using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Completed");
            // Laden Sie die Szene des Level-Selectors
            SceneManager.LoadScene("LevelSelector");
        }
    }
}
