using UnityEngine;

public class TrainLaneSwitch : MonoBehaviour, ITrain
{
    public int currentLane = 0;
    public float laneDistance = 4f;
    public float switchSpeed = 5f;

    private Vector3 targetPosition;

    private bool canSwitch = false; // 🔥 important

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        HandleInput();
        MoveToLane();
    }

    void HandleInput()
    {
        if (!canSwitch) return; // ❌ block input if not allowed

        if (Input.GetKeyDown(KeyCode.D))
        {
            SwitchRight();
            canSwitch = false; // only once per switch zone
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SwitchLeft();
            canSwitch = false;
        }
    }

    void SwitchRight()
    {
        if (currentLane < 1)
        {
            currentLane++;
        }
    }

    void SwitchLeft()
    {
        if (currentLane > 0)
        {
            currentLane--;
        }
    }

    void MoveToLane()
    {
        targetPosition = new Vector3(currentLane * laneDistance, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, switchSpeed * Time.deltaTime);
    }

    // 🔥 THIS IS CALLED BY YOUR LEVER / SWITCH
    public void EnableSwitch()
    {
        canSwitch = true;
        Debug.Log("Switch enabled!");
    }

    public void Train(bool state)
    {
        if (state)
        {
            EnableSwitch();
        }
    }
}