using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    InteractiveObject io;
    public Text field;

    public void Init(InteractiveObject io)
    {
        this.io = io;
        field.text = io.name;
    }
    public void Clicked()
    {
        io.UseIt();
        Destroy(gameObject);
    }
}
