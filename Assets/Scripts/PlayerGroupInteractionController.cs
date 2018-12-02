using System.Linq;

using UnityEngine;

public class PlayerGroupInteractionController : MonoBehaviour
{
    public GameObject SurvivorGroup;
    public float survivorPickupRadius = 2f;

    private void OnGUI()
    {
        if(Event.current.Equals(Event.KeyboardEvent("e")))
        {
            var nearby = from survivor in GameObject.FindGameObjectsWithTag("survivor")
                         where survivor.transform.parent != SurvivorGroup.transform &&
                         Vector3.Distance(survivor.transform.position, this.transform.position) <= survivorPickupRadius
                         select survivor.GetComponent<SurvivorFollowController>();

            nearby.ToList().ForEach(AddToSurvivorGroup);
        }

        if (Event.current.Equals(Event.KeyboardEvent("q")))
        {
            var nearby = from survivor in GameObject.FindGameObjectsWithTag("survivor")
                         where survivor.transform.parent == SurvivorGroup.transform &&
                         Vector3.Distance(survivor.transform.position, this.transform.position) <= survivorPickupRadius
                         select survivor.GetComponent<SurvivorFollowController>();

            nearby.ToList().ForEach(RemoveFromSurvivorGroup);
        }
    }

    private void AddToSurvivorGroup(SurvivorFollowController survivorComponent)
    {
        survivorComponent.transform.SetParent(SurvivorGroup.transform);
        survivorComponent.isInSurvivorGroup = true;
    }

    private void RemoveFromSurvivorGroup(SurvivorFollowController survivorComponent)
    {
        survivorComponent.transform.SetParent(SurvivorGroup.transform.parent);
        survivorComponent.isInSurvivorGroup = false;
    }
}
