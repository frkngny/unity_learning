using UnityEngine;

public class HolyWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private WheatDesignSO wheatDesignSO;
    [SerializeField] private PlayerController playerController;

    public void Collect()
    {
        playerController.SetJumpForce(wheatDesignSO.IncreaseDecreaseMultiplier, wheatDesignSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
