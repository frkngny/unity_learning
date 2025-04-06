using MaskTransitions;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinPopup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TimerUI _timerUI;
    [SerializeField] private Button _retryButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private TMP_Text _timerText;

    private void OnEnable()
    {
        _timerText.text = _timerUI.FinalTime;

        _retryButton.onClick.AddListener(OnRetryButtonClicked);
        _mainMenuButton.onClick.AddListener(OnMainMenuButtonClicked);
    }

    private void OnRetryButtonClicked()
    {
        TransitionManager.Instance.LoadLevel(Consts.Scenes.GAME);
    }

    private void OnMainMenuButtonClicked()
    {
        TransitionManager.Instance.LoadLevel(Consts.Scenes.MENU);
    }
}
