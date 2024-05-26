using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CarInventory
{
    private static List<string> cars = new List<string>();

    public static void AddCar(string carName)
    {
        cars.Add(carName);
        SaveCars();
    }

    public static List<string> GetCars()
    {
        LoadCars();
        return cars;
    }

    private static void SaveCars()
    {
        PlayerPrefs.SetInt("CarCount", cars.Count);
        for (int i = 0; i < cars.Count; i++)
        {
            PlayerPrefs.SetString("Car_" + i, cars[i]);
        }
    }

    private static void LoadCars()
    {
        cars.Clear();
        int carCount = PlayerPrefs.GetInt("CarCount", 0);
        for (int i = 0; i < carCount; i++)
        {
            cars.Add(PlayerPrefs.GetString("Car_" + i));
        }
    }
}
