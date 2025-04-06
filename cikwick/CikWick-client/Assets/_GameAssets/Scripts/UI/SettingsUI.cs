using System;
using DG.Tweening;
using MaskTransitions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _settingsPopupObject;
    [SerializeField] private GameObject _blackBackgroundObject;

    [Header("Buttons")]
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _musicButton;
    [SerializeField] private Button _soundButton;
    [SerializeField] private Button _resumeButton;
    [SerializeField] private Button _mainMenuButton;

    [Header("Settings")]
    [SerializeField] private float _scaleDuration;

    private Image _blackBackgroundImage;

    private void Awake()
    {
        _blackBackgroundImage = _blackBackgroundObject.GetComponent<Image>();
        _settingsPopupObject.transform.localScale = Vector3.zero;

        _settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        _resumeButton.onClick.AddListener(OnResumeButtonClicked);
        _mainMenuButton.onClick.AddListener(OnMainMenuButtonClicked);
    }

    private void OnMainMenuButtonClicked()
    {
        TransitionManager.Instance.LoadLevel(Consts.Scenes.MENU);
    }

    private void OnSettingsButtonClicked()
    {
        GameManager.Instance.ChangeGameState(GameState.Pause);

        _blackBackgroundObject.SetActive(true);
        _settingsPopupObject.SetActive(true);

        _blackBackgroundImage.DOFade(0.8f, _scaleDuration).SetEase(Ease.Linear);
        _settingsPopupObject.transform.DOScale(1f, _scaleDuration).SetEase(Ease.OutBack);
    }

    private void OnResumeButtonClicked()
    {
        _blackBackgroundImage.DOFade(0f, _scaleDuration).SetEase(Ease.Linear);
        _settingsPopupObject.transform.DOScale(0f, _scaleDuration).SetEase(Ease.OutExpo)
            .OnComplete(() => {
                GameManager.Instance.ChangeGameState(GameState.Resume);
                _blackBackgroundObject.SetActive(false);
                _settingsPopupObject.SetActive(false);
            });
    }
}
