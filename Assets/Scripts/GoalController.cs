using UnityEngine;

public class GoalController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.tag == "survivor")
        {
            Destroy(other.gameObject, 1.5f);
            GameManager.Instance.IncrementScore();
        }
    }
}
