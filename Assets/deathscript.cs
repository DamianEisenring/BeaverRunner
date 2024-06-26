using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathscript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �berpr�fen, ob das Objekt, das kollidiert, der Spieler ist (angenommen, der Spieler hat den Tag "Player")
        if (other.CompareTag("Player"))
        {
            // Spieler-Objekt zerst�ren
            Destroy(other.gameObject);

            // Szene wechseln zur LevelSelector-Szene
            SceneManager.LoadScene("LevelSelector");
        }
    }
}