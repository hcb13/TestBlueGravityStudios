using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOptionCloth : MonoBehaviour
{

    [SerializeField]
    private int _price;

    [SerializeField]
    private ITintableCloth _cloth;

    [SerializeField]
    private GameObject _player;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(GetCloth);
    }

    private void GetCloth()
    {
        _cloth.AddCloth(_player);
    }

}
