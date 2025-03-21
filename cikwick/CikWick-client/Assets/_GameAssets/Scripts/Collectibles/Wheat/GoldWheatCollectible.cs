using UnityEngine;
using UnityEngine.UI;

public class GoldWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private WheatDesignSO wheatDesignSO;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private PlayerStateUI _playerStateUI;

    private RectTransform _playerBoosterTransform;
    private Image _playerBoosterImage;

    private void Awake()
    {
        _playerBoosterTransform = _playerStateUI.GetBoosterSpeedTransform;
        _playerBoosterImage = _playerBoosterTransform.GetComponent<Image>();
    }

    public void Collect()
    {
        playerController.SetMovementSpeed(wheatDesignSO.IncreaseDecreaseMultiplier, wheatDesignSO.ResetBoostDuration);
        _playerStateUI.PlayBoosterUIAnimations(_playerBoosterTransform, _playerBoosterImage,
            _playerStateUI.GetGoldBoosterWheatImage, wheatDesignSO.ActiveSprite, wheatDesignSO.PassiveSprite,
            wheatDesignSO.ActiveWheatSprite, wheatDesignSO.PassiveWheatSprite, wheatDesignSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
