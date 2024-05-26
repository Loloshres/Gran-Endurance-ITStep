using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    public static int money;

    public static void SaveMoney()
    {
        PlayerPrefs.SetInt("Money", money);
    }

    public static void LoadMoney()
    {
        money = PlayerPrefs.GetInt("Money", 0);
    }
}