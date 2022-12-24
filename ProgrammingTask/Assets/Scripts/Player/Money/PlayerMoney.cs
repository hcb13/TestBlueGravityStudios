using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField]
    private int money;
    [SerializeField]
    private TextMeshProUGUI textMoney;

    public Action<bool> OnBuySuccess = delegate { };
    public Action<bool> OnSellSuccess = delegate { };

    private void Awake()
    {
        textMoney.text = money.ToString();
    }

    public void Buy(int price, bool isBuying)
    {
        if( money >= price && isBuying)
        {
            money -= price;
            textMoney.text = money.ToString();
            OnBuySuccess?.Invoke(true);
        }
        else
        {
            OnBuySuccess?.Invoke(false);
        }
    }

    public void Sell(int price, bool isSelling)
    {
        if (isSelling)
        {
            money += price;
            textMoney.text = money.ToString();
            OnSellSuccess?.Invoke(true);
        }
    }
}
