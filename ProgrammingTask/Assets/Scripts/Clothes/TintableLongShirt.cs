using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class TintableLongShirt : ITintableCloth
{
    public Sprite leftUpperArm;
    public Sprite leftLowerArm;

    public Sprite rightUpperArm;
    public Sprite rightLowerArm;

    public Sprite chest;
    public Sprite body;

    public Color clothColor;

    public override void AddCloth(GameObject _player)
    {
        _player.GetComponent<FemaleCharacterSetup>().leftUpperArmEquipment = leftUpperArm;
        _player.GetComponent<FemaleCharacterSetup>().leftUpperArmEquipmentColor = clothColor;
        _player.GetComponent<FemaleCharacterSetup>().leftLowerArmEquipment = leftLowerArm;
        _player.GetComponent<FemaleCharacterSetup>().leftLowerArmEquipmentColor = clothColor;

        _player.GetComponent<FemaleCharacterSetup>().rightUpperArmEquipment = rightUpperArm;
        _player.GetComponent<FemaleCharacterSetup>().rightUpperArmEquipmentColor = clothColor;
        _player.GetComponent<FemaleCharacterSetup>().rightLowerArmEquipment = rightLowerArm;
        _player.GetComponent<FemaleCharacterSetup>().rightLowerArmEquipmentColor = clothColor;

        _player.GetComponent<FemaleCharacterSetup>().chestEquipment = chest;
        _player.GetComponent<FemaleCharacterSetup>().chestEquipmentColor = clothColor;
        _player.GetComponent<FemaleCharacterSetup>().bodyEquipment = body;
        _player.GetComponent<FemaleCharacterSetup>().bodyEquipmentColor = clothColor;

        _player.GetComponent<FemaleCharacterSetup>().UpdateSprites(false);
    }
}
