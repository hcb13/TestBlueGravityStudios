using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintablePants : ITintableCloth
{
    public Sprite hips;

    public Sprite leftLowerLeg;
    public Sprite leftUpperLeg;

    public Sprite rightLowerLeg;
    public Sprite rightUpperLeg;

    public Color clothColor;

    public override void AddCloth(GameObject _player)
    {
        _player.GetComponent<FemaleCharacterSetup>().hipEquipment = hips;
        _player.GetComponent<FemaleCharacterSetup>().hipEquipmentColor = clothColor;

        _player.GetComponent<FemaleCharacterSetup>().leftLowerLegEquipment = leftLowerLeg;
        _player.GetComponent<FemaleCharacterSetup>().leftLowerLegEquipmentColor = clothColor;
        _player.GetComponent<FemaleCharacterSetup>().leftUpperLegEquipment = leftUpperLeg;
        _player.GetComponent<FemaleCharacterSetup>().leftUpperLegEquipmentColor = clothColor;

        _player.GetComponent<FemaleCharacterSetup>().rightLowerLegEquipment = rightLowerLeg;
        _player.GetComponent<FemaleCharacterSetup>().rightLowerLegEquipmentColor = clothColor;
        _player.GetComponent<FemaleCharacterSetup>().rightUpperLegEquipment = rightUpperLeg;
        _player.GetComponent<FemaleCharacterSetup>().rightUpperLegEquipmentColor = clothColor;

        _player.GetComponent<FemaleCharacterSetup>().UpdateSprites(false);
    }
}
