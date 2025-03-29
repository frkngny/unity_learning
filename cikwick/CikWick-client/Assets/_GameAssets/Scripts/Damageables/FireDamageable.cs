using UnityEngine;

public class FireDamageable : MonoBehaviour, IDamageable
{
    [SerializeField] private float _force = 10f; // Amount of damage to apply

    public void GiveDamage(Rigidbody playerRigidbody, Transform playerVisualTransform)
    {
        HealthManager.Instance.Damage(1); // Call the Damage method from HealthManager
        playerRigidbody.AddForce(-playerVisualTransform.forward * _force, ForceMode.Impulse); // Apply force to the player
        Destroy(gameObject); // Destroy the fire object
    }
    
}
