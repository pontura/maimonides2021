using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TatetiSlot : MonoBehaviour
{
    public Tateti tateti;
    public Vector2 axis;
    public Text textField;

    public void Init(Tateti tateti)
    {
        this.tateti = tateti;
    }
    public void OnClicked()
    {
        //if (IsActive())
        //    textField.text = "";
        //else
        //{
            if(tateti.turnID == 1)
                textField.text = "1";
            else
                textField.text = "2";
       // }
        tateti.OnSlotClicked();
    }
    public int GetTeamID()
    {
        if (textField.text == "1")
            return 1;
        else if (textField.text == "2")
            return 2;
        return 0;
    }
}
