using UnityEngine;

public class SurvivorFollowController : MonoBehaviour
{
    public GameObject goalTarget;

    public bool isInSurvivorGroup = false;

    private float survivorSpeed = 0f;

    private void Start()
    {
        survivorSpeed = Random.Range(2.5f, 4.5f);
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            goalTarget.transform.position,
            Time.deltaTime * (isInSurvivorGroup ? survivorSpeed : 0f));
    }
}
