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

    private void Awake()
    {
        textMoney.text = money.ToString();
    }
}
