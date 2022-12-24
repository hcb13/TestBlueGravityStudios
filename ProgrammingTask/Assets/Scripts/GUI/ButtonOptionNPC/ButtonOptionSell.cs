using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOptionSell : ButtonOptionNPC
{
    public Action<bool> OnSell = delegate { };

    private void Start()
    {
        _button.onClick.AddListener(SelectOption);
    }

    public override void SelectOption()
    {
        OnSell?.Invoke(true);
    }

}
