using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);

            SceneManager.LoadScene("LevelSelector");
        }
    }
}