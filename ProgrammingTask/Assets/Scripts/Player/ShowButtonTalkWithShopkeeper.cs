using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButtonTalkWithShopkeeper : MonoBehaviour
{
    [SerializeField]
    private GameObject _button;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            _button.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            _button.SetActive(false);
        }
    }
}
