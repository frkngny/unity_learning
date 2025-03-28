using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _blackBackgroundObject;
    [SerializeField] private GameObject _winPopup;
    [SerializeField] private GameObject _losePopup;

    [Header("Buttons")]
    [SerializeField] private Button _retryButton;
    [SerializeField] private Button _mainMenuButton;

    [Header("Settings")]
    [SerializeField] private float _scaleDuration = 0.3f;
    
    private Image _blackBackgroundImage;

    private void Awake()
    {
        _blackBackgroundImage = _blackBackgroundObject.GetComponent<Image>();
        _winPopup.transform.localScale = Vector3.zero;
        _losePopup.transform.localScale = Vector3.zero;
    }

    public void OnGameWin()
    {
        GameManager.Instance.ChangeGameState(GameState.Pause);

        _blackBackgroundObject.SetActive(true);
        _winPopup.SetActive(true);

        _blackBackgroundImage.DOFade(0.8f, _scaleDuration).SetEase(Ease.Linear);
        _winPopup.transform.DOScale(1.5f, _scaleDuration).SetEase(Ease.OutBack);
    }

    public void OnGameLose()
    {
        GameManager.Instance.ChangeGameState(GameState.Pause);

        _blackBackgroundObject.SetActive(true);
        _losePopup.SetActive(true);

        _blackBackgroundImage.DOFade(0.8f, _scaleDuration).SetEase(Ease.Linear);
        _losePopup.transform.DOScale(1.5f, _scaleDuration).SetEase(Ease.OutBack);
    }
}
