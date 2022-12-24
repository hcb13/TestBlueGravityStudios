using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonOptionNPC : MonoBehaviour, IButtonOptionNPC
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private GameObject _arrow1;
    [SerializeField]
    private GameObject _arrow2;

    private void Awake()
    {
        _arrow1.SetActive(false);
        _arrow2.SetActive(false);

        _button.onClick.AddListener(SelectOption);        
    }

    public virtual void SelectOption()
    {

    }

}
