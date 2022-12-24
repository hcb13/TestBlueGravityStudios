using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOptionBuy : ButtonOptionNPC
{
    public Action<bool> OnBuy = delegate { };

    private void Start()
    {
        _button.onClick.AddListener(SelectOption);
    }

    public override void SelectOption()
    {
        OnBuy?.Invoke(true);
    }

}
