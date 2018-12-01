using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject followTarget;
    public Vector3 targetOffset;
    public float movementDamping = 2f;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            followTarget.transform.position + targetOffset,
            Time.deltaTime * movementDamping);
    }
}
