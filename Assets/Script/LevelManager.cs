using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<GameManager>
{
    Player m_player;
    private void Awake()
    {
        Debug.Log(Pref.Coins);
        Debug.Log(Pref.CurPlayerId);
        Debug.Log(m_player);
        MakeSingleton(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        ActivePlayer();
    }

    // Update is called once per frame
    public void ActivePlayer()
    {
        if (m_player)
            Destroy(m_player.gameObject);

        var newPlayerPrefab = ShopManager.Ins.items[Pref.CurPlayerId].playerPb;

        if (newPlayerPrefab)
        {
            m_player = Instantiate(newPlayerPrefab, new Vector3(-0.4f, 3.5f, 60.0f), Quaternion.Euler(new Vector3(0.0f, 210.0f, 0.0f)));
        }

    }
}
