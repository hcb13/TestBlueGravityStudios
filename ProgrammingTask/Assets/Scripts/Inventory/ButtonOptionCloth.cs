using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ButtonOptionCloth : MonoBehaviour
{

    [SerializeField]
    private int _price = 10;

    [SerializeField]
    private TextMeshProUGUI _textPrice;

    [SerializeField]
    private Button _button;

    [SerializeField]
    private GameObject _imageLocked;

    [SerializeField]
    private GameObject _imageUnlocked;

    [SerializeField]
    private bool _isLocked = true;

    [SerializeField]
    private ITintableCloth _cloth;

    [SerializeField]
    private GameObject _player;

    [SerializeField]
    private GameObject _panelMoney;

    [SerializeField]
    private ButtonOptionBuy _optionBuy;

    [SerializeField]
    private ButtonOptionSell _optionSell;

    [SerializeField]
    private GameObject _inventory;


    
    private bool _isBuying;
    private bool IsBuying
    {
        set
        {
            _isBuying = value;
        }
        get
        {
            return _isBuying;
        }
    }
    private bool _isSelling;
    private bool _isSelected;

    public Action<int, bool> OnTryBuy = delegate { };
    public Action<int, bool> OnSell = delegate { };



    private void Awake()
    {
        _textPrice.text = _price.ToString();
        UpdateLocked();

        _isSelected = false;
        IsBuying = false;
        _isSelling = false;

        _button.onClick.AddListener(TryBuying);
        _button.onClick.AddListener(Sell);
       
        _panelMoney.GetComponent<PlayerMoney>().OnBuySuccess += SuccessBuying;
        _panelMoney.GetComponent<PlayerMoney>().OnSellSuccess += SuccessSelling;

        _optionBuy.OnBuy += UpdateIsBuying;
        _optionSell.OnSell += UpdateSelling;
    }

    private void UpdateLocked()
    {
        _imageLocked.SetActive(_isLocked);
        _imageUnlocked.SetActive(!_isLocked);        
    }

    private void UpdateIsBuying(bool isBuying)
    {
        IsBuying = isBuying;
    }

    private void TryBuying()
    {
        _isSelected = true;
        if(_isBuying && _isLocked )
        {
            _panelMoney.GetComponent<PlayerMoney>().Buy(_price, _isBuying);
            _isBuying = false;            
        }
        else
        {
            
            if (!_isLocked)
            {
                GetCloth();
            }
        }
    }

    private void SuccessBuying(bool isSuccess)
    {
        if (isSuccess && _isSelected)
        {
            GetCloth();
        }
    }

    private void UpdateSelling(bool isSelling)
    {
        _isSelling = true;
    }

    private void Sell()
    {
        _isSelected = true;
        
        if (_isSelling && !_isLocked)
        {
            _panelMoney.GetComponent<PlayerMoney>().Sell(_price, _isSelling);
            _isSelling = false;            
        }
    }

    private void SuccessSelling(bool isSuccess)
    {
        _inventory.SetActive(false);
    }

    private void GetCloth()
    {
        _isLocked = false;
        UpdateLocked();

        _cloth.AddCloth(_player);
        
        _isSelected = false;

        _inventory.SetActive(false);
    }

}
