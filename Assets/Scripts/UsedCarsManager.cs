using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsedCarsManager : MonoBehaviour
{
    public GameObject confirmPanel;
    public Text carNameText;
    public Text carPriceText;
    private int carPrice;
    private string carName;

    public void OnCarButtonClicked(string name, int price)
    {
        carName = name;
        carPrice = price;
        carNameText.text = name;
        carPriceText.text = price.ToString();
        confirmPanel.SetActive(true);
    }

    public void OnConfirmPurchase()
    {
        if (GameData.money >= carPrice)
        {
            GameData.money -= carPrice;
            GameData.SaveMoney();
            CarInventory.AddCar(carName);
            confirmPanel.SetActive(false);
        }
        else
        {
            Debug.Log("Not enough money!");
        }
    }

    public void OnCancelPurchase()
    {
        confirmPanel.SetActive(false);
    }
}
