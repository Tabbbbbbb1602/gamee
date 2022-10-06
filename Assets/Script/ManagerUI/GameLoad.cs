using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoad : MonoBehaviour
{
    public GameObject menuPause;
    public GameObject mainMenu;

    public void setActice()
    {
        mainMenu.SetActive(false);  
    }
    public void Show(bool isShow)
    {
        menuPause.SetActive(isShow);
        Time.timeScale = 0;
    }
}