using UnityEngine;

public class TrainController : MonoBehaviour
{
  [SerializeField] public float speed;
  [SerializeField] public float acceleration;
   [SerializeField] public float maxSpeed = 20;


    void Start()
    {

    }

    void Update()
    {
        if (acceleration > 0)
        {
            speed += acceleration * Time.deltaTime;
            if (speed >= maxSpeed)
            {
                speed = maxSpeed;
                acceleration = 0;
            }
        }
        else if (acceleration < 0)
        {
            speed += acceleration * Time.deltaTime;
            if (speed < 0)
            {
                speed = 0;
            }


        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    public void DecreaseSpeed(float amount)
    {
        speed -= amount;
        speed = Mathf.Clamp(speed, 0, maxSpeed);
    }
}
