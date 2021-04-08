using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;

    public void SetName(string name)
    {
        characterName = name;
    }
    public void SetColor(Color colorName)
    {
        GetComponent<Renderer>().material.color = colorName;
    }
    public void SetEdad(int edad)
    {
        //characterName = name;
    }

}
