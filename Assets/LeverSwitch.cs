using UnityEngine;

public class LeverSwitch : MonoBehaviour
{

    public GameObject SwitchIndicator;
    private void OnTriggerEnter(Collider other)
    {
        ITrain train = other.GetComponent<ITrain>();
        SwitchIndicator.SetActive(true); // Hide the switch indicator

        if (train != null)
        {
            train.Train(true); // Activate the train
            Debug.Log("Train has entered the lever switch area!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        SwitchIndicator.SetActive(false); // Hide the switch indicator
    }

}
