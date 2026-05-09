using UnityEngine;

public class TrainHealth : MonoBehaviour, IDamageable
{
    public int Health = 2;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IDamageable damageable = other.GetComponent<IDamageable>();
        if (damageable != null)
        {
            damageable.TakeDamage(1); // damage amount
            Debug.Log("Train hit something damageable!");
        }
    }

    void Die()
    {
        Debug.Log("Train has been destroyed!");
        Destroy(gameObject);

    }
}
