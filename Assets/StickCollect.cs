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
            // Erh�hen Sie den Z�hler und aktualisieren Sie den Text
            stickCounter.AddStick();
            Destroy(gameObject); // Zerst�rt das Stock-Objekt
        }
    }
}