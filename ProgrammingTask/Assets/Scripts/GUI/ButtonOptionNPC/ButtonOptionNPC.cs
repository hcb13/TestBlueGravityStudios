using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonOptionNPC : MonoBehaviour, IButtonOptionNPC
{
    [SerializeField]
    protected Button _button;
    [SerializeField]
    private GameObject _arrow1;
    [SerializeField]
    private GameObject _arrow2;

    private void Awake()
    {
        _arrow1.SetActive(false);
        _arrow2.SetActive(false);

               
    }

    public virtual void SelectOption()
    {

    }

}
