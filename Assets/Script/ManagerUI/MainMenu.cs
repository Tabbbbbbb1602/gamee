using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;

    private void Awake()
    {
        /*UiManager.Instance.OnGameStateChanged += showMainMenu;*/
    }

    private void showMainMenu(GameState obj)
    {
        gameObject.SetActive(true);
    }

    public void ShowSettings(GameObject setting)
    {
        setting.SetActive(true);
        gameObject.SetActive(false);
    }

    public void HideSettings(GameObject setting)
    {
        setting.SetActive(false);
        gameObject.SetActive(true);
    }

    public void ShowShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
