using UnityEngine;

public class TrainBrake : MonoBehaviour
{
    public TrainController movement;
    public float brakePower = 2f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Brake();
        }
    }

    void Brake()
    {
        movement.DecreaseSpeed(brakePower);
    }
}