using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector3 targetPosition;
    private bool isMoving = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0f;

            isMoving = true;
        }

        if (isMoving)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, targetPosition, step);

            // Check if we have reached close enough to the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                // Snap to the target position
                transform.position = targetPosition;

                // Stop moving
                isMoving = false;
            }
        }
    }
}