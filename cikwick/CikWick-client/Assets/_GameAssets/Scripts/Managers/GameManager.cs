using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public event Action<GameState> OnGameStateChanged;
    
    [Header("References")]
    [SerializeField] private EggCounterUI _eggCounterUI;
    [SerializeField] private WinLoseUI _winLoseUI;

    [Header("Settings")]
    [SerializeField] private int _maxEggCount = 5;
    [SerializeField] private float _gameEndDelay = 2f;

    private int _currentEggCount;
    private GameState _currentGameState;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        HealthManager.Instance.OnPlayerDied += HealthManager_OnPlayerDied;
    }

    private void OnEnable()
    {
        ChangeGameState(GameState.Play);
    }

    public void OnEggCollected()
    {
        _currentEggCount++;
        _eggCounterUI.SetEggCounterText(_currentEggCount, _maxEggCount);
        if (_currentEggCount == _maxEggCount)
        {
            _eggCounterUI.SetEggCompleted();
            ChangeGameState(GameState.GameOver);
            _winLoseUI.OnGameWin();
        }
    }

    private void HealthManager_OnPlayerDied()
    {
        if (_currentGameState == GameState.Play)
        {
            StartCoroutine(WaitForGameOver());
        }
    }

    private IEnumerator WaitForGameOver()
    {
        yield return new WaitForSeconds(_gameEndDelay);
        ChangeGameState(GameState.GameOver);
        _winLoseUI.OnGameLose();
    }

    public void ChangeGameState(GameState gameState)
    {
        OnGameStateChanged?.Invoke(gameState);
        _currentGameState = gameState;
    }

    public GameState GetCurrentGameState()
    {
        return _currentGameState;
    }
}
