using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePopup : MonoBehaviour
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
        SceneManager.LoadScene(Consts.Scenes.GAME);
        // GameManager.Instance.ChangeGameState(GameState.Resume);
        // GameManager.Instance.RestartGame();
    }

    private void OnMainMenuButtonClicked()
    {
        SceneManager.LoadScene(Consts.Scenes.MENU);
        // GameManager.Instance.ChangeGameState(GameState.Resume);
        // GameManager.Instance.LoadMainMenu();
    }
}
