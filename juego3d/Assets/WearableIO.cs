using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearableIO : InteractiveObject
{
    public WearableObject asset_to_wear;

    public override void UseIt() // es llamada cuando clickeo el thumb del inventario
    {
        character.actions.WeartObject(asset_to_wear);
        print("UseIt: soy una espada, no me dejo"); // que hago ?
    }
}
