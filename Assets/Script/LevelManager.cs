using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    Player m_player;

    public override void Awake()
    {
        MakeSingleton(false);
    }
    public override void Start()
    {
        base.Start();

        if (!PlayerPrefs.HasKey(PrefConst.COIN_KEY))
            Pref.Coins = 10000;

        ActivePlayer();
        GUIManager.Ins.UpdateCoins();
    }

    public void ActivePlayer()
    {
        if (m_player)
            Destroy(m_player.gameObject);

        var newPlayerPrefab = ShopManager.Ins.items[Pref.CurPlayerId].playerPb;



        if (newPlayerPrefab)
        {
            m_player = Instantiate(newPlayerPrefab, new Vector3(1.0f, -0.5f, -25f), Quaternion.identity);
            m_player.transform.localScale = new Vector3(2, 2, 2);
        }

    }
}
