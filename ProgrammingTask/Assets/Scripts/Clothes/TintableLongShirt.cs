using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class TintableLongShirt : MonoBehaviour, ITintableCloth
{
    public Sprite leftUpperArm;
    public Sprite leftLowerArm;

    public Sprite rightUpperArm;
    public Sprite rightLowerArm;

    public Sprite chest;
    public Sprite body;

    public void AddCloth(GameObject _player)
    {
        _player.GetComponent<FemaleCharacterSetup>().leftUpperArmEquipment = leftUpperArm;
        _player.GetComponent<FemaleCharacterSetup>().leftLowerArmEquipment = leftLowerArm;

        _player.GetComponent<FemaleCharacterSetup>().rightUpperArmEquipment = rightUpperArm;
        _player.GetComponent<FemaleCharacterSetup>().rightLowerArmEquipment = rightLowerArm;

        _player.GetComponent<FemaleCharacterSetup>().chestEquipment = chest;
        _player.GetComponent<FemaleCharacterSetup>().bodyEquipment = body;

        _player.GetComponent<FemaleCharacterSetup>().UpdateSprites(false);
    }
}
