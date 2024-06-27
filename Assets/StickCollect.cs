using UnityEngine;

public class StickCollect : MonoBehaviour
{
    private StickCounter stickCounter;

    private void Start()
    {
        // Finden Sie das StickCounter-Skript in der Szene
        stickCounter = FindObjectOfType<StickCounter>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Erhöhen Sie den Zähler und aktualisieren Sie den Text
            stickCounter.AddStick();
            Destroy(gameObject); // Zerstört das Stock-Objekt
        }
    }
}