using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameLoad;
    public GameObject game;

    public void MainMenu()
    {
        mainMenu.SetActive(true);
        gameLoad.SetActive(false);
        game.SetActive(false);
        Time.timeScale = 0;
    }
}
