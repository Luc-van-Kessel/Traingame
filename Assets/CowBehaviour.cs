using UnityEngine;

public class CowBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ITrain train = other.GetComponent<ITrain>();

        if (train != null)
        {
            // move sideways
            Vector3 moveDirection = Vector3.right; // Move to the right
            float moveDistance = 5f; // Distance to move

            // Move the cow to the side
            transform.position += moveDirection * moveDistance;

        }
    }
}
