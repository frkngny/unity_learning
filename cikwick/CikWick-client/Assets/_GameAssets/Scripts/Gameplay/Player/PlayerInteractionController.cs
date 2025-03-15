using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.TryGetComponent<ICollectible>(out var collectible))
        {
            collectible.Collect();
        }
    }
}
