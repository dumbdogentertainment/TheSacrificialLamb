using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    public float playerSpeed;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));
    }

    private void Move(float horizontalMovement, float verticalMovement)
    {
        Vector3 desiredMovement = new Vector3(horizontalMovement, 0f, verticalMovement).normalized * playerSpeed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + desiredMovement);
    }
}