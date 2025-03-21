using UnityEngine;
using UnityEngine.UI;

public class HolyWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private WheatDesignSO wheatDesignSO;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private PlayerStateUI _playerStateUI;

    private RectTransform _playerBoosterTransform;
    private Image _playerBoosterImage;

    private void Awake()
    {
        _playerBoosterTransform = _playerStateUI.GetBoosterJumpTransform;
        _playerBoosterImage = _playerBoosterTransform.GetComponent<Image>();
    }
    
    public void Collect()
    {
        playerController.SetJumpForce(wheatDesignSO.IncreaseDecreaseMultiplier, wheatDesignSO.ResetBoostDuration);
        _playerStateUI.PlayBoosterUIAnimations(_playerBoosterTransform, _playerBoosterImage,
            _playerStateUI.GetHolyBoosterWheatImage, wheatDesignSO.ActiveSprite, wheatDesignSO.PassiveSprite,
            wheatDesignSO.ActiveWheatSprite, wheatDesignSO.PassiveWheatSprite, wheatDesignSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
