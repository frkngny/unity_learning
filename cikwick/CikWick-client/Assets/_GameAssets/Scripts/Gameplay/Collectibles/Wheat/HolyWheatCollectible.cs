using UnityEngine;

public class HolyWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float jumpForceIncrease;
    [SerializeField] private float resetBoostDuration;

    public void Collect()
    {
        playerController.SetJumpForce(jumpForceIncrease, resetBoostDuration);
        Destroy(gameObject);
    }
}
