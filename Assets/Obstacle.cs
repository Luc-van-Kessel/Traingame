using UnityEngine;

public class Obstacle : MonoBehaviour, IDamageable
{
    [SerializeField] public int health = 1;

    private void OnTriggerEnter(Collider other)
    {
            IDamageable damageable = other.GetComponent<IDamageable>();

            if (damageable != null)
            {
                damageable.TakeDamage(1); // damage amount
                Debug.Log("Hit something damageable!");
            }
            // Add damage or stop game
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}