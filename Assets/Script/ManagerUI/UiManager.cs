using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : Singleton<UIManager>
{
    public UnityEvent OnVictory;
    public UnityEvent OnLose;
    public UnityEvent OnChangeTextCoins;
    // Start is called before the first frame update
    
    //phat su kien win game
     public void winGame()
    {
        OnVictory?.Invoke();
    }

    //phat su kien lose game
    public void loseGame()
    {
        OnLose?.Invoke();
    }

    public void changeTextCoins()
    {
        OnChangeTextCoins?.Invoke();
    }

}
