using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject gameSettings;

    private void Awake()
    {
    }

    private void showSettings(GameState obj)
    {
        gameObject.SetActive(true);
    }
}
