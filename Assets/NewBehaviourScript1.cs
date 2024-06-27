using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset; // Offset between the camera and the player

    void Start()
    {
        // If no offset is set, calculate the initial offset
        if (offset == Vector3.zero && player != null)
        {
            offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        if (player != null)
        {
            // Update the camera's position to follow the player
            transform.position = player.position + offset;
        }
    }
}

