using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class TintableShoes :  ITintableCloth
{
    public Sprite leftFoot;
    public Sprite rightFoot;

    public override void AddCloth(GameObject _player)
    {
        _player.GetComponent<FemaleCharacterSetup>().leftFootEquipment = leftFoot;
        _player.GetComponent<FemaleCharacterSetup>().rightFootEquipment = rightFoot;

        _player.GetComponent<FemaleCharacterSetup>().UpdateSprites(false);
    }
}
