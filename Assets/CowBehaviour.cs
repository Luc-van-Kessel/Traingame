using UnityEngine;

public class CowBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ITrain train = other.GetComponent<ITrain>();

        if (train != null)
        {

        }
    }
}
