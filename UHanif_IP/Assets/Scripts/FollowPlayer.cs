using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   public Transform player; // Reference to the player
    public Vector3 offset;   // Offset position relative to the player
    public float rotationSpeed = 5f; // Speed of camera rotation

    void Start()
    {
        // Set the initial offset based on the current camera and player positions
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Get mouse input for camera rotation
        float horizontal = Input.GetAxis("Mouse X") * rotationSpeed;

        // Rotate the camera around the player
        player.Rotate(Vector3.up * horizontal);

        // Maintain the offset distance behind the player after rotation
        Vector3 desiredPosition = player.position + player.TransformDirection(offset);
        transform.position = desiredPosition;

        // Make the camera look at the player
        transform.LookAt(player.position + Vector3.up * 1.5f); // Adjust look height as needed
    }
}

