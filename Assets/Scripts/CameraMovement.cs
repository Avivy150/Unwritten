using UnityEngine;

public class CameraMovement : MonoBehaviour
{
 // Camera lag while following makes the movement appear more smooth and not jerky
    public float smoothing = 1.5f;
    public float offset = -30f;

    // Target of the camera
    private Transform target;
    // Distance between camera and player
    private Vector3 dist;

    private GameObject playerCharacter;
    private bool canMove = true;

    // Called every physics step
    void FixedUpdate()
    {
        if (canMove)
        {
            if (playerCharacter == null)
            {
                playerCharacter = GameObject.FindGameObjectWithTag("Player");
                target = playerCharacter.transform;
                // Set the offset
                dist = transform.position - target.position;
            }
            
            // The position of the camera is the relative position of the camera from the player.
            Vector3 targetCameraPostion = target.position + dist + new Vector3(0f, 0f, offset);
            
            // Lerp the camera's position between it's current position and it's new position.
            transform.position = Vector3.Lerp(transform.position, targetCameraPostion, smoothing * Time.deltaTime);
        }
    }

    public void SetTarget(Transform targetObject)
    {
        target = targetObject;
    }

    public void SetCanMove(bool stopCameraMovement)
    {
        canMove = stopCameraMovement;
    }
}
