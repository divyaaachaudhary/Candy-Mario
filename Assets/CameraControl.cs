using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;        // Player's transform to follow
    public Vector3 offset;          // Offset from the player
    public float smoothSpeed = 0.125f;  // Smoothness of the camera movement

    void LateUpdate()
    {
        if (player == null) return;

        // Desired position of the camera
        Vector3 desiredPosition = player.position + offset;

        // Smoothly interpolate between current and desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Apply the smoothed position to the camera
        transform.position = smoothedPosition;

        // Optionally, keep the camera looking at the player
        // transform.LookAt(player);
    }
}
