using UnityEngine;

public class LeverSwitch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ITrain train = other.GetComponent<ITrain>();

        if (train != null)
        {
            train.Train(true); // Activate the train
            Debug.Log("Train has entered the lever switch area!");
        }
    }

    private void Update()
    {
        
    }
}
