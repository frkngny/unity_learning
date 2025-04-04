using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControllerUI : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _quitButton;

    private void Awake()
    {
        _playButton.onClick.AddListener(OnPlayButtonClicked);
        _quitButton.onClick.AddListener(OnQuitButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        // Load the game scene
        SceneManager.LoadScene(Consts.Scenes.GAME);
    }

    private void OnQuitButtonClicked()
    {
        // Quit the application
        Application.Quit();
    }
       
}
