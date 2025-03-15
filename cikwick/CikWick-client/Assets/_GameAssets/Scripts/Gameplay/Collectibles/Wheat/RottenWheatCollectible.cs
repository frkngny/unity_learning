using UnityEngine;

public class RottenWheatCollectible : MonoBehaviour, ICollectible
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float movementSpeedDecrease;
    [SerializeField] private float resetBoostDuration;

    public void Collect()
    {
        playerController.SetMovementSpeed(movementSpeedDecrease, resetBoostDuration);
        Destroy(gameObject);
    }
}
