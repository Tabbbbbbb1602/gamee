using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameLoad;
    public GameObject game;
    public GameObject settings;
    public GameObject winGame;
    public GameObject loseGameObj;
    public GameObject textCoins;

    private TouchInput inputs;

    public Text coinCountingText;


    public void Awake()
    {
        mainMenu.SetActive(true);
        game.SetActive(false);
        gameLoad.SetActive(false);
        settings.SetActive(false);
        inputs = new TouchInput();
    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.touch.touchpos.performed += StartThrow;
        UIManager.Ins.OnVictory.AddListener(victoryGame);
        UIManager.Ins.OnLose.AddListener(loseGames);
        UIManager.Ins.OnChangeTextCoins.AddListener(changeTextCoins);
    }

    private void StartThrow(InputAction.CallbackContext obj)
    {
        mainMenu.SetActive(false);
        gameLoad.SetActive(true);
    }

    private void OnDisable()
    {
        inputs.touch.touchpos.performed -= StartThrow;
        inputs.Disable();
    }

    public void showShop()
    {
        SceneManager.LoadScene("ShopMain");
    }

    public void showSetting()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
        Time.timeScale = 0;
    }

    public void closeSettings()
    {
        settings.SetActive(false);
        mainMenu.SetActive(true);
        Time.timeScale = 1;
    }

    public void showPauseGame()
    {
        game.SetActive(true);
        mainMenu.SetActive(false);
        Time.timeScale = 0;
    }

    public void showMainMenu()
    {
        //UIManager.Ins.changeTextCoins();
        mainMenu.SetActive(true);
        game.SetActive(false);
        gameLoad.SetActive(false);
        Time.timeScale = 1;
    }

    public void resume()
    {
        game.SetActive(false);
        gameLoad.SetActive(true);
        Time.timeScale = 1;
    }

    public void arena()
    {

    }


    public void loseGameUI()
    {

    }

    public void loseGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //thay doi bang lang nghe event
    public void victoryGame()
    {
        winGame.SetActive(true);
        gameLoad.SetActive(false);
    }

    public void loseGames()
    {
        loseGameObj.SetActive(true);
        gameLoad.SetActive(false);
    }

    public void changeTextCoins()
    {
        Debug.Log("abc");
        Pref.Coins += 1;
        if (coinCountingText)
            coinCountingText.text = "" + Pref.Coins;
    }

}
