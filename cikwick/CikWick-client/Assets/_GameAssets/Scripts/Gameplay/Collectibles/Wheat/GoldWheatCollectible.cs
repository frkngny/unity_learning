using UnityEngine;

public class GoldWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float movementSpeedIncrease;
    [SerializeField] private float resetBoostDuration;

    public void Collect()
    {
        playerController.SetMovementSpeed(movementSpeedIncrease, resetBoostDuration);
        Destroy(gameObject);
    }
}
