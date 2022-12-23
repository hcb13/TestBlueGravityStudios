using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInitClothes : MonoBehaviour
{
    private void Awake()
    {

        GameAssets.Instance.longShirt.AddCloth(gameObject);
        GameAssets.Instance.pants.AddCloth(gameObject);
        GameAssets.Instance.shoes.AddCloth(gameObject);

    }
}
