using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _instance;

    public static GameAssets Instance
    {
        get
        {
            if( _instance == null)
            {
                _instance = (Instantiate(Resources.Load("Prefabs/Game/GameAssets")) as GameObject).GetComponent<GameAssets>();
            }
            return _instance;
        }
    }

    public TintableLongShirt longShirt;
    public TintablePants pants;
    public TintableShoes shoes;
}
