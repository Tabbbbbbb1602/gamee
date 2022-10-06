using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance;
    public GameState State;

    public event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.mainMenu);
        UpdateGameState(GameState.gameLoad);
        UpdateGameState(GameState.settings);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.mainMenu:
                showMainMenu();
                break;
            case GameState.gameLoad:
                showGameLoad();
                break;
            case GameState.game:
                break;
            case GameState.settings:
                StateSettings();
                break;
            case GameState.lose:
                break;
            case GameState.victory:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        OnGameStateChanged?.Invoke(newState);
    }

    private void StateSettings()
    {
        
    }

    private void showGameLoad()
    {
        
    }

    private void showMainMenu()
    {
        
    }
}

public enum GameState{
    mainMenu,
    gameLoad,
    game,
    settings,
    lose,
    victory
}
